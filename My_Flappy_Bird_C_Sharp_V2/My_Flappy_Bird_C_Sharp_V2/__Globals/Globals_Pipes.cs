using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Flying_Bird_C_.__Globals
{
    internal class Globals_Pipes
    {

        public static List<Image> li_Of_Pipes = new List<Image>();
        public static int num_Of_Pipes = 4;
        public static int width_Of_Pipe = 100;
        public static int height_Of_Pipe = 200;
        public static int width_Bet_Pipes = 300;

        public static List<int> li_Of_Heights_Of_Pipes = new List<int>();

        public static double down_Pipes_Top = Globals_GameArea.gameArea_H - height_Of_Pipe - 190;
        public static double up_Pipes_Top = 0;

        public static double starting_Left = Globals_GameArea.gameArea.Width - 200;


        public static int pipes_Moving_Step = 10;
        public static bool does_Player_Pass_Pipe = false;

        public static Storyboard pipes_Storyboard = new Storyboard();


        public static int pipes_Timer_Tick_duration = 4;








    }
}
