using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD2._0.Data.Clases
{
    public class CategoriaManager
    {

        private string connectionString;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public CategoriaManager(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void CargarCategoria(DataGridView grid)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var CategoriaDataTable = new DataTable();

                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Categories";

                    connection.Open();

                    var dataReader = command.ExecuteReader();

                    CategoriaDataTable.Load(dataReader);

                    connection.Close();

                    grid.DataSource = CategoriaDataTable;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al cargar las categorías desde la base de datos.");
            }
        }

        public void CrearCategoria(DataGridView grid, string CategoryName, string Description, byte[] imagen)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO Categories (CategoryName, Description, Picture) VALUES (@CategoryName, @Description, @Picture)";

                    command.Parameters.AddWithValue("@CategoryName", CategoryName);
                    command.Parameters.AddWithValue("@Description", Description);

                    if (imagen == null)
                    {
                        command.Parameters.Add("@Picture", SqlDbType.Image).Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.Add("@Picture", SqlDbType.Image).Value = imagen;
                    }

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        CargarCategoria(grid);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al crear una nueva categoría.");
            }
        }

        public void ActualizarCategoria(DataGridView grid, string CategoryID, string CategoryName, string Description, byte[] imagen)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description, Picture = @Picture WHERE CategoryID = @CategoryID";

                    command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    command.Parameters.AddWithValue("@CategoryName", CategoryName);
                    command.Parameters.AddWithValue("@Description", Description);

                    if (imagen == null)
                    {
                        command.Parameters.Add("@Picture", SqlDbType.Image).Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.Add("@Picture", SqlDbType.Image).Value = imagen;
                    }

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        CargarCategoria(grid);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al actualizar una categoría.");
            }
        }

        public void EliminarCategoria(DataGridView grid, string CategoryID)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM Categories WHERE CategoryID = @CategoryID";

                    command.Parameters.AddWithValue("@CategoryID", CategoryID);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        foreach (DataGridViewRow row in grid.Rows)
                        {
                            if (row.Cells["CategoryID"].Value.ToString() == CategoryID)
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
                logger.Error(ex, "Error al eliminar una categoría.");
            }
        }
}   }
