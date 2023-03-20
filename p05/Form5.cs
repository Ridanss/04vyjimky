using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p05
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int[] ints = new int[2];
            string[] strings = new string[2];
            try
            {
                strings = textBox1.Text.Split('/');
                if (strings[0].Length == 6 && strings[1].Length == 4)
                {
                    ints[0] = Int32.Parse(strings[0]);
                    ints[1] = Int32.Parse(strings[1]);
                }
                else MessageBox.Show("r.číslo je neplatné");
                if (ints[0] % 11 != 0) MessageBox.Show("r.číslo je neplatné");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
