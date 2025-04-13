using My_Flappy_Bird_C_Sharp_V2.__Globals;
using My_Flappy_Bird_C_Sharp_V2.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Flappy_Bird_C_Sharp_V2._B2_The_Features
{
    internal class Enemies
    {
        #region The Fields
       private Creating_And_Adding_Image_To_GameArea_G obj_CAITGA = new Creating_And_Adding_Image_To_GameArea_G();
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------------------------
        public void creat_Add_Enemy_To_GameArea()
        {
            obj_CAITGA.create_Set_Add_Image_To_GameArea(
                Globals_Enemies.enemy_W,
                Globals_Enemies.enemy_H,
                Globals_Enemies.assets_Source,
                Globals_Enemies.enemy_Left_Pos,
                Globals_Enemies.enemy_Top_Pos,
              ref Globals_Enemies.enemy_Image

                );
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------

    }
}
