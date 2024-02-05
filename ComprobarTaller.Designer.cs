
namespace concesionarioApp
{
    partial class ComprobarTaller
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
            this.dataCarView = new System.Windows.Forms.DataGridView();
            this.actualizarBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noResuletasRd = new System.Windows.Forms.RadioButton();
            this.resueltasRd = new System.Windows.Forms.RadioButton();
            this.esperarValidacionRd = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCarView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCarView
            // 
            this.dataCarView.AllowUserToAddRows = false;
            this.dataCarView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.dataCarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCarView.Location = new System.Drawing.Point(37, 206);
            this.dataCarView.Margin = new System.Windows.Forms.Padding(4);
            this.dataCarView.Name = "dataCarView";
            this.dataCarView.RowHeadersWidth = 51;
            this.dataCarView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataCarView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCarView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataCarView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.dataCarView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataCarView.RowTemplate.Height = 24;
            this.dataCarView.Size = new System.Drawing.Size(898, 356);
            this.dataCarView.TabIndex = 1;
            this.dataCarView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCarView_CellContentClick);
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.actualizarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.actualizarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.actualizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarBtn.Location = new System.Drawing.Point(745, 581);
            this.actualizarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Size = new System.Drawing.Size(190, 36);
            this.actualizarBtn.TabIndex = 2;
            this.actualizarBtn.Text = "Confirmar";
            this.actualizarBtn.UseVisualStyleBackColor = false;
            this.actualizarBtn.Click += new System.EventHandler(this.actualizarBtn_Click);
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(831, 21);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 36);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Volver";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noResuletasRd);
            this.groupBox1.Controls.Add(this.resueltasRd);
            this.groupBox1.Controls.Add(this.esperarValidacionRd);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(906, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "-";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // noResuletasRd
            // 
            this.noResuletasRd.AutoSize = true;
            this.noResuletasRd.Location = new System.Drawing.Point(735, 31);
            this.noResuletasRd.Margin = new System.Windows.Forms.Padding(4);
            this.noResuletasRd.Name = "noResuletasRd";
            this.noResuletasRd.Size = new System.Drawing.Size(147, 26);
            this.noResuletasRd.TabIndex = 2;
            this.noResuletasRd.TabStop = true;
            this.noResuletasRd.Text = "No Resuletas";
            this.noResuletasRd.UseVisualStyleBackColor = true;
            // 
            // resueltasRd
            // 
            this.resueltasRd.AutoSize = true;
            this.resueltasRd.Location = new System.Drawing.Point(406, 29);
            this.resueltasRd.Margin = new System.Windows.Forms.Padding(4);
            this.resueltasRd.Name = "resueltasRd";
            this.resueltasRd.Size = new System.Drawing.Size(116, 26);
            this.resueltasRd.TabIndex = 1;
            this.resueltasRd.TabStop = true;
            this.resueltasRd.Text = "Resueltas";
            this.resueltasRd.UseVisualStyleBackColor = true;
            // 
            // esperarValidacionRd
            // 
            this.esperarValidacionRd.AutoSize = true;
            this.esperarValidacionRd.Location = new System.Drawing.Point(29, 29);
            this.esperarValidacionRd.Margin = new System.Windows.Forms.Padding(4);
            this.esperarValidacionRd.Name = "esperarValidacionRd";
            this.esperarValidacionRd.Size = new System.Drawing.Size(231, 26);
            this.esperarValidacionRd.TabIndex = 0;
            this.esperarValidacionRd.TabStop = true;
            this.esperarValidacionRd.Text = "Esperando validacion";
            this.esperarValidacionRd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 83);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::concesionarioApp.Resource1.Logocar;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // ComprobarTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(977, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actualizarBtn);
            this.Controls.Add(this.dataCarView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComprobarTaller";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPROBACIÓN DEL ESTADO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComprobarTaller_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCarView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCarView;
        private System.Windows.Forms.Button actualizarBtn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton noResuletasRd;
        private System.Windows.Forms.RadioButton resueltasRd;
        private System.Windows.Forms.RadioButton esperarValidacionRd;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}