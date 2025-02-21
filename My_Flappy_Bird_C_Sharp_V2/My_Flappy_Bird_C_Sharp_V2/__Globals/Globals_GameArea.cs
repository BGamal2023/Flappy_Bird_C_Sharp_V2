using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace My_Flappy_Bird_C_Sharp_V2.__Globals
{
    internal class Globals_GameArea
    {
        public static Canvas gameArea=new Canvas();
        public static int gameArea_W = Globals_MainWindow.mWindow_W;
        public static int gameArea_H=Globals_MainWindow.mWindow_H;
        public static Brush gameArea_Background_Color=Brushes.MediumAquamarine;
    }
}
