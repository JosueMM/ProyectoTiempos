﻿using ProyectoTiempos.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTiempos.Vistas
{
    public partial class FrmConfigCasa : Form
    {
        private Casa casa;
        public FrmConfigCasa()
        {
            InitializeComponent();
            casa = new Casa();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;

            if (validacionDinero())
            {
                double dinero = Convert.ToDouble(txtDinero.Text);
                casa.Insert(nombre, dinero);
                MessageBox.Show("Configuracion establecida");


            }

        }

        private Boolean validacionDinero()
        {
            Boolean a = false;

            try
            {
                Convert.ToDouble(txtDinero.Text);
                a = true;
            }
            catch (Exception e)
            {
                a = false;
                MessageBox.Show("Digite una cantidad de dinero valida, sin caracteres especiales");

            }
            if (a)
            {
                return true;
            }
            return false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

