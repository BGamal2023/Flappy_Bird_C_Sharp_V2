using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace My_Flappy_Bird_C_Sharp_V2._A1_MainMenu_Handler
{
    internal class MainWindow_Handler
    {
        #region The Fields
        #endregion
        //-----------------------------------------------------------------------------------------------------------------
        public void handle_MainWindow()
        {
            //----
              set_Dimensions();
            //----
            show_In_The_Middle_Of_The_Scrren();
            //----
        }
        //-----------------------------------------------------------------------------------------------------------------
        private void set_Dimensions()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Globals_MainWindow.mWindow.Width = Globals_MainWindow.mWindow_W;
                Globals_MainWindow.mWindow.Height = Globals_MainWindow.mWindow_H;
            });
            }
           
        //-----------------------------------------------------------------------------------------------------------------
        private void set_Background()
        {
           
        }
        //-----------------------------------------------------------------------------------------------------------------
        private void show_In_The_Middle_Of_The_Scrren()
        {

            Application.Current.Dispatcher.Invoke(() =>
            {
                Globals_MainWindow.mWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            });
        }
    }
}
