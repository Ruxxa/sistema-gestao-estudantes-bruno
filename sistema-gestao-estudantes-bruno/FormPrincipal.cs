﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestao_estudantes_bruno
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inserirEstudadanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudante inserirEstudante = new FormInserirEstudante();
            inserirEstudante.Show(this);
        }

        private void listarEstudantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaDeEstudantes listaDeEstudantes = new FormListaDeEstudantes();
            listaDeEstudantes.Show(this);
        }
    }
}
