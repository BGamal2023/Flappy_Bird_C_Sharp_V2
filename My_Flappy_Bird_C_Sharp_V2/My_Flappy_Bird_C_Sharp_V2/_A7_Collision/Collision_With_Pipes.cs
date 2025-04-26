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
        public bool does_Collison_With_Pipes_Happend(Image player)
        {
            //----
            foreach (Image i_Pipe in Globals_Pipes.li_Of_Pipes.ToList())
            {
                //----
                bool collision =
                    obj_CG.does_Collision_Happend(
                        player,
                        i_Pipe);
                //----
                if (collision)
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
