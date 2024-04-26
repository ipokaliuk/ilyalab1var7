using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilyalab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxBlue.Text = "0";
            textBoxGreen.Text = "0";
            textBoxRed.Text = "0";
        }

        private void UpdateColor()
        {
            int red, green, blue;
            if (int.TryParse(textBoxRed.Text, out red) && int.TryParse(textBoxGreen.Text, out green) && int.TryParse(textBoxBlue.Text, out blue))
            {
                if (red >= 0 && red <= 255 && green >= 0 && green <= 255 && blue >= 0 && blue <= 255)
                {
                    Color color = Color.FromArgb(red, green, blue);
                    textBoxColor.BackColor = color;
                }
                else
                {
                    MessageBox.Show("Кожне значення кольору повинно бути між 0 та 255", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні числа для кольорів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void textBoxGreen_TextChanged_1(object sender, EventArgs e)
        {
           UpdateColor();
        }

        private void textBoxBlue_TextChanged_1(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }
}