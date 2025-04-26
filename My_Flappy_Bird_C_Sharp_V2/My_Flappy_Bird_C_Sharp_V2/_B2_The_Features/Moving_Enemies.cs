using My_Flappy_Bird_C_Sharp_V2.__Globals;
using My_Flappy_Bird_C_Sharp_V2.General;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace My_Flappy_Bird_C_Sharp_V2._B2_The_Features
{
    internal class Moving_Enemies
    {
        #region The Fields
        private C_Moving_Image_G obj_MI = new C_Moving_Image_G();
        private int previous_Score = 0;
        #endregion
        //---------------------------------------------------------------------------------------------------------------------
        public void handle_The_Moving_Of_The_Enemy(
            double up_Moving_Step,
            double down_Moving_Step,
            double left_Moving_Step,
            double right_Moving_Step,
            Image enemy,
            Canvas gameArea)
        {

            //----
            handle_Conditions_For_Enemey_Moving(
         enemy,
         gameArea);
            //----
            move_The_Enemy_Down(
                down_Moving_Step,
               enemy);
            //----
            move_The_Enemy_Up(
                up_Moving_Step,
                 enemy);
            //----
            move_The_Enemy_Left(
                left_Moving_Step,
                enemy);
            //----
            move_The_Enemy_Right(
                right_Moving_Step,
                enemy);
            //----


        }
        //---------------------------------------------------------------------------------------------------------------------
        private void move_The_Enemy_Up(
             double up_Moving_Step,
           Image image)
        {
            if (Globals_Enemies.should_Enemy_Move_Up)
            {
                obj_MI.move_The_Image_Up(
                up_Moving_Step,
               image);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------
        private void move_The_Enemy_Down(
            double down_Moving_Step,
              Image image)
        {
            if (Globals_Enemies.should_Enemy_Move_Down)
            {
                obj_MI.move_The_Image_Down(
                down_Moving_Step,
               image);

            }
        }
        //---------------------------------------------------------------------------------------------------------------------
        private void move_The_Enemy_Right(
            double down_Moving_Step,
              Image image)
        {
            if (Globals_Enemies.should_Enemy_Move_Right)
            {
                obj_MI.move_The_Image_Right(
                down_Moving_Step,
               image);

            }
        }
        //---------------------------------------------------------------------------------------------------------------------
        private void move_The_Enemy_Left(
            double down_Moving_Step,
              Image image)
        {
            if (Globals_Enemies.should_Enemy_Move_Left)
            {
                obj_MI.move_The_Image_Left(
                down_Moving_Step,
               image);

            }
        }
        //-----------------------------------------------------------------------------------------------------------------------
        private void handle_Conditions_For_Enemey_Moving(
            Image enemy,
            Canvas gameArea)
        {
            Debug.WriteLine("##################################################################");
            Debug.WriteLine("enemey moving handling condition invoked");
            Debug.WriteLine("Score = " + Globals_Levels.current_Level_Score);
            Debug.WriteLine("##################################################################");
            Application.Current.Dispatcher.Invoke(() =>
            {

                //----
                if (Globals_Game.Score == 2)
                {
                    previous_Score = Globals_Game.Score;
                    Globals_Enemies.should_Enemy_Move_Left = true;
                    Debug.WriteLine("******************************************************************************************************************");
                    Debug.WriteLine("enemy left =" + Globals_Enemies.should_Enemy_Move_Left);
                    Debug.WriteLine("******************************************************************************************************************");
                }
                //----
                if (Globals_Game.Score - previous_Score == 2)
                {
                    previous_Score = Globals_Game.Score;
                    bool isChild = gameArea.Children.Contains(enemy);

                    if (isChild == false)
                    {
                        gameArea.Children.Add(enemy);
                        Canvas.SetLeft(enemy, Globals_Enemies.enemy_Left_Pos);
                        Canvas.SetTop(enemy, Globals_Enemies.enemy_Top_Pos);

                        Globals_Enemies.should_Enemy_Move_Left = true;

                    }

                }
                //----
                double left = Canvas.GetLeft(enemy);
                if (left < 0)
                {
                    Globals_Enemies.should_Enemy_Move_Left = false;
                    //----
                    gameArea.Children.Remove(enemy);
                    //----

                }


            });
        }
        //-----------------------------------------------------------------------------------------------------------------------

    }
}
