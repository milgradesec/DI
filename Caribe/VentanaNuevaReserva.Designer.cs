
namespace Caribe
{
    partial class VentanaNuevaReserva
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonDescartar = new System.Windows.Forms.Button();
            this.numericUpDownNAsistentes = new System.Windows.Forms.NumericUpDown();
            this.labelNAsistentes = new System.Windows.Forms.Label();
            this.labelCocina = new System.Windows.Forms.Label();
            this.comboBoxCocina = new System.Windows.Forms.ComboBox();
            this.checkBoxHabitaciones = new System.Windows.Forms.CheckBox();
            this.groupBoxCongreso = new System.Windows.Forms.GroupBox();
            this.labelNDias = new System.Windows.Forms.Label();
            this.numericUpDownNDias = new System.Windows.Forms.NumericUpDown();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNAsistentes)).BeginInit();
            this.groupBoxCongreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNDias)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(154, 42);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(231, 23);
            this.textBoxNombre.TabIndex = 0;
            this.toolTips.SetToolTip(this.textBoxNombre, "Nombre de la persona que hace la reserva\r\n");
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(154, 77);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(231, 23);
            this.textBoxTelefono.TabIndex = 1;
            this.toolTips.SetToolTip(this.textBoxTelefono, "Teléfono de contacto");
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(38, 42);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 15);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(38, 77);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(55, 15);
            this.labelTelefono.TabIndex = 3;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(154, 113);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(231, 23);
            this.dateTimePickerFecha.TabIndex = 4;
            this.toolTips.SetToolTip(this.dateTimePickerFecha, "Fecha del evento");
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(38, 113);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(41, 15);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Fecha:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Banquete",
            "Jornada",
            "Congreso"});
            this.comboBoxTipo.Location = new System.Drawing.Point(154, 147);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(120, 23);
            this.comboBoxTipo.TabIndex = 6;
            this.toolTips.SetToolTip(this.comboBoxTipo, "Tipo de evento");
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(38, 150);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(30, 15);
            this.labelTipo.TabIndex = 7;
            this.labelTipo.Text = "Tipo";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(60, 459);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(135, 44);
            this.buttonConfirmar.TabIndex = 8;
            this.buttonConfirmar.Text = "Confirmar";
            this.toolTips.SetToolTip(this.buttonConfirmar, "Confirmar la reseva");
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDescartar
            // 
            this.buttonDescartar.Location = new System.Drawing.Point(270, 459);
            this.buttonDescartar.Name = "buttonDescartar";
            this.buttonDescartar.Size = new System.Drawing.Size(135, 44);
            this.buttonDescartar.TabIndex = 9;
            this.buttonDescartar.Text = "Descartar";
            this.toolTips.SetToolTip(this.buttonDescartar, "Descartar la reserva");
            this.buttonDescartar.UseVisualStyleBackColor = true;
            this.buttonDescartar.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownNAsistentes
            // 
            this.numericUpDownNAsistentes.Location = new System.Drawing.Point(154, 185);
            this.numericUpDownNAsistentes.Name = "numericUpDownNAsistentes";
            this.numericUpDownNAsistentes.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownNAsistentes.TabIndex = 10;
            this.toolTips.SetToolTip(this.numericUpDownNAsistentes, "Número de asistentes que van al evento");
            // 
            // labelNAsistentes
            // 
            this.labelNAsistentes.AutoSize = true;
            this.labelNAsistentes.Location = new System.Drawing.Point(38, 192);
            this.labelNAsistentes.Name = "labelNAsistentes";
            this.labelNAsistentes.Size = new System.Drawing.Size(75, 15);
            this.labelNAsistentes.TabIndex = 11;
            this.labelNAsistentes.Text = "Nº asistentes";
            // 
            // labelCocina
            // 
            this.labelCocina.AutoSize = true;
            this.labelCocina.Location = new System.Drawing.Point(38, 228);
            this.labelCocina.Name = "labelCocina";
            this.labelCocina.Size = new System.Drawing.Size(86, 15);
            this.labelCocina.TabIndex = 13;
            this.labelCocina.Text = "Tipo de Cocina";
            // 
            // comboBoxCocina
            // 
            this.comboBoxCocina.FormattingEnabled = true;
            this.comboBoxCocina.Items.AddRange(new object[] {
            "Bufé",
            "Carta",
            "Pedir cita"});
            this.comboBoxCocina.Location = new System.Drawing.Point(154, 225);
            this.comboBoxCocina.Name = "comboBoxCocina";
            this.comboBoxCocina.Size = new System.Drawing.Size(120, 23);
            this.comboBoxCocina.TabIndex = 12;
            this.toolTips.SetToolTip(this.comboBoxCocina, "Tipo de cocina para el evento");
            // 
            // checkBoxHabitaciones
            // 
            this.checkBoxHabitaciones.AutoSize = true;
            this.checkBoxHabitaciones.Enabled = false;
            this.checkBoxHabitaciones.Location = new System.Drawing.Point(41, 73);
            this.checkBoxHabitaciones.Name = "checkBoxHabitaciones";
            this.checkBoxHabitaciones.Size = new System.Drawing.Size(142, 19);
            this.checkBoxHabitaciones.TabIndex = 14;
            this.checkBoxHabitaciones.Text = "Reservar Habitaciones";
            this.toolTips.SetToolTip(this.checkBoxHabitaciones, "Reservar habitaciones para los asistentes");
            this.checkBoxHabitaciones.UseVisualStyleBackColor = true;
            // 
            // groupBoxCongreso
            // 
            this.groupBoxCongreso.Controls.Add(this.labelNDias);
            this.groupBoxCongreso.Controls.Add(this.numericUpDownNDias);
            this.groupBoxCongreso.Controls.Add(this.checkBoxHabitaciones);
            this.groupBoxCongreso.Location = new System.Drawing.Point(38, 271);
            this.groupBoxCongreso.Name = "groupBoxCongreso";
            this.groupBoxCongreso.Size = new System.Drawing.Size(272, 108);
            this.groupBoxCongreso.TabIndex = 15;
            this.groupBoxCongreso.TabStop = false;
            this.groupBoxCongreso.Text = "Congreso";
            // 
            // labelNDias
            // 
            this.labelNDias.AutoSize = true;
            this.labelNDias.Location = new System.Drawing.Point(41, 36);
            this.labelNDias.Name = "labelNDias";
            this.labelNDias.Size = new System.Drawing.Size(45, 15);
            this.labelNDias.TabIndex = 16;
            this.labelNDias.Text = "Nº días";
            // 
            // numericUpDownNDias
            // 
            this.numericUpDownNDias.Enabled = false;
            this.numericUpDownNDias.Location = new System.Drawing.Point(116, 28);
            this.numericUpDownNDias.Name = "numericUpDownNDias";
            this.numericUpDownNDias.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownNDias.TabIndex = 15;
            this.toolTips.SetToolTip(this.numericUpDownNDias, "Número de dias que dura el congreso");
            // 
            // VentanaNuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 556);
            this.Controls.Add(this.groupBoxCongreso);
            this.Controls.Add(this.labelCocina);
            this.Controls.Add(this.comboBoxCocina);
            this.Controls.Add(this.labelNAsistentes);
            this.Controls.Add(this.numericUpDownNAsistentes);
            this.Controls.Add(this.buttonDescartar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "VentanaNuevaReserva";
            this.Text = "Nueva Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNAsistentes)).EndInit();
            this.groupBoxCongreso.ResumeLayout(false);
            this.groupBoxCongreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownNAsistentes;
        private System.Windows.Forms.Label labelNAsistentes;
        private System.Windows.Forms.Label labelCocina;
        private System.Windows.Forms.ComboBox comboBoxCocina;
        private System.Windows.Forms.CheckBox checkBoxHabitaciones;
        private System.Windows.Forms.GroupBox groupBoxCongreso;
        private System.Windows.Forms.Label labelNDias;
        private System.Windows.Forms.NumericUpDown numericUpDownNDias;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button buttonDescartar;
        private System.Windows.Forms.ToolTip toolTips;
    }
}