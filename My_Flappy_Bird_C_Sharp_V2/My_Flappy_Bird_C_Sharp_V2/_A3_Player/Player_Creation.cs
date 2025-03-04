using My_Flappy_Bird_C_Sharp_V2.__Globals;
using My_Flappy_Bird_C_Sharp_V2.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace My_Flappy_Bird_C_Sharp_V2._A3_Player
{
    internal class Player_Creation
    {
        #region Fields

        #endregion
        //-------------------------------------------------------------------------------------------------------------
        public void handle_The_Player()
        {
            //----
            create_The_Player();
            //----
            get_Image_From_Assets_For_The_Player();
            //----
            add_The_Player_To_The_GameArea();   
            //----
        }
        //-------------------------------------------------------------------------------------------------------------
        private void create_The_Player()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Globals_Player.img_Player = new Image();
                Globals_Player.img_Player.Width = Globals_Player.player_W;
                Globals_Player.img_Player.Height = Globals_Player.player_H;
            });


        }
        //-------------------------------------------------------------------------------------------------------------
        private void get_Image_From_Assets_For_The_Player()
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                string str_Player_Image_Path = "pack://application:,,,/Assets/Photos/bird.png";
                BitmapImage bitmap = new BitmapImage(new Uri(str_Player_Image_Path, UriKind.Absolute));
                Globals_Player.img_Player.Source = bitmap;
            });
            //----
        }
        //-------------------------------------------------------------------------------------------------------------
        private void add_The_Player_To_The_GameArea()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                Globals_GameArea.gameArea.Children.Add(Globals_Player.img_Player);
                //----
                double centerX = Globals_GameArea.gameArea.Width * 0.25;
                double centerY = (Globals_GameArea.gameArea.Height - Globals_Player.img_Player.Height) / 2;
                //----
                Canvas.SetLeft(Globals_Player.img_Player, centerX);
                Canvas.SetTop(Globals_Player.img_Player, centerY);
                //----
                Log.log("*************************************************************");
                Log.log("the center x = " + centerX);
                Log.log("the center y= " + centerY);
                Log.log("*************************************************************");
                //----
               
            });

        }
    }
}
