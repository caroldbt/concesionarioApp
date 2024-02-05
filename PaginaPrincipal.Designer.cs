
namespace concesionarioApp
{
    partial class PaginaPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.infoUserGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.anadirCoche = new System.Windows.Forms.Button();
            this.chatbtn = new System.Windows.Forms.Button();
            this.tallerCoches = new System.Windows.Forms.Button();
            this.tallerBtn = new System.Windows.Forms.Button();
            this.crearUsuario = new System.Windows.Forms.Button();
            this.comprobarCoches = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoUserGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoUserGrid
            // 
            this.infoUserGrid.AllowUserToAddRows = false;
            this.infoUserGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.infoUserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.infoUserGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.infoUserGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.infoUserGrid.Location = new System.Drawing.Point(110, 237);
            this.infoUserGrid.Name = "infoUserGrid";
            this.infoUserGrid.RowHeadersWidth = 51;
            this.infoUserGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.infoUserGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.infoUserGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUserGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.infoUserGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.infoUserGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.infoUserGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.infoUserGrid.RowTemplate.Height = 24;
            this.infoUserGrid.Size = new System.Drawing.Size(744, 233);
            this.infoUserGrid.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.anadirCoche);
            this.panel1.Controls.Add(this.chatbtn);
            this.panel1.Controls.Add(this.tallerCoches);
            this.panel1.Controls.Add(this.tallerBtn);
            this.panel1.Controls.Add(this.crearUsuario);
            this.panel1.Controls.Add(this.comprobarCoches);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 119);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // anadirCoche
            // 
            this.anadirCoche.BackColor = System.Drawing.Color.White;
            this.anadirCoche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.anadirCoche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.anadirCoche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anadirCoche.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anadirCoche.ForeColor = System.Drawing.Color.Transparent;
            this.anadirCoche.Image = global::concesionarioApp.Properties.Resources.coche1;
            this.anadirCoche.Location = new System.Drawing.Point(53, 24);
            this.anadirCoche.Name = "anadirCoche";
            this.anadirCoche.Size = new System.Drawing.Size(117, 75);
            this.anadirCoche.TabIndex = 1;
            this.anadirCoche.UseVisualStyleBackColor = false;
            this.anadirCoche.Click += new System.EventHandler(this.anadirCoche_Click);
            // 
            // chatbtn
            // 
            this.chatbtn.BackColor = System.Drawing.Color.White;
            this.chatbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.chatbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.chatbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatbtn.ForeColor = System.Drawing.Color.Transparent;
            this.chatbtn.Image = global::concesionarioApp.Properties.Resources.chat;
            this.chatbtn.Location = new System.Drawing.Point(803, 24);
            this.chatbtn.Name = "chatbtn";
            this.chatbtn.Size = new System.Drawing.Size(117, 75);
            this.chatbtn.TabIndex = 6;
            this.chatbtn.UseVisualStyleBackColor = false;
            this.chatbtn.Click += new System.EventHandler(this.chatbtn_Click);
            // 
            // tallerCoches
            // 
            this.tallerCoches.BackColor = System.Drawing.Color.White;
            this.tallerCoches.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tallerCoches.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.tallerCoches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tallerCoches.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallerCoches.ForeColor = System.Drawing.Color.Transparent;
            this.tallerCoches.Image = global::concesionarioApp.Properties.Resources.modelo2;
            this.tallerCoches.Location = new System.Drawing.Point(204, 24);
            this.tallerCoches.Name = "tallerCoches";
            this.tallerCoches.Size = new System.Drawing.Size(117, 75);
            this.tallerCoches.TabIndex = 2;
            this.tallerCoches.UseVisualStyleBackColor = false;
            this.tallerCoches.Click += new System.EventHandler(this.tallerCoches_Click);
            // 
            // tallerBtn
            // 
            this.tallerBtn.BackColor = System.Drawing.Color.White;
            this.tallerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tallerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.tallerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tallerBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.tallerBtn.Image = global::concesionarioApp.Properties.Resources.taller1;
            this.tallerBtn.Location = new System.Drawing.Point(511, 24);
            this.tallerBtn.Name = "tallerBtn";
            this.tallerBtn.Size = new System.Drawing.Size(117, 75);
            this.tallerBtn.TabIndex = 4;
            this.tallerBtn.UseVisualStyleBackColor = false;
            this.tallerBtn.Click += new System.EventHandler(this.tallerBtn_Click);
            // 
            // crearUsuario
            // 
            this.crearUsuario.BackColor = System.Drawing.Color.White;
            this.crearUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.crearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.crearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearUsuario.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.crearUsuario.Image = global::concesionarioApp.Properties.Resources.registrarEmpleados1;
            this.crearUsuario.Location = new System.Drawing.Point(660, 24);
            this.crearUsuario.Name = "crearUsuario";
            this.crearUsuario.Size = new System.Drawing.Size(117, 75);
            this.crearUsuario.TabIndex = 5;
            this.crearUsuario.UseVisualStyleBackColor = false;
            this.crearUsuario.Click += new System.EventHandler(this.crearUsuario_Click);
            // 
            // comprobarCoches
            // 
            this.comprobarCoches.BackColor = System.Drawing.Color.White;
            this.comprobarCoches.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.comprobarCoches.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.comprobarCoches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comprobarCoches.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprobarCoches.Image = global::concesionarioApp.Properties.Resources.verCoche;
            this.comprobarCoches.Location = new System.Drawing.Point(359, 24);
            this.comprobarCoches.Name = "comprobarCoches";
            this.comprobarCoches.Size = new System.Drawing.Size(117, 75);
            this.comprobarCoches.TabIndex = 3;
            this.comprobarCoches.UseVisualStyleBackColor = false;
            this.comprobarCoches.Click += new System.EventHandler(this.comprobarCoches_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(977, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.infoUserGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaginaPrincipal";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaginaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoUserGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button anadirCoche;
        private System.Windows.Forms.Button comprobarCoches;
        private System.Windows.Forms.Button tallerCoches;
        private System.Windows.Forms.Button crearUsuario;
        private System.Windows.Forms.DataGridView infoUserGrid;
        private System.Windows.Forms.Button tallerBtn;
        private System.Windows.Forms.Button chatbtn;
		private System.Windows.Forms.Panel panel1;
    }
}