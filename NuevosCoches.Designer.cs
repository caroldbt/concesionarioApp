
namespace concesionarioApp
{
    partial class NuevosCoches
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
			this.matriculaInput = new System.Windows.Forms.TextBox();
			this.imagenesInput = new System.Windows.Forms.TextBox();
			this.descripcionInput = new System.Windows.Forms.TextBox();
			this.precioCompraInput = new System.Windows.Forms.TextBox();
			this.precioAlquilerInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.fechaCocheInput = new System.Windows.Forms.DateTimePicker();
			this.agregarConfirmBtn = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.groupCoche = new System.Windows.Forms.GroupBox();
			this.enVentaInput = new System.Windows.Forms.RadioButton();
			this.enAlquilerInput = new System.Windows.Forms.RadioButton();
			this.enTallerInput = new System.Windows.Forms.RadioButton();
			this.estadoInput = new System.Windows.Forms.ComboBox();
			this.propietarioBox = new System.Windows.Forms.ComboBox();
			this.marcaInput = new System.Windows.Forms.ComboBox();
			this.propietarioInput = new System.Windows.Forms.ComboBox();
			this.modelosInput = new System.Windows.Forms.ComboBox();
			this.elegirColorBtn = new System.Windows.Forms.Button();
			this.colorInput = new System.Windows.Forms.TextBox();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.backBtn = new System.Windows.Forms.Button();
			this.lblErrorMatricula = new System.Windows.Forms.Label();
			this.lblErrorMarca = new System.Windows.Forms.Label();
			this.lblErrorModelo = new System.Windows.Forms.Label();
			this.lblErrorPrecioCompra = new System.Windows.Forms.Label();
			this.lblErrorPrecioAlquiler = new System.Windows.Forms.Label();
			this.lblErrorEstado = new System.Windows.Forms.Label();
			this.lblErrorColor = new System.Windows.Forms.Label();
			this.lblErrorDescripcion = new System.Windows.Forms.Label();
			this.lblErrorImagenes = new System.Windows.Forms.Label();
			this.imgButton = new System.Windows.Forms.Button();
			this.imgList = new System.Windows.Forms.ListBox();
			this.dataTallerList = new System.Windows.Forms.ListBox();
			this.dataTallerbtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupCoche.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// matriculaInput
			// 
			this.matriculaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.matriculaInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.matriculaInput.ForeColor = System.Drawing.Color.White;
			this.matriculaInput.Location = new System.Drawing.Point(26, 117);
			this.matriculaInput.MaxLength = 7;
			this.matriculaInput.Name = "matriculaInput";
			this.matriculaInput.Size = new System.Drawing.Size(175, 30);
			this.matriculaInput.TabIndex = 0;
			this.matriculaInput.TextChanged += new System.EventHandler(this.matriculaInput_TextChanged);
			// 
			// imagenesInput
			// 
			this.imagenesInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.imagenesInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imagenesInput.ForeColor = System.Drawing.Color.White;
			this.imagenesInput.Location = new System.Drawing.Point(361, 423);
			this.imagenesInput.Multiline = true;
			this.imagenesInput.Name = "imagenesInput";
			this.imagenesInput.Size = new System.Drawing.Size(383, 31);
			this.imagenesInput.TabIndex = 15;
			// 
			// descripcionInput
			// 
			this.descripcionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.descripcionInput.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descripcionInput.ForeColor = System.Drawing.Color.White;
			this.descripcionInput.Location = new System.Drawing.Point(360, 259);
			this.descripcionInput.Multiline = true;
			this.descripcionInput.Name = "descripcionInput";
			this.descripcionInput.Size = new System.Drawing.Size(384, 28);
			this.descripcionInput.TabIndex = 13;
			this.descripcionInput.TextChanged += new System.EventHandler(this.descripcionInput_TextChanged);
			// 
			// precioCompraInput
			// 
			this.precioCompraInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.precioCompraInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.precioCompraInput.ForeColor = System.Drawing.Color.White;
			this.precioCompraInput.Location = new System.Drawing.Point(360, 177);
			this.precioCompraInput.Name = "precioCompraInput";
			this.precioCompraInput.Size = new System.Drawing.Size(175, 30);
			this.precioCompraInput.TabIndex = 11;
			this.precioCompraInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioCompraInput_KeyPress);
			// 
			// precioAlquilerInput
			// 
			this.precioAlquilerInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.precioAlquilerInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.precioAlquilerInput.ForeColor = System.Drawing.Color.White;
			this.precioAlquilerInput.Location = new System.Drawing.Point(569, 177);
			this.precioAlquilerInput.Name = "precioAlquilerInput";
			this.precioAlquilerInput.Size = new System.Drawing.Size(175, 30);
			this.precioAlquilerInput.TabIndex = 12;
			this.precioAlquilerInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioAlquilerInput_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "matricula";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 246);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 21);
			this.label2.TabIndex = 14;
			this.label2.Text = "modelo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(357, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 21);
			this.label3.TabIndex = 15;
			this.label3.Text = "propietario";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(356, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 21);
			this.label4.TabIndex = 16;
			this.label4.Text = "precioCompra";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(565, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 21);
			this.label5.TabIndex = 17;
			this.label5.Text = "precioAlquiler";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 21);
			this.label6.TabIndex = 18;
			this.label6.Text = "marca";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(25, 322);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 21);
			this.label7.TabIndex = 19;
			this.label7.Text = "estado";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(26, 398);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(54, 21);
			this.label11.TabIndex = 23;
			this.label11.Text = "color";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(356, 235);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(106, 21);
			this.label12.TabIndex = 24;
			this.label12.Text = "descripcion";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(357, 399);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(96, 21);
			this.label13.TabIndex = 25;
			this.label13.Text = "imagenes";
			// 
			// fechaCocheInput
			// 
			this.fechaCocheInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fechaCocheInput.Location = new System.Drawing.Point(360, 335);
			this.fechaCocheInput.MaxDate = new System.DateTime(2023, 1, 18, 0, 0, 0, 0);
			this.fechaCocheInput.Name = "fechaCocheInput";
			this.fechaCocheInput.Size = new System.Drawing.Size(384, 30);
			this.fechaCocheInput.TabIndex = 14;
			this.fechaCocheInput.Value = new System.DateTime(2023, 1, 18, 0, 0, 0, 0);
			this.fechaCocheInput.ValueChanged += new System.EventHandler(this.fechaCocheInput_ValueChanged);
			// 
			// agregarConfirmBtn
			// 
			this.agregarConfirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
			this.agregarConfirmBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
			this.agregarConfirmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
			this.agregarConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.agregarConfirmBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.agregarConfirmBtn.Location = new System.Drawing.Point(766, 549);
			this.agregarConfirmBtn.Name = "agregarConfirmBtn";
			this.agregarConfirmBtn.Size = new System.Drawing.Size(190, 48);
			this.agregarConfirmBtn.TabIndex = 17;
			this.agregarConfirmBtn.Text = "Confirmar";
			this.agregarConfirmBtn.UseVisualStyleBackColor = false;
			this.agregarConfirmBtn.Click += new System.EventHandler(this.agregarConfirmBtn_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(357, 310);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(135, 21);
			this.label14.TabIndex = 28;
			this.label14.Text = "Fecha coche:";
			// 
			// groupCoche
			// 
			this.groupCoche.Controls.Add(this.enVentaInput);
			this.groupCoche.Controls.Add(this.enAlquilerInput);
			this.groupCoche.Controls.Add(this.enTallerInput);
			this.groupCoche.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupCoche.Location = new System.Drawing.Point(26, 476);
			this.groupCoche.Name = "groupCoche";
			this.groupCoche.Size = new System.Drawing.Size(171, 136);
			this.groupCoche.TabIndex = 29;
			this.groupCoche.TabStop = false;
			this.groupCoche.Enter += new System.EventHandler(this.groupCoche_Enter);
			// 
			// enVentaInput
			// 
			this.enVentaInput.AutoSize = true;
			this.enVentaInput.Location = new System.Drawing.Point(16, 23);
			this.enVentaInput.Name = "enVentaInput";
			this.enVentaInput.Size = new System.Drawing.Size(111, 25);
			this.enVentaInput.TabIndex = 6;
			this.enVentaInput.TabStop = true;
			this.enVentaInput.Text = "enVenta";
			this.enVentaInput.UseVisualStyleBackColor = true;
			// 
			// enAlquilerInput
			// 
			this.enAlquilerInput.AutoSize = true;
			this.enAlquilerInput.Location = new System.Drawing.Point(16, 54);
			this.enAlquilerInput.Name = "enAlquilerInput";
			this.enAlquilerInput.Size = new System.Drawing.Size(115, 25);
			this.enAlquilerInput.TabIndex = 7;
			this.enAlquilerInput.TabStop = true;
			this.enAlquilerInput.Text = "enalquiler";
			this.enAlquilerInput.UseVisualStyleBackColor = true;
			// 
			// enTallerInput
			// 
			this.enTallerInput.AutoSize = true;
			this.enTallerInput.Location = new System.Drawing.Point(16, 85);
			this.enTallerInput.Name = "enTallerInput";
			this.enTallerInput.Size = new System.Drawing.Size(97, 25);
			this.enTallerInput.TabIndex = 8;
			this.enTallerInput.TabStop = true;
			this.enTallerInput.Text = "enTaller";
			this.enTallerInput.UseVisualStyleBackColor = true;
			// 
			// estadoInput
			// 
			this.estadoInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.estadoInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.estadoInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.estadoInput.ForeColor = System.Drawing.Color.White;
			this.estadoInput.FormattingEnabled = true;
			this.estadoInput.Location = new System.Drawing.Point(26, 346);
			this.estadoInput.Name = "estadoInput";
			this.estadoInput.Size = new System.Drawing.Size(175, 29);
			this.estadoInput.TabIndex = 4;
			// 
			// propietarioBox
			// 
			this.propietarioBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.propietarioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.propietarioBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.propietarioBox.ForeColor = System.Drawing.Color.White;
			this.propietarioBox.FormattingEnabled = true;
			this.propietarioBox.Items.AddRange(new object[] {
            "Si",
            "No"});
			this.propietarioBox.Location = new System.Drawing.Point(360, 116);
			this.propietarioBox.Name = "propietarioBox";
			this.propietarioBox.Size = new System.Drawing.Size(175, 29);
			this.propietarioBox.TabIndex = 9;
			this.propietarioBox.SelectedIndexChanged += new System.EventHandler(this.propietarioBox_SelectedIndexChanged);
			// 
			// marcaInput
			// 
			this.marcaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.marcaInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.marcaInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.marcaInput.ForeColor = System.Drawing.Color.White;
			this.marcaInput.FormattingEnabled = true;
			this.marcaInput.Location = new System.Drawing.Point(26, 194);
			this.marcaInput.Name = "marcaInput";
			this.marcaInput.Size = new System.Drawing.Size(175, 29);
			this.marcaInput.TabIndex = 2;
			this.marcaInput.SelectedIndexChanged += new System.EventHandler(this.marcaInput_SelectedIndexChanged);
			// 
			// propietarioInput
			// 
			this.propietarioInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.propietarioInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.propietarioInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.propietarioInput.ForeColor = System.Drawing.Color.White;
			this.propietarioInput.FormattingEnabled = true;
			this.propietarioInput.Location = new System.Drawing.Point(569, 116);
			this.propietarioInput.Name = "propietarioInput";
			this.propietarioInput.Size = new System.Drawing.Size(175, 29);
			this.propietarioInput.TabIndex = 10;
			// 
			// modelosInput
			// 
			this.modelosInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.modelosInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modelosInput.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modelosInput.ForeColor = System.Drawing.Color.White;
			this.modelosInput.FormattingEnabled = true;
			this.modelosInput.Location = new System.Drawing.Point(26, 270);
			this.modelosInput.Name = "modelosInput";
			this.modelosInput.Size = new System.Drawing.Size(175, 29);
			this.modelosInput.TabIndex = 3;
			this.modelosInput.SelectedIndexChanged += new System.EventHandler(this.modelosInput_SelectedIndexChanged);
			// 
			// elegirColorBtn
			// 
			this.elegirColorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
			this.elegirColorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
			this.elegirColorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
			this.elegirColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.elegirColorBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elegirColorBtn.Location = new System.Drawing.Point(219, 399);
			this.elegirColorBtn.Name = "elegirColorBtn";
			this.elegirColorBtn.Size = new System.Drawing.Size(119, 47);
			this.elegirColorBtn.TabIndex = 35;
			this.elegirColorBtn.Text = "Color";
			this.elegirColorBtn.UseVisualStyleBackColor = false;
			this.elegirColorBtn.Click += new System.EventHandler(this.elegirColorBtn_Click);
			// 
			// colorInput
			// 
			this.colorInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.colorInput.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colorInput.ForeColor = System.Drawing.Color.White;
			this.colorInput.Location = new System.Drawing.Point(26, 422);
			this.colorInput.Multiline = true;
			this.colorInput.Name = "colorInput";
			this.colorInput.Size = new System.Drawing.Size(175, 28);
			this.colorInput.TabIndex = 5;
			this.colorInput.TextChanged += new System.EventHandler(this.colorInput_TextChanged);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// backBtn
			// 
			this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
			this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
			this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
			this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backBtn.Location = new System.Drawing.Point(827, 30);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(128, 36);
			this.backBtn.TabIndex = 37;
			this.backBtn.Text = "Volver";
			this.backBtn.UseVisualStyleBackColor = false;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// lblErrorMatricula
			// 
			this.lblErrorMatricula.AutoSize = true;
			this.lblErrorMatricula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErrorMatricula.Location = new System.Drawing.Point(27, 150);
			this.lblErrorMatricula.Name = "lblErrorMatricula";
			this.lblErrorMatricula.Size = new System.Drawing.Size(53, 20);
			this.lblErrorMatricula.TabIndex = 38;
			this.lblErrorMatricula.Text = "label8";
			// 
			// lblErrorMarca
			// 
			this.lblErrorMarca.AutoSize = true;
			this.lblErrorMarca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErrorMarca.Location = new System.Drawing.Point(29, 226);
			this.lblErrorMarca.Name = "lblErrorMarca";
			this.lblErrorMarca.Size = new System.Drawing.Size(61, 20);
			this.lblErrorMarca.TabIndex = 40;
			this.lblErrorMarca.Text = "label10";
			// 
			// lblErrorModelo
			// 
			this.lblErrorModelo.AutoSize = true;
			this.lblErrorModelo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErrorModelo.Location = new System.Drawing.Point(27, 302);
			this.lblErrorModelo.Name = "lblErrorModelo";
			this.lblErrorModelo.Size = new System.Drawing.Size(61, 20);
			this.lblErrorModelo.TabIndex = 41;
			this.lblErrorModelo.Text = "label15";
			// 
			// lblErrorPrecioCompra
			// 
			this.lblErrorPrecioCompra.AutoSize = true;
			this.lblErrorPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErrorPrecioCompra.Location = new System.Drawing.Point(357, 209);
			this.lblErrorPrecioCompra.Name = "lblErrorPrecioCompra";
			this.lblErrorPrecioCompra.Size = new System.Drawing.Size(61, 20);
			this.lblErrorPrecioCompra.TabIndex = 43;
			this.lblErrorPrecioCompra.Text = "label17";
			// 
			// lblErrorPrecioAlquiler
			// 
			this.lblErrorPrecioAlquiler.AutoSize = true;
			this.lblErrorPrecioAlquiler.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErrorPrecioAlquiler.Location = new System.Drawing.Point(565, 209);
			this.lblErrorPrecioAlquiler.Name = "lblErrorPrecioAlquiler";
			this.lblErrorPrecioAlquiler.Size = new System.Drawing.Size(61, 20);
			this.lblErrorPrecioAlquiler.TabIndex = 44;
			this.lblErrorPrecioAlquiler.Text = "label18";
			// 
			// lblErrorEstado
			// 
			this.lblErrorEstado.AutoSize = true;
			this.lblErrorEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErrorEstado.Location = new System.Drawing.Point(29, 378);
			this.lblErrorEstado.Name = "lblErrorEstado";
			this.lblErrorEstado.Size = new System.Drawing.Size(61, 20);
			this.lblErrorEstado.TabIndex = 45;
			this.lblErrorEstado.Text = "label19";
			// 
			// lblErrorColor
			// 
			this.lblErrorColor.AutoSize = true;
			this.lblErrorColor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErrorColor.Location = new System.Drawing.Point(29, 453);
			this.lblErrorColor.Name = "lblErrorColor";
			this.lblErrorColor.Size = new System.Drawing.Size(61, 20);
			this.lblErrorColor.TabIndex = 47;
			this.lblErrorColor.Text = "label20";
			// 
			// lblErrorDescripcion
			// 
			this.lblErrorDescripcion.AutoSize = true;
			this.lblErrorDescripcion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErrorDescripcion.Location = new System.Drawing.Point(357, 290);
			this.lblErrorDescripcion.Name = "lblErrorDescripcion";
			this.lblErrorDescripcion.Size = new System.Drawing.Size(61, 20);
			this.lblErrorDescripcion.TabIndex = 48;
			this.lblErrorDescripcion.Text = "label21";
			// 
			// lblErrorImagenes
			// 
			this.lblErrorImagenes.AutoSize = true;
			this.lblErrorImagenes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErrorImagenes.Location = new System.Drawing.Point(365, 457);
			this.lblErrorImagenes.Name = "lblErrorImagenes";
			this.lblErrorImagenes.Size = new System.Drawing.Size(61, 20);
			this.lblErrorImagenes.TabIndex = 49;
			this.lblErrorImagenes.Text = "label22";
			// 
			// imgButton
			// 
			this.imgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
			this.imgButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
			this.imgButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
			this.imgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.imgButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imgButton.Location = new System.Drawing.Point(766, 406);
			this.imgButton.Name = "imgButton";
			this.imgButton.Size = new System.Drawing.Size(190, 44);
			this.imgButton.TabIndex = 16;
			this.imgButton.Text = "Agregar Imagen";
			this.imgButton.UseVisualStyleBackColor = false;
			this.imgButton.Click += new System.EventHandler(this.imgButton_Click);
			// 
			// imgList
			// 
			this.imgList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.imgList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imgList.ForeColor = System.Drawing.Color.White;
			this.imgList.FormattingEnabled = true;
			this.imgList.ItemHeight = 21;
			this.imgList.Location = new System.Drawing.Point(361, 501);
			this.imgList.Name = "imgList";
			this.imgList.Size = new System.Drawing.Size(383, 109);
			this.imgList.TabIndex = 90;
			this.imgList.SelectedIndexChanged += new System.EventHandler(this.imgList_SelectedIndexChanged);
			// 
			// dataTallerList
			// 
			this.dataTallerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.dataTallerList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataTallerList.ForeColor = System.Drawing.Color.White;
			this.dataTallerList.FormattingEnabled = true;
			this.dataTallerList.ItemHeight = 21;
			this.dataTallerList.Location = new System.Drawing.Point(219, 498);
			this.dataTallerList.Name = "dataTallerList";
			this.dataTallerList.Size = new System.Drawing.Size(119, 109);
			this.dataTallerList.TabIndex = 93;
			this.dataTallerList.SelectedIndexChanged += new System.EventHandler(this.dataTallerList_SelectedIndexChanged);
			// 
			// dataTallerbtn
			// 
			this.dataTallerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
			this.dataTallerbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
			this.dataTallerbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
			this.dataTallerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dataTallerbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataTallerbtn.Location = new System.Drawing.Point(219, 453);
			this.dataTallerbtn.Name = "dataTallerbtn";
			this.dataTallerbtn.Size = new System.Drawing.Size(119, 38);
			this.dataTallerbtn.TabIndex = 92;
			this.dataTallerbtn.Text = "dataTallerbtn";
			this.dataTallerbtn.UseVisualStyleBackColor = false;
			this.dataTallerbtn.Click += new System.EventHandler(this.dataTallerbtn_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.backBtn);
			this.panel1.Location = new System.Drawing.Point(1, -1);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(975, 90);
			this.panel1.TabIndex = 94;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = global::concesionarioApp.Resource1.Logocar;
			this.pictureBox1.Location = new System.Drawing.Point(0, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(103, 85);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 94;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// NuevosCoches
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
			this.ClientSize = new System.Drawing.Size(977, 640);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataTallerList);
			this.Controls.Add(this.dataTallerbtn);
			this.Controls.Add(this.precioCompraInput);
			this.Controls.Add(this.imgButton);
			this.Controls.Add(this.propietarioInput);
			this.Controls.Add(this.imgList);
			this.Controls.Add(this.lblErrorImagenes);
			this.Controls.Add(this.lblErrorDescripcion);
			this.Controls.Add(this.lblErrorColor);
			this.Controls.Add(this.lblErrorEstado);
			this.Controls.Add(this.lblErrorPrecioAlquiler);
			this.Controls.Add(this.lblErrorPrecioCompra);
			this.Controls.Add(this.lblErrorModelo);
			this.Controls.Add(this.lblErrorMarca);
			this.Controls.Add(this.lblErrorMatricula);
			this.Controls.Add(this.colorInput);
			this.Controls.Add(this.elegirColorBtn);
			this.Controls.Add(this.modelosInput);
			this.Controls.Add(this.marcaInput);
			this.Controls.Add(this.propietarioBox);
			this.Controls.Add(this.estadoInput);
			this.Controls.Add(this.groupCoche);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.agregarConfirmBtn);
			this.Controls.Add(this.fechaCocheInput);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.precioAlquilerInput);
			this.Controls.Add(this.descripcionInput);
			this.Controls.Add(this.imagenesInput);
			this.Controls.Add(this.matriculaInput);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NuevosCoches";
			this.Opacity = 0.96D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Agregar coches";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevosCoches_FormClosing);
			this.Load += new System.EventHandler(this.NuevosCoches_Load);
			this.groupCoche.ResumeLayout(false);
			this.groupCoche.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matriculaInput;
        private System.Windows.Forms.TextBox imagenesInput;
        private System.Windows.Forms.TextBox descripcionInput;
        private System.Windows.Forms.TextBox precioCompraInput;
        private System.Windows.Forms.TextBox precioAlquilerInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker fechaCocheInput;
        private System.Windows.Forms.Button agregarConfirmBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupCoche;
        private System.Windows.Forms.ComboBox estadoInput;
        private System.Windows.Forms.ComboBox propietarioBox;
        private System.Windows.Forms.ComboBox marcaInput;
        private System.Windows.Forms.ComboBox propietarioInput;
        private System.Windows.Forms.RadioButton enVentaInput;
        private System.Windows.Forms.RadioButton enAlquilerInput;
        private System.Windows.Forms.RadioButton enTallerInput;
        private System.Windows.Forms.ComboBox modelosInput;
        private System.Windows.Forms.Button elegirColorBtn;
        private System.Windows.Forms.TextBox colorInput;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label lblErrorImagenes;
        private System.Windows.Forms.Label lblErrorDescripcion;
        private System.Windows.Forms.Label lblErrorColor;
        private System.Windows.Forms.Label lblErrorEstado;
        private System.Windows.Forms.Label lblErrorPrecioAlquiler;
        private System.Windows.Forms.Label lblErrorPrecioCompra;
        private System.Windows.Forms.Label lblErrorModelo;
        private System.Windows.Forms.Label lblErrorMarca;
        private System.Windows.Forms.Label lblErrorMatricula;
        private System.Windows.Forms.Button imgButton;
        private System.Windows.Forms.ListBox imgList;
        private System.Windows.Forms.ListBox dataTallerList;
        private System.Windows.Forms.Button dataTallerbtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}