using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korop_AI_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Value = 125;
            trackBar2.Value = 125;
            trackBar3.Value = 125;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
 
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            Color сolor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            panel1.BackColor = сolor;
            Clipboard.SetText(ColorTranslator.ToHtml(сolor));
            string hexColor = Clipboard.GetText();
            toolTip1.SetToolTip(panel1,hexColor);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}
