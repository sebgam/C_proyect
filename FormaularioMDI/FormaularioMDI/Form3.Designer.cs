namespace FormaularioMDI
{
    partial class txt_pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txt_pass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            this.iTalk_ComboBox1 = new iTalk.iTalk_ComboBox();
            this.txt_contra = new iTalk.iTalk_TextBox_Small();
            this.txt_user = new iTalk.iTalk_TextBox_Small();
            this.ProgressBar1 = new iTalk.iTalk_ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(31, 317);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(130, 33);
            this.iTalk_Button_21.TabIndex = 7;
            this.iTalk_Button_21.Text = "Iniciar sesion";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // iTalk_ComboBox1
            // 
            this.iTalk_ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.iTalk_ComboBox1.DropDownHeight = 100;
            this.iTalk_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iTalk_ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ComboBox1.FormattingEnabled = true;
            this.iTalk_ComboBox1.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.iTalk_ComboBox1.IntegralHeight = false;
            this.iTalk_ComboBox1.ItemHeight = 20;
            this.iTalk_ComboBox1.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "INVITADO"});
            this.iTalk_ComboBox1.Location = new System.Drawing.Point(31, 155);
            this.iTalk_ComboBox1.Name = "iTalk_ComboBox1";
            this.iTalk_ComboBox1.Size = new System.Drawing.Size(135, 26);
            this.iTalk_ComboBox1.StartIndex = 0;
            this.iTalk_ComboBox1.TabIndex = 3;
            // 
            // txt_contra
            // 
            this.txt_contra.BackColor = System.Drawing.Color.Transparent;
            this.txt_contra.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_contra.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contra.Location = new System.Drawing.Point(31, 271);
            this.txt_contra.MaxLength = 32767;
            this.txt_contra.Multiline = false;
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.ReadOnly = false;
            this.txt_contra.Size = new System.Drawing.Size(135, 28);
            this.txt_contra.TabIndex = 2;
            this.txt_contra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_contra.UseSystemPasswordChar = true;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.Transparent;
            this.txt_user.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_user.ForeColor = System.Drawing.Color.DimGray;
            this.txt_user.Location = new System.Drawing.Point(31, 211);
            this.txt_user.MaxLength = 32767;
            this.txt_user.Multiline = false;
            this.txt_user.Name = "txt_user";
            this.txt_user.ReadOnly = false;
            this.txt_user.Size = new System.Drawing.Size(135, 28);
            this.txt_user.TabIndex = 1;
            this.txt_user.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_user.UseSystemPasswordChar = false;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ProgressBar1.Location = new System.Drawing.Point(31, -5);
            this.ProgressBar1.Maximum = ((long)(100));
            this.ProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProgressBar1.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
            this.ProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.ProgressBar1.TabIndex = 0;
            this.ProgressBar1.Text = "iTalk_ProgressBar1";
            this.ProgressBar1.Value = ((long)(0));
            // 
            // txt_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 374);
            this.Controls.Add(this.iTalk_Button_21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iTalk_ComboBox1);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.ProgressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "txt_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBar circular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_ProgressBar ProgressBar1;
        private iTalk.iTalk_TextBox_Small txt_user;
        private iTalk.iTalk_TextBox_Small txt_contra;
        private iTalk.iTalk_ComboBox iTalk_ComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private iTalk.iTalk_Button_2 iTalk_Button_21;
        private System.Windows.Forms.Timer timer1;
    }
}