namespace AdmToSap
{
    partial class frmGetProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCargaProd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.buttonCargaInv = new System.Windows.Forms.Button();
            this.buttonCargaPrecios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCargaProd
            // 
            this.buttonCargaProd.Location = new System.Drawing.Point(12, 60);
            this.buttonCargaProd.Name = "buttonCargaProd";
            this.buttonCargaProd.Size = new System.Drawing.Size(122, 23);
            this.buttonCargaProd.TabIndex = 0;
            this.buttonCargaProd.Text = "Cargar Productos";
            this.buttonCargaProd.UseVisualStyleBackColor = true;
            this.buttonCargaProd.Click += new System.EventHandler(this.buttonCargaProd_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde:";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(86, 15);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirst.TabIndex = 0;
            this.textBoxFirst.Text = "0";
            // 
            // buttonCargaInv
            // 
            this.buttonCargaInv.Location = new System.Drawing.Point(12, 60);
            this.buttonCargaInv.Name = "buttonCargaInv";
            this.buttonCargaInv.Size = new System.Drawing.Size(122, 23);
            this.buttonCargaInv.TabIndex = 4;
            this.buttonCargaInv.Text = "Cargar Inventarios";
            this.buttonCargaInv.UseVisualStyleBackColor = true;
            this.buttonCargaInv.Click += new System.EventHandler(this.buttonCargaInv_Click);
            // 
            // buttonCargaPrecios
            // 
            this.buttonCargaPrecios.Location = new System.Drawing.Point(12, 60);
            this.buttonCargaPrecios.Name = "buttonCargaPrecios";
            this.buttonCargaPrecios.Size = new System.Drawing.Size(121, 23);
            this.buttonCargaPrecios.TabIndex = 3;
            this.buttonCargaPrecios.Text = "Carga Precios";
            this.buttonCargaPrecios.UseVisualStyleBackColor = true;
            this.buttonCargaPrecios.Click += new System.EventHandler(this.buttonCargaPrecios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha:";
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(285, 15);
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(100, 20);
            this.textBoxLast.TabIndex = 1;
            this.textBoxLast.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta:";
            // 
            // frmGetProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 96);
            this.Controls.Add(this.textBoxLast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCargaPrecios);
            this.Controls.Add(this.buttonCargaInv);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonCargaProd);
            this.Name = "frmGetProductos";
            this.Text = "frmGetProductos";
            this.Load += new System.EventHandler(this.frmGetProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargaProd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.Button buttonCargaInv;
        private System.Windows.Forms.Button buttonCargaPrecios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLast;
        private System.Windows.Forms.Label label3;
    }
}