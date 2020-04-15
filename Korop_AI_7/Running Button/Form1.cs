using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Running_Button
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            int offset = 1;
            int r = 10;
            if (x >= button1.Left - r && x <= button1.Right + r && y >= button1.Top - r && y <= button1.Bottom + r)
                Running(x, y, r, offset);
        }

        public void Running(int x, int y, int r, int offset)
        {
                int Width = this.Width - button1.Width;
                int Height = this.Height - button1.Height*3;
                if ((x >= button1.Left - r) && (x <= button1.Left) && (button1.Right < Width))
                    button1.Left = button1.Left + offset;
                if ((x <= button1.Right + r) && (x >= button1.Right) && (button1.Left > button1.Width/2))
                    button1.Left = button1.Left - offset;
                if ((y <= button1.Bottom + r) && (y >= button1.Bottom) && (button1.Top > button1.Height))
                    button1.Top = button1.Top - offset;
                if ((y >= button1.Top - r) && (y <= button1.Top) && (button1.Bottom < Height))
                    button1.Top = button1.Top + offset;          
        }
    }
}