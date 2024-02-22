
using CRUD2._0.Data.Clases;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUD2._0.SuplidoresForm;

namespace CRUD2._0
{
    public partial class ProductosForm : Form
    {
        private ProductosValidator _validator;
        public ProductosForm()
        {
            InitializeComponent();

            Load += Suplidores_Load;
            _validator = new ProductosValidator();
        }

        private void Suplidores_Load(object sender, EventArgs e)
        {
         

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Leer los productos
            var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            var manager = new ProductosManager(connectionString);
            manager.CargarProductos(ProductosDataGrid);



        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {

        }

        private void crear_Click(object sender, EventArgs e)
        {

            var Productos = new Productos
            {
                ProductID = ProductID.Text,
                ProductName = ProductName.Text,
                SupplierID = SupplierID.Text,
                CategoryID = CategoryID.Text,
                QuantityPerUnit = QuiantityPerUnit.Text,
                UnitPrice = UnitPrice.Text,
                UnitsInStock = UnitslnStock.Text,
                UnitsOnOrder = UnitsOnOrder.Text,
                ReorderLevel = ReorderLevel.Text,
                Discontinued = Discontinued.Text
            };

            var resultado = _validator.Validate(Productos);

            if (resultado.IsValid)
            {
                // El modelo es válido
                MessageBox.Show("El producto se ha agregado correctamente");
            
                //Crear o agregar los Productos

                var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                var manager = new ProductosManager(connectionString);
                manager.CrearProductos(ProductosDataGrid, ProductName.Text, SupplierID.Text, CategoryID.Text, QuiantityPerUnit.Text, UnitPrice.Text, UnitslnStock.Text, UnitsOnOrder.Text, ReorderLevel.Text, Discontinued.Text);
                ;


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

        private void Actualizar_Click(object sender, EventArgs e)
        {
           

            var Productos = new Productos
            {
                ProductID = ProductID.Text,
                ProductName = ProductName.Text,
                SupplierID = SupplierID.Text,
                CategoryID = CategoryID.Text,
                QuantityPerUnit= QuiantityPerUnit.Text,
                UnitPrice = UnitPrice.Text,
                UnitsInStock = UnitslnStock.Text,
                UnitsOnOrder = UnitsOnOrder.Text,
                ReorderLevel = ReorderLevel.Text,
                Discontinued = Discontinued.Text
            };

            var resultado = _validator.Validate(Productos);

            if (resultado.IsValid)
            {
                // El modelo es válido
                MessageBox.Show("El producto se ha Actualizado correctamente");
                //Actualizar los productos
                var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                var manager = new ProductosManager(connectionString);
                manager.ActualizarProductos(ProductosDataGrid, ProductID.Text, ProductName.Text, SupplierID.Text, CategoryID.Text, QuiantityPerUnit.Text, UnitPrice.Text, UnitslnStock.Text, UnitsOnOrder.Text, ReorderLevel.Text, Discontinued.Text);
                ;

                
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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            var ProductoID = ProductID.Text;

            if (string.IsNullOrEmpty(ProductoID))
            {
                MessageBox.Show("Debe especificar el ID del Producto para eliminarlo");
                return;
            }

            if (!Regex.IsMatch(ProductoID, @"^\d+$"))
            {
                MessageBox.Show("El ID del Producto debe contener solo dígitos");
                return;
            }

            // El ID del suplidor es válido, continuar con la eliminación
            MessageBox.Show("El Producto se ha Eliminado correctamente");

          
            //Eliminar el producto de la base de datos
            var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            var manager = new ProductosManager(connectionString);
            manager.EliminarProductos(ProductosDataGrid, ProductID.Text);
            ;
        }

        
    }
    public class ProductosValidator : AbstractValidator<Productos>
    {
        public ProductosValidator()
        {
            // Validar la propiedad ProductID
            RuleFor(x => x.ProductID)
                .NotEmpty().WithMessage("El ID del producto es obligatorio")
                .Matches(@"^\d+$").WithMessage("El ID debe contener al menos un dígito");

            // Validar la propiedad ProductName
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("El nombre del producto es obligatorio")
                .Length(2, 40).WithMessage("El nombre del producto debe tener entre 2 y 40 caracteres");

            // Validar la propiedad SupplierID
            RuleFor(x => x.SupplierID)
                .NotEmpty().WithMessage("El ID del suplidor es obligatorio")
                .Matches(@"^\d+$").WithMessage("El ID debe contener al menos un dígito");

            // Validar la propiedad CategoryID
            RuleFor(x => x.CategoryID)
                .NotEmpty().WithMessage("El ID de la categoría es obligatorio")
                .Matches(@"^\d+$").WithMessage("El ID debe contener al menos un dígito");

            // Validar la propiedad QuantityPerUnit
            RuleFor(x => x.QuantityPerUnit)
                .NotEmpty().WithMessage("La cantidad por unidad es obligatoria")
                .Length(2, 20).WithMessage("La cantidad por unidad debe tener entre 2 y 40 caracteres");

            // Validar la propiedad UnitPrice
            RuleFor(x => x.UnitPrice)
            .NotEmpty().WithMessage("El precio unitario es obligatorio")
             .Must(x => decimal.TryParse(x, out _) && x.Length <= 10).WithMessage("El precio unitario puede ser un número decimal con un máximo de 10 dígitos");


            // Validar la propiedad UnitsInStock
            RuleFor(x => x.UnitsInStock)
                .NotEmpty().WithMessage("Las unidades en stock son obligatorias")
                .Matches(@"^\d+$").WithMessage("Las unidades en stock deben contener solo dígitos");

            // Validar la propiedad UnitsOnOrder
            RuleFor(x => x.UnitsOnOrder)
                .NotEmpty().WithMessage("Las unidades en orden son obligatorias")
                .Matches(@"^\d+$").WithMessage("Las unidades en orden deben contener solo dígitos");

            // Validar la propiedad ReorderLevel
            RuleFor(x => x.ReorderLevel)
                .NotEmpty().WithMessage("El nivel de reorden es obligatorio")
                .Matches(@"^\d+$").WithMessage("El nivel de reorden debe contener solo dígitos");

            // Validar la propiedad Discontinued
            RuleFor(x => x.Discontinued)
                .NotEmpty().WithMessage("El estado de descontinuado es obligatorio")
                .Matches(@"^(True|False|1|0)$").WithMessage("El estado de descontinuado debe ser True, False, 1 o 0");

        }
    }
    public class Productos
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string SupplierID { get; set; }
        public string CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }
    }


}
