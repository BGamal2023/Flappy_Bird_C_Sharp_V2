using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Flappy_Bird_C_Sharp_V2._A5_Score
{
    internal class Score_GM
    {
        #region The Fields
        private Score_Creating_Handler obj_SCH=new Score_Creating_Handler();
        private Score_Increasing_Handler obj_SIH=new Score_Increasing_Handler();    
        #endregion
        //------------------------------------------------------------------------------------------------------------
        public void handle_Creating_The_Score_In_GameArea()
        {
            obj_SCH.add_The_Score_To_The_GameArea();
        }
        //------------------------------------------------------------------------------------------------------------
        public void handle_Increasing_The_Score_During_Playing()
        {
            obj_SIH.handle_Increasing_The_Score_Of_The_Player();
        }
    }
}
