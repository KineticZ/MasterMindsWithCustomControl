using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMinds.Controls
{
    public partial class ColorSelector : UserControl
    {
        public Color[] colors;
        public ColorSelector()
        {
            InitializeComponent();
            textBox1.Text = "Select Color";
        }
        private void ColorSelector_Load(object sender, EventArgs e)
        {
            colors = new Color[]
            {
                Color.Red,
                Color.Blue,
                Color.Green
            };

            comboBox1.Items.AddRange(colors.Cast<object>().ToArray());
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            => panel1.BackColor = (Color)((sender as ComboBox).SelectedItem);
       
    }
}
