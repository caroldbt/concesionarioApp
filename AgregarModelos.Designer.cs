
namespace concesionarioApp
{
    partial class AgregarModelos
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
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.marcaInput = new System.Windows.Forms.ComboBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.marcaLbl = new System.Windows.Forms.Label();
            this.erroresInputModelo = new System.Windows.Forms.Label();
            this.confirmModelBtn = new System.Windows.Forms.Button();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.titLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descripcionInput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreInput
            // 
            this.nombreInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.nombreInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreInput.ForeColor = System.Drawing.Color.White;
            this.nombreInput.Location = new System.Drawing.Point(296, 257);
            this.nombreInput.MaxLength = 20;
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(292, 30);
            this.nombreInput.TabIndex = 0;
            // 
            // marcaInput
            // 
            this.marcaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.marcaInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaInput.ForeColor = System.Drawing.Color.White;
            this.marcaInput.FormattingEnabled = true;
            this.marcaInput.Location = new System.Drawing.Point(296, 332);
            this.marcaInput.Name = "marcaInput";
            this.marcaInput.Size = new System.Drawing.Size(292, 29);
            this.marcaInput.TabIndex = 1;
            this.marcaInput.SelectedIndexChanged += new System.EventHandler(this.marcaInput_SelectedIndexChanged);
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.Location = new System.Drawing.Point(292, 233);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(65, 22);
            this.nombreLbl.TabIndex = 2;
            this.nombreLbl.Text = "label1";
            // 
            // marcaLbl
            // 
            this.marcaLbl.AutoSize = true;
            this.marcaLbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaLbl.Location = new System.Drawing.Point(292, 308);
            this.marcaLbl.Name = "marcaLbl";
            this.marcaLbl.Size = new System.Drawing.Size(65, 22);
            this.marcaLbl.TabIndex = 3;
            this.marcaLbl.Text = "label2";
            // 
            // erroresInputModelo
            // 
            this.erroresInputModelo.AutoSize = true;
            this.erroresInputModelo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroresInputModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.erroresInputModelo.Location = new System.Drawing.Point(292, 446);
            this.erroresInputModelo.Name = "erroresInputModelo";
            this.erroresInputModelo.Size = new System.Drawing.Size(53, 20);
            this.erroresInputModelo.TabIndex = 4;
            this.erroresInputModelo.Text = "label3";
            // 
            // confirmModelBtn
            // 
            this.confirmModelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.confirmModelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.confirmModelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.confirmModelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmModelBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmModelBtn.Location = new System.Drawing.Point(294, 496);
            this.confirmModelBtn.Name = "confirmModelBtn";
            this.confirmModelBtn.Size = new System.Drawing.Size(292, 42);
            this.confirmModelBtn.TabIndex = 3;
            this.confirmModelBtn.Text = "Agregar";
            this.confirmModelBtn.UseVisualStyleBackColor = false;
            this.confirmModelBtn.Click += new System.EventHandler(this.confirmModelBtn_Click);
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.AutoSize = true;
            this.descripcionLbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLbl.Location = new System.Drawing.Point(301, 379);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(65, 22);
            this.descripcionLbl.TabIndex = 7;
            this.descripcionLbl.Text = "label3";
            // 
            // titLbl
            // 
            this.titLbl.AutoSize = true;
            this.titLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titLbl.Location = new System.Drawing.Point(412, 156);
            this.titLbl.Name = "titLbl";
            this.titLbl.Size = new System.Drawing.Size(72, 23);
            this.titLbl.TabIndex = 8;
            this.titLbl.Text = "label1";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(821, 30);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 35);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Volver";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::concesionarioApp.Resource1.Logocar;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 88);
            this.panel1.TabIndex = 10;
            // 
            // descripcionInput
            // 
            this.descripcionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.descripcionInput.Location = new System.Drawing.Point(296, 404);
            this.descripcionInput.Name = "descripcionInput";
            this.descripcionInput.Size = new System.Drawing.Size(292, 39);
            this.descripcionInput.TabIndex = 11;
            this.descripcionInput.Text = "";
            // 
            // AgregarModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(977, 640);
            this.Controls.Add(this.descripcionInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titLbl);
            this.Controls.Add(this.descripcionLbl);
            this.Controls.Add(this.confirmModelBtn);
            this.Controls.Add(this.erroresInputModelo);
            this.Controls.Add(this.marcaLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.marcaInput);
            this.Controls.Add(this.nombreInput);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarModelos";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR MODELO DE COHES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarModelos_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.ComboBox marcaInput;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label marcaLbl;
        private System.Windows.Forms.Label erroresInputModelo;
        private System.Windows.Forms.Button confirmModelBtn;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.Label titLbl;
		private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox descripcionInput;
    }
}