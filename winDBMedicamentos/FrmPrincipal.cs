﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winDBMedicamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmMedicamentos f = new fmMedicamentos();
            f.ShowDialog();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLaboratorio fL = new FrmLaboratorio();
            fL.ShowDialog();
        }
    }
}
