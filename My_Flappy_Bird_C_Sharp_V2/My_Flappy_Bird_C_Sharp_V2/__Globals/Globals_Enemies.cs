using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace My_Flappy_Bird_C_Sharp_V2.__Globals
{
    internal class Globals_Enemies
    {

        public static Image enemy_Image;
        public static int enemy_W = 50;
        public static int enemy_H = 50;
        public static double enemy_Left_Pos = Globals_GameArea.gameArea.Width * 0.75;
        public static double enemy_Top_Pos = (Globals_GameArea.gameArea.Height - enemy_H) / 2;
        public static int enemy_Moving_Step = 12;
        public static bool should_I_Move_Enemy_Up = false;
        public static bool should_I_Move_Enemy_Down = true;

        public static int zIndex = 5;

        public static bool should_Enemy_Move_Up = false;
        public static bool should_Enemy_Move_Down = true;

        public static string assets_Source= "pack://application:,,,/Assets/Photos/enemy.png";

        public static DispatcherTimer enemy_Moving_Timer = new DispatcherTimer();
        public static int enemy_Moving_Timer_Tick_Duration = 100;

        public static List<Image> li_Of_Enemy_Life_Images = new List<Image>();

       
    }
}
