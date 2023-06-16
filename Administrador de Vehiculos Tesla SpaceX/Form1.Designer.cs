namespace Proyecto_2_Tema_1
{
    partial class Form1
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
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.gbModelo = new System.Windows.Forms.GroupBox();
            this.lblAlta = new System.Windows.Forms.Label();
            this.lblDuenio = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblKms = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.lblAutonomia = new System.Windows.Forms.Label();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtDuenio = new System.Windows.Forms.TextBox();
            this.lblServiceTXT = new System.Windows.Forms.Label();
            this.lblAsientosTXT = new System.Windows.Forms.Label();
            this.lblAutonomiaTXT = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDuenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAutonomia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAsientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMasViejo = new System.Windows.Forms.Button();
            this.lblTesla = new System.Windows.Forms.Label();
            this.lblSpaceX = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(55, 139);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(210, 24);
            this.comboMarca.TabIndex = 1;
            this.comboMarca.Text = "Seleccione Marca";
            this.comboMarca.SelectedIndexChanged += new System.EventHandler(this.comboMarca_SelectedIndexChanged);
            // 
            // gbModelo
            // 
            this.gbModelo.Controls.Add(this.lblServiceTXT);
            this.gbModelo.Controls.Add(this.lblAutonomia);
            this.gbModelo.Controls.Add(this.lblAsientosTXT);
            this.gbModelo.Controls.Add(this.lblAsientos);
            this.gbModelo.Controls.Add(this.lblAutonomiaTXT);
            this.gbModelo.Controls.Add(this.lblService);
            this.gbModelo.Location = new System.Drawing.Point(63, 216);
            this.gbModelo.Name = "gbModelo";
            this.gbModelo.Size = new System.Drawing.Size(193, 148);
            this.gbModelo.TabIndex = 2;
            this.gbModelo.TabStop = false;
            // 
            // lblAlta
            // 
            this.lblAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAlta.Location = new System.Drawing.Point(496, 28);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(490, 43);
            this.lblAlta.TabIndex = 3;
            this.lblAlta.Text = "Sistema de Gestion Tesla-SpaceX";
            this.lblAlta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDuenio
            // 
            this.lblDuenio.Location = new System.Drawing.Point(52, 481);
            this.lblDuenio.Name = "lblDuenio";
            this.lblDuenio.Size = new System.Drawing.Size(90, 20);
            this.lblDuenio.TabIndex = 7;
            this.lblDuenio.Text = "Duenio";
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(52, 452);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(90, 20);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color";
            // 
            // lblKms
            // 
            this.lblKms.Location = new System.Drawing.Point(52, 418);
            this.lblKms.Name = "lblKms";
            this.lblKms.Size = new System.Drawing.Size(90, 20);
            this.lblKms.TabIndex = 9;
            this.lblKms.Text = "Kms Actuales";
            // 
            // lblAnio
            // 
            this.lblAnio.Location = new System.Drawing.Point(52, 389);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(90, 20);
            this.lblAnio.TabIndex = 10;
            this.lblAnio.Text = "Anio";
            // 
            // comboModelo
            // 
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(55, 175);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(210, 24);
            this.comboModelo.TabIndex = 11;
            this.comboModelo.Text = "Seleccione Modelo";
            this.comboModelo.SelectedIndexChanged += new System.EventHandler(this.comboModelo_SelectedIndexChanged);
            // 
            // lblAutonomia
            // 
            this.lblAutonomia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAutonomia.Location = new System.Drawing.Point(11, 43);
            this.lblAutonomia.Name = "lblAutonomia";
            this.lblAutonomia.Size = new System.Drawing.Size(90, 20);
            this.lblAutonomia.TabIndex = 14;
            this.lblAutonomia.Text = "Autonomia:";
            // 
            // lblAsientos
            // 
            this.lblAsientos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAsientos.Location = new System.Drawing.Point(11, 72);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(90, 20);
            this.lblAsientos.TabIndex = 13;
            this.lblAsientos.Text = "Asientos:";
            // 
            // lblService
            // 
            this.lblService.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblService.Location = new System.Drawing.Point(11, 101);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(90, 20);
            this.lblService.TabIndex = 12;
            this.lblService.Text = "Service:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(105, 386);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(160, 22);
            this.txtAnio.TabIndex = 15;
            // 
            // txtKms
            // 
            this.txtKms.Location = new System.Drawing.Point(148, 415);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(117, 22);
            this.txtKms.TabIndex = 16;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(105, 450);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(160, 22);
            this.txtColor.TabIndex = 17;
            // 
            // txtDuenio
            // 
            this.txtDuenio.Location = new System.Drawing.Point(105, 478);
            this.txtDuenio.Name = "txtDuenio";
            this.txtDuenio.Size = new System.Drawing.Size(160, 22);
            this.txtDuenio.TabIndex = 18;
            // 
            // lblServiceTXT
            // 
            this.lblServiceTXT.Location = new System.Drawing.Point(103, 101);
            this.lblServiceTXT.Name = "lblServiceTXT";
            this.lblServiceTXT.Size = new System.Drawing.Size(79, 20);
            this.lblServiceTXT.TabIndex = 19;
            // 
            // lblAsientosTXT
            // 
            this.lblAsientosTXT.Location = new System.Drawing.Point(103, 72);
            this.lblAsientosTXT.Name = "lblAsientosTXT";
            this.lblAsientosTXT.Size = new System.Drawing.Size(79, 20);
            this.lblAsientosTXT.TabIndex = 20;
            // 
            // lblAutonomiaTXT
            // 
            this.lblAutonomiaTXT.Location = new System.Drawing.Point(103, 43);
            this.lblAutonomiaTXT.Name = "lblAutonomiaTXT";
            this.lblAutonomiaTXT.Size = new System.Drawing.Size(79, 20);
            this.lblAutonomiaTXT.TabIndex = 21;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(167, 516);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(98, 23);
            this.btnCrear.TabIndex = 19;
            this.btnCrear.Text = "Dar de Alta";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cModelo,
            this.cAnio,
            this.cKms,
            this.cColor,
            this.cDuenio,
            this.cAutonomia,
            this.cAsientos,
            this.cService});
            this.dgvVehiculos.Location = new System.Drawing.Point(296, 139);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 24;
            this.dgvVehiculos.Size = new System.Drawing.Size(738, 159);
            this.dgvVehiculos.TabIndex = 20;
            this.dgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(934, 309);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cModelo
            // 
            this.cModelo.HeaderText = "Modelo";
            this.cModelo.MinimumWidth = 6;
            this.cModelo.Name = "cModelo";
            // 
            // cAnio
            // 
            this.cAnio.HeaderText = "Anio";
            this.cAnio.MinimumWidth = 6;
            this.cAnio.Name = "cAnio";
            // 
            // cKms
            // 
            this.cKms.HeaderText = "Kms";
            this.cKms.MinimumWidth = 6;
            this.cKms.Name = "cKms";
            // 
            // cColor
            // 
            this.cColor.HeaderText = "Color";
            this.cColor.MinimumWidth = 6;
            this.cColor.Name = "cColor";
            // 
            // cDuenio
            // 
            this.cDuenio.HeaderText = "Duenio";
            this.cDuenio.MinimumWidth = 6;
            this.cDuenio.Name = "cDuenio";
            // 
            // cAutonomia
            // 
            this.cAutonomia.HeaderText = "Autonomia";
            this.cAutonomia.MinimumWidth = 6;
            this.cAutonomia.Name = "cAutonomia";
            // 
            // cAsientos
            // 
            this.cAsientos.HeaderText = "Asientos";
            this.cAsientos.MinimumWidth = 6;
            this.cAsientos.Name = "cAsientos";
            // 
            // cService
            // 
            this.cService.HeaderText = "Service";
            this.cService.MinimumWidth = 6;
            this.cService.Name = "cService";
            // 
            // btnMasViejo
            // 
            this.btnMasViejo.Location = new System.Drawing.Point(763, 309);
            this.btnMasViejo.Name = "btnMasViejo";
            this.btnMasViejo.Size = new System.Drawing.Size(165, 28);
            this.btnMasViejo.TabIndex = 22;
            this.btnMasViejo.Text = "Ver Mas Antiguo";
            this.btnMasViejo.UseVisualStyleBackColor = true;
            this.btnMasViejo.Click += new System.EventHandler(this.btnMasViejo_Click);
            // 
            // lblTesla
            // 
            this.lblTesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesla.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTesla.Location = new System.Drawing.Point(290, 93);
            this.lblTesla.Name = "lblTesla";
            this.lblTesla.Size = new System.Drawing.Size(490, 43);
            this.lblTesla.TabIndex = 23;
            this.lblTesla.Text = "Tesla";
            // 
            // lblSpaceX
            // 
            this.lblSpaceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceX.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSpaceX.Location = new System.Drawing.Point(290, 352);
            this.lblSpaceX.Name = "lblSpaceX";
            this.lblSpaceX.Size = new System.Drawing.Size(490, 43);
            this.lblSpaceX.TabIndex = 24;
            this.lblSpaceX.Text = "SpaceX";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.Location = new System.Drawing.Point(296, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 159);
            this.dataGridView1.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Anio";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Kms";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Color";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Duenio";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Autonomia";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Asientos";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Service";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ver Mas Antiguo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(934, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSpaceX);
            this.Controls.Add(this.lblTesla);
            this.Controls.Add(this.btnMasViejo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDuenio);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtKms);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.gbModelo);
            this.Controls.Add(this.lblKms);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblAlta);
            this.Controls.Add(this.lblDuenio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbModelo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.GroupBox gbModelo;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.Label lblDuenio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblKms;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.Label lblAutonomia;
        private System.Windows.Forms.Label lblAsientos;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtDuenio;
        private System.Windows.Forms.Label lblServiceTXT;
        private System.Windows.Forms.Label lblAsientosTXT;
        private System.Windows.Forms.Label lblAutonomiaTXT;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKms;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDuenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAutonomia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAsientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cService;
        private System.Windows.Forms.Button btnMasViejo;
        private System.Windows.Forms.Label lblTesla;
        private System.Windows.Forms.Label lblSpaceX;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

