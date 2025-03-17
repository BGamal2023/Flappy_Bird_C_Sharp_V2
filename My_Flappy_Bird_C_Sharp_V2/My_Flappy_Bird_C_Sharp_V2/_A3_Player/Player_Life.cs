using My_Flappy_Bird_C_Sharp_V2.__Globals;
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
    internal class Player_Life
    {
        #region The Fields 
        #endregion
        //----------------------------------------------------------------------------------------
        public void handle_Creating_Player_Life_Image()
        {
            //----
            create_Images_For_Player_Life();
            //----
            add_Player_Life_Images_To_GameArea();
            //----
        }
        //-----------------------------------------------------------------------------------------
        private void create_Images_For_Player_Life()
        {



            #region Clear Old List 
            Globals_Player.li_Of_Player_Life_Images.Clear();    
            #endregion
            //----
            for (int i = 0; i < Globals_Player.num_Of_Plyer_Life; i++)
            {
                //----
                Image i_Player_Life = new Image()
                {
                    Width = Globals_Player.height_And_Width_For_Image_Player_Life,
                    Height = Globals_Player.height_And_Width_For_Image_Player_Life,

                };
                //----
                get_Image_From_Assets_For_The_Player(i_Player_Life);
                //----
                Globals_Player.li_Of_Player_Life_Images.Add(i_Player_Life);
                //----
            }
            //----
        }
        //-----------------------------------------------------------------------------------------
        private void add_Player_Life_Images_To_GameArea()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                int left_Pos = 0;
                for (int i = 0; i < Globals_Player.li_Of_Player_Life_Images.Count; i++)
                {
                    
                    Image i_Player_Life_Image = Globals_Player.li_Of_Player_Life_Images[i];

                    Globals_GameArea.gameArea.Children.Add(i_Player_Life_Image);
                    Canvas.SetLeft(i_Player_Life_Image, left_Pos);
                    Canvas.SetTop(i_Player_Life_Image, Globals_GameArea.gameArea_H - 2 * i_Player_Life_Image.Height);

                    left_Pos = (int)(left_Pos + i_Player_Life_Image.Width);
                }
            });

        }
        //---------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        private void get_Image_From_Assets_For_The_Player(Image image)
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                string str_Player_Image_Path = "pack://application:,,,/Assets/Photos/bird.png";
                BitmapImage bitmap = new BitmapImage(new Uri(str_Player_Image_Path, UriKind.Absolute));
                image.Source = bitmap;
            });
            //----
        }
    }
}
