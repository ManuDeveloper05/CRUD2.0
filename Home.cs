using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD2._0
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SuplidoresForm suplidoresForm = new SuplidoresForm();
            suplidoresForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriasForm categoriasForm = new CategoriasForm();
            categoriasForm.ShowDialog();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuplidoresForm suplidoresForm = new SuplidoresForm();
            suplidoresForm.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriasForm categoriasForm = new CategoriasForm();
            categoriasForm.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa esta creado para facilitar la gestion de los suplidores, categorias y productos almacenados en la base de datos Northwind. " +
                " En la ventana principal se encuentra las opciones 'Suplidores', 'Categorias', 'Productos' cuyas opciones los llevara a realizar la gestion de cada apartado. " +
                "Luego de entrar a algunos de los apartados, vera los botones 'Crear = almacenara los datos ingresados correctamente' 'Actualizar= actualizara los datos existente " +
                "correctamente ingresados' 'Eliminar = eliminara los datos previamente ingresados, tomando como referencia el ID de dichos datos' y 'Leer' 'Leer= cargara los datos ya almacenados' ");
        }
    }
}
