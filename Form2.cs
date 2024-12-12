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
    public partial class Form2 : Form
    {
        private string[,] name = new string[10, 6];
        private int index = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("PUSTO");
                return;
            }
            string[] jojo = new string[]
            {
                textBox1.Text,
                DateTime.Now.ToString(),
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                comboBox1.Text
            };
            if(index < name.GetLength(0))
            {
                for(int i = 0; i < jojo.Length; i++)
                {
                    name[index, i] = jojo[i];
                }
                index++;
                MessageBox.Show("USPEH");
 
            }
            else
            {
                MessageBox.Show("KALL");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                dataGridView1.Rows.Clear();

                dataGridView1.Columns.Add("1","1");
                dataGridView1.Columns.Add("2", "2");
                dataGridView1.Columns.Add("3", "3");
                dataGridView1.Columns.Add("4", "4");
                dataGridView1.Columns.Add("5", "5");
                dataGridView1.Columns.Add("6", "6");
                
                for(int i = 0; i < index; i++)
                {
                    dataGridView1.Rows.Add
                        (
                        name[i,0],
                        name[i,1],
                        name[i,2],
                        name[i,3],
                        name[i,4],
                        name[i,5]
                        );
                }

            }
            else
            {
                MessageBox.Show("KALL");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("PUSTO V PERVOM");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == textBox1.Text)
                {
                    row.Cells[2].Value = textBox2.Text;
                    row.Cells[3].Value = textBox3.Text;
                    row.Cells[4].Value = textBox4.Text;
                    row.Cells[5].Value = comboBox1.Text;

                    int rowindex = row.Index;

                    name[rowindex, 2] = textBox2.Text;
                    name[rowindex, 3] = textBox3.Text;
                    name[rowindex, 4] = textBox4.Text;
                    name[rowindex, 5] = comboBox1.Text;

                    return;
                }

            }
            MessageBox.Show("KALLL");
        }
    }
}
