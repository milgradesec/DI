using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Caribe
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public ArrayList Reservas = new();

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaNuevaReserva nuevaReserva = new();
            nuevaReserva.ShowDialog(this);
            nuevaReserva.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (Reserva reserva in Reservas)
            {
                string[] subItems = { reserva.Nombre, reserva.Telefono, reserva.Fecha, reserva.Tipo, reserva.Asistentes.ToString(), reserva.TipoCocina, reserva.Dias.ToString(), reserva.ReservarHabitaciones };
                ListViewItem item = new ListViewItem(subItems);
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void toolStripMenuNuevaReserva_Click(object sender, EventArgs e)
        {
            VentanaNuevaReserva nuevaReserva = new();
            nuevaReserva.ShowDialog(this);
            nuevaReserva.Dispose();
        }
    }
}
