using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace flow
{
    public partial class MainGameForm : Form
    {
        public User UserPlayer { get; set; }
        public bool MouseIsDown { get; set; }
        public bool GridIsSet { get; set; }
        public int PreviousLevel { get; set; }
        public LinkedListNode<Cell> LastVisitedCell { get; set; }
        public Cell PrevCell { get; set; }
        public int UpDownStart { get; set; } // 1 up, -1 down


        //Added
        //public Dictionary<string, Levels> Users { get; set; }

        public MainGameForm(User user)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            UserPlayer = user;
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
            UserPlayer.MyGame.Grid.formGraphics = e.Graphics;
            UserPlayer.MyGame.Grid.Draw();
            UserPlayer.Levels.Draw(e.Graphics);
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || e.X > 500 || !GridIsSet)
                return;
            var Cell = UserPlayer.MyGame.Grid.GetCellUnderMouse(e.X, e.Y);
            if (Cell.Color == Color.Black)
                return;
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
                    Invalidate();
                }
            }
            else if (UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Count > 2) // started
            {
                if (UpDownStart == 1) // clear down
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
                    //Invalidate();
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
            }


            if (Equals(Cell, UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First.Value))
                UpDownStart = 1;
            else if (Equals(Cell, UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Value))
                UpDownStart = -1;
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = PreviousLevel.ToString();
            if (MouseIsDown)
            {
                var Cell = UserPlayer.MyGame.Grid.GetCellUnderMouse(e.X, e.Y);

                Color beforeColor = Cell.Color;

                // clear on touch another
                if (beforeColor != Color.Black && beforeColor != UserPlayer.MyGame.FirstColor)
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
                        Invalidate();
                    }
                }

                if (!UserPlayer.MyGame.Grid.AreAdjacent(PrevCell, Cell))
                    return;

                if (Cell is NormalCell &&
                    beforeColor != Color.Black &&
                    beforeColor == UserPlayer.MyGame.FirstColor &&
                    UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Contains(Cell) &&
                    !Equals(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First.Next?.Value, Cell) &&
                    !Equals(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Previous?.Value, Cell))
                {
                    if (UpDownStart == 1) // clear down
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
                        //Invalidate();
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
                }



                if (!(Cell is InitialCell) && !UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Contains(Cell))
                {
                    Cell.Color = UserPlayer.MyGame.FirstColor;

                    if (UpDownStart == 1)
                        LastVisitedCell = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.AddBefore(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last, Cell);
                    else
                        LastVisitedCell = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.AddAfter(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First, Cell);

                    UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].Update();
                    label2.Text = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].ToString();

                    PrevCell = Cell;
                    Invalidate();
                    Pipes.Graphics = UserPlayer.MyGame.Grid.formGraphics;

                }

                if (Cell is InitialCell && UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Count > 2 && (UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Value.Equals(Cell) || UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First.Value.Equals(Cell)))
                {
                    label2.Text = "OVER";
                    Invalidate();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int level))
            {
                GridIsSet = true;
                UserPlayer.MyGame.Grid = UserPlayer.Levels.RegularLevels[6][1];
            }
            else
            {
                GridIsSet = true;
                UserPlayer.MyGame.Grid = UserPlayer.Levels.RegularLevels[6][level];
                if (PreviousLevel != 0 && level != PreviousLevel)
                {
                    //MessageBox.Show($"previous {PreviousLevel}, level {level}");
                    UserPlayer.Levels.RegularLevels[6][PreviousLevel].Reset();

                }
            }
            PreviousLevel = level;
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PreviousLevel == 0)
                PreviousLevel = 1;
            UserPlayer.Levels.RegularLevels[6][PreviousLevel].Reset();
            label2.Text = "";
            Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (menu.Visible == true)
            {
                showMenu.Text = "Hide Menu";
                menu.Visible = false;
                showMenu.Text = "Show Menu";
            }
            else
            {
                showMenu.Text = "Show Menu";
                menu.Visible = true;
                showMenu.Text = "Hide Menu";
            }
        }

        private void MainGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void SaveFile()
        {
            string fileName = UserPlayer.Name;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = File.Create("../../SaveGames/" + fileName + ".flw"))
                formatter.Serialize(file, UserPlayer);
        }
    }
}
