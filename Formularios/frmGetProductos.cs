using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdmToSap
{
    public partial class frmGetProductos : Form
    {
        frmMain fMain;

        public frmGetProductos()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        public void frmGetProductosShow(frmMain frm)
        {
            fMain = frm;
            this.buttonCargaInv.Visible = false;
            this.buttonCargaPrecios.Visible = false;
            this.ShowDialog();
        }

        private void frmGetProductos_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxFirst;
        }

        public void frmGetInventarioShow(frmMain frm)
        {
            fMain = frm;
            this.buttonCargaProd.Visible = false;
            this.buttonCargaPrecios.Visible = false;
            this.ShowDialog();
        }

        public void frmGetPreciosShow(frmMain frm)
        {
            fMain = frm;
            this.buttonCargaProd.Visible = false;
            this.buttonCargaInv.Visible = false;
            this.ShowDialog();
        }

        private void buttonCargaPecios_Click(object sender, EventArgs e)
        {
        }

        private void buttonCargaPrecios_Click(object sender, EventArgs e)
        {
            Procesos pro = new Procesos();
            DateTime datetime = dateTimePicker1.Value;
            pro.getPreciosManual(String.Format("{0:yyyyMMdd}", datetime), textBoxFirst.Text, textBoxLast.Text, fMain);
        }

        private void buttonCargaProd_Click(object sender, EventArgs e)
        {
            Procesos pro = new Procesos();
            DateTime datetime = dateTimePicker1.Value;
            pro.getProductosManual(String.Format("{0:yyyyMMdd}", datetime), textBoxFirst.Text,textBoxLast.Text, fMain);
        }

        private void buttonCargaInv_Click(object sender, EventArgs e)
        {
            Procesos pro = new Procesos();
            DateTime datetime = dateTimePicker1.Value;
            pro.getInventariosManual(String.Format("{0:yyyyMMdd}", datetime), textBoxFirst.Text,textBoxLast.Text, fMain);

        }
    }
}
