# flow

## by [Anton Kahwaji 161555](https://github.com/anton31kah) and [Oliver Dimitriov 161535](https://github.com/voirtimid)

## [You can download it here](https://github.com/anton31kah/flow/releases)

The goal of this game is to connect all colors without overlapping each other, and leaving no empty spaces.

Inspired by: Flow Free from Big Duck Games, [You can find them here](https://www.bigduckgames.com/flowfree/)

Notes: This is only for our University Visual Programming course project, we are not using it commercially.

Enjoy 100+ levels and non-ending hours of fun.

It is a simple click and drag mouse game. You need to click on a colored cell and then drag it to make a path to the other matching color cell.

There are 5 groups of levels, each one of them with 30 levels. Varying from 25 to 81 cells in one Grid Level. The 5 groups levels are 5x5; 6x6; 7x7; 8x8; 9x9 Grid.

When you start the application you see a splash screen. You need to enter a username that will be unique for you. If you are new the account will be created. Then you can start playing the game. Otherwise, if you had already played once, you can log in with your username and continue playing from where you stopped, meaning that your Game State is saved locally (you should save explicitly, there is no autoSave (to prevent from saving unwanted actions)). There is also a View Stats button that shows all of the logged in users with their number of completed levels, you can also sort by name or completed levels by clicking on the column header.

On the main game screen, on the left side is positioned the grid where each level will be drawn and solved by you. In the middle, you can see the current game stats (flows, elapsed time, and completion percentage) and a few helping buttons (save reset current level, logout). On the right are the groups and levels from which you can choose. Your selection of the group and level is highlighted so you can see which level you are currently solving. The completed levels will stay highlighted and once you solve all 30 levels from one group, the group will also stay highlighted.

Everything starts with a simple Cell, we have two types of cells, Normal Cell, and Initial Cell. They contain their basic info, location, color, size and etc. Those cells are all grouped in a Grid, which contains info on how many cells are in it, and some info connected to its own cells. Multiple Grids make Levels, and multiple Levels with same grid size make a Group. All this is very precisely done and worked through. So the one property with the biggest data structure is the one where we store the levels. Its function tag is: `Dictionary<int, Dictionary<int, Grid>>`

![Dictionary<int, Dictionary<int, Grid>>](https://github.com/anton31kah/flow/blob/master/Screenshot_1.png)

To generate those levels we didn't do it manually, we used some python scripts to automate the process, the only thing we did was provide it with the screenshots (which we had to do manually because of the iOS restrictions) and in return, it gave us a nice C# formatted code ready for development.

For the stats, we have TimeSpan which is updated every one second. The FinishedPercent is calculated like this:

![FinishedPercent calculation](https://github.com/anton31kah/flow/blob/master/Screenshot_2.png)

When you select a level from the right side, this is what actually is happening in the background, we calculate where exactly you clicked, ignoring any clicks in empty spaces (even those few pixels between levels), whether the click was valid or not is determined by the return value of the method, while the group or level number you chose is stored in the out int value of the method, here is the sample code from the method.

```csharp
public int IsGroupOrLevelUnderMouse(int x, int y, out int groupLevel)
{
    if (y >= 60 && y <= 110)
    {
        int width = 750;
        int height = 60;
        for (int i = 5; i <= 9; i++, width += 55)
        {
            if (x >= width && x <= width + 50 && y >= height && y <= height + 50)
            {
                groupLevel = i;
                return 1;
            }
        }
    }
    else if (y >= 160 && y <= 490)
    {
        int height = 160;
        int width = 750;
        for (int i = 1; i <= 30; i++, width += 55)
        {
            if (x >= width && x <= width + 50 && y >= height && y <= height + 50)
            {
                groupLevel = i;
                return -1;
            }

            if (i % 5 == 0)
            {
                width = 695;
                height += 55;
            }
        }
    }

    groupLevel = 0;
    return 0;
}
```

Some screenshots to see how the game looks

![Splashscreen](https://github.com/anton31kah/flow/blob/master/Screenshot_3.png)

![Main game](https://github.com/anton31kah/flow/blob/master/Screenshot_4.png)

![In game](https://github.com/anton31kah/flow/blob/master/Screenshot_5.png)