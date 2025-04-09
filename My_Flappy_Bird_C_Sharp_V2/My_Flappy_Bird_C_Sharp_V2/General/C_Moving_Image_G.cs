using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace My_Flappy_Bird_C_Sharp_V2.General
{
    internal class C_Moving_Image_G
    {

        //---------------------------------------------------------------------------------------------------------------------
        public void handle_The_Moving_Of_The_Image()
        {

        }
        //---------------------------------------------------------------------------------------------------------------------
        public void move_The_Image_Up(
            double up_Moving_Step,
            Image image)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {

                double top = Canvas.GetTop(image);
                top -= up_Moving_Step;

                Canvas.SetTop(image, top);

            });
        }
        //---------------------------------------------------------------------------------------------------------------------
        public void move_The_Image_Down(
             double down_Moving_Step,
            Image image)
        {

            Application.Current.Dispatcher.Invoke(() =>
            {

                double top = Canvas.GetTop(image);
                top += down_Moving_Step;

                Canvas.SetTop(image, top);
            });
        }
        //---------------------------------------------------------------------------------------------------------------------
        public void move_The_Image_Right(
            double right_Moving_Step,
            Image image)
        {

            Application.Current.Dispatcher.Invoke(() =>
            {
                double left = Canvas.GetLeft(image);
                left += right_Moving_Step;

                Canvas.SetLeft(image, left);

            });
        }
        //---------------------------------------------------------------------------------------------------------------------
        public void move_The_Image_Left(
         double left_Moving_Step,
         Image image)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                double left = Canvas.GetLeft(image);
                left -= left_Moving_Step;

                Canvas.SetLeft(image, left);

            });

        }
        //---------------------------------------------------------------------------------------------------------------------

    }
}

