using Flying_Bird_C_.__Globals;
using My_Flappy_Bird_C_Sharp_V2.__Globals;
using My_Flappy_Bird_C_Sharp_V2._A5_Score;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace My_Flappy_Bird_C_Sharp_V2._A6_Pipes.Moving
{
    internal class Pipes_Moving_Handler
    {
        #region Fields
        private int count = 0;
        #endregion
        //--------------------------------------------------------------------------------------------------------------------------------------
        public void handl_The_Moving_Of_The_Pipes()
        {
            // move_The_Pipes_V1();
          //  move_The_Pipes_V2();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void move_The_Pipes_V1()
        {

            //----
            foreach (var i_Pipe in Globals_Pipes.li_Of_Pipes.ToList())
            {


                Application.Current.Dispatcher.Invoke(() =>
                {
                    Globals_GameArea.gameArea.Children.Remove(i_Pipe);

                    double left = Canvas.GetLeft(i_Pipe);
                    if (left < -Globals_Pipes.width_Of_Pipe)
                    {
                        Image last_Pipe = Globals_Pipes.li_Of_Pipes.Last();
                        double left_Of_Last_Pipe = Canvas.GetLeft(last_Pipe);
                        left = left_Of_Last_Pipe + Globals_Pipes.width_Bet_Pipes;

                        Globals_Pipes.li_Of_Pipes.Remove(i_Pipe);
                        Globals_Pipes.li_Of_Pipes.Add(i_Pipe);
                    }
                    Globals_GameArea.gameArea.Children.Add(i_Pipe);
                    Canvas.SetLeft(i_Pipe, left - Globals_Pipes.pipes_Moving_Step);
                });
            }
            //----
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void move_The_Pipes_V2()
        {
            //----

            //----
            foreach (var i_Pipe in Globals_Pipes.li_Of_Pipes.ToList())
            {
                //----
                Application.Current.Dispatcher.Invoke(() =>
                {
                    //----
                    Globals_GameArea.gameArea.Children.Remove(i_Pipe);
                    //----
                    double left = Canvas.GetLeft(i_Pipe);
                    //----
                    if (left < -Globals_Pipes.width_Of_Pipe)
                    {
                        //--
                        Image last_Pipe = Globals_Pipes.li_Of_Pipes.Last();
                        //--
                        double left_Of_Last_Pipe = Canvas.GetLeft(last_Pipe);
                        //--
                        left = left_Of_Last_Pipe + Globals_Pipes.width_Bet_Pipes;
                        //--
                        Globals_Pipes.li_Of_Pipes.Remove(i_Pipe);
                        Globals_Pipes.li_Of_Pipes.Add(i_Pipe);
                        //--
                        //--
                    }
                    //----
                    Globals_GameArea.gameArea.Children.Add(i_Pipe);
                    Canvas.SetLeft(i_Pipe, left - Globals_Pipes.pipes_Moving_Step);
                    //----
                });
                //----
            }
            //----
          //  Score_Handler.handle_Player_Score();
            //----

        }
        //---------------------------------------------------------------------------------------------------------------------------------------

    }
}
