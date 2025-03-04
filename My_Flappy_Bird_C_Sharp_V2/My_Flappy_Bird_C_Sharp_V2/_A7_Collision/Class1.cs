using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace My_Flappy_Bird_C_Sharp_V2._A7_Collision
{
    internal class Class1
    {
        //-----------------------------------------------------------------------------------------------------------
        private bool does_Collision_Happend(
            Image image1, 
            Image image2)
        {
          check_Collision_Bet_2_Images(image1,image2);
            return true;
        }
        //----------------------------------------------------------------------------------------------------------------
        public static bool check_Collision_Bet_2_Images(Image image1, Image image2)
        {
            Rect rect1 = new Rect(Canvas.GetLeft(image1), Canvas.GetTop(image1), image1.ActualWidth, image1.ActualHeight);
            Rect rect2 = new Rect(Canvas.GetLeft(image2), Canvas.GetTop(image2), image2.ActualWidth, image2.ActualHeight);

            return rect1.IntersectsWith(rect2);

        }
        //----------------------------------------------------------------------------------------------------------------
    }
}
