using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penilaian_Week_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonProses_Click(object sender, EventArgs e)
        {
            string tampung = TextBoxInput.Text.ToUpper();
            string warna;
            if (tampung.Contains("ISI:"))
            {
                if (tampung.Remove(4) == "ISI:")
                {
                    LabelOutput.Text = TextBoxInput.Text.Remove(0, 4);
                }
                else
                    MessageBox.Show("Syntax tidak terdaftar!");
            }
            else if (tampung.Contains("WARNA:"))
            {

                if (tampung.Remove(6) == "WARNA:")
                {
                    warna = tampung.Remove(0, 6);
                    if (warna == "DEFAULT")
                        LabelOutput.ForeColor = Color.Black;
                    else if (warna == "MERAH")
                        LabelOutput.ForeColor = Color.Red;
                    else if (warna == "HIJAU")
                        LabelOutput.ForeColor = Color.Green;
                    else if (warna == "BIRU")
                        LabelOutput.ForeColor = Color.Blue;
                    else
                        MessageBox.Show("Syntax tidak terdaftar!");
                }
            }
            else if (tampung == "BESARKAN")
                LabelOutput.Font = new Font(LabelOutput.Font.Name, LabelOutput.Font.Size + 1);
            else if (tampung == "KECILKAN")
            {
                if (LabelOutput.Font.Size > 1)
                {
                    LabelOutput.Font = new Font(LabelOutput.Font.Name, LabelOutput.Font.Size - 1);
                }
            }
            else if (tampung == "SHOWN")
                LabelOutput.Visible = true;
            else if (tampung == "HIDE")
                LabelOutput.Visible = false;
            else if (tampung == "RESTART")
            {
                LabelOutput.Font = LabelDuplicate.Font;
                LabelOutput.Text = LabelDuplicate.Text;
                LabelOutput.ForeColor = LabelDuplicate.ForeColor;
            }
            else
                MessageBox.Show("Syntax tidak terdaftar!");
        }
    }
}
