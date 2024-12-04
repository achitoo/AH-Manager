namespace AutosHuembes.Formularios
{
    partial class Order
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgbOrders = new System.Windows.Forms.DataGridView();
            this.Comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbOrders
            // 
            this.dgbOrders.AllowUserToAddRows = false;
            this.dgbOrders.AllowUserToDeleteRows = false;
            this.dgbOrders.AllowUserToResizeRows = false;
            this.dgbOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dgbOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgbOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgbOrders.ColumnHeadersHeight = 40;
            this.dgbOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comprador,
            this.Marca,
            this.Modelo,
            this.Año,
            this.Monto,
            this.Detalles});
            this.dgbOrders.EnableHeadersVisualStyles = false;
            this.dgbOrders.GridColor = System.Drawing.Color.LightGray;
            this.dgbOrders.Location = new System.Drawing.Point(30, 118);
            this.dgbOrders.Name = "dgbOrders";
            this.dgbOrders.ReadOnly = true;
            this.dgbOrders.RowHeadersWidth = 40;
            this.dgbOrders.RowTemplate.Height = 28;
            this.dgbOrders.Size = new System.Drawing.Size(918, 531);
            this.dgbOrders.TabIndex = 68;
            this.dgbOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbOrders_CellClick);
            // 
            // Comprador
            // 
            this.Comprador.HeaderText = "Comprador";
            this.Comprador.MinimumWidth = 8;
            this.Comprador.Name = "Comprador";
            this.Comprador.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 8;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 8;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.MinimumWidth = 8;
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 8;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.MinimumWidth = 8;
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddOrder.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(30, 672);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(138, 48);
            this.btnAddOrder.TabIndex = 2;
            this.btnAddOrder.Text = "Agregar";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.Location = new System.Drawing.Point(176, 672);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(138, 48);
            this.btnEditOrder.TabIndex = 5;
            this.btnEditOrder.Text = "Editar";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Location = new System.Drawing.Point(322, 672);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(138, 48);
            this.btnDeleteOrder.TabIndex = 6;
            this.btnDeleteOrder.Text = "Eliminar";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(361, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 27);
            this.label1.TabIndex = 78;
            this.label1.Text = "Gestionar tus ventas";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(986, 769);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dgbOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgbOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label label1;
    }
}
