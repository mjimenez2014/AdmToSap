﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdmToSap
{
    public  partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // listBoxLog.Items.Insert(0, "Recuperando Información en ADM Software......");
            new frmDocXFecha(this).ShowDialog();
           
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void baseDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDato frmbd = new frmBaseDato();
            frmbd.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ConnectDb condb = new ConnectDb();
            LocalDataBase ldb = new LocalDataBase();
            Temporizadores temp = new Temporizadores();

            ldb.creaDB();
            condb.getConnect();
            temp.startProcess(this);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Procesos pro = new Procesos();
            pro.addClientes(this);
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PartnerDb pdb = new PartnerDb();
            pdb.getPartners();
        }



        private void verLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLog frmlog = new frmLog();
            frmlog.Show();
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            new frmPagosXFecha(this).ShowDialog();
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa frmempresa = new frmEmpresa();
            
            frmempresa.Show();
        }

        private void respuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRespuestas frmresp = new frmRespuestas();
            frmresp.Show();
        }



        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temporizadores temp = new Temporizadores();
            frmTemporizador frmtemp = new frmTemporizador(this);
            frmtemp.UpDownHoraEnvio.Value =  Convert.ToDecimal(temp.getHoraEnvio().Hour);
            frmtemp.UpDownHoraRecibo.Value = Convert.ToDecimal(temp.getHoraRecibo().Hour);
            frmtemp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGetProductos frmgetpro = new frmGetProductos();
            frmgetpro.frmGetProductosShow(this);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGetProductos frmgetpro = new frmGetProductos();
            frmgetpro.frmGetInventarioShow(this);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            frmGetProductos frmgetpro = new frmGetProductos();
            frmgetpro.frmGetPreciosShow(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Procesos pro = new Procesos();
            pro.addJournalEntry(this);
        }


        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Text = "Adm To Sap";
            notifyIcon1.BalloonTipTitle = "Adm To Sap";
            notifyIcon1.BalloonTipText = "Puente entre ADM y SAP";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000);
        }



        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSucursales frmsucursales = new frmSucursales();
            frmsucursales.Show();
        }

        private void bodegasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmBodegas frmbodega = new frmBodegas();
            frmbodega.Show();
        }

        private void bancosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmBancos frmbancos = new frmBancos();
            frmbancos.Show();
        }

        private void documentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDocumento formdoc = new frmDocumento();
            formdoc.Show();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            String evento =  log.verEvento();

            listBoxLog.Items.Insert(0, evento);

        }

        public void addItemListBox()
        {
            Log log = new Log();
            String evento = log.verEvento();

            listBoxLog.Items.Insert(0, evento);
        }

        public frmMain getFrmMain()
        {
            return this;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Procesos pro = new Procesos();
            pro.addClientes(this);
        }

        private void informeDeEnvíosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          frmExportExcel frmexport = new frmExportExcel();
          frmexport.Show();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Environment.Exit(0);
        }

        private void informeDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPreciosToExcel().ShowDialog();
        }

        private void informeDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmStockToExcel().ShowDialog();
        }

        private void informeDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmProductosToExcel().ShowDialog();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.listBoxLog.Items.Clear();
            this.labelEstadoProceso.Text = "";
        }

        private void soloErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmErrorEnvioExcel().ShowDialog();
        }


    }
}
