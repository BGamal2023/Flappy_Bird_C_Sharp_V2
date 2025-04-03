using Flying_Bird_C_.__Globals;
using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace My_Flappy_Bird_C_Sharp_V2._A6_Pipes.Creating
{
    internal class Pipes_Creating_And_Moving
    {
        #region Fields

        #endregion
        //--------------------------------------------------------------------------------------------------------------------------
        public void handle_Creating_And_Adding_The_Pipes_To_GameArea()
        {
            //----
            // create_List_Of_Pipes();
            //----
            //  add_The_Pipes_To_GameArea_V0();
            //-----
            creat_And_Add_The_Pipes_To_GameArea_V1();
            //-----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void create_List_Of_Pipes()
        {
            //----
            for (int i = 0; i < Globals_Pipes.num_Of_Pipes; i++)
            {
                //----
                if (i % 2 == 0)
                {
                    //up pipe
                    create_Up_Image_And_Get_Its_Image_Then_Add_It_To_The_List_Of_Pipes();
                }
                //----
                else
                {
                    // down pipe
                    method_2();
                }
                //----
            }
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private BitmapImage get_The_Down_Image()
        {
            string str_Image_Path = "pack://application:,,,/Assets/Photos/pipedown.png";

            BitmapImage bitmap_Up_Pipe_Imgae = new BitmapImage();
            bitmap_Up_Pipe_Imgae.BeginInit();
            bitmap_Up_Pipe_Imgae.UriSource = new Uri(str_Image_Path, UriKind.Absolute);
            bitmap_Up_Pipe_Imgae.EndInit();

            return bitmap_Up_Pipe_Imgae;
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private BitmapImage get_The_UP_Image()
        {
            string str_Image_Path = "pack://application:,,,/Assets/Photos/pipe.png";
            BitmapImage bitmap_Down_Pipe_Imgae = new BitmapImage();
            bitmap_Down_Pipe_Imgae.BeginInit();
            bitmap_Down_Pipe_Imgae.UriSource = new Uri(str_Image_Path, UriKind.Absolute);
            bitmap_Down_Pipe_Imgae.EndInit();

            return bitmap_Down_Pipe_Imgae;
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void create_Up_Image_And_Get_Its_Image_Then_Add_It_To_The_List_Of_Pipes()
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                BitmapImage bitmap_Up_Pipe_Imgae = get_The_Down_Image();

                //----
                Image i_Image = new Image()
                {
                    Width = Globals_Pipes.width_Of_Pipe,
                    Height = Globals_Pipes.height_Of_Pipe
                };
                //----
                i_Image.Source = bitmap_Up_Pipe_Imgae;
                //----
                Globals_Pipes.li_Of_Pipes.Add(i_Image);
                //----
            });
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void add_The_Pipes_To_GameArea_V0()
        {
            //----
            for (int i = 0; i < Globals_Pipes.li_Of_Pipes.Count; i++)
            {
                //----
                if (i % 2 == 0)
                {
                    // down pipe
                    //----
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //----
                        if (Globals_Pipes.li_Of_Pipes[i].Parent is Panel parentPanel)
                        {
                            parentPanel.Children.Remove(Globals_Pipes.li_Of_Pipes[i]);
                        }
                        //----
                        Globals_GameArea.gameArea.Children.Add(Globals_Pipes.li_Of_Pipes[i]);
                        //----
                        Canvas.SetLeft(Globals_Pipes.li_Of_Pipes[i],
                            Globals_Pipes.starting_Left);
                        Canvas.SetTop(Globals_Pipes.li_Of_Pipes[i],
                            0);
                        //----
                    });
                    //----
                }
                //----
                else
                {
                    // down pipes
                    //----
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //----
                        if (Globals_Pipes.li_Of_Pipes[i].Parent is Panel parentPanel)
                        {
                            parentPanel.Children.Remove(Globals_Pipes.li_Of_Pipes[i]); // Remove it from the old parent
                        }
                        //----
                        Globals_GameArea.gameArea.Children.Add(Globals_Pipes.li_Of_Pipes[i]);
                        //----
                        Canvas.SetLeft(Globals_Pipes.li_Of_Pipes[i],
                            Globals_Pipes.starting_Left);
                        Canvas.SetTop(Globals_Pipes.li_Of_Pipes[i], Globals_Pipes.down_Pipes_Top
                              );
                        //----
                    });
                    //----
                }
                //----
                Globals_Pipes.starting_Left = Globals_Pipes.starting_Left + Globals_Pipes.width_Bet_Pipes;
                //----
            }
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void method_2()
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                BitmapImage bitmap_Down_Pipe_Imgae = get_The_UP_Image();
                //----
                //----
                Image i_Image = new Image()
                {
                    Width = Globals_Pipes.width_Of_Pipe,
                    Height = Globals_Pipes.height_Of_Pipe
                };
                //----
                i_Image.Source = bitmap_Down_Pipe_Imgae;
                //----
                Globals_Pipes.li_Of_Pipes.Add(i_Image);
                //----
            });
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void creat_And_Add_The_Pipes_To_GameArea_V0()
        {
            //-------------
            #region Create 2 up Pipes 
            Image image_Pipe_1_UP = new Image
            {
                Width = Globals_Pipes.width_Of_Pipe,
                Height = Globals_Pipes.height_Of_Pipe
            };
            image_Pipe_1_UP.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/photos/pipe.png"));
            Image image_Pipe_2_UP = new Image
            {
                Width = Globals_Pipes.width_Of_Pipe,
                Height = Globals_Pipes.height_Of_Pipe
            };
            image_Pipe_2_UP.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/photos/pipe.png"));
            #endregion
            //-------------
            #region Create 2 down Pipes
            Image image_Pipe_1_Down = new Image
            {
                Width = Globals_Pipes.width_Of_Pipe,
                Height = Globals_Pipes.height_Of_Pipe
            };
            image_Pipe_1_Down.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/photos/pipedown.png"));

            Image image_Pipe_2_Down = new Image
            {
                Width = Globals_Pipes.width_Of_Pipe,
                Height = Globals_Pipes.height_Of_Pipe
            };
            image_Pipe_2_Down.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/photos/pipedown.png"));
            #endregion
            //-----------
            #region setLeft And setTop For All Images 
            Canvas.SetLeft(image_Pipe_1_UP, 800);
            Canvas.SetTop(image_Pipe_1_UP, Globals_Pipes.up_Pipes_Top);


            Canvas.SetLeft(image_Pipe_1_Down, 860);
            Canvas.SetTop(image_Pipe_1_Down, Globals_Pipes.down_Pipes_Top);


            Canvas.SetLeft(image_Pipe_2_UP, 920);
            Canvas.SetTop(image_Pipe_2_UP, Globals_Pipes.up_Pipes_Top);

            Canvas.SetLeft(image_Pipe_2_Down, 980);
            Canvas.SetTop(image_Pipe_2_Down, Globals_Pipes.down_Pipes_Top);
            #endregion
            //-------------
            #region Adding All images The GameArea
            Globals_GameArea.gameArea.Children.Add(image_Pipe_1_UP);
            Globals_GameArea.gameArea.Children.Add(image_Pipe_1_Down);

            Globals_GameArea.gameArea.Children.Add(image_Pipe_2_UP);
            Globals_GameArea.gameArea.Children.Add(image_Pipe_2_Down);
            #endregion
            //-------------
            #region Create DoublAnimation for every pipe
            DoubleAnimation backgroundAnimation_image_Pipe_1_UP = new DoubleAnimation
            {
                From = 800,               // Starting position
                To = 0,              // Move the image completely off-screen to the left
                Duration = new Duration(TimeSpan.FromMilliseconds(Globals_GameBackground.background_timer_Tick_duration)), // Duration of the animation
                RepeatBehavior = RepeatBehavior.Forever, // Make the animation repeat forever
                AutoReverse = false     // No reverse, we want continuous scrolling
            };

            DoubleAnimation backgroundAnimation_image_Pipe_1_Down = new DoubleAnimation
            {
                From = 860,               // Starting position
                To = 60,              // Move the image completely off-screen to the left
                Duration = new Duration(TimeSpan.FromMilliseconds(Globals_GameBackground.background_timer_Tick_duration)), // Duration of the animation
                RepeatBehavior = RepeatBehavior.Forever, // Make the animation repeat forever
                AutoReverse = false     // No reverse, we want continuous scrolling
            };


            DoubleAnimation backgroundAnimation_image_Pipe_2_UP = new DoubleAnimation
            {
                From = 920,               // Starting position
                To = 120,              // Move the image completely off-screen to the left
                Duration = new Duration(TimeSpan.FromMilliseconds(Globals_GameBackground.background_timer_Tick_duration)), // Duration of the animation
                RepeatBehavior = RepeatBehavior.Forever, // Make the animation repeat forever
                AutoReverse = false     // No reverse, we want continuous scrolling
            };


            DoubleAnimation backgroundAnimation_image_Pipe_2_Down = new DoubleAnimation
            {
                From = 980,               // Starting position
                To = 180,              // Move the image completely off-screen to the left
                Duration = new Duration(TimeSpan.FromMilliseconds(Globals_GameBackground.background_timer_Tick_duration)), // Duration of the animation
                RepeatBehavior = RepeatBehavior.Forever, // Make the animation repeat forever
                AutoReverse = false     // No reverse, we want continuous scrolling
            };

            #endregion
            //-------------
            #region Add All BackgroundAnimations to the Storyboard

            Storyboard.SetTarget(backgroundAnimation_image_Pipe_1_UP, image_Pipe_1_UP);
            Storyboard.SetTargetProperty(backgroundAnimation_image_Pipe_1_UP, new PropertyPath("(Canvas.Left)"));

            Storyboard.SetTarget(backgroundAnimation_image_Pipe_2_UP, image_Pipe_2_UP);
            Storyboard.SetTargetProperty(backgroundAnimation_image_Pipe_2_UP, new PropertyPath("(Canvas.Left)"));

            Storyboard.SetTarget(backgroundAnimation_image_Pipe_1_Down, image_Pipe_1_Down);
            Storyboard.SetTargetProperty(backgroundAnimation_image_Pipe_1_Down, new PropertyPath("(Canvas.Left)"));

            Storyboard.SetTarget(backgroundAnimation_image_Pipe_2_Down, image_Pipe_2_Down);
            Storyboard.SetTargetProperty(backgroundAnimation_image_Pipe_2_Down, new PropertyPath("(Canvas.Left)"));

            #endregion
            // Create a Storyboard for the animation
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(backgroundAnimation_image_Pipe_1_UP);
            storyboard.Begin();

            storyboard.Children.Add(backgroundAnimation_image_Pipe_2_UP);
            storyboard.Begin();

            storyboard.Children.Add(backgroundAnimation_image_Pipe_1_Down);
            storyboard.Begin();

            storyboard.Children.Add(backgroundAnimation_image_Pipe_2_Down);
            storyboard.Begin();

        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void creat_And_Add_The_Pipes_To_GameArea_V1()
        {
            //-------------
            #region Clear Old List Of Pipes
            Globals_Pipes.li_Of_Pipes.Clear();
            #endregion
            //-------------
            #region Create 1 up Pipes 
            Image image_Pipe_1_UP = new Image
            {
                Width = Globals_Pipes.width_Of_Pipe,
                Height = Globals_Pipes.height_Of_Pipe
            };
            image_Pipe_1_UP.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/photos/pipedown.png"));

            #endregion
            //-------------
            #region Create 1 down Pipes
            Image image_Pipe_1_Down = new Image
            {
                Width = Globals_Pipes.width_Of_Pipe,
                Height = Globals_Pipes.height_Of_Pipe
            };
            image_Pipe_1_Down.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/photos/pipe.png"));

            #endregion
            //-----------
            #region setLeft And setTop For All Images 
            Canvas.SetLeft(image_Pipe_1_UP, 800);
            Canvas.SetTop(image_Pipe_1_UP, Globals_Pipes.up_Pipes_Top);


            Canvas.SetLeft(image_Pipe_1_Down, 1200);
            Canvas.SetTop(image_Pipe_1_Down, Globals_Pipes.down_Pipes_Top);
            #endregion
            //-------------
            #region Adding all Images To The Pipes List
            Globals_Pipes.li_Of_Pipes.Add(image_Pipe_1_Down);
            Globals_Pipes.li_Of_Pipes.Add(image_Pipe_1_UP);
            #endregion
            //-------------
            #region Adding All images The GameArea
            for (int i = 0; i < Globals_Pipes.li_Of_Pipes.Count; i++)
            {
                Image i_Pipe = Globals_Pipes.li_Of_Pipes[i];
                Globals_GameArea.gameArea.Children.Add(i_Pipe);
            }
            #endregion
            //-------------
            #region Create DoublAnimation for every pipe
            DoubleAnimation backgroundAnimation_image_Pipe_1_UP = new DoubleAnimation
            {
                From = 800,               // Starting position
                To = -800,              // Move the image completely off-screen to the left
                Duration = new Duration(TimeSpan.FromMilliseconds(Globals_Pipes.pipes_Timer_Tick_duration)), // Duration of the animation
                RepeatBehavior = RepeatBehavior.Forever, // Make the animation repeat forever
                AutoReverse = false     // No reverse, we want continuous scrolling
            };

            DoubleAnimation backgroundAnimation_image_Pipe_1_Down = new DoubleAnimation
            {
                From = 1200,               // Starting position
                To = -400,              // Move the image completely off-screen to the left
                Duration = new Duration(TimeSpan.FromMilliseconds(Globals_Pipes.pipes_Timer_Tick_duration)), // Duration of the animation
                RepeatBehavior = RepeatBehavior.Forever, // Make the animation repeat forever
                AutoReverse = false     // No reverse, we want continuous scrolling
            };



            #endregion
            //-------------
            #region Add All BackgroundAnimations to the Storyboard

            Storyboard.SetTarget(backgroundAnimation_image_Pipe_1_UP, image_Pipe_1_UP);
            Storyboard.SetTargetProperty(backgroundAnimation_image_Pipe_1_UP, new PropertyPath("(Canvas.Left)"));


            Storyboard.SetTarget(backgroundAnimation_image_Pipe_1_Down, image_Pipe_1_Down);
            Storyboard.SetTargetProperty(backgroundAnimation_image_Pipe_1_Down, new PropertyPath("(Canvas.Left)"));

            #endregion
            //-------------
            #region Create a Storyboard for the animation
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(backgroundAnimation_image_Pipe_1_UP);
            storyboard.Children.Add(backgroundAnimation_image_Pipe_1_Down);
           // storyboard.Completed += (s, e) => Storyboard_Completed(s, e);

            Globals_Pipes.pipes_Storyboard = storyboard;
            #endregion
            //-------------

        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void Storyboard_Completed(object? sender, EventArgs e)
        {
            Debug.WriteLine("story completed");
            Debug.WriteLine("****************************************************************");
            Globals_Pipes.does_Player_Pass_Pipe = true;
        }
        //--------------------------------------------------------------------------------------------------------------------------
    }
}
