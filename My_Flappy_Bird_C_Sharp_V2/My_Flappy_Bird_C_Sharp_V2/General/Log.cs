using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Flappy_Bird_C_Sharp_V2.General
{
    internal class Log
    {
        #region The Fields
        #endregion 
        //----------------------------------------------------------------------------------------------------------------------------
        public static void log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
