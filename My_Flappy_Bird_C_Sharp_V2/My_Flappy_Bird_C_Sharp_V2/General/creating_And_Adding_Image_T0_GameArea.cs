using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace My_Flappy_Bird_C_Sharp_V2.General
{
    internal class creating_And_Adding_Image_T0_GameArea
    {
        public void create_Set_Add_Image_To_GameArea(
            double width,
            double height,
            String assets_Source,
            double left_Pos,
            double top_Pos,
            ref Image image)
        {
            //----
           image= create_The_Image(
                width,
                height);
            //----
            get_Image_From_Assets(
                image,
                assets_Source);
            //----
            add_The_Image_To_The_GameArea(
                left_Pos,
                top_Pos,
                image);
            //-----

        }

        //-------------------------------------------------------------------------------------------------------------
        private Image create_The_Image(
             double width,
             double height
             )
        {
            Image tempImage= null;  
            Application.Current.Dispatcher.Invoke(() =>
            {
                tempImage = new Image();
                tempImage.Width = width;
                tempImage.Height = height;
            });

            return tempImage;
        }
        //-------------------------------------------------------------------------------------------------------------
        private void get_Image_From_Assets(
            Image image,
            string image_Path)
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                string str_Player_Image_Path = image_Path;
                BitmapImage bitmap = new BitmapImage(new Uri(str_Player_Image_Path, UriKind.Absolute));
                image.Source = bitmap;
            });
            //----
        }
        //-------------------------------------------------------------------------------------------------------------
        private void add_The_Image_To_The_GameArea(
              double left_Pos,
            double top_Pos,
            Image image)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                Globals_GameArea.gameArea.Children.Add(image);
                //----
                double centerX = left_Pos;
                double centerY = top_Pos;
                //----
                Canvas.SetLeft(image, centerX);
                Canvas.SetTop(image, centerY);
                //----

            });

        }
    }
}
