using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace My_Flappy_Bird_C_Sharp_V2.__Globals
{
    internal class Globals_GameBackground
    {
        public static int game_Background_W=Globals_GameArea.gameArea_W;
        public static int game_Background_H=Globals_GameArea.gameArea_H;

        public static int background_timer_Tick_duration = 2;

        public static Storyboard background_Storyboard = new Storyboard();
        public static int counter = 0;
        public static BitmapImage bmi_Background_GameArea = new BitmapImage(new Uri("pack://application:,,,/Assets/photos/background_8.jpg"));
    }
}
