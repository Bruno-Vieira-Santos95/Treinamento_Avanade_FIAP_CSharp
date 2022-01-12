using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace mediaAlunoArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double[] v = new double[10];
            double total = 0;

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = double.Parse(Interaction.InputBox($"Digite a nota do aluno {(i + 1).ToString()}"));
                total += v[i]/10;
            }
            MessageBox.Show($"A média é {total.ToString("0.00")}");
        }
    }
}
