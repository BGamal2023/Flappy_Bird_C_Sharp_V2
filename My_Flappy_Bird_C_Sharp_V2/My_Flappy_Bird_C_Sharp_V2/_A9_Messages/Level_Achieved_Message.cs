using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using My_Flappy_Bird_C_Sharp_V2.__Globals;

namespace My_Flappy_Bird_C_Sharp_V2._A9_Messages
{
    internal class Level_Achieved_Message
    {
        //---------------------------------------------------------------------------------------------------------
        public void handle_Level_Success_Message(Window mWindow)
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                Canvas level_Success_Canvas = new Canvas();
                level_Success_Canvas.Width = 400;
                level_Success_Canvas.Height = 150;
                level_Success_Canvas.Background = Brushes.Aqua;
                // Create a TextBlock to display text
                TextBlock level_Success_Text = new TextBlock
                {
                    Text = "Congratulation...! Level Done.....", // Set your text
                    FontSize = 24,               // Set font size
                    Foreground = Brushes.Black,   // Set text color
                    FontWeight = FontWeights.Bold // Set font weight
                };
                TextBlock tryAgainText = new TextBlock
                {
                    Text = "What Would You Like To Do..?",
                    FontSize = 18,
                    Foreground = Brushes.Red,
                    FontWeight = FontWeights.SemiBold,
                    TextAlignment = TextAlignment.Center
                };
                double textWidth = GetTextWidth(level_Success_Text);


                // Calculate the left position to center the text horizontally on the Canvas
                double canvasWidth = level_Success_Canvas.Width;

                double leftPosition = (canvasWidth - textWidth) / 2;

                level_Success_Canvas.Children.Add(level_Success_Text);
                level_Success_Canvas.Children.Add(tryAgainText);

                Canvas.SetLeft(level_Success_Text, leftPosition);
                Canvas.SetTop(level_Success_Text, 20);  // Set Y position


                Canvas.SetLeft(tryAgainText, leftPosition);
                Canvas.SetTop(tryAgainText, 50);

                // Add the TextBlock to the Canvas

                Button btn_Repeat_Same_Level = new Button
                {
                    Content = "Repeat Same Level",
                    Width = 110,   // Button width
                    Height = 30   // Button height
                };

                // Create "Exit" Button
                Button exit_Game_Button = new Button
                {
                    Content = "Exit Game",
                    Width = 110,   // Button width
                    Height = 30   // Button height
                };
                Button btn_Next_Level = new Button
                {
                    Content = "Next Level",
                    Width = 110,   // Button width
                    Height = 30   // Button height
                };

                Globals_Buttons.btn_Repeat_Same_Level = btn_Repeat_Same_Level;
                Globals_Buttons.btn_Next_Level = btn_Next_Level;
                Globals_Buttons.btn_Exit_The_Game = exit_Game_Button;


                // **Distribute Buttons Evenly**
                double totalButtonWidth = btn_Repeat_Same_Level.Width * 3;
                double spacing = (canvasWidth - totalButtonWidth) / 4; // Divide available space into 4 equal parts

                // Position buttons
                Canvas.SetLeft(btn_Repeat_Same_Level, spacing);
                Canvas.SetTop(btn_Repeat_Same_Level, 100);

                Canvas.SetLeft(btn_Next_Level, spacing * 2 + btn_Repeat_Same_Level.Width);
                Canvas.SetTop(btn_Next_Level, 100);

                Canvas.SetLeft(exit_Game_Button, spacing * 3 + btn_Repeat_Same_Level.Width * 2);
                Canvas.SetTop(exit_Game_Button, 100);
                //----
                level_Success_Canvas.Children.Add(btn_Repeat_Same_Level);
                level_Success_Canvas.Children.Add(btn_Next_Level);
                level_Success_Canvas.Children.Add(exit_Game_Button);
                //----



                Globals_GameArea.gameArea.Children.Add(level_Success_Canvas);
                Canvas.SetLeft(level_Success_Canvas, 200);
                Canvas.SetTop(level_Success_Canvas, 100);
                Canvas.SetZIndex(level_Success_Canvas, 10);



            });
            //----
        }
        //---------------------------------------------------------------------------------------------------------
        private double GetTextWidth(TextBlock textBlock)
        {
            // Create a FormattedText object to measure the text
            FormattedText formattedText = new FormattedText(
                textBlock.Text, // The text of the TextBlock
                System.Globalization.CultureInfo.CurrentCulture,
                System.Windows.FlowDirection.LeftToRight,
                new Typeface(textBlock.FontFamily, textBlock.FontStyle, textBlock.FontWeight, textBlock.FontStretch),
                textBlock.FontSize,  // Font size of the text
                textBlock.Foreground  // Text color (brush)
            );

            // Return the width of the formatted text
            return formattedText.Width;
        }
        //---------------------------------------------------------------------------------------------------------
    }
}
