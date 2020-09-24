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
        public event EventHandler ColorSelected;
        public Color[] Colors { get; set; }
        public Color? SelectedColor
        {
            get => SelectedColor as Color?;
        }
        public ColorSelector()
        {
            InitializeComponent();
            textBox1.Text = "Select Color";

            Colors = Array.Empty<Color>();
        }
        private void ColorSelector_Load(object sender, EventArgs e)
        {        
            comboBox1.Items.AddRange(Colors.Cast<object>().ToArray());
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.BackColor = (Color)((sender as ComboBox).SelectedItem);
            ColorSelected.Invoke(this, e);
        }
       
    }
}
