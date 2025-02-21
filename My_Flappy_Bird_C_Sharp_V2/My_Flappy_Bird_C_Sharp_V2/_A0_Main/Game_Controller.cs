using My_Flappy_Bird_C_Sharp_V2.__Globals;
using My_Flappy_Bird_C_Sharp_V2._A1_MainMenu_Handler;
using My_Flappy_Bird_C_Sharp_V2._A2_GameArea_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace My_Flappy_Bird_C_Sharp_V2._A0_Main
{
    internal class Game_Controller
    {
        #region The Fields
        private MainWindow_Handler obj_MWH = new MainWindow_Handler();
        private GameArea_Handler obj_GAH = new GameArea_Handler();
        #endregion
        //---------------------------------------------------------------------------------------------------------
        public void handle_The_Game(Window mWindow)
        {
            //----
            Globals_MainWindow.mWindow = mWindow;
            //----
            obj_MWH.handle_MainWindow();
            //---
            obj_GAH.handle_The_GameArea();
            //---
        }
        //---------------------------------------------------------------------------------------------------------

    }
}
