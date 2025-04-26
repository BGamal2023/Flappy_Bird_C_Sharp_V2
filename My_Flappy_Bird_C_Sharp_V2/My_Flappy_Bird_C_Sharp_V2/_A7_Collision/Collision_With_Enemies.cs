using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Flappy_Bird_C_Sharp_V2._A7_Collision
{
    internal class Collision_With_Enemies
    {
        #region The Fields
        private Collision_G obj_CG = new Collision_G();
        #endregion
        //---------------------------------------------------------------------------------------------------------------
        public bool check_Collision_With_The_Enemy()
        {
            return obj_CG.does_Collision_Happend(Globals_Enemies.enemy_Image, Globals_Player.img_Player);
        }
        //---------------------------------------------------------------------------------------------------------------
    }
}
