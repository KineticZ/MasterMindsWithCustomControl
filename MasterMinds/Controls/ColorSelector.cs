using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MasterMinds.Controls
{
    public partial class ColorSelector : UserControl
    {
        public event EventHandler ColorSelected;
        
        public Color[] Colors { get; set; }

        public string TextForTextBox
        {
            get
            {
                return textBox.Text;
            }

            set
            {
                textBox.Text = value;
            }
        }

        public void ResetPanel()
        {
            panel.BackColor = Color.White;
        }
               
        public Color SelectedColor
        {
            get => comboBox1.SelectedItem == null ? Color.Empty : (Color)comboBox1.SelectedItem;
        }
        public ColorSelector()
        {
            InitializeComponent();
            textBox.Text = "Select Color";

            Colors = Array.Empty<Color>();
        }
        private void ColorSelector_Load(object sender, EventArgs e)
        {        
            comboBox1.Items.AddRange(Colors.Cast<object>().ToArray());
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel.BackColor = (Color)((sender as ComboBox).SelectedItem);
            ColorSelected?.Invoke(this, e);
        }
       
    }
}
