using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace My_Flappy_Bird_C_Sharp_V2.__Globals
{
    internal class Globals_Player
    {
        ///Player
        public static Image img_Player;
        public static int player_W = 50;
        public static int player_H = 50;
        public static double player_Left_Pos = Globals_GameArea.gameArea.Width * 0.25;
        public static double player_Top_Pos= (Globals_GameArea.gameArea.Height - player_H) / 2;
        public static int player_Moving_Step = 12;
        public static bool should_I_Move_Player_Up = false;
        public static bool should_I_Move_Player_Down = true;

        public static int zIndex = 5;

        public static bool should_Plyer_Move_Up = false;
        public static bool should_Plyer_Move_Down = true;

        public static string asset_Path = "pack://application:,,,/Assets/Photos/bird.png";

        public static DispatcherTimer player_Moving_Timer=new DispatcherTimer();
        public static int player_Moving_Timer_Tick_Duration = 100;

        public static List<Image> li_Of_Player_Life_Images= new List<Image>();
        public static int num_Of_Plyer_Life = 3;
        public static int height_And_Width_For_Image_Player_Life = 38;
    }
}
