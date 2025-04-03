using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Flappy_Bird_C_Sharp_V2._B1_Levels
{
    internal class Levels_Controller
    {
        #region The Fields
        private Level_1 obj_Level_1 = new Level_1();
        private Level_2 obj_Level_2 = new Level_2();
        private Level_3 obj_Level_3 = new Level_3();
        private Level_4 obj_Level_4 = new Level_4();
        private Level_5 obj_Level_5 = new Level_5();
        private Level_6 obj_Level_6 = new Level_6();
        private Level_7 obj_Level_7 = new Level_7();
        private Level_8 obj_Level_8 = new Level_8();
        #endregion
        //-----------------------------------------------------------------------------------------------------------------------
        public void handle_Levels()
        {
            if (Globals_Levels.did_The_Player_Achieve_The_Level_Target)
            {
                increase_Level_Num();
                detetc_The_Level();
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------
        public void monitor_The_Score()
        {
            if (Globals_Game.Score == Globals_Levels.current_Level_Score)
            {
                Globals_Levels.did_The_Player_Achieve_The_Level_Target = true;
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------
        public void increase_Level_Num()
        {
            Globals_Levels.current_Level_No++;
            Globals_Levels.previous_Level_No++;
            Globals_Levels.next_Level_No++;
        }
        //-----------------------------------------------------------------------------------------------------------------------
        public void detetc_The_Level()
        {
            switch (Globals_Levels.current_Level_No)
            {
                case 1:
                    Globals_Levels.current_Level = obj_Level_1;

                    break;
                case 2:
                    Globals_Levels.current_Level = obj_Level_2;

                    break;
                case 3:
                    Globals_Levels.current_Level = obj_Level_3;

                    break;
                case 4:
                    Globals_Levels.current_Level = obj_Level_4;
                    break;
                case 5:
                    Globals_Levels.current_Level = obj_Level_5;

                    break;
                case 6:
                    Globals_Levels.current_Level = obj_Level_6;

                    break;
                case 7:
                    Globals_Levels.current_Level = obj_Level_7;

                    break;
                case 8:
                    Globals_Levels.current_Level = obj_Level_8;
                    break;
                case 9:
                    break;
                case 10: break;

            }
        }
        //-----------------------------------------------------------------------------------------------------------------------

    }
}
