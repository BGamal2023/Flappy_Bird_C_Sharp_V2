using Flying_Bird_C_.__Globals;
using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace My_Flappy_Bird_C_Sharp_V2._B1_Levels
{
    internal class Level_3 : I_Level
    {
        public void Run()
        {

            Application.Current.Dispatcher.Invoke(() =>
            {
                Globals_GameBackground.background_timer_Tick_duration = 3500;
                Globals_Pipes.pipes_Timer_Tick_duration = 1750;
                Globals_Player.player_Moving_Step = 35;

                //--------------------------------------
                Globals_Levels.current_Level_No = 3;
                Globals_Levels.previous_Level_No = 2;
                Globals_Levels.next_Level_No = 4;
                Globals_Levels.current_Level_Score = 10;
                Globals_Levels.Level_No = 3;
                //--------------------------------------
                Globals_MainWindow.mWindow_W = 800;
                Globals_MainWindow.mWindow_H = 600;
                Globals_MainWindow.mWindow_BGround_Color = Brushes.Aqua;
                //--------------------------------------
                Globals_Game.game_Timer_Tick_Duration = 25;
                Globals_Game.color_Of_Game_Data = System.Windows.Media.Brushes.Black;
                Globals_Game.Score = 0;
                //--------------------------------------
                Globals_GameArea.gameArea_W = Globals_MainWindow.mWindow_W;
                Globals_GameArea.gameArea_H = Globals_MainWindow.mWindow_H;
                Globals_GameArea.gameArea_Background_Color = Brushes.MediumAquamarine;
                //--------------------------------------
                Globals_GameBackground.game_Background_W = Globals_GameArea.gameArea_W;
                Globals_GameBackground.game_Background_H = Globals_GameArea.gameArea_H;
                Globals_GameBackground.counter = 0;
                Globals_GameBackground.bmi_Background_GameArea = new BitmapImage(new Uri("pack://application:,,,/Assets/photos/background_6.jpg"));
                //--------------------------------------
                Globals_Pipes.num_Of_Pipes = 4;
                Globals_Pipes.width_Of_Pipe = 100;
                Globals_Pipes.height_Of_Pipe = 200;
                Globals_Pipes.width_Bet_Pipes = 300;
                Globals_Pipes.down_Pipes_Top = Globals_GameArea.gameArea_H - Globals_Pipes.height_Of_Pipe - 190;
                Globals_Pipes.up_Pipes_Top = 0;
                Globals_Pipes.starting_Left = Globals_GameArea.gameArea.Width - 200;
                Globals_Pipes.pipes_Moving_Step = 10;
                Globals_Pipes.does_Player_Pass_Pipe = false;
                //--------------------------------------
                Globals_Levels.level_No_Lable_W = 30;
                Globals_Levels.level_No_Lable_H = 20;
                Globals_Levels.level_No_Lable_Left = Globals_GameArea.gameArea_W - 220;
                Globals_Levels.level_No_Lable_Top = 10;
                Globals_Levels.level_No_TextBlock_FontSize = 25;
                Globals_Levels.level_No_TextBlock_Left = Globals_GameArea.gameArea_W - 50;
                Globals_Levels.level_No_TextBlock_Top = 17;
                Globals_Levels.zIndex_Level_No_Lable = 5;
                Globals_Levels.zIndex_Level_No_TextBlock = 5;
                //--------
                Globals_Levels.Level_Target = Globals_Levels.current_Level_Score;
                Globals_Levels.level_Target_Lable_W = 30;
                Globals_Levels.level_Target_Lable_H = 20;
                Globals_Levels.level_Target_Lable_Left = Globals_GameArea.gameArea_W - 560;
                Globals_Levels.level_Target_Lable_Top = 10;
                Globals_Levels.level_Target_TextBlock_FontSize = 25;
                Globals_Levels.level_Target_TextBlock_Left = Globals_GameArea.gameArea_W - 400;
                Globals_Levels.level_Target_TextBlock_Top = 17;
                Globals_Levels.zIndex_Level_Target_Lable = 5;
                Globals_Levels.zIndex_Level_Target_TextBlock = 5;
                Globals_Levels.did_The_Player_Achieve_The_Level_Target = false;
                //--------------------------------------
            });
        }
    }
}
