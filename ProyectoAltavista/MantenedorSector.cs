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
    public partial class MantenedorSector : Form
    {
        public MantenedorSector()
        {
            InitializeComponent();
        }

        private void lbRegistrar_Click(object sender, EventArgs e)
        {
            MNuevoSector registroSector = new MNuevoSector();
            registroSector.Show();
            this.Close();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            MModificarSector modificaSector = new MModificarSector();
            modificaSector.Show();
            this.Close();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menPrincipal = new MenuPrincipal();
            menPrincipal.Show();
            this.Close();
        }
    }
}
