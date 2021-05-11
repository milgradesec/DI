using System;
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
    public partial class VentanaResultado : Form
    {
        public int nAciertos;
        public string ganadora;
        public string usuario;

        public VentanaResultado()
        {
            InitializeComponent();
        }

        public VentanaResultado(int nAciertos, string ganadora, string usuario)
        {
            InitializeComponent();

            this.nAciertos = nAciertos;
            this.ganadora = ganadora ?? throw new ArgumentNullException(nameof(ganadora));
            this.usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));

            textBox1.Text = usuario;
            textBox2.Text = ganadora;
            textBox3.Text = nAciertos.ToString();
        }
    }
}
