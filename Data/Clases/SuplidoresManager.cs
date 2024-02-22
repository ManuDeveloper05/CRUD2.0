using FluentValidation;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD2._0.Data.Clases
{
    public class SuplidoresManager
    {

        private string connectionString;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public SuplidoresManager(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void CargarSuplidores(DataGridView grid)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var SuplidorDataTable = new DataTable();

                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Suppliers";

                    connection.Open();

                    var dataReader = command.ExecuteReader();

                    SuplidorDataTable.Load(dataReader);

                    connection.Close();

                    grid.DataSource = SuplidorDataTable;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar los suplidores desde la base de datos.");
            }
        }

        public void CrearSuplidor(DataGridView grid, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax, string HomePage)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO Suppliers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage) VALUES (@companyName, @contactName, @contactTitle, @address, @city, @region, @postalCode, @country, @phone, @fax, @homePage)";

                    command.Parameters.AddWithValue("@companyName", CompanyName);
                    command.Parameters.AddWithValue("@contactName", ContactName);
                    command.Parameters.AddWithValue("@contactTitle", ContactTitle);
                    command.Parameters.AddWithValue("@address", Address);
                    command.Parameters.AddWithValue("@city", City);
                    command.Parameters.AddWithValue("@region", Region);
                    command.Parameters.AddWithValue("@postalCode", PostalCode);
                    command.Parameters.AddWithValue("@country", Country);
                    command.Parameters.AddWithValue("@phone", Phone);
                    command.Parameters.AddWithValue("@fax", Fax);
                    command.Parameters.AddWithValue("@homePage", HomePage);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        CargarSuplidores(grid);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al crear un nuevo suplidor.");
            }
        }

        public void ActualizarSuplidores(DataGridView grid, string SuplidorID, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax, string HomePage)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "UPDATE Suppliers SET CompanyName = @companyName, ContactName = @contactName, ContactTitle = @contactTitle, Address = @address, City = @city, Region = @region, PostalCode = @postalCode, Country = @country, Phone = @phone, Fax = @fax, HomePage = @homePage WHERE SupplierID = @supplierID";

                    command.Parameters.AddWithValue("@companyName", CompanyName);
                    command.Parameters.AddWithValue("@contactName", ContactName);
                    command.Parameters.AddWithValue("@contactTitle", ContactTitle);
                    command.Parameters.AddWithValue("@address", Address);
                    command.Parameters.AddWithValue("@city", City);
                    command.Parameters.AddWithValue("@region", Region);
                    command.Parameters.AddWithValue("@postalCode", PostalCode);
                    command.Parameters.AddWithValue("@country", Country);
                    command.Parameters.AddWithValue("@phone", Phone);
                    command.Parameters.AddWithValue("@fax", Fax);
                    command.Parameters.AddWithValue("@homePage", HomePage);
                    command.Parameters.AddWithValue("@supplierID", SuplidorID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        CargarSuplidores(grid);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al actualizar un suplidor.");
            }
        }

        public void EliminarSuplidor(DataGridView grid, string SupplierID)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";

                    command.Parameters.AddWithValue("@SupplierID", SupplierID);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        foreach (DataGridViewRow row in grid.Rows)
                        {
                            if (row.Cells["SupplierID"].Value.ToString() == SupplierID)
                            {
                                grid.Rows.Remove(row);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al eliminar un suplidor.");
            }
        }


    }
}
