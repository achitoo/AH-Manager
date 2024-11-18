namespace Borrador_1.Formularios
{
    partial class FrmOrder
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
            this.dgvCostumer = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCostumer = new System.Windows.Forms.Button();
            this.btnEditCostumer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackOrderFrmToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCostumer
            // 
            this.dgvCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostumer.Location = new System.Drawing.Point(371, 102);
            this.dgvCostumer.Name = "dgvCostumer";
            this.dgvCostumer.RowHeadersWidth = 51;
            this.dgvCostumer.RowTemplate.Height = 24;
            this.dgvCostumer.Size = new System.Drawing.Size(415, 310);
            this.dgvCostumer.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddCustomer);
            this.groupBox1.Controls.Add(this.btnDeleteCostumer);
            this.groupBox1.Controls.Add(this.btnEditCostumer);
            this.groupBox1.Location = new System.Drawing.Point(100, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(239, 310);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opcion";
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Location = new System.Drawing.Point(36, 21);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(166, 46);
            this.BtnAddCustomer.TabIndex = 0;
            this.BtnAddCustomer.Text = "Agregar";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCostumer
            // 
            this.btnDeleteCostumer.Location = new System.Drawing.Point(36, 181);
            this.btnDeleteCostumer.Name = "btnDeleteCostumer";
            this.btnDeleteCostumer.Size = new System.Drawing.Size(166, 46);
            this.btnDeleteCostumer.TabIndex = 2;
            this.btnDeleteCostumer.Text = "Eliminar";
            this.btnDeleteCostumer.UseVisualStyleBackColor = true;
            // 
            // btnEditCostumer
            // 
            this.btnEditCostumer.Location = new System.Drawing.Point(36, 101);
            this.btnEditCostumer.Name = "btnEditCostumer";
            this.btnEditCostumer.Size = new System.Drawing.Size(166, 46);
            this.btnEditCostumer.TabIndex = 1;
            this.btnEditCostumer.Text = "Editar";
            this.btnEditCostumer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestion de ordenes";
            // 
            // btnBackOrderFrmToMain
            // 
            this.btnBackOrderFrmToMain.Location = new System.Drawing.Point(691, 12);
            this.btnBackOrderFrmToMain.Name = "btnBackOrderFrmToMain";
            this.btnBackOrderFrmToMain.Size = new System.Drawing.Size(117, 55);
            this.btnBackOrderFrmToMain.TabIndex = 8;
            this.btnBackOrderFrmToMain.Text = "Regresar al menu principal";
            this.btnBackOrderFrmToMain.UseVisualStyleBackColor = true;
            this.btnBackOrderFrmToMain.Click += new System.EventHandler(this.btnBackOrderFrmToMain_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 477);
            this.Controls.Add(this.btnBackOrderFrmToMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCostumer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCostumer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCostumer;
        private System.Windows.Forms.Button btnEditCostumer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackOrderFrmToMain;
    }
}