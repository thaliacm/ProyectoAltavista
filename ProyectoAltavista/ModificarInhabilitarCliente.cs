﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAltavista
{
    public partial class ModificarInhabilitarCliente : Form
    {
        public ModificarInhabilitarCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorCliente menuMantenedorCliente = new MantenedorCliente();
            menuMantenedorCliente.Show();
            this.Close();
        }
    }
}
