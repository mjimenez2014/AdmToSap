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
    public partial class frmPagosXFecha : Form
    {
        frmMain frmmain;
        public frmPagosXFecha()
        {
            InitializeComponent();
        }

        public frmPagosXFecha(frmMain frmmain)
        {
            InitializeComponent();
            this.frmmain = frmmain;
        }

        private void frmPagosXFecha_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime inicial = dateTimePicker1.Value;
            DateTime final = dateTimePicker2.Value;
            DateTime horaIni = dateTimePickerHIni.Value;
            DateTime horafin = dateTimePickerHFin.Value;

            Procesos poc = new Procesos();
            poc.addPaymentsXFecha(this.frmmain, inicial, final,horaIni,horafin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
