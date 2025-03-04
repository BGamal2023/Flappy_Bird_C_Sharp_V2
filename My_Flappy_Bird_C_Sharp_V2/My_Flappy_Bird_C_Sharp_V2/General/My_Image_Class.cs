using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;

namespace My_Flappy_Bird_C_Sharp_V2.General
{
    internal class My_Image_Class
    {
        #region The Fields
        #endregion
        //--------------------------------------------------------------------------------------------------------------------
        public void create_Image_And_Get_Its_Source_From_Assets_Folder(
            int width,
            int height,
            string image_Path)
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                Image imag = new Image()
                {
                    Width = width,
                    Height = height,
                };

                BitmapImage bitmap = new BitmapImage(new Uri(image_Path, UriKind.Absolute));
                imag.Source = bitmap;
            });
            //----
        }
        //-----------------------------------------------------------------------------------------------------------------------
        public void add_The_Image_To_The_GameArea(
            Image image,
            Canvas gameArea)
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                gameArea.Children.Add(image);
            });
            //----
        }
        //----------------------------------------------------------------------------------------------------------------------
        public void remove_The_Image_From_The_GameArea(
            Image image,
            Canvas gameArea)
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                gameArea.Children.Remove(image);
            });
            //----
        }
    }
}
