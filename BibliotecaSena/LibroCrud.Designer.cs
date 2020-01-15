namespace BibliotecaSena
{
    partial class LibroCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibroCrud));
            this.Libro = new System.Windows.Forms.ListBox();
            this.Excluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cboEditorial = new System.Windows.Forms.ComboBox();
            this.txtCodigoE = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblCodigoL = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblNomLibro = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Libro
            // 
            this.Libro.FormattingEnabled = true;
            this.Libro.Location = new System.Drawing.Point(509, 98);
            this.Libro.Name = "Libro";
            this.Libro.Size = new System.Drawing.Size(203, 147);
            this.Libro.TabIndex = 16;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(491, 352);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(120, 52);
            this.Excluir.TabIndex = 15;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(152, 352);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(120, 52);
            this.btnIncluir.TabIndex = 14;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(312, 352);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 52);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // cboEditorial
            // 
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(265, 246);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(121, 21);
            this.cboEditorial.TabIndex = 12;
            // 
            // txtCodigoE
            // 
            this.txtCodigoE.Location = new System.Drawing.Point(265, 117);
            this.txtCodigoE.Name = "txtCodigoE";
            this.txtCodigoE.ReadOnly = true;
            this.txtCodigoE.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoE.TabIndex = 11;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(128, 244);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(70, 20);
            this.lblE.TabIndex = 10;
            this.lblE.Text = "Editorial:";
            // 
            // lblCodigoL
            // 
            this.lblCodigoL.AutoSize = true;
            this.lblCodigoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoL.Location = new System.Drawing.Point(135, 117);
            this.lblCodigoL.Name = "lblCodigoL";
            this.lblCodigoL.Size = new System.Drawing.Size(63, 20);
            this.lblCodigoL.TabIndex = 9;
            this.lblCodigoL.Text = "Codigo:";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.Location = new System.Drawing.Point(388, 28);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(82, 31);
            this.lblLibro.TabIndex = 17;
            this.lblLibro.Text = "Libro:";
            // 
            // lblNomLibro
            // 
            this.lblNomLibro.AutoSize = true;
            this.lblNomLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLibro.Location = new System.Drawing.Point(71, 179);
            this.lblNomLibro.Name = "lblNomLibro";
            this.lblNomLibro.Size = new System.Drawing.Size(127, 20);
            this.lblNomLibro.TabIndex = 18;
            this.lblNomLibro.Text = "Nombre del libro:";
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(265, 181);
            this.txtLibro.Multiline = true;
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.ReadOnly = true;
            this.txtLibro.Size = new System.Drawing.Size(100, 29);
            this.txtLibro.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(406, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // LibroCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.lblNomLibro);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.Libro);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboEditorial);
            this.Controls.Add(this.txtCodigoE);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblCodigoL);
            this.Name = "LibroCrud";
            this.Text = "LibroCrud";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Libro;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cboEditorial;
        private System.Windows.Forms.TextBox txtCodigoE;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblCodigoL;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblNomLibro;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}