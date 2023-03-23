using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            if(PlatnostRc(ints, strings))
            {
                MessageBox.Show("Rodné číslo je platné");
            }
            else
            {
                MessageBox.Show("Rodné číslo je neplatné");
            }
        }

        public bool PlatnostRc(int[] ints, string[] strings)
        {
            try
            {
                strings = textBox1.Text.Split('/');
                if (strings[0].Length == 6 && strings[1].Length == 4)
                {
                    ints[0] = Int32.Parse(strings[0]);
                    ints[1] = Int32.Parse(strings[1]);

                    if ((ints[0] + ints[1]) % 11 == 0)
                    {
                        int rokc = Int32.Parse(strings[0].Substring(0, 2));
                        int mesc = Int32.Parse(strings[0].Substring(2, 2));
                        int denc = Int32.Parse(strings[0].Substring(4, 2));
                        if (rokc <= DateTime.Today.Year) rokc += 2000;
                        else rokc += 1900;
                        if (mesc > 50) mesc -= 50;
                        DateTime naroz = new DateTime(rokc, mesc, denc);
                        if (naroz != null) return true;
                    }
                }
                return false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
