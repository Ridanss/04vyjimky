using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                if (n > 0)
                {
                    Random rnd = new Random();
                    int[] pole = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        pole[i] = rnd.Next(1, 21);
                        listBox1.Items.Add(pole[i]);
                    }
                    try
                    {
                        int p = pole[0];
                        for (int i = 0; i < pole[5]; i++)
                        {
                            checked
                            {
                                pole[0] *= p;
                            }
                        }
                        MessageBox.Show(string.Format($"Součin {pole[0]}"));
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch(OverflowException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
