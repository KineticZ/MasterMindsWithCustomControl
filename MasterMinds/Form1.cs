using MasterMinds.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MasterMinds
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private List<Color> ColorsToGuess { get; set; }
        public Form1()
        {
            InitializeComponent();
            initGame();
        }
        private List<Color> ShuffleColors(List<Color> colors, int numberOfColorsToGuess)
        {
            var copyOfColors = new List<Color>(colors);
            var newListOfColors = new List<Color>();
            for (int i = 0; i < copyOfColors.Count; i++)
            {
                int randomIndex = random.Next(copyOfColors.Count);
                Color tempColor = copyOfColors[i];
                copyOfColors[i] = copyOfColors[randomIndex];
                copyOfColors[randomIndex] = tempColor;                
            }
            for (int i = 0; i < numberOfColorsToGuess; i++)
            {
                newListOfColors.Add(copyOfColors[i]);
            }

            return newListOfColors;
        }
        private void initGame()
        {
            var colorSelectors = Controls.OfType<ColorSelector>().ToList(); ;
            Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Black };
            colorSelectors.ForEach(colorSelector => colorSelector.Colors = colors);

            guessButton.Enabled = false;

            ColorsToGuess = new List<Color>();
            ColorsToGuess = ShuffleColors(colors.ToList(), 3);
        }
        private void Form1_Load(object sender, EventArgs e)
            => Text = "Master Minds Color Game";

        private void colorSelector_ColorSelected(object sender, EventArgs e)
        {
            var selectorControls = Controls.OfType<ColorSelector>(); // grabs the collection of controls pertaining to the ColorSelector.
            //Check the collection if it's unique.
            guessButton.Enabled = selectorControls.Select(selectorControl => selectorControl.SelectedColor)
                                             .Where(selectorContorl => !selectorContorl.IsEmpty)
                                             .Distinct()
                                             .Count() == selectorControls.Count();
        }
        private void checkSelectedColors()
        {
            //get a collection of selectors
            var selectorControls = Controls.OfType<ColorSelector>().ToList();
            selectorControls.Reverse();
            var selectedColors = selectorControls.Select(selectorControl => selectorControl.SelectedColor).ToList();
            int numberOfCorrectBoxes = 0;

            //check if the color exist and if the color is in the correct spot
            for (int i = 0; i < ColorsToGuess.Count; i++)
            {
                bool doesExist = ColorsToGuess.Contains(selectedColors[i]);
                if (doesExist && ColorsToGuess[i] == selectedColors[i])
                {
                    selectorControls[i].TextForTextBox = "Correct";
                    numberOfCorrectBoxes++;
                }
                else if (doesExist)
                {
                    selectorControls[i].TextForTextBox = "Wrong spot";
                }
                else
                {
                    selectorControls[i].TextForTextBox = "Incorrect Color";
                }
            }

            //Change Text if all 3 are correct.
            if (numberOfCorrectBoxes == selectorControls.Count)
            {
                timer.Enabled = true;            
            }
        }
        private void guessButton_Click(object sender, EventArgs e)
            => checkSelectedColors();

        private void timer_Tick(object sender, EventArgs e)
        {
            initGame();
            var selectorControls = Controls.OfType<ColorSelector>().ToList();
            selectorControls.ForEach(selectorControl => selectorControl.TextForTextBox = "Select Color");
            selectorControls.ForEach(selectorControl => selectorControl.ResetPanel());
            timer.Enabled = false;
        }
    }
}
