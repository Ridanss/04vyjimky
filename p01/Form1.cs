using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int a) && int.TryParse(textBox2.Text, out int b))
            {
                try
                {
                    int souc = checked(a + b);
                    int roz = a - b;
                    int soucin = checked(a * b);
                    int podi = a / b;
                    MessageBox.Show(string.Format($"součet: {souc}\nrozdíl: {roz}\nsoučin: {soucin}\npodíl: {podi}"));
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("Chyba, " + ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show("Chyba, " + ex.Message);
                }
                catch (ArithmeticException ex)
                {
                    MessageBox.Show("Chyba, " + ex.Message);
                }
            }
            else MessageBox.Show("Chyba, zadejte prosím čísla");
        }
    }
}
