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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackOrderFrmToMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgbOrder = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMontoTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.btnLoadFile = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgbOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestion de ordenes";
            // 
            // btnBackOrderFrmToMain
            // 
            this.btnBackOrderFrmToMain.Location = new System.Drawing.Point(780, 32);
            this.btnBackOrderFrmToMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackOrderFrmToMain.Name = "btnBackOrderFrmToMain";
            this.btnBackOrderFrmToMain.Size = new System.Drawing.Size(132, 69);
            this.btnBackOrderFrmToMain.TabIndex = 8;
            this.btnBackOrderFrmToMain.Text = "Regresar al menu principal";
            this.btnBackOrderFrmToMain.UseVisualStyleBackColor = true;
            this.btnBackOrderFrmToMain.Click += new System.EventHandler(this.btnBackOrderFrmToMain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 93);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gestion de orden";
            // 
            // dgbOrder
            // 
            this.dgbOrder.AllowUserToAddRows = false;
            this.dgbOrder.AllowUserToDeleteRows = false;
            this.dgbOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbOrder.Location = new System.Drawing.Point(326, 164);
            this.dgbOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgbOrder.Name = "dgbOrder";
            this.dgbOrder.RowHeadersWidth = 62;
            this.dgbOrder.RowTemplate.Height = 28;
            this.dgbOrder.Size = new System.Drawing.Size(585, 406);
            this.dgbOrder.TabIndex = 10;
            this.dgbOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbOrder_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMontoTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.tbBrand);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.tbDetails);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(308, 405);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos General";
            // 
            // tbMontoTotal
            // 
            this.tbMontoTotal.Location = new System.Drawing.Point(118, 298);
            this.tbMontoTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMontoTotal.Name = "tbMontoTotal";
            this.tbMontoTotal.Size = new System.Drawing.Size(112, 26);
            this.tbMontoTotal.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Monto total";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnEdit,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(3, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(302, 29);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::Borrador_1.Properties.Resources.Guardar;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(34, 24);
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::Borrador_1.Properties.Resources.Editar;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(34, 24);
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::Borrador_1.Properties.Resources.eliminar;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 24);
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(118, 65);
            this.tbBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(112, 26);
            this.tbBrand.TabIndex = 5;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(118, 254);
            this.tbYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(112, 26);
            this.tbYear.TabIndex = 7;
            // 
            // tbDetails
            // 
            this.tbDetails.Location = new System.Drawing.Point(118, 151);
            this.tbDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDetails.Multiline = true;
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDetails.Size = new System.Drawing.Size(112, 73);
            this.tbDetails.TabIndex = 6;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(118, 104);
            this.tbModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(112, 26);
            this.tbModel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Detalles del V.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Modelo";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveFile,
            this.btnLoadFile});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(922, 29);
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveFile.Image = global::Borrador_1.Properties.Resources.GuardarArch;
            this.btnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(34, 24);
            this.btnSaveFile.Text = "Guardar archivo";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadFile.Image = global::Borrador_1.Properties.Resources.Cargar;
            this.btnLoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(34, 24);
            this.btnLoadFile.Text = "Cargar archivo";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 596);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgbOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackOrderFrmToMain);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOrder";
            this.Text = "Orden";
            ((System.ComponentModel.ISupportInitialize)(this.dgbOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackOrderFrmToMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgbOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMontoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSaveFile;
        private System.Windows.Forms.ToolStripButton btnLoadFile;
    }
}