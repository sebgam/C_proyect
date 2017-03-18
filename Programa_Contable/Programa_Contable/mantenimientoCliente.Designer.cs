namespace Programa_Contable
{
    partial class mantenimientoCliente
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApeCli = new System.Windows.Forms.TextBox();
            this.txtNomCli = new System.Windows.Forms.TextBox();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.lblhide3 = new System.Windows.Forms.Label();
            this.lblhide2 = new System.Windows.Forms.Label();
            this.lblhide1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administracionDataSet = new Programa_Contable.AdministracionDataSet();
            this.clienteTableAdapter = new Programa_Contable.AdministracionDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnSalir.Location = new System.Drawing.Point(463, 299);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id Cliente:";
            // 
            // txtApeCli
            // 
            this.txtApeCli.Location = new System.Drawing.Point(163, 142);
            this.txtApeCli.Name = "txtApeCli";
            this.txtApeCli.Size = new System.Drawing.Size(211, 20);
            this.txtApeCli.TabIndex = 14;
            // 
            // txtNomCli
            // 
            this.txtNomCli.Location = new System.Drawing.Point(163, 94);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.Size = new System.Drawing.Size(211, 20);
            this.txtNomCli.TabIndex = 13;
            // 
            // txtIdCli
            // 
            this.txtIdCli.Location = new System.Drawing.Point(163, 49);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(211, 20);
            this.txtIdCli.TabIndex = 12;
            // 
            // lblhide3
            // 
            this.lblhide3.AutoSize = true;
            this.lblhide3.Location = new System.Drawing.Point(335, 315);
            this.lblhide3.Name = "lblhide3";
            this.lblhide3.Size = new System.Drawing.Size(0, 13);
            this.lblhide3.TabIndex = 26;
            // 
            // lblhide2
            // 
            this.lblhide2.AutoSize = true;
            this.lblhide2.Location = new System.Drawing.Point(214, 312);
            this.lblhide2.Name = "lblhide2";
            this.lblhide2.Size = new System.Drawing.Size(0, 13);
            this.lblhide2.TabIndex = 25;
            // 
            // lblhide1
            // 
            this.lblhide1.AutoSize = true;
            this.lblhide1.Location = new System.Drawing.Point(76, 313);
            this.lblhide1.Name = "lblhide1";
            this.lblhide1.Size = new System.Drawing.Size(0, 13);
            this.lblhide1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AccessibleName = "";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Id Producto";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AccessibleName = "";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Desacripcion";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Producto creado:";
            this.label5.Visible = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.administracionDataSet;
            // 
            // administracionDataSet
            // 
            this.administracionDataSet.DataSetName = "AdministracionDataSet";
            this.administracionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // mantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 387);
            this.Controls.Add(this.lblhide3);
            this.Controls.Add(this.lblhide2);
            this.Controls.Add(this.lblhide1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApeCli);
            this.Controls.Add(this.txtNomCli);
            this.Controls.Add(this.txtIdCli);
            this.Name = "mantenimientoCliente";
            this.Text = "Mantenimiento Cliente";
            this.Load += new System.EventHandler(this.mantenimientoCliente_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.txtIdCli, 0);
            this.Controls.SetChildIndex(this.txtNomCli, 0);
            this.Controls.SetChildIndex(this.txtApeCli, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.lblhide1, 0);
            this.Controls.SetChildIndex(this.lblhide2, 0);
            this.Controls.SetChildIndex(this.lblhide3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApeCli;
        private System.Windows.Forms.TextBox txtNomCli;
        private System.Windows.Forms.TextBox txtIdCli;
        private System.Windows.Forms.Label lblhide3;
        private System.Windows.Forms.Label lblhide2;
        private System.Windows.Forms.Label lblhide1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private AdministracionDataSet administracionDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private AdministracionDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}