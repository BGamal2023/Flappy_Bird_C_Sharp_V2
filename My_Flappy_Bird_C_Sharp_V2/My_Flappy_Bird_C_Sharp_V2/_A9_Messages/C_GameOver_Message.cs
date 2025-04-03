using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace My_Flappy_Bird_C_Sharp_V2._A9_Messages
{
    internal class C_GameOver_Message : I_Message
    {
        //---------------------------------------------------------------------------------------------------------
        public void Run(Window mWindow)
        {
           handle_GameOver_Message(mWindow);    
        }
        //---------------------------------------------------------------------------------------------------------
        public void handle_GameOver_Message(Window mWindow)
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                Canvas gameOver_Canvas = new Canvas();
                gameOver_Canvas.Width = 400;
                gameOver_Canvas.Height = 150;
                gameOver_Canvas.Background = Brushes.Aqua;
                // Create a TextBlock to display text
                TextBlock gameOver_Text = new TextBlock
                {
                    Text = "GAME OVER", // Set your text
                    FontSize = 24,               // Set font size
                    Foreground = Brushes.Black,   // Set text color
                    FontWeight = FontWeights.Bold // Set font weight
                };
                TextBlock tryAgainText = new TextBlock
                {
                    Text = "Try Again?",
                    FontSize = 18,
                    Foreground = Brushes.Red,
                    FontWeight = FontWeights.SemiBold,
                    TextAlignment = TextAlignment.Center
                };
                double textWidth = GetTextWidth(gameOver_Text);


                // Calculate the left position to center the text horizontally on the Canvas
                double canvasWidth = gameOver_Canvas.Width;

                double leftPosition = (canvasWidth - textWidth) / 2;

                gameOver_Canvas.Children.Add(gameOver_Text);
                gameOver_Canvas.Children.Add(tryAgainText);

                Canvas.SetLeft(gameOver_Text, leftPosition);
                Canvas.SetTop(gameOver_Text, 20);  // Set Y position


                Canvas.SetLeft(tryAgainText, leftPosition);
                Canvas.SetTop(tryAgainText, 50);

                // Add the TextBlock to the Canvas



                Button playAgain_Button = new Button
                {
                    Content = "Yes",
                    Width = 50,   // Button width
                    Height = 30   // Button height
                };

                // Create "Exit" Button
                Button exit_Game_Button = new Button
                {
                    Content = "No",
                    Width = 50,   // Button width
                    Height = 30   // Button height
                };


                Globals_Buttons.btn_playAgain = playAgain_Button;
                Globals_Buttons.btn_Exit_The_Game = exit_Game_Button;

                // Calculate the left positions of the buttons to ensure they are evenly distributed
                double gap = (gameOver_Canvas.Width - 2 * playAgain_Button.Width) / 3;

                // Set the position of "Resume" Button
                Canvas.SetLeft(playAgain_Button, gap); // First button at the gap
                Canvas.SetTop(playAgain_Button, 100);
                // Set the position of "Exit" Button
                Canvas.SetLeft(exit_Game_Button, gap + playAgain_Button.Width + gap); // Second button at the second gap
                Canvas.SetTop(exit_Game_Button, 100);
                // Add the buttons to the canvas
                gameOver_Canvas.Children.Add(playAgain_Button);
                gameOver_Canvas.Children.Add(exit_Game_Button);




                Globals_GameArea.gameArea.Children.Add(gameOver_Canvas);
                Canvas.SetLeft(gameOver_Canvas, 200);
                Canvas.SetTop(gameOver_Canvas, 100);
                Canvas.SetZIndex(gameOver_Canvas, 10);



            });
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
