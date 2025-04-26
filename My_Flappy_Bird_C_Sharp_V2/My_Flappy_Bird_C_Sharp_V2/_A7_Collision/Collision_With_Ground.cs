using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Flappy_Bird_C_Sharp_V2._A7_Collision
{
    internal class Collision_With_Ground
    {
        #region The Fields
        private Collision_G obj_CG = new Collision_G();
        #endregion
        //--------------------------------------------------------------------------------------------------------
        public bool is_Ground_Collison_Detected()
        {
            return obj_CG.does_Collision_Happend(Globals_Ground.ground, Globals_Player.img_Player);
        }
    }
}
