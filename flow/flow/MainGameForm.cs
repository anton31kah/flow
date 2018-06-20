using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace flow
{
    public partial class MainGameForm : Form
    {
        public readonly string PATH = @"%USERPROFILE%\Documents\flow";
        public User UserPlayer { get; set; }
        public bool MouseIsDown { get; set; }
        public bool GridIsSet { get; set; }
        public LinkedListNode<Cell> LastVisitedCell { get; set; }
        public Cell PrevCell { get; set; }
        public Timer Timer { get; set; }

        public MainGameForm(User user)
        {
            InitializeComponent();
            DoubleBuffered = true;
            UserPlayer = user;
            if (UserPlayer.MyGame.LevelGroup * UserPlayer.MyGame.LevelNumber == 0)
                continueLabel.Visible = false;
            PATH = Environment.ExpandEnvironmentVariables(PATH);
            Text = $"Flow - {UserPlayer.Name}";
            UserPlayer.MyGame.Grid.TimeElapsed = new TimeSpan();
        }

        private void MainGameForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
            UserPlayer.MyGame.Grid.FormGraphics = e.Graphics;
            UserPlayer.MyGame.Grid.Draw();
            UserPlayer.Levels.Draw(e.Graphics,
                                   UserPlayer.MyGame.LevelGroup,
                                   UserPlayer.MyGame.LevelNumber,
                                   UserPlayer.SolvedLevels);
        }

        private void MainGameForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X > 500) // level choosing
            {
                int groupOrLevel = UserPlayer.Levels.IsGroupOrLevelUnderMouse(e.X, e.Y, out int groupLevel);

                if (groupOrLevel > 0)
                {
                    UserPlayer.MyGame.LevelGroup = groupLevel;
                    UserPlayer.MyGame.LevelNumber = 1;
                }
                else if (groupOrLevel < 0)
                    UserPlayer.MyGame.LevelNumber = groupLevel;

                if (UserPlayer.MyGame.LevelGroup * UserPlayer.MyGame.LevelNumber != 0)
                {
                    continueLabel.Visible = false;
                    UserPlayer.MyGame.Grid =
                        UserPlayer.Levels.RegularLevels[UserPlayer.MyGame.LevelGroup][UserPlayer.MyGame.LevelNumber];
                    GridIsSet = true;
                    connectedPipesLabel.Text =
                        $"Flows: {UserPlayer.MyGame.Grid.BetterCompletedPipes.Values.Count(v => v)}/{UserPlayer.MyGame.Grid.Paths.Count}";
                    pipeFinishedLabel.Text = $"Pipe: {UserPlayer.MyGame.Grid.FinishedPercent}%";
                    if (Timer != null)
                        Timer.Tick -= Timer_Tick;
                    Timer = new Timer {Interval = 1000};
                    Timer.Tick += Timer_Tick;

                    if (!UserPlayer.IsLevelSolved(UserPlayer.MyGame.LevelGroup, UserPlayer.MyGame.LevelNumber))
                    {
                        elapsedTimeLabel.Text = "Time: 00:00";
                        UserPlayer.MyGame.Grid.TimeElapsed = new TimeSpan();
                    }

                    Timer.Start();
                    Invalidate();
                }

                return;
            }


            if (e.Button != MouseButtons.Left || !GridIsSet)
                return;
            var Cell = UserPlayer.MyGame.Grid.GetCellUnderMouse(e.X, e.Y);

            if (Cell.Color == Color.Black)
                return;

            if (UserPlayer.IsLevelSolved(UserPlayer.MyGame.LevelGroup, UserPlayer.MyGame.LevelNumber))
            {
                resetButton_Click(null, null);

                return;
            }

            MouseIsDown = true;
            UserPlayer.MyGame.FirstColor = Cell.Color;
            LastVisitedCell = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].LastAddedCell;
            PrevCell = Cell;

            if (Cell is InitialCell && UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Count > 2)
            {
                var node = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First;

                while (node != null)
                {
                    var next = node.Next;

                    if (node.Value is InitialCell)
                    {
                        foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
                        {
                            foreach (Cell cell in row)
                            {
                                if (Equals(cell, node.Value))
                                {
                                    node.Value.PipeDirection.Clear();
                                    node.Value.IsConnected = false;
                                    node.Value.NumberOfPipes = 0;

                                    goto Outside;
                                }
                            }
                        }
                    }

                    if (node.Value is NormalCell)
                    {
                        UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Remove(node);

                        foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
                        {
                            foreach (Cell cell in row)
                            {
                                if (Equals(cell, node.Value))
                                {
                                    node.Value.PipeDirection.Clear();
                                    node.Value.Color = Color.Black;
                                    node.Value.IsConnected = false;
                                    node.Value.NumberOfPipes = 0;

                                    goto Outside;
                                }
                            }
                        }
                    }

                    Outside:

                    node = next;
                }

                connectedPipesLabel.Text =
                    $"Flows: {UserPlayer.MyGame.Grid.BetterCompletedPipes.Values.Count(v => v)}/{UserPlayer.MyGame.Grid.Paths.Count}";
                pipeFinishedLabel.Text = $"Pipe: {UserPlayer.MyGame.Grid.FinishedPercent}%";
            }
            else if (UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Count > 2) // started
            {
                if (UserPlayer.MyGame.Grid.ColorUpDownStart[UserPlayer.MyGame.FirstColor] == 1) // clear down
                {
                    var node = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Find(Cell)?.Next;

                    while (node?.Value is NormalCell)
                    {
                        var next = node.Next;
                        UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Remove(node);

                        foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
                        {
                            foreach (Cell cell in row)
                            {
                                if (Equals(cell, node.Value))
                                {
                                    node.Value.PipeDirection.Clear();
                                    node.Value.Color = Color.Black;
                                    node.Value.IsConnected = false;
                                    node.Value.NumberOfPipes = 0;

                                    goto Outside;
                                }
                            }
                        }

                        Outside:
                        node = next;
                    }
                }
                else // clear up
                {
                    var node = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Find(Cell)?.Previous;

                    while (node?.Value is NormalCell)
                    {
                        var prev = node.Previous;
                        UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Remove(node);

                        foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
                        {
                            foreach (Cell cell in row)
                            {
                                if (Equals(cell, node.Value))
                                {
                                    node.Value.PipeDirection.Clear();
                                    node.Value.Color = Color.Black;
                                    node.Value.IsConnected = false;
                                    node.Value.NumberOfPipes = 0;

                                    goto Outside;
                                }
                            }
                        }

                        Outside:
                        node = prev;
                    }
                }

                UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].Update();
                connectedPipesLabel.Text =
                    $"Flows: {UserPlayer.MyGame.Grid.BetterCompletedPipes.Values.Count(v => v)}/{UserPlayer.MyGame.Grid.Paths.Count}";
                pipeFinishedLabel.Text = $"Pipe: {UserPlayer.MyGame.Grid.FinishedPercent}%";
            }


            if (Equals(Cell, UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First.Value))
                UserPlayer.MyGame.Grid.ColorUpDownStart[UserPlayer.MyGame.FirstColor] = 1;
            else if (Equals(Cell, UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Value))
                UserPlayer.MyGame.Grid.ColorUpDownStart[UserPlayer.MyGame.FirstColor] = -1;

            Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!UserPlayer.IsLevelSolved(UserPlayer.MyGame.LevelGroup, UserPlayer.MyGame.LevelNumber))
                UserPlayer.MyGame.Grid.TimeElapsed += UserPlayer.MyGame.Grid.DefaultTick;
            elapsedTimeLabel.Text = $"Time: {UserPlayer.MyGame.Grid.TimeElapsed:mm\\:ss}";
        }

        private void MainGameForm_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
        }

        private void MainGameForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIsDown)
            {
                var Cell = UserPlayer.MyGame.Grid.GetCellUnderMouse(e.X, e.Y);

                Color beforeColor = Cell.Color;

                if (!UserPlayer.MyGame.Grid.AreAdjacent(PrevCell, Cell))
                    return; // why the heck was this between the two clears

                if (beforeColor != Color.Black && beforeColor != UserPlayer.MyGame.FirstColor && Cell is NormalCell)
                {
                    var node = UserPlayer.MyGame.Grid.Paths[beforeColor].PathList.First;

                    while (node != null)
                    {
                        var next = node.Next;

                        if (node.Value is InitialCell)
                        {
                            foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
                            {
                                foreach (Cell cell in row)
                                {
                                    if (Equals(cell, node.Value))
                                    {
                                        node.Value.PipeDirection.Clear();
                                        node.Value.IsConnected = false;
                                        node.Value.NumberOfPipes = 0;

                                        goto Outside;
                                    }
                                }
                            }
                        }

                        if (node.Value is NormalCell)
                        {
                            UserPlayer.MyGame.Grid.Paths[beforeColor].PathList.Remove(node);

                            foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
                            {
                                foreach (Cell cell in row)
                                {
                                    if (Equals(cell, node.Value))
                                    {
                                        node.Value.PipeDirection.Clear();
                                        node.Value.Color = Color.Black;
                                        node.Value.IsConnected = false;
                                        node.Value.NumberOfPipes = 0;

                                        goto Outside;
                                    }
                                }
                            }
                        }

                        Outside:

                        node = next;
                    }

                    connectedPipesLabel.Text =
                        $"Flows: {UserPlayer.MyGame.Grid.BetterCompletedPipes.Values.Count(v => v)}/{UserPlayer.MyGame.Grid.Paths.Count}";
                    pipeFinishedLabel.Text = $"Pipe: {UserPlayer.MyGame.Grid.FinishedPercent}%";
                }

                if (Cell is NormalCell &&
                    beforeColor != Color.Black &&
                    beforeColor == UserPlayer.MyGame.FirstColor &&
                    UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Contains(Cell) &&
                    !Equals(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First.Next?.Value,
                            Cell) &&
                    !Equals(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Previous?.Value,
                            Cell))
                {
                    if (UserPlayer.MyGame.Grid.ColorUpDownStart[UserPlayer.MyGame.FirstColor] == 1) // clear down
                    {
                        var node = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Find(Cell)?.Next;

                        while (node?.Value is NormalCell)
                        {
                            var next = node.Next;
                            UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Remove(node);

                            foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
                            {
                                foreach (Cell cell in row)
                                {
                                    if (Equals(cell, node.Value))
                                    {
                                        node.Value.PipeDirection.Clear();
                                        node.Value.Color = Color.Black;
                                        node.Value.IsConnected = false;
                                        node.Value.NumberOfPipes = 0;

                                        goto Outside;
                                    }
                                }
                            }

                            Outside:
                            node = next;
                        }
                    }
                    else // clear up
                    {
                        var node = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor]
                                             .PathList.Find(Cell)
                                             ?.Previous;

                        while (node?.Value is NormalCell)
                        {
                            var prev = node.Previous;
                            UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Remove(node);

                            foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
                            {
                                foreach (Cell cell in row)
                                {
                                    if (Equals(cell, node.Value))
                                    {
                                        node.Value.PipeDirection.Clear();
                                        node.Value.Color = Color.Black;
                                        node.Value.IsConnected = false;
                                        node.Value.NumberOfPipes = 0;

                                        goto Outside;
                                    }
                                }
                            }

                            Outside:
                            node = prev;
                        }
                    }

                    connectedPipesLabel.Text =
                        $"Flows: {UserPlayer.MyGame.Grid.BetterCompletedPipes.Values.Count(v => v)}/{UserPlayer.MyGame.Grid.Paths.Count}";
                    pipeFinishedLabel.Text = $"Pipe: {UserPlayer.MyGame.Grid.FinishedPercent}%";
                }


                if (!(Cell is InitialCell) &&
                    !UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Contains(Cell))
                {
                    Cell.Color = UserPlayer.MyGame.FirstColor;

                    if (UserPlayer.MyGame.Grid.ColorUpDownStart[UserPlayer.MyGame.FirstColor] == 1)
                        LastVisitedCell = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor]
                                                    .PathList
                                                    .AddBefore(UserPlayer
                                                               .MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor]
                                                               .PathList.Last,
                                                               Cell);
                    else
                        LastVisitedCell = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor]
                                                    .PathList
                                                    .AddAfter(UserPlayer
                                                              .MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor]
                                                              .PathList.First,
                                                              Cell);


                    if (UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Count >= 3 &&
                        Math.Abs(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First.Value.Row -
                                 UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor]
                                           .PathList.First.Next.Value.Row) +
                        Math.Abs(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First.Value.Col -
                                 UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor]
                                           .PathList.First.Next.Value.Col) == 1 &&
                        Math.Abs(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Value.Row -
                                 UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor]
                                           .PathList.Last.Previous.Value.Row) +
                        Math.Abs(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Value.Col -
                                 UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor]
                                           .PathList.Last.Previous.Value.Col) == 1)
                    {
                        UserPlayer.ChangedSomething = true;
                        Text = $"Flow - {UserPlayer.Name}*";

                        connectedPipesLabel.Text =
                            $"Flows: {UserPlayer.MyGame.Grid.BetterCompletedPipes.Values.Count(v => v)}/{UserPlayer.MyGame.Grid.Paths.Count}";

                        if (UserPlayer.MyGame.Grid.BetterCompletedPipes.Values.Count(v => v) ==
                            UserPlayer.MyGame.Grid.Paths.Count)
                        {
                            if (!UserPlayer.SolvedLevels.ContainsKey(UserPlayer.MyGame.LevelGroup))
                                UserPlayer.SolvedLevels[UserPlayer.MyGame.LevelGroup] = new HashSet<int>();
                            UserPlayer.SolvedLevels[UserPlayer.MyGame.LevelGroup].Add(UserPlayer.MyGame.LevelNumber);
                        }
                    }

                    UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].Update();
                    pipeFinishedLabel.Text = $"Pipe: {UserPlayer.MyGame.Grid.FinishedPercent}%";

                    PrevCell = Cell;
                    Pipes.Graphics = UserPlayer.MyGame.Grid.FormGraphics;
                }

                if (Cell is InitialCell &&
                    UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Count > 2 &&
                    (UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Value.Equals(Cell) ||
                     UserPlayer.MyGame
                               .Grid.Paths[UserPlayer.MyGame.FirstColor]
                               .PathList.First.Value.Equals(Cell)))
                {
                    // "OVER";
                    UserPlayer.ChangedSomething = true;
                    Text = $"Flow - {UserPlayer.Name}*";

                    connectedPipesLabel.Text =
                        $"Flows: {UserPlayer.MyGame.Grid.BetterCompletedPipes.Values.Count(v => v)}/{UserPlayer.MyGame.Grid.Paths.Count}";

                    if (UserPlayer.MyGame.Grid.BetterCompletedPipes.Values.Count(v => v) ==
                        UserPlayer.MyGame.Grid.Paths.Count)
                    {
                        if (!UserPlayer.SolvedLevels.ContainsKey(UserPlayer.MyGame.LevelGroup))
                            UserPlayer.SolvedLevels[UserPlayer.MyGame.LevelGroup] = new HashSet<int>();
                        UserPlayer.SolvedLevels[UserPlayer.MyGame.LevelGroup].Add(UserPlayer.MyGame.LevelNumber);
                    }
                }

                Invalidate();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Reset", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            UserPlayer.Levels.RegularLevels[UserPlayer.MyGame.LevelGroup][UserPlayer.MyGame.LevelNumber].Reset();
            connectedPipesLabel.Text = $"Flows: 0/{UserPlayer.MyGame.Grid.Paths.Count}";
            elapsedTimeLabel.Text = "Time: 00:00";
            pipeFinishedLabel.Text = $"Pipe: {UserPlayer.MyGame.Grid.FinishedPercent}%";
            UserPlayer.ChangedSomething = true;
            Text = $"Flow - {UserPlayer.Name}*";

            UserPlayer.MyGame.Grid.TimeElapsed = new TimeSpan();
            if (UserPlayer.IsLevelSolved(UserPlayer.MyGame.LevelGroup, UserPlayer.MyGame.LevelNumber))
                UserPlayer.SolvedLevels[UserPlayer.MyGame.LevelGroup].Remove(UserPlayer.MyGame.LevelNumber);

            Invalidate();
        }

        public void SaveFile()
        {
            string fileName = UserPlayer.Name;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = File.Create($@"{PATH}\{fileName}.flw"))
                formatter.Serialize(file, UserPlayer);
        }

        private void MainGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserPlayer.ChangedSomething)
            {
                var dialogResult =
                    MessageBox.Show("Are you sure you want to close the game without saving? Unsaved changes will be lost",
                                    "Exit without save?",
                                    MessageBoxButtons.YesNo);
                e.Cancel = dialogResult == DialogResult.No;

                if (dialogResult == DialogResult.Yes)
                {
                    var loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
            else
            {
                var loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFile();
            UserPlayer.ChangedSomething = false;
            Text = $"Flow - {UserPlayer.Name}";
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}