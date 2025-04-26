using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace My_Flappy_Bird_C_Sharp_V2.__Globals
{
    internal class Globals_Ground
    {
        public static double ground_H = 200;
        public static double ground_W =Globals_GameArea.gameArea_W ;
        public static int ground_zIndex = 1;

        public static double ground_Left_Pos = 0;
        public static double ground_Top_Pos = Globals_Pipes.down_Pipes_Top + Globals_Pipes.height_Of_Pipe+5;

        public static Rectangle ground = new Rectangle();
    }
}
