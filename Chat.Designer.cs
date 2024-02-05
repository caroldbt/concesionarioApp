
namespace concesionarioApp
{
    partial class Chat
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
            this.listMensajes = new System.Windows.Forms.ListBox();
            this.conversacionesList = new System.Windows.Forms.ListBox();
            this.enviarInput = new System.Windows.Forms.TextBox();
            this.enviarBtn = new System.Windows.Forms.Button();
            this.recibidosLbl = new System.Windows.Forms.Label();
            this.chatLbl = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.elegirUsuario = new System.Windows.Forms.Button();
            this.listaUsuarioMensajes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listMensajes
            // 
            this.listMensajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.listMensajes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMensajes.ForeColor = System.Drawing.Color.White;
            this.listMensajes.FormattingEnabled = true;
            this.listMensajes.ItemHeight = 21;
            this.listMensajes.Location = new System.Drawing.Point(48, 147);
            this.listMensajes.Name = "listMensajes";
            this.listMensajes.Size = new System.Drawing.Size(300, 403);
            this.listMensajes.TabIndex = 0;
            this.listMensajes.SelectedIndexChanged += new System.EventHandler(this.listMensajes_SelectedIndexChanged);
            // 
            // conversacionesList
            // 
            this.conversacionesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.conversacionesList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversacionesList.ForeColor = System.Drawing.Color.White;
            this.conversacionesList.ItemHeight = 21;
            this.conversacionesList.Location = new System.Drawing.Point(409, 141);
            this.conversacionesList.Name = "conversacionesList";
            this.conversacionesList.Size = new System.Drawing.Size(510, 256);
            this.conversacionesList.TabIndex = 1;
            // 
            // enviarInput
            // 
            this.enviarInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.enviarInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarInput.Location = new System.Drawing.Point(409, 441);
            this.enviarInput.Name = "enviarInput";
            this.enviarInput.Size = new System.Drawing.Size(335, 30);
            this.enviarInput.TabIndex = 2;
            // 
            // enviarBtn
            // 
            this.enviarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.enviarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarBtn.Location = new System.Drawing.Point(770, 432);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(149, 37);
            this.enviarBtn.TabIndex = 3;
            this.enviarBtn.Text = "Enviar";
            this.enviarBtn.UseVisualStyleBackColor = false;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // recibidosLbl
            // 
            this.recibidosLbl.AutoSize = true;
            this.recibidosLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recibidosLbl.Location = new System.Drawing.Point(44, 106);
            this.recibidosLbl.Name = "recibidosLbl";
            this.recibidosLbl.Size = new System.Drawing.Size(103, 23);
            this.recibidosLbl.TabIndex = 4;
            this.recibidosLbl.Text = "Recibidos";
            // 
            // chatLbl
            // 
            this.chatLbl.AutoSize = true;
            this.chatLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatLbl.Location = new System.Drawing.Point(405, 106);
            this.chatLbl.Name = "chatLbl";
            this.chatLbl.Size = new System.Drawing.Size(59, 23);
            this.chatLbl.TabIndex = 5;
            this.chatLbl.Text = "Chat";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(855, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 39);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Volver";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // elegirUsuario
            // 
            this.elegirUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.elegirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elegirUsuario.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elegirUsuario.Location = new System.Drawing.Point(770, 496);
            this.elegirUsuario.Name = "elegirUsuario";
            this.elegirUsuario.Size = new System.Drawing.Size(149, 42);
            this.elegirUsuario.TabIndex = 7;
            this.elegirUsuario.Text = "Enviar a nuevo";
            this.elegirUsuario.UseVisualStyleBackColor = false;
            this.elegirUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaUsuarioMensajes
            // 
            this.listaUsuarioMensajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.listaUsuarioMensajes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaUsuarioMensajes.FormattingEnabled = true;
            this.listaUsuarioMensajes.Location = new System.Drawing.Point(409, 509);
            this.listaUsuarioMensajes.Name = "listaUsuarioMensajes";
            this.listaUsuarioMensajes.Size = new System.Drawing.Size(335, 29);
            this.listaUsuarioMensajes.TabIndex = 8;
            this.listaUsuarioMensajes.SelectedIndexChanged += new System.EventHandler(this.listaUsuarioMensajes_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 84);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::concesionarioApp.Resource1.Logocar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(977, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listaUsuarioMensajes);
            this.Controls.Add(this.elegirUsuario);
            this.Controls.Add(this.chatLbl);
            this.Controls.Add(this.recibidosLbl);
            this.Controls.Add(this.enviarBtn);
            this.Controls.Add(this.enviarInput);
            this.Controls.Add(this.conversacionesList);
            this.Controls.Add(this.listMensajes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Chat";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHAT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMensajes;
        private System.Windows.Forms.TextBox enviarInput;
        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.Label recibidosLbl;
        private System.Windows.Forms.Label chatLbl;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox conversacionesList;
        private System.Windows.Forms.Button elegirUsuario;
        private System.Windows.Forms.ComboBox listaUsuarioMensajes;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}