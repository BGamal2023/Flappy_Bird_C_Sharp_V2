using Flying_Bird_C_.__Globals;
using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace My_Flappy_Bird_C_Sharp_V2._A5_Score
{
    internal class Score_Increasing_Handler
    {
        #region The Fields
        private HashSet<Image> scoredPipes = new HashSet<Image>(); // Keep track of scored pipes
        #endregion
        //--------------------------------------------------------------------------------------------------------------------------
        public void handle_Increasing_The_Score_Of_The_Player()
        {
            //------
            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                for (int i = 0; i < Globals_Pipes.li_Of_Pipes.Count; i++)
                {
                    //----
                    Image i_Pipe = Globals_Pipes.li_Of_Pipes[i];
                    //----
                    increase_Score_By_One_If_The_Player_Pass_A_Pipe(i_Pipe);
                    //-----
                    remove_The_Pipe_From_ScoredPipes_List_If_It_Come_Again_In_Front_Of_The_Player(i_Pipe);
                    //-----
                }
                //----
            });
            //------
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void increase_Score_By_One_If_The_Player_Pass_A_Pipe(Image pipe)
        {
            //----
            if (did_Player_Pass_A_Pipe(pipe))
            {
                Globals_Game.Score++;
                Globals_Game.scoreTextBlock.Text = $"{Globals_Game.Score}";

                scoredPipes.Add(pipe);
            }
            //-----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private bool did_Player_Pass_A_Pipe(Image i_Pipe)
        {
            //----
            double i_Pipe_Left = Canvas.GetLeft(i_Pipe);
            //----
            if (i_Pipe_Left < Globals_Player.player_Left_Pos &&
                        i_Pipe_Left + Globals_Pipes.width_Of_Pipe > Globals_Player.player_Left_Pos
                      && !scoredPipes.Contains(i_Pipe))
            {
                return true;
            }
            return false;
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void remove_The_Pipe_From_ScoredPipes_List_If_It_Come_Again_In_Front_Of_The_Player(Image Pipe)
        {
            //-----
            double i_Pipe_Left = Canvas.GetLeft(Pipe);
            //-----
            if (i_Pipe_Left > Globals_Player.player_Left_Pos && scoredPipes.Contains(Pipe))
            {
                scoredPipes.Remove(Pipe);
            }
            //-----
        }
        //--------------------------------------------------------------------------------------------------------------------------
    }
}
