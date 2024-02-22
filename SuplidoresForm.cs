using CRUD2._0.Data.Clases;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CRUD2._0
{
    public partial class SuplidoresForm : Form
    {

        private SuplidorValidator _validator;
        public SuplidoresForm()
        {
            InitializeComponent();

            _validator = new SuplidorValidator();
        }

       

        private void Leer_Click(object sender, EventArgs e)
        {
            //Leer los Suplidores
            var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            var manager = new SuplidoresManager(connectionString);
            manager.CargarSuplidores(SuplidoresDataGrid);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            var suplidorID = SuplidorID.Text;

            if (string.IsNullOrEmpty(suplidorID))
            {
                MessageBox.Show("Debe especificar el ID del suplidor para eliminarlo");
                return;
            }

            if (!Regex.IsMatch(suplidorID, @"^\d+$"))
            {
                MessageBox.Show("El ID del suplidor debe contener solo dígitos");
                return;
            }

            // El ID del suplidor es válido, continuar con la eliminación
            MessageBox.Show("El suplidor se ha Eliminado correctamente");

            var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            var manager = new SuplidoresManager(connectionString);
            manager.EliminarSuplidor(SuplidoresDataGrid, suplidorID);
        }




        private void Actualizar_Click(object sender, EventArgs e)
        {
            var suplidor = new Suplidor
            {
                SuplidorID = SuplidorID.Text,
                CompanyName = CompanyName.Text,
                ContactName = ContactName.Text,
                ContactTitle = ContactTitle.Text,
                Address = Address.Text,
                City = City.Text,
                Region = Region.Text,
                PostalCode = PostalCode.Text,
                Country = Country.Text,
                Phone = Phone.Text,
                Fax = Fax.Text,
                HomePage = HomePage.Text
            };

            var resultado = _validator.Validate(suplidor);

            if (resultado.IsValid)
            {
                // El modelo es válido
                MessageBox.Show("El suplidor se ha Actualizado correctamente");

                //Actualizar Suplidor
                var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                var manager = new SuplidoresManager(connectionString);
                manager.ActualizarSuplidores(SuplidoresDataGrid, SuplidorID.Text, CompanyName.Text, ContactName.Text, ContactTitle.Text, Address.Text, City.Text, Region.Text, PostalCode.Text, Country.Text, Phone.Text, Fax.Text, HomePage.Text);
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

        private void crear_Click(object sender, EventArgs e)
        {
            var suplidor = new Suplidor
            {
                SuplidorID = SuplidorID.Text,
                CompanyName = CompanyName.Text,
                ContactName = ContactName.Text,
                ContactTitle = ContactTitle.Text,
                Address = Address.Text,
                City = City.Text,
                Region = Region.Text,
                PostalCode = PostalCode.Text,
                Country = Country.Text,
                Phone = Phone.Text,
                Fax = Fax.Text,
                HomePage = HomePage.Text
            };

            var resultado = _validator.Validate(suplidor);

            if (resultado.IsValid)
            {
                // El modelo es válido
                MessageBox.Show("El suplidor se ha creado correctamente");

                //crear suplidor
                var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
                var manager = new SuplidoresManager(connectionString);
                manager.CrearSuplidor(SuplidoresDataGrid, CompanyName.Text, ContactName.Text, ContactTitle.Text, Address.Text, City.Text, Region.Text, PostalCode.Text, Country.Text, Phone.Text, Fax.Text, HomePage.Text);
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

    
        public class SuplidorValidator : AbstractValidator<Suplidor>
        {
           
            public SuplidorValidator()
            {
               
                // Validar la propiedad SuplidorID
                RuleFor(x => x.SuplidorID)
                .NotEmpty().WithMessage("El ID del Suplidor es obligatorio")
                 .Matches(@"^\d+$").WithMessage("El ID debe contener al menos un dígito");

                // Validar la propiedad CompanyName
                RuleFor(x => x.CompanyName)
                    .NotEmpty().WithMessage("El nombre de la compañía del suplidor es obligatorio")
                    .Length(2, 40).WithMessage("El nombre de la compañía debe tener entre 2 y 40 caracteres");

                // Validar la propiedad ContactName
                RuleFor(x => x.ContactName)
                    .NotEmpty().WithMessage("El nombre de contacto del suplidor es obligatorio")
                    .Length(2, 30).WithMessage("El nombre de contacto debe tener entre 2 y 30 caracteres");

                // Validar la propiedad Address
                RuleFor(x => x.Address)
                    .NotEmpty().WithMessage("La dirección del suplidor es obligatoria")
                    .Length(10, 60).WithMessage("La dirección debe tener entre 10 y 60 caracteres");

                // Validar la propiedad City
                RuleFor(x => x.City)
                    .NotEmpty().WithMessage("La ciudad del suplidor es obligatoria")
                    .Length(2, 15).WithMessage("El nombre de la ciudad debe tener entre 2 y 15 caracteres");

                // Validar la propiedad Region
                RuleFor(x => x.Region)
                    .Length(2, 10).WithMessage("La región debe tener entre 2 y 10 caracteres");

                // Validar la propiedad PostalCode
                RuleFor(x => x.PostalCode)
                    .Length(2, 10).WithMessage("El código postal debe tener entre 2 y 10 caracteres");

                // Validar la propiedad Country
                RuleFor(x => x.Country)
                    .NotEmpty().WithMessage("El país del suplidor es obligatorio")
                    .Length(2, 15).WithMessage("El nombre del país debe tener entre 2 y 15 caracteres");

                // Validar la propiedad Phone
                RuleFor(x => x.Phone)
                    .NotEmpty().WithMessage("El teléfono del suplidor es obligatorio")
                    .Matches(@"^\d{10}$").WithMessage("El teléfono debe tener 10 dígitos");

                RuleFor(x => x.Fax)
               .Matches(@"^\d{10}$|^$").WithMessage("El fax debe tener 10 dígitos o estar vacío");


                // Validar la propiedad HomePage
                RuleFor(x => x.HomePage)
                .Length(0, 250).WithMessage("La página web debe tener entre 0 y 250 caracteres");
            }
        
        }

       
        public class Suplidor
        {
            public string SuplidorID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public string HomePage { get; set; }
        }


    }

}

