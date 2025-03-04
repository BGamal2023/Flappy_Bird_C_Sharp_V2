using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace My_Flappy_Bird_C_Sharp_V2._A3_Player
{
    internal class Plyer_Moving_Handler
    {
        #region The Fields
        #endregion
        //---------------------------------------------------------------------------------------------------------------------
        public void handle_The_Moving_Of_The_Player()
        {
            move_The_Player_Down();
            move_The_Player_Up();
        }
        //---------------------------------------------------------------------------------------------------------------------
        private void move_The_Player_Up()
        {
            if (Globals_Player.should_I_Move_Player_Up)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    double top = Canvas.GetTop(Globals_Player.img_Player);
                    top -= Globals_Player.player_Moving_Step;

                    Canvas.SetTop(Globals_Player.img_Player, top);

                });
            }
        }
        //---------------------------------------------------------------------------------------------------------------------
        private void move_The_Player_Down()
        {
            if (Globals_Player.should_I_Move_Player_Down)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    double top = Canvas.GetTop(Globals_Player.img_Player);
                    top += Globals_Player.player_Moving_Step;

                    Canvas.SetTop(Globals_Player.img_Player, top);
                });

            }
        }
        //---------------------------------------------------------------------------------------------------------------------
    }
}
