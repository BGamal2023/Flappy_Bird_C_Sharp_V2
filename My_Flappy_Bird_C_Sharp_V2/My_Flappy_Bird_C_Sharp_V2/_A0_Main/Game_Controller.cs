using Flying_Bird_C_.__Globals;
using My_Flappy_Bird_C_Sharp_V2.__Globals;
using My_Flappy_Bird_C_Sharp_V2._A1_MainMenu_Handler;
using My_Flappy_Bird_C_Sharp_V2._A2_GameArea_Handler;
using My_Flappy_Bird_C_Sharp_V2._A3_Player;
using My_Flappy_Bird_C_Sharp_V2._A5_Score;
using My_Flappy_Bird_C_Sharp_V2._A6_Pipes.Creating;
using My_Flappy_Bird_C_Sharp_V2._A6_Pipes.Moving;
using My_Flappy_Bird_C_Sharp_V2._A7_Collision;
using My_Flappy_Bird_C_Sharp_V2._A9_Messages;
using My_Flappy_Bird_C_Sharp_V2._B1_Levels;
using My_Flappy_Bird_C_Sharp_V2._B2_The_Features;
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
        private Pipes_Creating_And_Moving obj_PiPC = new Pipes_Creating_And_Moving();
        private Pipes_Moving_Handler obj_PipMH = new Pipes_Moving_Handler();
        private DateTime start;
        private DateTime end;
        private TimeSpan diff;
        private Collision_Handler obj_CH = new Collision_Handler();
        private Player_Life obj_PL = new Player_Life();
        private My_Image_Class obj_IC = new My_Image_Class();
        private Score_GM obj_SGM = new Score_GM();
        private Level_Achieved_Message obj_LAM = new Level_Achieved_Message();
        private Levels_Controller obj_LC = new Levels_Controller();
        private Level_1 obj_L1 = new Level_1();
        private Enemies obj_Enemy=new Enemies();
     
        #endregion
        //---------------------------------------------------------------------------------------------------------
        public void Handle_The_Game(Window mWindow)
        {
            //----
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
            obj_Enemy.creat_Add_Enemy_To_GameArea();    
            //----
            obj_SGM.handle_Creating_The_Score_In_GameArea();
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
                Globals_Levels.current_Level.Run();
                //----
                Moving();
                //----
                Actions_After_Collision(mWindow);
                //----
                Actions_After_Level_Score_Reached(mWindow);
                //----
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
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();  // This will close the application
        }
        //---------------------------------------------------------------------------------------------------------
        private void ResumeButton_Click(object sender, RoutedEventArgs e, Window mWindow)
        {
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
            while (Globals_Collision.does_Collision_Happend == false
                    && Globals_Levels.did_The_Player_Achieve_The_Level_Target == false)
            {
                start = DateTime.Now;
                obj_PMH.handle_The_Moving_Of_The_Player();
                obj_PipMH.handl_The_Moving_Of_The_Pipes();
                Globals_Collision.does_Collision_Happend = obj_CH.handle_Player_Collision();
                obj_SGM.handle_Increasing_The_Score_During_Playing();
                obj_LC.monitor_The_Score();

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
            if (Globals_Player.li_Of_Player_Life_Images.Count == 1)
            {
                C_GameOver_Message obj_GOM = new C_GameOver_Message();
                Globals_Messages.current_Message = obj_GOM;
                Globals_Messages.current_Message.Run(mWindow);

                Globals_Buttons.btn_playAgain.Click += (sender, e) => playAgain_Button_Click(sender, e, mWindow); // Handler for Resume Button click
                Globals_Buttons.btn_Exit_The_Game.Click += ExitButton_Click;      // Handler for Exit Button click
            }
            else
            {
                //----
                Application.Current.Dispatcher.Invoke(() =>
                {
                    //----
                    if (Globals_Player.num_Of_Plyer_Life > 0)
                    {
                        Globals_Player.num_Of_Plyer_Life -= 1;
                    }
                    //----
                    C_Resume_Message obj_RM = new C_Resume_Message();

                    Globals_Messages.current_Message = obj_RM;
                    Globals_Messages.current_Message.Run(mWindow);
                    Globals_Buttons.btn_Resume.Click += (sender, e) => ResumeButton_Click(sender, e, mWindow); // Handler for Resume Button click
                    Globals_Buttons.btn_Exit_The_Game.Click += ExitButton_Click;      // Handler for Exit Button click
                    //-----
                });
                //----
            }
        }
        //---------------------------------------------------------------------------------------------------------
        private void playAgain_Button_Click(object sender, RoutedEventArgs e, Window mWindow)
        {
            gameOver_Actions(mWindow);
        }
        //---------------------------------------------------------------------------------------------------------
        private void gameOver_Actions(Window mWindow)
        {
            ///bug ...fill this method
            Globals_Player.num_Of_Plyer_Life = 3;
            Globals_Game.Score = 0;
            Globals_Game.scoreTextBlock.Text = $"{Globals_Game.Score}";

            Handle_The_Game(mWindow);


        }
        //---------------------------------------------------------------------------------------------------------
        private void Actions_After_Level_Score_Reached(Window mWindow)
        {
            if (Globals_Levels.did_The_Player_Achieve_The_Level_Target)
            {
                //----
                Globals_GameBackground.background_Storyboard.Stop();
                Globals_Pipes.pipes_Storyboard.Stop();
                //----
                // show message >>with buttons callbacks >>>> go to next level ...repeat current level .....Exit>>>>>.
                obj_LAM.handle_Level_Success_Message(mWindow);
                Globals_Buttons.btn_Repeat_Same_Level.Click += (sender, e) => btn_Repeat_Same_Level_Click(sender, e, mWindow);
                Globals_Buttons.btn_Next_Level.Click += (sender, e) => btn_Next_Level_Click(sender, e, mWindow);

                //----
            }

        }
        //---------------------------------------------------------------------------------------------------------
        private void btn_Repeat_Same_Level_Click(object sender, RoutedEventArgs e, Window mWindow)
        {

            gameOver_Actions(mWindow);
        }
        //---------------------------------------------------------------------------------------------------------
        private void btn_Next_Level_Click(object sender, RoutedEventArgs e, Window mWindow)
        {
            obj_LC.increase_Level_Num();
            obj_LC.detetc_The_Level();  
            Globals_Levels.current_Level.Run();
            Handle_The_Game(mWindow);
        }
        //---------------------------------------------------------------------------------------------------------
        private void start_With_Level_1()
        {
          
        }
    }
}

