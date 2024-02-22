using CRUD2._0.Data.Clases;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUD2._0
{
    public partial class CategoriasForm : Form
    {
        private CategoriaValidator _validator;
        public CategoriasForm()
        {
            InitializeComponent();
            _validator = new CategoriaValidator();
        }

        private void Leer_Click(object sender, EventArgs e)
        {
            //Cargar las categorias
            var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            var manager = new CategoriaManager(connectionString);
            manager.CargarCategoria(CategoriasDataGrid);
        }

        private void crear_Click(object sender, EventArgs e)
        {
            var Categoria = new Categoria
            {
                CategoryID = CategoryID.Text,
                CategoryName = CategoryName.Text,
                Description = Description.Text,
            };

            var resultado = _validator.Validate(Categoria);

            if (resultado.IsValid)
            {
                MessageBox.Show("La categoría se ha creado correctamente");
                // Crear las categorías
                var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                var manager = new CategoriaManager(connectionString);

                // Convertir la imagen del PictureBox a un arreglo de bytes, si no es nula
                byte[] imagenBytes = null;
                if (Imagen.Image != null)
                {
                    imagenBytes = ImageToByteArray(Imagen.Image);
                }

                manager.CrearCategoria(CategoriasDataGrid, CategoryName.Text, Description.Text, imagenBytes);
            }
            else
            {
                // Mostrar los errores de validación
                foreach (var error in resultado.Errors)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
        }


        private void Subir_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Archivos De Imagen(*.png *.jpg *.JPEG)|*.png; *jpg; *.JPEG";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                Imagen.Image = Image.FromFile(archivo.FileName);
            }
        }

        // Método para convertir una imagen a un arreglo de bytes
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            var CategoriaID = CategoryID.Text;

            if (string.IsNullOrEmpty(CategoriaID))
            {
                MessageBox.Show("Debe especificar el ID de la categoria para eliminarlo");
                return;
            }

            if (!Regex.IsMatch(CategoriaID, @"^\d+$"))
            {
                MessageBox.Show("El ID de la categoria debe contener solo dígitos");
                return;
            }

            // El ID de la categoria es válido, continuar con la eliminación
            MessageBox.Show("La categoria se ha Eliminado correctamente");
            //Eliminar la categoria de la base de datos
            var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            var manager = new CategoriaManager(connectionString);
            manager.EliminarCategoria(CategoriasDataGrid, CategoryID.Text);

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            var Categoria = new Categoria
            {
              
                CategoryID = CategoryID.Text,
                CategoryName = CategoryName.Text,
                Description = Description.Text,
              
            };

           var resultado = _validator.Validate(Categoria);

            if (resultado.IsValid)
            {
                // El modelo es válido
                MessageBox.Show("La categoria se ha Actualizado correctamente");
                // Actualizar las categorías
                var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                var manager = new CategoriaManager(connectionString);

                // Convertir la imagen del PictureBox a un arreglo de bytes
                byte[] imagenBytes = ImageToByteArray(Imagen.Image);

                manager.ActualizarCategoria(CategoriasDataGrid, CategoryID.Text, CategoryName.Text, Description.Text, imagenBytes);

            }
            else
            {
                // Mostrar los errores de validación
                foreach (var error in resultado.Errors)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
        
        }
    }
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        { 
            // Validar la propiedad CategoryID
            RuleFor(x => x.CategoryID)
                .NotEmpty().WithMessage("El ID de la categoría es obligatorio")
                .Matches(@"^\d+$").WithMessage("El ID debe contener al menos un dígito");
           
            // Validar la propiedad ProductName
            RuleFor(x => x.CategoryName)
                .NotEmpty().WithMessage("El nombre de la Categoria es obligatorio")
                .Length(2, 15).WithMessage("El nombre de la Categoria debe tener entre 2 y 15 caracteres");

            RuleFor(x => x.Description)
           .NotEmpty().WithMessage("La descripcion es obligatoria")
           .Length(2, 200).WithMessage("La descripcion debe tener entre 2 y 200 caracteres");

        }
    }
    public class Categoria
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
      
    }
}
