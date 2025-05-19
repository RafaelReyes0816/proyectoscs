using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppPila.Clases;

namespace AppPila
{
    public partial class frmPruebaPila : Form
    {
        private Pila<string> pilaString;
        public frmPruebaPila()
        {
            InitializeComponent();
            this.pilaString = new Pila<string>(5);
            pbarEstado.Style = ProgressBarStyle.Continuous;
        }

        private void frmPruebaPila_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarPB()
        {
            pbarEstado.Value = this.pilaString.Size() * 20;
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if(pilaString.IsFull())
            {
                MessageBox.Show("La pila esta llena, no se puede agregar nada");
            } else
            {
                this.pilaString.Push(txtElemento.Text);
                ActualizarPB();
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if(this.pilaString.IsEmpty())
            {
                MessageBox.Show("La pila esta vacia, no se puede quitar nada");
            } else
            {
                MessageBox.Show("Elemento eliminado: " + this.pilaString.Pop());
                ActualizarPB();
            }
        }
    }
}
