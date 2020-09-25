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
        public Form1()
        {
            InitializeComponent();
            var colorSelectors = Controls.OfType<ColorSelector>().ToList(); ;
            Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue };
            colorSelectors.ForEach(colorSelector => colorSelector.Colors = colors);

            guessButton.Enabled = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void colorSelector_ColorSelected(object sender, EventArgs e)
        {
            var selectorControls = Controls.OfType<ColorSelector>(); // grabs the collection of controls pertaining to the ColorSelector.
            //Check the collection if it's unique.
            guessButton.Enabled = selectorControls.Select(selectorControl => selectorControl.SelectedColor)
                                             .Where(selectorContorl => !selectorContorl.IsEmpty)
                                             .Distinct()
                                             .Count() == selectorControls.Count();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            //get a collection of selectors
            var selectorControls = Controls.OfType<ColorSelector>();
       
                                                                            
        }
  
    }
}
