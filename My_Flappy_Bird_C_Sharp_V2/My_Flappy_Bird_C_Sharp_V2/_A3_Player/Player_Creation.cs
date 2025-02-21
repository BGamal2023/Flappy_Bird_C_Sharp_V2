using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Flappy_Bird_C_Sharp_V2._A3_Player
{
    internal class Player_Creation
    {
        #region Fields

        #endregion
        //-------------------------------------------------------------------------------------------------------------
        public void set_Player_Dimension()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Globals.img_Player = new Image();
                Globals.img_Player.Width = Globals.player_W;
                Globals.img_Player.Height = Globals.player_H;
            });


        }
        //-------------------------------------------------------------------------------------------------------------
        public void get_Image_From_Assets_For_The_Player()
        {
            //----

            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                string str_Player_Image_Path = "pack://application:,,,/Assets/Photos/bird.png";
                BitmapImage bitmap = new BitmapImage(new Uri(str_Player_Image_Path, UriKind.Absolute));
                Globals.img_Player.Source = bitmap;
            });
            //----
        }
        //-------------------------------------------------------------------------------------------------------------
        public void add_The_Player_To_The_GameArea()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {


                //----
                Globals.gameArea.Children.Add(Globals.img_Player);
                //----
                double centerX = Globals.gameArea.Width * 0.25;
                double centerY = (Globals.gameArea.Height - Globals.img_Player.Height) / 2;
                //----
                Canvas.SetLeft(Globals.img_Player, centerX);
                Canvas.SetTop(Globals.img_Player, centerY);

                Log.log("*************************************************************");
                Log.log("the center x = " + centerX);
                Log.log("the center y= " + centerY);
                Log.log("*************************************************************");
                //----

            });

        }
    }
}
