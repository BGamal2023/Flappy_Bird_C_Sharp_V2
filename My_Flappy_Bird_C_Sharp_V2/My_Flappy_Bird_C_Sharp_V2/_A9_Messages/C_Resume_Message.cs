using My_Flappy_Bird_C_Sharp_V2.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace My_Flappy_Bird_C_Sharp_V2._A9_Messages
{
    internal class C_Resume_Message : I_Message
    {
        #region The Fields
        #endregion
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        public void Run(Window mWindow)
        {
            handle_Resume_Message_After_Collision(mWindow);
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        public void handle_Resume_Message_After_Collision(Window mWindow)
        {
            //----
            Canvas canvas = new Canvas();
            canvas.Width = 400;
            canvas.Height = 150;
            canvas.Background = Brushes.Aqua;

            // Create a TextBlock to display text
            TextBlock textBlock = new TextBlock
            {
                Text = "You Lost Life!", // Set your text
                FontSize = 24,               // Set font size
                Foreground = Brushes.Black,   // Set text color
                FontWeight = FontWeights.Bold // Set font weight
            };

            double textWidth = GetTextWidth(textBlock);


            // Calculate the left position to center the text horizontally on the Canvas
            double canvasWidth = canvas.Width;

            double leftPosition = (canvasWidth - textWidth) / 2;

            canvas.Children.Add(textBlock);

            Canvas.SetLeft(textBlock, leftPosition);
            Canvas.SetTop(textBlock, 20);  // Set Y position

            // Add the TextBlock to the Canvas



            Button resumeButton = new Button
            {
                Content = "Resume",
                Width = 50,   // Button width
                Height = 30   // Button height
            };

            // Create "Exit" Button
            Button exitButton = new Button
            {
                Content = "Exit",
                Width = 50,   // Button width
                Height = 30   // Button height
            };


            Globals_Buttons.resumeButton = resumeButton;
            Globals_Buttons.exitButton = exitButton;

            // Calculate the left positions of the buttons to ensure they are evenly distributed
            double gap = (canvas.Width - 2 * resumeButton.Width) / 3;

            // Set the position of "Resume" Button
            Canvas.SetLeft(resumeButton, gap); // First button at the gap
            Canvas.SetTop(resumeButton, 100);
            // Set the position of "Exit" Button
            Canvas.SetLeft(exitButton, gap + resumeButton.Width + gap); // Second button at the second gap
            Canvas.SetTop(exitButton, 100);
            // Add the buttons to the canvas
            canvas.Children.Add(resumeButton);
            canvas.Children.Add(exitButton);




            Globals_GameArea.gameArea.Children.Add(canvas);
            Canvas.SetLeft(canvas, 200);
            Canvas.SetTop(canvas, 100);
            Canvas.SetZIndex(canvas, 10);
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
