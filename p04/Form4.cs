using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);

                double z = a;
                if (n == 0) MessageBox.Show("Mocnina je 1");
                else
                {
                    for (int i = 1; i < Math.Abs(n); i++)
                    {
                        checked
                        {
                            a *= z;
                        }

                    }

                    MessageBox.Show(string.Format($"Mocnina je {(n < 0 ? "1/" : "")}{a}"));

                }

            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
