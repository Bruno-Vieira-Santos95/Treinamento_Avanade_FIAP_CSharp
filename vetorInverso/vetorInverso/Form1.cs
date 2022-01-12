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

namespace vetorInverso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double[] va = new double[5];
            double[] vb = new double[5];
            int i2 = va.Length - 1;

            for (int i = 0; i < va.Length; i++)
            {
                va[i] = double.Parse(Interaction.InputBox($"Digite o {(i+1).ToString()}º número"));
                vb[i2] = va[i];
                i2--;
            }
            

            for (int i = 0; i < va.Length; i++)
            {
                lstVB.Items.Add(vb[i].ToString());

            }
            
        }
    }
}
