using My_Flappy_Bird_C_Sharp_V2.__Globals;
using My_Flappy_Bird_C_Sharp_V2._A0_Main;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace My_Flappy_Bird_C_Sharp_V2
{
  
    public partial class MainWindow : Window
    {
        #region The Fields
        private Game_Controller obj_GC=new Game_Controller();
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------
        public MainWindow()
        {
            //----
            InitializeComponent();
            //----
            obj_GC.Handle_The_Game(this);
            //----
            this.KeyDown += onKeyDown;
            this.KeyUp += onKeyUp;
        }
        //----------------------------------------------------------------------------------------------------------------------------
        private void onKeyUp(object sender, KeyEventArgs e)
        {
            Globals_Player.should_I_Move_Player_Down = true;
            Globals_Player.should_I_Move_Player_Up = false;

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            Globals_Player.should_I_Move_Player_Up = true;
            Globals_Player.should_I_Move_Player_Down = false;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}