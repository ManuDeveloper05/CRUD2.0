using NLog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; 

public class ProductosManager
{
    private string connectionString;

    public ProductosManager(string connectionString)
    {
        this.connectionString = connectionString;
    }

    private static readonly Logger logger = LogManager.GetCurrentClassLogger();

    public void DoSomething()
    {
        logger.Info("Este es un mensaje de información.");
        logger.Warn("¡Cuidado! Algo podría estar mal.");
        try
        {
            // Código que podría generar una excepción
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Ocurrió un error.");
        }
    }

 public void CargarProductos(DataGridView grid)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "Select * From Products";

                connection.Open();

                var dataReader = command.ExecuteReader();

                var ProductosDataTable = new DataTable();
                ProductosDataTable.Load(dataReader);

                grid.DataSource = ProductosDataTable;
            }
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Error al cargar los productos desde la base de datos.");
        }
    }


    public void CrearProductos(DataGridView grid, string productName, string supplierID, string categoryID, string quantityPerUnit, string unitPrice, string unitsInStock, string unitsOnOrder, string reorderLevel, string discontinued)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Products VALUES(@productName, @supplierID, @categoryID, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)";

                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@supplierID", supplierID);
                command.Parameters.AddWithValue("@categoryID", categoryID);
                command.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
                command.Parameters.AddWithValue("@unitPrice", unitPrice);
                command.Parameters.AddWithValue("@unitsInStock", unitsInStock);
                command.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
                command.Parameters.AddWithValue("@reorderLevel", reorderLevel);
                command.Parameters.AddWithValue("@discontinued", discontinued);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery(); // Ejecutar la inserción y obtener el número de filas afectadas
                connection.Close();

                if (rowsAffected > 0)
                {
                    // Si se insertó al menos una fila en la base de datos, cargar los productos en el DataGridView
                    CargarProductos(grid);
                }
            }
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Error al crear productos.");
        }
    }

    public void ActualizarProductos(DataGridView grid, string ProductID, string productName, string supplierID, string categoryID, string quantityPerUnit, string unitPrice, string unitsInStock, string unitsOnOrder, string reorderLevel, string discontinued)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE Products SET ProductName = @productName, SupplierID = @supplierID, CategoryID = @categoryID, QuantityPerUnit = @quantityPerUnit, UnitPrice = @unitPrice, UnitsInStock = @unitsInStock, UnitsOnOrder = @unitsOnOrder, ReorderLevel = @reorderLevel, Discontinued = @discontinued WHERE ProductID = @productID";

                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@supplierID", supplierID);
                command.Parameters.AddWithValue("@categoryID", categoryID);
                command.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
                command.Parameters.AddWithValue("@unitPrice", unitPrice);
                command.Parameters.AddWithValue("@unitsInStock", unitsInStock);
                command.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
                command.Parameters.AddWithValue("@reorderLevel", reorderLevel);
                command.Parameters.AddWithValue("@discontinued", discontinued);
                command.Parameters.AddWithValue("@productID", ProductID);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery(); // Ejecutar la actualización y obtener el número de filas afectadas
                connection.Close();

                if (rowsAffected > 0)
                {
                    // Si se actualizó al menos una fila, cargar los productos en el DataGridView
                    CargarProductos(grid);
                }
            }
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Error al actualizar productos.");
        }
    }

    public void EliminarProductos(DataGridView grid, string ProductID)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Products WHERE ProductID = @productID";

                command.Parameters.AddWithValue("@productID", ProductID);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery(); // Ejecutar la eliminación y obtener el número de filas afectadas
                connection.Close();

                if (rowsAffected > 0)
                {
                    // Si se eliminó al menos una fila en la base de datos, eliminar la fila correspondiente del DataGridView
                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        if (row.Cells["ProductID"].Value.ToString() == ProductID)
                        {
                            grid.Rows.Remove(row);
                            break; // Terminar el bucle una vez que se haya eliminado la fila
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Error al eliminar productos.");
        }
    }


}
