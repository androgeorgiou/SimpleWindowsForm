using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeorgiouAndronikos
{
    public partial class Form2 : Form
    {
        //float mo;
        
        public Form2()
        {
            InitializeComponent();
        }

     

        private void average_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            float z = float.Parse(textBox3.Text);
            float a = float.Parse(textBox4.Text);
            mo.Text = ((x + y + z + a)/4).ToString();
            MessageBox.Show("Ο βαθμός σου ειναι" + " " + mo.Text);
        }

        private void closeok_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
