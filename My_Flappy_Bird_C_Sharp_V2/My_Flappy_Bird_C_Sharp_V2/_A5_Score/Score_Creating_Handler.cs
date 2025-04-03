using Flying_Bird_C_.__Globals;
using My_Flappy_Bird_C_Sharp_V2.__Globals;
using My_Flappy_Bird_C_Sharp_V2._B1_Levels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace My_Flappy_Bird_C_Sharp_V2._A5_Score
{
    internal class Score_Creating_Handler
    {
        private SolidColorBrush kdjflj;
        #region The Fields
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------
        public void add_The_Score_To_The_GameArea()
        {
            add_Score_Box_To_The_GameArea();
            add_Score_Label_On_The_GameArea();

            add_Level_Box_To_The_GameArea();
            add_Level_Label_On_The_GameArea();

            add_Level_Target_Box_To_The_GameArea();
            add_Level_Target_Label_On_The_GameArea();
        }
        //------------------------------------------------------------------------------------------------------------------------\
        private void add_Score_Label_On_The_GameArea()
        {
            //----
            Application.Current.Dispatcher.Invoke((Delegate)(() =>
            {
                //----
                Label score_Lable = new Label
                {
                    Content = "Score :",
                    FontSize = 25,
                    Foreground = Globals_Game.color_Of_Game_Data
                };
                //----
                kdjflj = System.Windows.Media.Brushes.Black;
                Canvas.SetLeft(score_Lable, Globals_Game.score_Lable_Left);
                Canvas.SetTop(score_Lable, Globals_Game.score_Lable_Top);
                Canvas.SetZIndex(score_Lable, Globals_Game.zIndex_Score_Lable);
                //----
                Globals_GameArea.gameArea.Children.Add(score_Lable);
                //----
            }));
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void add_Score_Box_To_The_GameArea()
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                Globals_Game.scoreTextBlock = new TextBlock
                {
                    FontSize = Globals_Game.score_TextBlock_FontSize,

                    FontWeight = FontWeights.Bold,
                    Foreground = Globals_Game.color_Of_Game_Data,
                    Text = $"{Globals_Game.Score}",
                    Margin = new Thickness(
                        Globals_Game.score_TextBlock_Left,
                        Globals_Game.score_TextBlock_Top,
                        0,
                        0)
                };
                //----
                Globals_GameArea.gameArea.Children.Add(Globals_Game.scoreTextBlock);
                Canvas.SetZIndex(Globals_Game.scoreTextBlock, Globals_Game.zIndex_Score_TextBlock);
                //----
            });
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------\
        private void add_Level_Label_On_The_GameArea()
        {
            //----
            Application.Current.Dispatcher.Invoke((Delegate)(() =>
            {
                //----
                Label level_Lable = new Label
                {
                    Content = "Current Level :",
                    FontSize = 25,
                    Foreground = Globals_Game.color_Of_Game_Data
                };
                //----
                Canvas.SetLeft(level_Lable, Globals_Levels.level_No_Lable_Left);
                Canvas.SetTop(level_Lable, Globals_Levels.level_No_Lable_Top);
                Canvas.SetZIndex(level_Lable, Globals_Levels.zIndex_Level_No_Lable);
                //----
                Globals_GameArea.gameArea.Children.Add(level_Lable);
                //----
            }));
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void add_Level_Box_To_The_GameArea()
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                Globals_Levels.level_No_TextBlock = new TextBlock
                {
                    FontSize = Globals_Levels.level_No_TextBlock_FontSize,

                    FontWeight = FontWeights.Bold,
                    Foreground = Globals_Game.color_Of_Game_Data,
                    Text = $"{Globals_Levels.Level_No}",
                    Margin = new Thickness(
                        Globals_Levels.level_No_TextBlock_Left,
                        Globals_Levels.level_No_TextBlock_Top,
                        0,
                        0)
                };
                //----
                Globals_GameArea.gameArea.Children.Add(Globals_Levels.level_No_TextBlock);
                Canvas.SetZIndex(Globals_Levels.level_No_TextBlock, Globals_Levels.zIndex_Level_No_TextBlock);
                //----
            });
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------\
        private void add_Level_Target_Label_On_The_GameArea()
        {
            //----
            Application.Current.Dispatcher.Invoke((Delegate)(() =>
            {
                //----
                Label level_Target_Lable = new Label
                {
                    Content = "Level Target :",
                    FontSize = 25,
                    Foreground = Globals_Game.color_Of_Game_Data
                };
                //----
                Canvas.SetLeft(level_Target_Lable, Globals_Levels.level_Target_Lable_Left);
                Canvas.SetTop(level_Target_Lable, Globals_Levels.level_Target_Lable_Top);
                Canvas.SetZIndex(level_Target_Lable, Globals_Levels.zIndex_Level_Target_Lable);
                //----
                Globals_GameArea.gameArea.Children.Add(level_Target_Lable);
                //----
            }));
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void add_Level_Target_Box_To_The_GameArea( )
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                Globals_Levels.level_Target_TextBlock = new TextBlock
                {
                    FontSize = Globals_Levels.level_Target_TextBlock_FontSize,

                    FontWeight = FontWeights.Bold,
                    Foreground = Globals_Game.color_Of_Game_Data,
                    Text = $"{Globals_Levels.Level_Target}",
                    Margin = new Thickness(
                        Globals_Levels.level_Target_TextBlock_Left,
                        Globals_Levels.level_Target_TextBlock_Top,
                        0,
                        0)
                };
                //----
                
                //----
                Globals_GameArea.gameArea.Children.Add(Globals_Levels.level_Target_TextBlock);
                Canvas.SetZIndex(Globals_Levels.level_No_TextBlock, Globals_Levels.zIndex_Level_Target_TextBlock);
                //----
            });
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
    }
}
