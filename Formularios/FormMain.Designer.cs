﻿
namespace AdmToSap
{
     partial  class  frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respuestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temporizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasDeVinculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeEnvíosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soloErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelEstadoProceso = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Document";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.tablasDeVinculoToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDatosToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.verLogToolStripMenuItem,
            this.respuestasToolStripMenuItem,
            this.temporizadorToolStripMenuItem,
            this.sToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // baseDatosToolStripMenuItem
            // 
            this.baseDatosToolStripMenuItem.Name = "baseDatosToolStripMenuItem";
            this.baseDatosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.baseDatosToolStripMenuItem.Text = "Base Datos";
            this.baseDatosToolStripMenuItem.Click += new System.EventHandler(this.baseDatosToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // verLogToolStripMenuItem
            // 
            this.verLogToolStripMenuItem.Name = "verLogToolStripMenuItem";
            this.verLogToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.verLogToolStripMenuItem.Text = "Ver Log";
            this.verLogToolStripMenuItem.Click += new System.EventHandler(this.verLogToolStripMenuItem_Click);
            // 
            // respuestasToolStripMenuItem
            // 
            this.respuestasToolStripMenuItem.Name = "respuestasToolStripMenuItem";
            this.respuestasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.respuestasToolStripMenuItem.Text = "Respuestas";
            this.respuestasToolStripMenuItem.Click += new System.EventHandler(this.respuestasToolStripMenuItem_Click);
            // 
            // temporizadorToolStripMenuItem
            // 
            this.temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            this.temporizadorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.temporizadorToolStripMenuItem.Text = "Temporizador";
            this.temporizadorToolStripMenuItem.Click += new System.EventHandler(this.temporizadorToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sToolStripMenuItem.Text = "Salir";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // tablasDeVinculoToolStripMenuItem
            // 
            this.tablasDeVinculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bodegasToolStripMenuItem,
            this.bancosToolStripMenuItem,
            this.documentosToolStripMenuItem,
            this.sucursalesToolStripMenuItem});
            this.tablasDeVinculoToolStripMenuItem.Name = "tablasDeVinculoToolStripMenuItem";
            this.tablasDeVinculoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.tablasDeVinculoToolStripMenuItem.Text = "Tabla de Paridad";
            // 
            // bodegasToolStripMenuItem
            // 
            this.bodegasToolStripMenuItem.Name = "bodegasToolStripMenuItem";
            this.bodegasToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.bodegasToolStripMenuItem.Text = "Bodegas";
            this.bodegasToolStripMenuItem.Click += new System.EventHandler(this.bodegasToolStripMenuItem_Click_1);
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            this.bancosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.bancosToolStripMenuItem.Text = "Bancos";
            this.bancosToolStripMenuItem.Click += new System.EventHandler(this.bancosToolStripMenuItem_Click_1);
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.documentosToolStripMenuItem.Text = "Documentos";
            this.documentosToolStripMenuItem.Click += new System.EventHandler(this.documentosToolStripMenuItem_Click_1);
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            this.sucursalesToolStripMenuItem.Click += new System.EventHandler(this.sucursalesToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeDeEnvíosToolStripMenuItem,
            this.informeDePreciosToolStripMenuItem,
            this.informeDeStockToolStripMenuItem,
            this.informeDeProductosToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // informeDeEnvíosToolStripMenuItem
            // 
            this.informeDeEnvíosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soloErrorToolStripMenuItem});
            this.informeDeEnvíosToolStripMenuItem.Name = "informeDeEnvíosToolStripMenuItem";
            this.informeDeEnvíosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.informeDeEnvíosToolStripMenuItem.Text = "Informe de Envíos";
            this.informeDeEnvíosToolStripMenuItem.Click += new System.EventHandler(this.informeDeEnvíosToolStripMenuItem_Click);
            // 
            // soloErrorToolStripMenuItem
            // 
            this.soloErrorToolStripMenuItem.Name = "soloErrorToolStripMenuItem";
            this.soloErrorToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.soloErrorToolStripMenuItem.Text = "Errores";
            this.soloErrorToolStripMenuItem.Click += new System.EventHandler(this.soloErrorToolStripMenuItem_Click);
            // 
            // informeDePreciosToolStripMenuItem
            // 
            this.informeDePreciosToolStripMenuItem.Name = "informeDePreciosToolStripMenuItem";
            this.informeDePreciosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.informeDePreciosToolStripMenuItem.Text = "Informe de Precios";
            this.informeDePreciosToolStripMenuItem.Click += new System.EventHandler(this.informeDePreciosToolStripMenuItem_Click);
            // 
            // informeDeStockToolStripMenuItem
            // 
            this.informeDeStockToolStripMenuItem.Name = "informeDeStockToolStripMenuItem";
            this.informeDeStockToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.informeDeStockToolStripMenuItem.Text = "Informe de Stock";
            this.informeDeStockToolStripMenuItem.Click += new System.EventHandler(this.informeDeStockToolStripMenuItem_Click);
            // 
            // informeDeProductosToolStripMenuItem
            // 
            this.informeDeProductosToolStripMenuItem.Name = "informeDeProductosToolStripMenuItem";
            this.informeDeProductosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.informeDeProductosToolStripMenuItem.Text = "Informe de Productos";
            this.informeDeProductosToolStripMenuItem.Click += new System.EventHandler(this.informeDeProductosToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Payments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Get Productos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Get Inventario";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Get Precios";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 130);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Add Journal Entry";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(781, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 30);
            this.button8.TabIndex = 9;
            this.button8.Text = "Ocultar Ventana";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.Location = new System.Drawing.Point(179, 58);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(721, 160);
            this.listBoxLog.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registro de Eventos";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(20, 40);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(137, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Add Partner";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Versión: 20161029_1800";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(656, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Limpia Registro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // labelEstadoProceso
            // 
            this.labelEstadoProceso.AutoSize = true;
            this.labelEstadoProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoProceso.ForeColor = System.Drawing.Color.Red;
            this.labelEstadoProceso.Location = new System.Drawing.Point(245, 268);
            this.labelEstadoProceso.Name = "labelEstadoProceso";
            this.labelEstadoProceso.Size = new System.Drawing.Size(0, 20);
            this.labelEstadoProceso.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 300);
            this.ControlBox = false;
            this.Controls.Add(this.labelEstadoProceso);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adm To Sap";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLogToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem respuestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temporizadorToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem tablasDeVinculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        public System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeEnvíosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem informeDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeProductosToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label labelEstadoProceso;
        private System.Windows.Forms.ToolStripMenuItem soloErrorToolStripMenuItem;
    }
}

