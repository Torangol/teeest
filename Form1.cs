using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username == "qwe" && password == "qwe")
            {
                MessageBox.Show("USPEH");

                Form2 perehod = new Form2();
                perehod.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("KALL");
            }
        }
    }
}
