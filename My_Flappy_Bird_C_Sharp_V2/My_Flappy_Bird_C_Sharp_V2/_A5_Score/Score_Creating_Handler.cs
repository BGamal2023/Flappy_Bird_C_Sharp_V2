using Flying_Bird_C_.__Globals;
using My_Flappy_Bird_C_Sharp_V2.__Globals;
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
        #region The Fields
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------
        public void add_The_Score_To_The_GameArea()
        {
            add_Score_Box_To_The_GameArea();
            add_Score_Label_On_The_GameArea();
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
                    Foreground = System.Windows.Media.Brushes.Black
                };
                //----
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
                    Foreground = Brushes.Black,
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
    }
}
