using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primitiva
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public ArrayList combinacionGanadora = new();
        public ArrayList combinacionUsuario = new();
        public int reintegroGanador;
        public int reintegroUsuario;

        public void generarCombinacionGanadora()
        {
            Random rnd = new Random();
            reintegroGanador = rnd.Next(1, 37);

            for (int i = 0; i < 6; i++)
            {
                int n = rnd.Next(1, 14);
                while (combinacionGanadora.Contains(n))
                {
                    n = rnd.Next(1, 14);
                }
                combinacionGanadora.Add(n);
            }
            combinacionGanadora.Sort();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            checkBox32.Checked = false;
            checkBox33.Checked = false;
            checkBox34.Checked = false;
            checkBox35.Checked = false;
            checkBox36.Checked = false;
            numericUpDown1.Value = 1;
            combinacionUsuario.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && combinacionUsuario.Count == 6)
            {
                checkBox1.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox1.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(1);
            }

            if (!checkBox1.Checked)
            {
                combinacionUsuario.Remove(1);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && combinacionUsuario.Count == 6)
            {
                checkBox2.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox2.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(2);
            }

            if (!checkBox2.Checked)
            {
                combinacionUsuario.Remove(2);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && combinacionUsuario.Count == 6)
            {
                checkBox3.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox3.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(3);
            }

            if (!checkBox3.Checked)
            {
                combinacionUsuario.Remove(3);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked && combinacionUsuario.Count == 6)
            {
                checkBox4.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox4.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(4);
            }

            if (!checkBox4.Checked)
            {
                combinacionUsuario.Remove(4);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked && combinacionUsuario.Count == 6)
            {
                checkBox5.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox5.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(5);
            }

            if (!checkBox5.Checked)
            {
                combinacionUsuario.Remove(5);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked && combinacionUsuario.Count == 6)
            {
                checkBox6.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox6.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(6);
            }

            if (!checkBox6.Checked)
            {
                combinacionUsuario.Remove(6);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked && combinacionUsuario.Count == 6)
            {
                checkBox7.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox7.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(7);
            }

            if (!checkBox7.Checked)
            {
                combinacionUsuario.Remove(7);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked && combinacionUsuario.Count == 6)
            {
                checkBox8.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox8.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(8);
            }

            if (!checkBox8.Checked)
            {
                combinacionUsuario.Remove(8);
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked && combinacionUsuario.Count == 6)
            {
                checkBox9.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox9.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(9);
            }

            if (!checkBox9.Checked)
            {
                combinacionUsuario.Remove(9);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked && combinacionUsuario.Count == 6)
            {
                checkBox10.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox10.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(10);
            }

            if (!checkBox10.Checked)
            {
                combinacionUsuario.Remove(10);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked && combinacionUsuario.Count == 6)
            {
                checkBox11.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox11.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(11);
            }

            if (!checkBox11.Checked)
            {
                combinacionUsuario.Remove(11);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked && combinacionUsuario.Count == 6)
            {
                checkBox12.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox12.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(12);
            }

            if (!checkBox12.Checked)
            {
                combinacionUsuario.Remove(12);
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked && combinacionUsuario.Count == 6)
            {
                checkBox13.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox13.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(13);
            }

            if (!checkBox13.Checked)
            {
                combinacionUsuario.Remove(13);
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked && combinacionUsuario.Count == 6)
            {
                checkBox14.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox14.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(14);
            }

            if (!checkBox14.Checked)
            {
                combinacionUsuario.Remove(14);
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked && combinacionUsuario.Count == 6)
            {
                checkBox15.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox15.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(15);
            }

            if (!checkBox15.Checked)
            {
                combinacionUsuario.Remove(15);
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked && combinacionUsuario.Count == 6)
            {
                checkBox16.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox16.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(16);
            }

            if (!checkBox16.Checked)
            {
                combinacionUsuario.Remove(16);
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked && combinacionUsuario.Count == 6)
            {
                checkBox17.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox17.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(17);
            }

            if (!checkBox17.Checked)
            {
                combinacionUsuario.Remove(17);
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked && combinacionUsuario.Count == 6)
            {
                checkBox18.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox18.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(18);
            }

            if (!checkBox18.Checked)
            {
                combinacionUsuario.Remove(18);
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked && combinacionUsuario.Count == 6)
            {
                checkBox19.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox19.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(19);
            }

            if (!checkBox19.Checked)
            {
                combinacionUsuario.Remove(19);
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked && combinacionUsuario.Count == 6)
            {
                checkBox20.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox20.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(20);
            }

            if (!checkBox20.Checked)
            {
                combinacionUsuario.Remove(20);
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked && combinacionUsuario.Count == 6)
            {
                checkBox21.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox21.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(21);
            }

            if (!checkBox21.Checked)
            {
                combinacionUsuario.Remove(21);
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked && combinacionUsuario.Count == 6)
            {
                checkBox22.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox22.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(22);
            }

            if (!checkBox22.Checked)
            {
                combinacionUsuario.Remove(22);
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked && combinacionUsuario.Count == 6)
            {
                checkBox23.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox23.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(23);
            }

            if (!checkBox23.Checked)
            {
                combinacionUsuario.Remove(23);
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked && combinacionUsuario.Count == 6)
            {
                checkBox24.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox24.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(24);
            }

            if (!checkBox24.Checked)
            {
                combinacionUsuario.Remove(24);
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked && combinacionUsuario.Count == 6)
            {
                checkBox25.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox25.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(25);
            }

            if (!checkBox25.Checked)
            {
                combinacionUsuario.Remove(25);
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked && combinacionUsuario.Count == 6)
            {
                checkBox26.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox26.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(26);
            }

            if (!checkBox26.Checked)
            {
                combinacionUsuario.Remove(26);
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked && combinacionUsuario.Count == 6)
            {
                checkBox27.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox27.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(27);
            }

            if (!checkBox27.Checked)
            {
                combinacionUsuario.Remove(27);
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked && combinacionUsuario.Count == 6)
            {
                checkBox28.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox28.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(28);
            }

            if (!checkBox28.Checked)
            {
                combinacionUsuario.Remove(28);
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked && combinacionUsuario.Count == 6)
            {
                checkBox29.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox29.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(29);
            }

            if (!checkBox29.Checked)
            {
                combinacionUsuario.Remove(29);
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked && combinacionUsuario.Count == 6)
            {
                checkBox30.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox30.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(30);
            }

            if (!checkBox30.Checked)
            {
                combinacionUsuario.Remove(30);
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked && combinacionUsuario.Count == 6)
            {
                checkBox31.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox31.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(31);
            }

            if (!checkBox31.Checked)
            {
                combinacionUsuario.Remove(31);
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked && combinacionUsuario.Count == 6)
            {
                checkBox32.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox32.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(32);
            }

            if (!checkBox32.Checked)
            {
                combinacionUsuario.Remove(32);
            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked && combinacionUsuario.Count == 6)
            {
                checkBox33.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox33.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(33);
            }

            if (!checkBox33.Checked)
            {
                combinacionUsuario.Remove(33);
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked && combinacionUsuario.Count == 6)
            {
                checkBox34.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox34.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(34);
            }

            if (!checkBox34.Checked)
            {
                combinacionUsuario.Remove(34);
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked && combinacionUsuario.Count == 6)
            {
                checkBox35.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox35.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(35);
            }

            if (!checkBox35.Checked)
            {
                combinacionUsuario.Remove(35);
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked && combinacionUsuario.Count == 6)
            {
                checkBox36.Checked = false;
                MessageBox.Show("No puedes seleccionar más números.", "Error");
                return;
            }

            if (checkBox36.Checked && combinacionUsuario.Count < 6)
            {
                combinacionUsuario.Add(36);
            }

            if (!checkBox36.Checked)
            {
                combinacionUsuario.Remove(36);
            }
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            if (combinacionUsuario.Count != 6)
            {
                MessageBox.Show("Tienes que seleccionar 6 números.", "Error");
                return;
            }
            combinacionUsuario.Sort();
            reintegroUsuario = (int)numericUpDown1.Value;

            generarCombinacionGanadora();

            int nAciertos = 0;
            foreach (var n in combinacionUsuario)
            {
                if (combinacionGanadora.Contains(n))
                {
                    nAciertos += 1;
                }
            }

            String ganadora = "";
            foreach (var n in combinacionGanadora)
            {
                ganadora = String.Concat(ganadora, n.ToString(), " ");
            }
            ganadora = String.Concat(ganadora, "  R: ", reintegroGanador.ToString());

            String usuario = "";
            foreach (var n in combinacionUsuario)
            {
                usuario = String.Concat(usuario, n.ToString(), " ");
            }
            usuario = String.Concat(usuario, "  R: ", reintegroUsuario.ToString());

            VentanaResultado resultado = new VentanaResultado(nAciertos, ganadora, usuario);
            resultado.ShowDialog(this);
            resultado.Dispose();
        }
    }
}
