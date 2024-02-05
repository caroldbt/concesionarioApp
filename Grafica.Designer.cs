
namespace concesionarioApp
{
    partial class Grafica
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.graficaResultado = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.disponiblesRd = new System.Windows.Forms.RadioButton();
			this.marcasRd = new System.Windows.Forms.RadioButton();
			this.comprasRd = new System.Windows.Forms.RadioButton();
			this.generalRd = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.graficaResultado)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// graficaResultado
			// 
			chartArea1.Name = "ChartArea1";
			this.graficaResultado.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.graficaResultado.Legends.Add(legend1);
			this.graficaResultado.Location = new System.Drawing.Point(12, 89);
			this.graficaResultado.Name = "graficaResultado";
			this.graficaResultado.Size = new System.Drawing.Size(953, 539);
			this.graficaResultado.TabIndex = 0;
			this.graficaResultado.Text = "chart1";
			this.graficaResultado.Click += new System.EventHandler(this.graficaResultado_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.disponiblesRd);
			this.groupBox1.Controls.Add(this.marcasRd);
			this.groupBox1.Controls.Add(this.comprasRd);
			this.groupBox1.Controls.Add(this.generalRd);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(22, -2);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(943, 84);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// disponiblesRd
			// 
			this.disponiblesRd.AutoSize = true;
			this.disponiblesRd.Location = new System.Drawing.Point(769, 28);
			this.disponiblesRd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.disponiblesRd.Name = "disponiblesRd";
			this.disponiblesRd.Size = new System.Drawing.Size(143, 25);
			this.disponiblesRd.TabIndex = 3;
			this.disponiblesRd.TabStop = true;
			this.disponiblesRd.Text = "radioButton3";
			this.disponiblesRd.UseVisualStyleBackColor = true;
			// 
			// marcasRd
			// 
			this.marcasRd.AutoSize = true;
			this.marcasRd.Location = new System.Drawing.Point(496, 28);
			this.marcasRd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.marcasRd.Name = "marcasRd";
			this.marcasRd.Size = new System.Drawing.Size(143, 25);
			this.marcasRd.TabIndex = 2;
			this.marcasRd.TabStop = true;
			this.marcasRd.Text = "radioButton3";
			this.marcasRd.UseVisualStyleBackColor = true;
			// 
			// comprasRd
			// 
			this.comprasRd.AutoSize = true;
			this.comprasRd.Location = new System.Drawing.Point(237, 28);
			this.comprasRd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comprasRd.MaximumSize = new System.Drawing.Size(995, 687);
			this.comprasRd.Name = "comprasRd";
			this.comprasRd.Size = new System.Drawing.Size(143, 25);
			this.comprasRd.TabIndex = 1;
			this.comprasRd.TabStop = true;
			this.comprasRd.Text = "radioButton2";
			this.comprasRd.UseVisualStyleBackColor = true;
			// 
			// generalRd
			// 
			this.generalRd.AutoSize = true;
			this.generalRd.Location = new System.Drawing.Point(8, 29);
			this.generalRd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.generalRd.Name = "generalRd";
			this.generalRd.Size = new System.Drawing.Size(143, 25);
			this.generalRd.TabIndex = 0;
			this.generalRd.TabStop = true;
			this.generalRd.Text = "radioButton1";
			this.generalRd.UseVisualStyleBackColor = true;
			// 
			// Grafica
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
			this.ClientSize = new System.Drawing.Size(977, 640);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.graficaResultado);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(995, 687);
			this.Name = "Grafica";
			this.Opacity = 0.96D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Graficas";
			this.Load += new System.EventHandler(this.Grafica_Load);
			((System.ComponentModel.ISupportInitialize)(this.graficaResultado)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficaResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton disponiblesRd;
        private System.Windows.Forms.RadioButton marcasRd;
        private System.Windows.Forms.RadioButton comprasRd;
        private System.Windows.Forms.RadioButton generalRd;
    }
}