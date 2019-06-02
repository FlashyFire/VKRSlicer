using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics;

namespace SlicerProto
{
    [DefaultBindingProperty("Color")]
    public partial class ColorPicker : UserControl
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        public Color4 Color {
            get {
                return (Color4)panColor.BackColor;
            }
            set {
                panColor.BackColor = (Color)value;
            }
        }

        private void butColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = panColor.BackColor;
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                panColor.BackColor = colorDialog1.Color;
                DataBindings["Color"]?.WriteValue();
            }
        }
    }
}
