using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeorgiouAndronikos
{
    public partial class Form1 : Form
    {
        string eksamino;
        string mathimata;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void CLose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (aeksamino.Checked == true)
            {
                eksamino = " Α Εξάμηνο";
            }
            if (beksamino.Checked == true)
            {
                eksamino = " Β Εξάμηνο";
            }
            if (geksamino.Checked == true)
            {
                eksamino = " Γ Εξάμηνο";
            }
            if (deksamino.Checked == true)
            {
                eksamino = " Δ Εξάμηνο";
            }

            if (programing.CheckState == CheckState.Checked)
            {
                mathimata += " Προγραμματισμός";
            }
            if (gamedev.CheckState == CheckState.Checked)
            {
                mathimata += " Κατασκευή Παιχνιδιών";
            }
            if (SQL.CheckState == CheckState.Checked)
            {
                mathimata += " Βάσεις Δεδομένων";
            }
            if (diktia.CheckState == CheckState.Checked)
            {
                mathimata += " Δίκτυα";
            }

            MessageBox.Show(onoma.Text + " " + eksamino + " " + mathimata);

        }

        private void μέσοςΌροςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.ShowDialog();
        }

        private void κλείσιμοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Δεν το διαγραφω γιατι χαλαει η φορμα
      

        private void αοθήκευσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = onoma.Text + eksamino + mathimata ;

            DialogResult saveResult = saveFileDialog1.ShowDialog();
            if (saveResult == DialogResult.OK)
            { 



                try
                {
                    string path = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(data);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
        }
    }
}
