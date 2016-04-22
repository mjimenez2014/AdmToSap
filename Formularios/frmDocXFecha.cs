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
    public partial class frmDocXFecha : Form
    {
        frmMain frmmain;
        public frmDocXFecha()
        {
            InitializeComponent();
        }

        public frmDocXFecha(frmMain frmmain)
        {
            InitializeComponent();
            this.frmmain = frmmain;
        }

        private void frmPagosXFecha_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmmain.listBoxLog.Items.Insert(0, "Recuperando Información en ADM Software......");
            DateTime inicial = dateTimePickerInicial.Value;
            DateTime final = dateTimePickerFinal.Value;
            DateTime horaIni = dateTimePickerHIni.Value;
            DateTime horafin = dateTimePickerHFin.Value;

            Procesos poc = new Procesos();
            poc.addDocXFecha(this.frmmain, inicial, final, horaIni,horafin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
