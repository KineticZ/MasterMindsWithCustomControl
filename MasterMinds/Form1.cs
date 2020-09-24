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
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            var colorSelectors = Controls.OfType<ColorSelector>();
            Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue};
            

        }

        private void colorSelector1_ColorSelected(object sender, EventArgs e)
        {
            var selectorControls = Controls.OfType<ColorSelector>(); // grabs the collection of controls pertaining to the ColorSelector.
            //Check the collection if it's unique.
            guessButton.Enabled = selectorControls.Select(d => d.SelectedColor)
                                             .Where(d => d.HasValue)
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
