using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Flappy_Bird_C_Sharp_V2._B3_Ground
{
    internal class Ground
    {
        #region The Fields
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------------------------
        public void create_And_Add_Ground_To_The_GameArea()
        {
            // Create the rectangle
            Rectangle ground = new Rectangle
            {
                Width = Globals_Ground.ground_W,
                Height = Globals_Ground.ground_H,
                Fill = Brushes.Blue
            };

            // Set its position on the canvas
            Canvas.SetLeft(ground, Globals_Ground.ground_Left_Pos); // X coordinate
            Canvas.SetTop(ground, Globals_Ground.ground_Top_Pos);  // Y coordinate
            ground.Visibility = Visibility.Hidden;
            Canvas.SetZIndex(ground, Globals_Ground.ground_zIndex);

            Globals_Ground.ground = ground;            // Add it to the canvas
            Globals_GameArea.gameArea.Children.Add(ground);
        }
    }
}
