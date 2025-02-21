using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace My_Flappy_Bird_C_Sharp_V2._A2_GameArea_Handler
{
    internal class GameArea_Handler
    {
        #region The Fields
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------
        public void handle_The_GameArea()
        {
            //----
            create_New_GameArea();
            //----
            set_The_GameArea_Dimensions();
            //----
            set_The_Background_Color();
            //---
            add_The_GameArea_To_The_MainWindow();
            //---
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void create_New_GameArea()
        {
            Canvas gameArea = new Canvas();
            Globals_GameArea.gameArea = gameArea;
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void set_The_GameArea_Dimensions()
        {
            Globals_GameArea.gameArea.Width = Globals_GameArea.gameArea_W;
            Globals_GameArea.gameArea.Height=Globals_GameArea.gameArea_H;
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void set_The_Background_Color()
        {
            Globals_GameArea.gameArea.Background=Globals_GameArea.gameArea_Background_Color;
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void add_The_GameArea_To_The_MainWindow()
        {
            Globals_MainWindow.mWindow.Content = Globals_GameArea.gameArea;
        }
    }
}
