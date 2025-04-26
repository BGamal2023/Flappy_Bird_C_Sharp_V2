using Flying_Bird_C_.__Globals;
using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace My_Flappy_Bird_C_Sharp_V2._A7_Collision
{
    internal class Collision_Handler
    {
        #region The Fields
        private Collision_With_Pipes obj_CWP = new Collision_With_Pipes();
        private Collision_With_Enemies obj_CWE = new Collision_With_Enemies();
        private Collision_With_Ground obj_CWG = new Collision_With_Ground();
        private bool is_Collision_With_Any_Pipe_Detected = false;
        private bool is_Collision_With_The_Ground_Detected = false;
        private bool is_Collision_With_The_Enemy_Detected = false;
        #endregion

        //---------------------------------------------------------------------------------------------------------------
        public void handle_Player_Collision()
        {
            //----
            if (Globals_Player.img_Player == null)
            {
                Globals_Collision.does_Collision_Happend = false;
                return;
            }
            //----
            is_Collision_With_Any_Pipe_Detected =
                obj_CWP.is_Collison_With_Any_Pipe_Detected();
            is_Collision_With_The_Enemy_Detected =
                obj_CWE.check_Collision_With_The_Enemy();
            is_Collision_With_The_Ground_Detected =
                obj_CWG.is_Ground_Collison_Detected();
            //----
            Globals_Collision.does_Collision_Happend =
                is_Collision_With_The_Ground_Detected ||
                is_Collision_With_Any_Pipe_Detected ||
                is_Collision_With_The_Enemy_Detected;
            //----
        }
    }
}
