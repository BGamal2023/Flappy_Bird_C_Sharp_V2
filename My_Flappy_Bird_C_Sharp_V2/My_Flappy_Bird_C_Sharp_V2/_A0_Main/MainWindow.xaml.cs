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
            obj_GC.handle_The_Game(this);
            //----
        }
        //----------------------------------------------------------------------------------------------------------------------------

    }
}