using My_Flappy_Bird_C_Sharp_V2.__Globals;
using My_Flappy_Bird_C_Sharp_V2._B3_Ground;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace My_Flappy_Bird_C_Sharp_V2._A2_GameArea_Handler
{
    internal class GameArea_Handler
    {
        #region The Fields
        private Ground obj_Gro = new Ground();
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------
        public void handle_The_GameArea()
        {
            //----
            create_New_GameArea();
            //----
            set_The_GameArea_Dimensions();
            //----
            set_The_Background_Color();
            //---
            obj_Gro.create_And_Add_Ground_To_The_GameArea();
            //----
            get_And_Set_GameArea_Background_Image_V2();
            //----
            add_The_GameArea_To_The_MainWindow();
            //---
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void create_New_GameArea()
        {
            Canvas gameArea = new Canvas();
            Globals_GameArea.gameArea = gameArea;
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void set_The_GameArea_Dimensions()
        {
            Globals_GameArea.gameArea.Width = Globals_GameArea.gameArea_W;
            Globals_GameArea.gameArea.Height = Globals_GameArea.gameArea_H;
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void set_The_Background_Color()
        {
            Globals_GameArea.gameArea.Background = Globals_GameArea.gameArea_Background_Color;
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void get_And_Set_GameArea_Background_Image_V0()
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                string str_GameArea_Background_Photo = "pack://application:,,,/Assets/Photos/background_5.jpg";
                //----
                ImageBrush imageBrush = new ImageBrush();
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(str_GameArea_Background_Photo, UriKind.Absolute);
                bitmapImage.EndInit();
                //----
                imageBrush.ImageSource = bitmapImage;
                Globals_GameArea.gameArea.Background = imageBrush;
                //----
            });
            //----
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void add_The_GameArea_To_The_MainWindow()
        {
            Globals_MainWindow.mWindow.Content = Globals_GameArea.gameArea;
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void get_And_Set_GameArea_Background_Image_V1()
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                // Create an Image element for the background
                Image backgroundImage = new Image();
                backgroundImage.Width = Globals_GameArea.gameArea_W;
                backgroundImage.Height = Globals_GameArea.gameArea_H;

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
                    Duration = new Duration(TimeSpan.FromSeconds(5)), // Duration of the animation
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
            });
            //----
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void get_And_Set_GameArea_Background_Image_V2()
        {

            //----
            Image backgroundImage1 = new Image
            {
                Width = Globals_GameArea.gameArea_W,
                Height = Globals_GameArea.gameArea_H
            };
            backgroundImage1.Source = Globals_GameBackground.bmi_Background_GameArea;

            Image backgroundImage2 = new Image
            {
                Width = Globals_GameArea.gameArea_W,  // Set the width of the image
                Height = Globals_GameArea.gameArea_H
            };
            backgroundImage2.Source = Globals_GameBackground.bmi_Background_GameArea;
            //----

            Canvas.SetLeft(backgroundImage1, 0);
            Canvas.SetTop(backgroundImage1, 0);
            Canvas.SetLeft(backgroundImage2, 800);
            Canvas.SetTop(backgroundImage2, 0);


            Globals_GameArea.gameArea.Children.Add(backgroundImage1);
            Globals_GameArea.gameArea.Children.Add(backgroundImage2);

            // Create a DoubleAnimation for moving both images
            DoubleAnimation backgroundAnimation = new DoubleAnimation
            {
                From = 0,               // Starting position
                To = -800,              // Move the image completely off-screen to the left
                Duration = new Duration(TimeSpan.FromMilliseconds(Globals_GameBackground.background_timer_Tick_duration)), // Duration of the animation
                RepeatBehavior = RepeatBehavior.Forever, // Make the animation repeat forever
                AutoReverse = false     // No reverse, we want continuous scrolling
            };

            // Apply the animation to the Canvas.Left property for both images
            Storyboard.SetTarget(backgroundAnimation, backgroundImage1);
            Storyboard.SetTargetProperty(backgroundAnimation, new PropertyPath("(Canvas.Left)"));

            // Create a Storyboard for the animation
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(backgroundAnimation);

            // Start the animation
            storyboard.Begin();

            // Another animation for the second image
            DoubleAnimation backgroundAnimation2 = new DoubleAnimation
            {
                From = 800,           // Starting position for the second image (just after the first image)
                To = 0,               // Move it to the left edge (same path as the first image)
                Duration = new Duration(TimeSpan.FromMilliseconds(Globals_GameBackground.background_timer_Tick_duration)),
                RepeatBehavior = RepeatBehavior.Forever,
                AutoReverse = false
            };

            // Apply the animation to the second image
            Storyboard.SetTarget(backgroundAnimation2, backgroundImage2);
            Storyboard.SetTargetProperty(backgroundAnimation2, new PropertyPath("(Canvas.Left)"));

            // Start the second animation
            storyboard.Children.Add(backgroundAnimation2);
            storyboard.Begin();
            Globals_GameBackground.background_Storyboard = storyboard;
        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void add_Start_Game_Botton()
        {

            // Create the Button
            Button start_Button = new Button();
            start_Button.Content = "Start";
            start_Button.Width = 100;
            start_Button.Height = 50;

            // Set the button's position on the canvas
            Canvas.SetLeft(start_Button, 100);  // X position
            Canvas.SetTop(start_Button, 100);   // Y position

            // Set button's appearance (optional)
            start_Button.Background = Brushes.LightBlue;
            start_Button.Foreground = Brushes.DarkBlue;
            start_Button.FontSize = 14;

            Globals_GameArea.gameArea.Children.Add(start_Button);
            Canvas.SetZIndex(start_Button, 100);
            start_Button.Click += (sender, e) =>
            {


                start_Button.Visibility = Visibility.Collapsed;
            };
        }
        //------------------------------------------------------------------------------------------------------------------------------

    }
}
