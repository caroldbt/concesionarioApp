
namespace concesionarioApp
{
    partial class VistaCoches
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VentasPendientesRadioButton = new System.Windows.Forms.RadioButton();
            this.TallerRadioButton = new System.Windows.Forms.RadioButton();
            this.AlquilerRadioButton = new System.Windows.Forms.RadioButton();
            this.VentasRadioButton = new System.Windows.Forms.RadioButton();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.generarGrafica = new System.Windows.Forms.Button();
            this.validarVentaBtn = new System.Windows.Forms.Button();
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
            this.dataCarView.Location = new System.Drawing.Point(36, 192);
            this.dataCarView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataCarView.Name = "dataCarView";
            this.dataCarView.RowHeadersWidth = 51;
            this.dataCarView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataCarView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCarView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataCarView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.dataCarView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataCarView.RowTemplate.Height = 24;
            this.dataCarView.Size = new System.Drawing.Size(898, 356);
            this.dataCarView.TabIndex = 0;
            this.dataCarView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCarView_CellContentClick);
            this.dataCarView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataCarView_CellPainting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VentasPendientesRadioButton);
            this.groupBox1.Controls.Add(this.TallerRadioButton);
            this.groupBox1.Controls.Add(this.AlquilerRadioButton);
            this.groupBox1.Controls.Add(this.VentasRadioButton);
            this.groupBox1.Controls.Add(this.TodosRadioButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(944, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // VentasPendientesRadioButton
            // 
            this.VentasPendientesRadioButton.AutoSize = true;
            this.VentasPendientesRadioButton.Location = new System.Drawing.Point(754, 28);
            this.VentasPendientesRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VentasPendientesRadioButton.Name = "VentasPendientesRadioButton";
            this.VentasPendientesRadioButton.Size = new System.Drawing.Size(184, 26);
            this.VentasPendientesRadioButton.TabIndex = 4;
            this.VentasPendientesRadioButton.TabStop = true;
            this.VentasPendientesRadioButton.Text = "PendienteVenta";
            this.VentasPendientesRadioButton.UseVisualStyleBackColor = true;
            // 
            // TallerRadioButton
            // 
            this.TallerRadioButton.AutoSize = true;
            this.TallerRadioButton.Location = new System.Drawing.Point(564, 29);
            this.TallerRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TallerRadioButton.Name = "TallerRadioButton";
            this.TallerRadioButton.Size = new System.Drawing.Size(150, 26);
            this.TallerRadioButton.TabIndex = 3;
            this.TallerRadioButton.TabStop = true;
            this.TallerRadioButton.Text = "radioButton3";
            this.TallerRadioButton.UseVisualStyleBackColor = true;
            // 
            // AlquilerRadioButton
            // 
            this.AlquilerRadioButton.AutoSize = true;
            this.AlquilerRadioButton.Location = new System.Drawing.Point(384, 28);
            this.AlquilerRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AlquilerRadioButton.Name = "AlquilerRadioButton";
            this.AlquilerRadioButton.Size = new System.Drawing.Size(150, 26);
            this.AlquilerRadioButton.TabIndex = 2;
            this.AlquilerRadioButton.TabStop = true;
            this.AlquilerRadioButton.Text = "radioButton3";
            this.AlquilerRadioButton.UseVisualStyleBackColor = true;
            // 
            // VentasRadioButton
            // 
            this.VentasRadioButton.AutoSize = true;
            this.VentasRadioButton.Location = new System.Drawing.Point(194, 29);
            this.VentasRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VentasRadioButton.Name = "VentasRadioButton";
            this.VentasRadioButton.Size = new System.Drawing.Size(150, 26);
            this.VentasRadioButton.TabIndex = 1;
            this.VentasRadioButton.TabStop = true;
            this.VentasRadioButton.Text = "radioButton2";
            this.VentasRadioButton.UseVisualStyleBackColor = true;
            // 
            // TodosRadioButton
            // 
            this.TodosRadioButton.AutoSize = true;
            this.TodosRadioButton.Location = new System.Drawing.Point(8, 29);
            this.TodosRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TodosRadioButton.Name = "TodosRadioButton";
            this.TodosRadioButton.Size = new System.Drawing.Size(150, 26);
            this.TodosRadioButton.TabIndex = 0;
            this.TodosRadioButton.TabStop = true;
            this.TodosRadioButton.Text = "radioButton1";
            this.TodosRadioButton.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(822, 24);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(112, 36);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Volver";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 85);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::concesionarioApp.Resource1.Logocar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // generarGrafica
            // 
            this.generarGrafica.Location = new System.Drawing.Point(419, 555);
            this.generarGrafica.Name = "generarGrafica";
            this.generarGrafica.Size = new System.Drawing.Size(127, 53);
            this.generarGrafica.TabIndex = 4;
            this.generarGrafica.Text = "Generar Grafica";
            this.generarGrafica.UseVisualStyleBackColor = true;
            this.generarGrafica.Click += new System.EventHandler(this.generarGrafica_Click);
            // 
            // validarVentaBtn
            // 
            this.validarVentaBtn.Location = new System.Drawing.Point(419, 555);
            this.validarVentaBtn.Name = "validarVentaBtn";
            this.validarVentaBtn.Size = new System.Drawing.Size(123, 63);
            this.validarVentaBtn.TabIndex = 5;
            this.validarVentaBtn.Text = "Validar Venta";
            this.validarVentaBtn.UseVisualStyleBackColor = true;
            this.validarVentaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // VistaCoches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(977, 640);
            this.Controls.Add(this.validarVentaBtn);
            this.Controls.Add(this.generarGrafica);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataCarView);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaCoches";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COCHES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VistaCoches_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCarView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCarView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton TallerRadioButton;
        private System.Windows.Forms.RadioButton AlquilerRadioButton;
        private System.Windows.Forms.RadioButton VentasRadioButton;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button generarGrafica;
        private System.Windows.Forms.Button validarVentaBtn;
        private System.Windows.Forms.RadioButton VentasPendientesRadioButton;
    }

}