using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caribe
{
    public partial class VentanaNuevaReserva : Form
    {
        public VentanaNuevaReserva()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedIndex == 2)
            {
                numericUpDownNDias.Enabled = true;
                checkBoxHabitaciones.Enabled = true;
            }
            else
            {
                numericUpDownNDias.Enabled = false;
                checkBoxHabitaciones.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reserva reserva = new();
            reserva.Nombre = textBoxNombre.Text;
            reserva.Telefono = textBoxTelefono.Text;
            reserva.Fecha = dateTimePickerFecha.Value.ToLongDateString();
            reserva.Tipo = comboBoxTipo.SelectedItem.ToString();
            reserva.Asistentes = (int)numericUpDownNAsistentes.Value;
            reserva.TipoCocina = comboBoxCocina.SelectedItem.ToString();
            reserva.Dias = (int)numericUpDownNDias.Value;
            if (checkBoxHabitaciones.Enabled && checkBoxHabitaciones.Checked)
            {
                reserva.ReservarHabitaciones = "Si";
            }
            else
            {
                reserva.ReservarHabitaciones = "No";
            }


            var principal = (VentanaPrincipal)this.Owner;
            principal.Reservas.Add(reserva);

            this.Close();
        }
    }
}
