using My_Flappy_Bird_C_Sharp_V2._B1_Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace My_Flappy_Bird_C_Sharp_V2.__Globals
{
    internal class Globals_Levels
    {

        public static I_Level current_Level = new C_Level();

        public static int current_Level_No = 0;
        public static int previous_Level_No = 0;
        public static int next_Level_No = 0;
        public static int current_Level_Score = 5;

        public static int Level_No = 0;
        public static int level_No_Lable_W = 30;
        public static int level_No_Lable_H = 20;
        public static int level_No_Lable_Left = Globals_GameArea.gameArea_W - 220;
        public static int level_No_Lable_Top = 10;

        public static TextBlock level_No_TextBlock;
        public static int level_No_TextBlock_FontSize = 25;
        public static int level_No_TextBlock_Left = Globals_GameArea.gameArea_W - 50;
        public static int level_No_TextBlock_Top = 17;

        public static int zIndex_Level_No_Lable = 5;
        public static int zIndex_Level_No_TextBlock = 5;

        //--------------------------------------------------------------------------------------------------------------------------------
        public static int Level_Target = 0;

        public static int level_Target_Lable_W = 30;
        public static int level_Target_Lable_H = 20;
        public static int level_Target_Lable_Left = Globals_GameArea.gameArea_W - 560;
        public static int level_Target_Lable_Top = 10;

        public static TextBlock level_Target_TextBlock;
        public static int level_Target_TextBlock_FontSize = 25;
        public static int level_Target_TextBlock_Left = Globals_GameArea.gameArea_W - 400;
        public static int level_Target_TextBlock_Top = 17;

        public static int zIndex_Level_Target_Lable = 5;
        public static int zIndex_Level_Target_TextBlock = 5;

        public static bool did_The_Player_Achieve_The_Level_Target=false;   







    }
}
