using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace My_Flappy_Bird_C_Sharp_V2.__Globals
{
    internal class Globals_Game
    {
        public static int game_Timer_Tick_Duration = 25;
        ///Score
        public static int Score = 0;
        public static int Score_Lable_W = 30;
        public static int Score_Lable_H = 20;
        public static int score_Lable_Left = 5;
        public static int score_Lable_Top = 10;

        public static TextBlock scoreTextBlock;
        public static int score_TextBlock_FontSize = 25;
        public static int score_TextBlock_Left = 90;
        public static int score_TextBlock_Top = 18;

        public static int zIndex_Score_Lable = 5;
        public static int zIndex_Score_TextBlock = 5;
    }
}
