using Flying_Bird_C_.__Globals;
using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace My_Flappy_Bird_C_Sharp_V2._A7_Collision
{
    internal class Collision_With_Pipes
    {
        #region The Fields 
        private Collision_G obj_CG = new Collision_G();
        #endregion
        //--------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool is_Collison_With_Any_Pipe_Detected()
        {
            //----
            foreach (Image i_Pipe in Globals_Pipes.li_Of_Pipes.ToList())
            {
                //----
                bool is_Colliding_With_Any_Pipe =
                    obj_CG.does_Collision_Happend(
                        Globals_Player.img_Player,
                        i_Pipe);
                //----
                if (is_Colliding_With_Any_Pipe)
                {
                    return true;
                }
                //----
            }
            //----
            return false;
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------

    }
}
