using Flying_Bird_C_.__Globals;
using My_Flappy_Bird_C_Sharp_V2.__Globals;
using My_Flappy_Bird_C_Sharp_V2._A1_MainMenu_Handler;
using My_Flappy_Bird_C_Sharp_V2._A2_GameArea_Handler;
using My_Flappy_Bird_C_Sharp_V2._A3_Player;
using My_Flappy_Bird_C_Sharp_V2._A5_Score;
using My_Flappy_Bird_C_Sharp_V2._A6_Pipes.Creating;
using My_Flappy_Bird_C_Sharp_V2._A6_Pipes.Moving;
using My_Flappy_Bird_C_Sharp_V2._A7_Collision;
using My_Flappy_Bird_C_Sharp_V2.General;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace My_Flappy_Bird_C_Sharp_V2._A0_Main
{
    internal class Game_Controller
    {
        #region The Fields
        private MainWindow_Handler obj_MWH = new MainWindow_Handler();
        private GameArea_Handler obj_GAH = new GameArea_Handler();
        private Player_Creation obj_PC = new Player_Creation();
        private Plyer_Moving_Handler obj_PMH = new Plyer_Moving_Handler();
        private DispatcherTimer game_Dispatcher_Timer = new DispatcherTimer();
        private Score_Handler obj_SH = new Score_Handler();
        private Pipes_Creating obj_PiPC = new Pipes_Creating();
        private Pipes_Moving_Handler obj_PipMH = new Pipes_Moving_Handler();
        private DateTime start;
        private DateTime end;
        private TimeSpan diff;
        private Collision_Handler obj_CH = new Collision_Handler();
        private Player_Life obj_PL = new Player_Life();
        private My_Image_Class obj_IC = new My_Image_Class();
        #endregion
        //---------------------------------------------------------------------------------------------------------
        public void Handle_The_Game(Window mWindow)
        {
            Globals_Collision.does_Collision_Happend = false;
            //----
            Globals_MainWindow.mWindow = mWindow;
            //----
            obj_MWH.handle_MainWindow();
            //---
            obj_GAH.handle_The_GameArea();
            //---
            obj_PC.handle_The_Player();
            //----
            obj_SH.add_Score_To_GameArea();
            //----
            obj_PiPC.handle_Creating_And_Adding_The_Pipes_To_GameArea();
            //----
            obj_PL.handle_Creating_Player_Life_Image();
            //----
            add_The_Start_Button(mWindow);
            //---
            // Moving(mWindow);
            //----
        }
        //---------------------------------------------------------------------------------------------------------
        private void game_Loop(Window mWindow)
        {
            //----
            Thread game_Thread = new Thread(() =>
            {
                Moving();

                Actions_After_Collision(mWindow);

            });
            //----
            game_Thread.Start();
            //----
        }
        //---------------------------------------------------------------------------------------------------------
        private void Stop(Window mWindow)
        {

            Restart(mWindow);
        }
        //---------------------------------------------------------------------------------------------------------
        private void Restart(Window mWindow)
        {
            game_Loop(mWindow);
        }
        //---------------------------------------------------------------------------------------------------------
        private double GetTextWidth(TextBlock textBlock)
        {
            // Create a FormattedText object to measure the text
            FormattedText formattedText = new FormattedText(
                textBlock.Text, // The text of the TextBlock
                System.Globalization.CultureInfo.CurrentCulture,
                System.Windows.FlowDirection.LeftToRight,
                new Typeface(textBlock.FontFamily, textBlock.FontStyle, textBlock.FontWeight, textBlock.FontStretch),
                textBlock.FontSize,  // Font size of the text
                textBlock.Foreground  // Text color (brush)
            );

            // Return the width of the formatted text
            return formattedText.Width;
        }
        //---------------------------------------------------------------------------------------------------------
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();  // This will close the application
        }
        //---------------------------------------------------------------------------------------------------------
        private void ResumeButton_Click(object sender, RoutedEventArgs e, Window mWindow)
        {


            /// bug # i am here ....what should i do befor i invoke the below method

            Handle_The_Game(mWindow);
        }
        //---------------------------------------------------------------------------------------------------------
        private void add_The_Start_Button(Window mWindow)
        {


            Button startButton = new Button
            {
                Content = "Start the Game",
                Width = 120,
                Height = 40
            };

            // Add click event
            startButton.Click += (s, e) =>
            {
                // Remove the button from the canvas
                Globals_GameArea.gameArea.Children.Remove(startButton);

                // Additional code to execute after button removal
                Globals_Pipes.pipes_Storyboard.Begin();
                Globals_GameBackground.background_Storyboard.Begin();
                game_Loop(mWindow);
            };


            // Add the button to the Canvas
            Globals_GameArea.gameArea.Children.Add(startButton);

            // Center the button
            double canvasWidth = Globals_GameArea.gameArea.Width;
            double canvasHeight = Globals_GameArea.gameArea.Height;
            Canvas.SetLeft(startButton, (canvasWidth - startButton.Width) / 2);
            Canvas.SetTop(startButton, (canvasHeight - startButton.Height) / 2);



        }
        //---------------------------------------------------------------------------------------------------------
        private void Moving()
        {
            while (Globals_Collision.does_Collision_Happend == false)
            {
                start = DateTime.Now;
                obj_PMH.handle_The_Moving_Of_The_Player();
                obj_PipMH.handl_The_Moving_Of_The_Pipes();
                Globals_Collision.does_Collision_Happend = obj_CH.handle_Player_Collision();
                //  Globals_GameBackground.background_Storyboard.Stop();
                end = DateTime.Now;

                diff = end - start;
                if (diff.TotalMilliseconds < 50)
                {
                    Thread.Sleep((int)(50 - diff.TotalMilliseconds));
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------
        private void Actions_After_Collision(Window mWindow)
        {
            //----
            Globals_GameBackground.background_Storyboard.Stop();
            Globals_Pipes.pipes_Storyboard.Stop();

              // i will check for game over actions 
           
                //----
                Application.Current.Dispatcher.Invoke(() =>
                {
                    //----
                    if (Globals_Player.num_Of_Plyer_Life > 0)
                    {
                        Globals_Player.num_Of_Plyer_Life -= 1;

                    }
                    //----
                    Canvas canvas = new Canvas();
                    canvas.Width = 400;
                    canvas.Height = 150;
                    canvas.Background = Brushes.Aqua;

                    // Create a TextBlock to display text
                    TextBlock textBlock = new TextBlock
                    {
                        Text = "You Lost Life!", // Set your text
                        FontSize = 24,               // Set font size
                        Foreground = Brushes.Black,   // Set text color
                        FontWeight = FontWeights.Bold // Set font weight
                    };

                    double textWidth = GetTextWidth(textBlock);


                    // Calculate the left position to center the text horizontally on the Canvas
                    double canvasWidth = canvas.Width;

                    double leftPosition = (canvasWidth - textWidth) / 2;

                    canvas.Children.Add(textBlock);

                    Canvas.SetLeft(textBlock, leftPosition);
                    Canvas.SetTop(textBlock, 20);  // Set Y position

                    // Add the TextBlock to the Canvas



                    Button resumeButton = new Button
                    {
                        Content = "Resume",
                        Width = 50,   // Button width
                        Height = 30   // Button height
                    };

                    // Create "Exit" Button
                    Button exitButton = new Button
                    {
                        Content = "Exit",
                        Width = 50,   // Button width
                        Height = 30   // Button height
                    };

                    // Calculate the left positions of the buttons to ensure they are evenly distributed
                    double gap = (canvas.Width - 2 * resumeButton.Width) / 3;

                    // Set the position of "Resume" Button
                    Canvas.SetLeft(resumeButton, gap); // First button at the gap
                    Canvas.SetTop(resumeButton, 100);
                    // Set the position of "Exit" Button
                    Canvas.SetLeft(exitButton, gap + resumeButton.Width + gap); // Second button at the second gap
                    Canvas.SetTop(exitButton, 100);
                    // Add the buttons to the canvas
                    canvas.Children.Add(resumeButton);
                    canvas.Children.Add(exitButton);

                    resumeButton.Click += (sender, e) => ResumeButton_Click(sender, e, mWindow); // Handler for Resume Button click
                    exitButton.Click += ExitButton_Click;      // Handler for Exit Button click


                    Globals_GameArea.gameArea.Children.Add(canvas);
                    Canvas.SetLeft(canvas, 200);
                    Canvas.SetTop(canvas, 100);
                    Canvas.SetZIndex(canvas, 10);
                });
                //----
           

        }
        //---------------------------------------------------------------------------------------------------------
        private void gameOver_Actions()
        {

        }
    }
}

