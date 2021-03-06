﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bancos_Contabilidad
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalOrdenCompra fpoc = new frmPrincipalOrdenCompra();
            fpoc.WindowState = FormWindowState.Maximized;
            fpoc.MdiParent = this;
            fpoc.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrincipalEstadosFinancieros fpef = new frmPrincipalEstadosFinancieros();
            fpef.WindowState = FormWindowState.Maximized;
            fpef.MdiParent = this;
            fpef.Show();
        }

        private void activosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalActivoFijo fpaf = new frmPrincipalActivoFijo();
            fpaf.WindowState = FormWindowState.Maximized;
            fpaf.MdiParent = this;
            fpaf.Show();
        }

        private void pasivosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPasivoFijo fppf = new frmPrincipalPasivoFijo();
            fppf.WindowState = FormWindowState.Maximized;
            fppf.MdiParent = this;
            fppf.Show();
        }
    }
}
