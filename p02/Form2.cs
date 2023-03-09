using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox2.Text);
                int lines = textBox1.Lines.Count();
                if (n > lines)
                {
                    MessageBox.Show("Čísel je méně než n");
                    n = lines;
                }
                int souc = 0;
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        souc = checked(souc + int.Parse(textBox1.Lines[i]));
                    }
                    catch(FormatException)
                    {
                        n++;
                        continue;
                    }
                    catch(OverflowException ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                }
                MessageBox.Show(string.Format($"součet: {souc}"));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Chyba, " + ex.Message);
            }
        }
    }
}
