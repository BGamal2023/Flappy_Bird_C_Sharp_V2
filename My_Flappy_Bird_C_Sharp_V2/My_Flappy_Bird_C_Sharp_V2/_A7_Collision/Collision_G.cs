using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace My_Flappy_Bird_C_Sharp_V2._A7_Collision
{
    internal class Collision_G
    {
        #region The Fieles
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------------------
        public bool does_Collision_Happend(Image image1, Image image2)
        {
            //----
            bool does_Thread_Finished = false;
            Rect rect1;
            Rect rect2;
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                rect1 = new Rect(Canvas.GetLeft(image1), Canvas.GetTop(image1), image1.ActualWidth, image1.ActualHeight);
                rect2 = new Rect(Canvas.GetLeft(image2), Canvas.GetTop(image2), image2.ActualWidth, image2.ActualHeight);

                does_Thread_Finished = true;
            });
            //----
            while (!does_Thread_Finished)
            {
                Thread.Sleep(50);
            }
            //----
            return rect1.IntersectsWith(rect2);
            //----
        }
        //---------------------------------------------------------------------------------------------------------------
    }
}
