namespace BibliotecaSena
{
    partial class EditorialCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorialCrud));
            this.lblEditorial = new System.Windows.Forms.Label();
            this.labCodigoE = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.txtCodigoE = new System.Windows.Forms.TextBox();
            this.cboEditorial = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.lbEditorial = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(343, 41);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(112, 31);
            this.lblEditorial.TabIndex = 0;
            this.lblEditorial.Text = "Editorial";
            this.lblEditorial.Click += new System.EventHandler(this.label1_Click);
            // 
            // labCodigoE
            // 
            this.labCodigoE.AutoSize = true;
            this.labCodigoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCodigoE.Location = new System.Drawing.Point(205, 128);
            this.labCodigoE.Name = "labCodigoE";
            this.labCodigoE.Size = new System.Drawing.Size(63, 20);
            this.labCodigoE.TabIndex = 1;
            this.labCodigoE.Text = "Codigo:";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(198, 197);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(70, 20);
            this.lblE.TabIndex = 2;
            this.lblE.Text = "Editorial:";
            this.lblE.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCodigoE
            // 
            this.txtCodigoE.Location = new System.Drawing.Point(305, 127);
            this.txtCodigoE.Name = "txtCodigoE";
            this.txtCodigoE.ReadOnly = true;
            this.txtCodigoE.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoE.TabIndex = 3;
            // 
            // cboEditorial
            // 
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(305, 195);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(121, 21);
            this.cboEditorial.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(349, 294);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 52);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(181, 294);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(120, 52);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(517, 294);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(120, 52);
            this.Excluir.TabIndex = 7;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // lbEditorial
            // 
            this.lbEditorial.FormattingEnabled = true;
            this.lbEditorial.Location = new System.Drawing.Point(559, 127);
            this.lbEditorial.Name = "lbEditorial";
            this.lbEditorial.Size = new System.Drawing.Size(120, 95);
            this.lbEditorial.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // EditorialCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbEditorial);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboEditorial);
            this.Controls.Add(this.txtCodigoE);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.labCodigoE);
            this.Controls.Add(this.lblEditorial);
            this.Name = "EditorialCrud";
            this.Text = "EditorialCrud";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label labCodigoE;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.TextBox txtCodigoE;
        private System.Windows.Forms.ComboBox cboEditorial;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.ListBox lbEditorial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}