using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows;
using My_Flappy_Bird_C_Sharp_V2.__Globals;

namespace My_Flappy_Bird_C_Sharp_V2._A4_Game_Background
{
    internal class Game_Background
    {
        #region The Fields
        #endregion
        //-------------------------------------------------------------------------------------------------------------------------
        public void handl_The_Game_Background()
        {
            handle_The_Moving_Of_The_Game_Background_Photo();
        }
        //-------------------------------------------------------------------------------------------------------------------------
        private void handle_The_Moving_Of_The_Game_Background_Photo()
        {
            // Create an Image element for the background
            Image backgroundImage = new Image();
            backgroundImage.Width = 800;
            backgroundImage.Height = 450;

            // Set the source of the image (change the URI to match your background image location)
            backgroundImage.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/photos/background_3.jpg"));

            // Add the background image to the Canvas
            Globals_GameArea.gameArea.Children.Add(backgroundImage);

            // Position the image at the start (initial position on the canvas)
            Canvas.SetLeft(backgroundImage, 0);
            Canvas.SetTop(backgroundImage, 0);
            Canvas.SetZIndex(backgroundImage, 0);
            // Create a DoubleAnimation to animate the Canvas.Left property (moving the image)
            DoubleAnimation backgroundAnimation = new DoubleAnimation
            {
                From = 0,                // Starting position (initial position)
                To = -800,               // Ending position (move the image off-screen to the left)
                Duration = new Duration(TimeSpan.FromSeconds(Globals_GameBackground.timer_Tick_duration)), // Duration of the animation
                RepeatBehavior = RepeatBehavior.Forever, // Make the animation repeat forever
                AutoReverse = false      // Don't reverse the animation
            };

            // Apply the animation to the Canvas.Left property of the background image
            Storyboard.SetTarget(backgroundAnimation, backgroundImage);
            Storyboard.SetTargetProperty(backgroundAnimation, new PropertyPath("(Canvas.Left)"));

            // Create a Storyboard and add the animation to it
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(backgroundAnimation);

            // Start the animation
            storyboard.Begin();
            Globals_GameBackground.background_Storyboard = storyboard;  
        
    }
        //-------------------------------------------------------------------------------------------------------------------------
    }
}
