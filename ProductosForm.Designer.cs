namespace CRUD2._0
{
    partial class ProductosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crear = new System.Windows.Forms.Button();
            this.Leer = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.SupplierID = new System.Windows.Forms.TextBox();
            this.CategoryID = new System.Windows.Forms.TextBox();
            this.QuiantityPerUnit = new System.Windows.Forms.TextBox();
            this.UnitPrice = new System.Windows.Forms.TextBox();
            this.UnitslnStock = new System.Windows.Forms.TextBox();
            this.UnitsOnOrder = new System.Windows.Forms.TextBox();
            this.ReorderLevel = new System.Windows.Forms.TextBox();
            this.Discontinued = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductosDataGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crear
            // 
            this.crear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.crear.Location = new System.Drawing.Point(187, 550);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(191, 56);
            this.crear.TabIndex = 1;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = false;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // Leer
            // 
            this.Leer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Leer.BackColor = System.Drawing.Color.DarkGray;
            this.Leer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Leer.Location = new System.Drawing.Point(907, 550);
            this.Leer.Name = "Leer";
            this.Leer.Size = new System.Drawing.Size(161, 56);
            this.Leer.TabIndex = 1;
            this.Leer.Text = "Leer";
            this.Leer.UseVisualStyleBackColor = false;
            this.Leer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Actualizar.BackColor = System.Drawing.Color.Teal;
            this.Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Actualizar.Location = new System.Drawing.Point(429, 550);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(200, 56);
            this.Actualizar.TabIndex = 1;
            this.Actualizar.Text = "Actualizar ";
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eliminar.BackColor = System.Drawing.Color.Red;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Eliminar.Location = new System.Drawing.Point(672, 550);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(195, 56);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // ProductID
            // 
            this.ProductID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(318, 290);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(116, 30);
            this.ProductID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(396, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestionar Productos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 44);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(1, 904);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1286, 43);
            this.panel2.TabIndex = 4;
            // 
            // ProductName
            // 
            this.ProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(318, 333);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(236, 30);
            this.ProductName.TabIndex = 2;
            // 
            // SupplierID
            // 
            this.SupplierID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierID.Location = new System.Drawing.Point(318, 379);
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.Size = new System.Drawing.Size(116, 30);
            this.SupplierID.TabIndex = 2;
            // 
            // CategoryID
            // 
            this.CategoryID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryID.Location = new System.Drawing.Point(318, 424);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(116, 30);
            this.CategoryID.TabIndex = 2;
            // 
            // QuiantityPerUnit
            // 
            this.QuiantityPerUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuiantityPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuiantityPerUnit.Location = new System.Drawing.Point(318, 467);
            this.QuiantityPerUnit.Name = "QuiantityPerUnit";
            this.QuiantityPerUnit.Size = new System.Drawing.Size(236, 30);
            this.QuiantityPerUnit.TabIndex = 2;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPrice.Location = new System.Drawing.Point(907, 300);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(117, 30);
            this.UnitPrice.TabIndex = 2;
            // 
            // UnitslnStock
            // 
            this.UnitslnStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitslnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitslnStock.Location = new System.Drawing.Point(907, 342);
            this.UnitslnStock.Name = "UnitslnStock";
            this.UnitslnStock.Size = new System.Drawing.Size(117, 30);
            this.UnitslnStock.TabIndex = 2;
            // 
            // UnitsOnOrder
            // 
            this.UnitsOnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitsOnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsOnOrder.Location = new System.Drawing.Point(907, 388);
            this.UnitsOnOrder.Name = "UnitsOnOrder";
            this.UnitsOnOrder.Size = new System.Drawing.Size(117, 30);
            this.UnitsOnOrder.TabIndex = 2;
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReorderLevel.Location = new System.Drawing.Point(907, 436);
            this.ReorderLevel.Name = "ReorderLevel";
            this.ReorderLevel.Size = new System.Drawing.Size(117, 30);
            this.ReorderLevel.TabIndex = 2;
            // 
            // Discontinued
            // 
            this.Discontinued.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Discontinued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discontinued.Location = new System.Drawing.Point(907, 481);
            this.Discontinued.Name = "Discontinued";
            this.Discontinued.Size = new System.Drawing.Size(49, 30);
            this.Discontinued.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(82, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID de producto";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(82, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de producto";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(82, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID de proveedor";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(82, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID de categoría";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(82, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad por unidad";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(653, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Precio unitario";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(651, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Unidades en stock";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(651, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Unidades en pedido";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(653, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nivel de pedido";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(653, 474);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Discontinuado";
            // 
            // ProductosDataGrid
            // 
            this.ProductosDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductosDataGrid.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.ProductosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGrid.Location = new System.Drawing.Point(12, 633);
            this.ProductosDataGrid.Name = "ProductosDataGrid";
            this.ProductosDataGrid.RowHeadersWidth = 51;
            this.ProductosDataGrid.RowTemplate.Height = 24;
            this.ProductosDataGrid.Size = new System.Drawing.Size(1275, 265);
            this.ProductosDataGrid.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::CRUD2._0.Properties.Resources.Productos;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(187, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 163);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1285, 948);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProductosDataGrid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Discontinued);
            this.Controls.Add(this.ReorderLevel);
            this.Controls.Add(this.UnitsOnOrder);
            this.Controls.Add(this.UnitslnStock);
            this.Controls.Add(this.UnitPrice);
            this.Controls.Add(this.QuiantityPerUnit);
            this.Controls.Add(this.CategoryID);
            this.Controls.Add(this.SupplierID);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Leer);
            this.Controls.Add(this.crear);
            this.Name = "ProductosForm";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.Button Leer;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox SupplierID;
        private System.Windows.Forms.TextBox CategoryID;
        private System.Windows.Forms.TextBox QuiantityPerUnit;
        private System.Windows.Forms.TextBox UnitPrice;
        private System.Windows.Forms.TextBox UnitslnStock;
        private System.Windows.Forms.TextBox UnitsOnOrder;
        private System.Windows.Forms.TextBox ReorderLevel;
        private System.Windows.Forms.TextBox Discontinued;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView ProductosDataGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}