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
    public partial class MantenedorDeInmueble : Form
    {
        public MantenedorDeInmueble()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btRegresarInmueble_Click(object sender, EventArgs e)
        {
            MenuPrincipal menPrincipal = new MenuPrincipal();
            menPrincipal.Show();
            this.Close();
        }

    }
}
