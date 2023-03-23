using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p06
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int lines = textBox1.Lines.Count();
            int[] pole = new int[lines];
            for(int i = 0; i < lines; i++)
            {
                try
                {
                    pole[i] = int.Parse(textBox1.Lines[i]);
                    listBox1.Items.Add(pole[i]);
                }
                catch(FormatException)
                {
                    pole[i] = 0;
                    listBox1.Items.Add(pole[i]);
                }
                catch (OverflowException)
                {
                    Int64 test = Int64.Parse(textBox1.Lines[i]);
                    if (test > Int32.MaxValue) pole[i] = Int32.MaxValue;
                    else if (test < Int32.MinValue) pole[i] = Int32.MinValue;
                    listBox1.Items.Add(pole[i]);
                }
            }
        }
    }
}
