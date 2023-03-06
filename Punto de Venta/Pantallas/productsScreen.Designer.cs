
namespace Punto_de_Venta
{
    partial class productsScreen
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
            this.txtFilterProduct = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtReOrdProduct = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtCostProduct = new System.Windows.Forms.TextBox();
            this.txtDesProduct = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExistenceProduct = new System.Windows.Forms.TextBox();
            this.dtpDateProduct = new System.Windows.Forms.DateTimePicker();
            this.cbDepartamentProduct = new System.Windows.Forms.ComboBox();
            this.cbMeasureProduct = new System.Windows.Forms.ComboBox();
            this.dtpChangeDateProduct = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbActiveProduct = new System.Windows.Forms.ComboBox();
=======
            this.codProdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desProdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CosInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExisInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CambioPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterProduct
            // 
            this.txtFilterProduct.Location = new System.Drawing.Point(853, 105);
            this.txtFilterProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterProduct.Multiline = true;
            this.txtFilterProduct.Name = "txtFilterProduct";
            this.txtFilterProduct.Size = new System.Drawing.Size(193, 26);
            this.txtFilterProduct.TabIndex = 54;
            this.txtFilterProduct.TextChanged += new System.EventHandler(this.txtFilterProduct_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(772, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 30);
            this.label12.TabIndex = 53;
            this.label12.Text = "Filtro:";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteProduct.Location = new System.Drawing.Point(1024, 660);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(185, 63);
            this.btnDeleteProduct.TabIndex = 51;
            this.btnDeleteProduct.Text = "Eliminar";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Navy;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditProduct.Location = new System.Drawing.Point(817, 660);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(185, 63);
            this.btnEditProduct.TabIndex = 50;
            this.btnEditProduct.Text = "Editar";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Green;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(607, 660);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(185, 63);
            this.btnAddProduct.TabIndex = 49;
            this.btnAddProduct.Text = "Agregar";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtReOrdProduct
            // 
<<<<<<< HEAD
            this.txtReOrdProduct.Location = new System.Drawing.Point(351, 574);
            this.txtReOrdProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.txtReOrdProduct.Location = new System.Drawing.Point(261, 459);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.txtReOrdProduct.Multiline = true;
            this.txtReOrdProduct.Name = "txtReOrdProduct";
            this.txtReOrdProduct.Size = new System.Drawing.Size(193, 26);
            this.txtReOrdProduct.TabIndex = 45;
            this.txtReOrdProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReOrdProduct_KeyPress);
            // 
            // txtPriceProduct
            // 
<<<<<<< HEAD
            this.txtPriceProduct.Location = new System.Drawing.Point(351, 406);
            this.txtPriceProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.txtPriceProduct.Location = new System.Drawing.Point(261, 323);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.txtPriceProduct.Multiline = true;
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(193, 26);
            this.txtPriceProduct.TabIndex = 44;
            this.txtPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceProduct_KeyPress);
            // 
            // txtCostProduct
            // 
<<<<<<< HEAD
            this.txtCostProduct.Location = new System.Drawing.Point(351, 353);
            this.txtCostProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.txtCostProduct.Location = new System.Drawing.Point(261, 280);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.txtCostProduct.Multiline = true;
            this.txtCostProduct.Name = "txtCostProduct";
            this.txtCostProduct.Size = new System.Drawing.Size(193, 26);
            this.txtCostProduct.TabIndex = 43;
            this.txtCostProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostProduct_KeyPress);
            // 
            // txtDesProduct
            // 
<<<<<<< HEAD
            this.txtDesProduct.Location = new System.Drawing.Point(351, 156);
            this.txtDesProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.txtDesProduct.Location = new System.Drawing.Point(261, 120);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.txtDesProduct.Multiline = true;
            this.txtDesProduct.Name = "txtDesProduct";
            this.txtDesProduct.Size = new System.Drawing.Size(193, 62);
            this.txtDesProduct.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label11.Location = new System.Drawing.Point(199, 516);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label11.Location = new System.Drawing.Point(147, 412);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 30);
            this.label11.TabIndex = 39;
            this.label11.Text = "Existencia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label10.Location = new System.Drawing.Point(144, 406);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label10.Location = new System.Drawing.Point(106, 323);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 30);
            this.label10.TabIndex = 38;
            this.label10.Text = "Precio unitario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label9.Location = new System.Drawing.Point(144, 460);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label9.Location = new System.Drawing.Point(106, 367);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 30);
            this.label9.TabIndex = 37;
            this.label9.Text = "Fecha de alta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label7.Location = new System.Drawing.Point(92, 574);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label7.Location = new System.Drawing.Point(67, 459);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 30);
            this.label7.TabIndex = 35;
            this.label7.Text = "Punto de Reorden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label6.Location = new System.Drawing.Point(245, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label6.Location = new System.Drawing.Point(182, 280);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label5.Location = new System.Drawing.Point(87, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label5.Location = new System.Drawing.Point(63, 234);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Unidad de medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label4.Location = new System.Drawing.Point(132, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label4.Location = new System.Drawing.Point(97, 190);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(175, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label3.Location = new System.Drawing.Point(129, 120);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 56);
            this.label2.TabIndex = 30;
            this.label2.Text = "Productos";
            // 
<<<<<<< HEAD
            // txtExistenceProduct
            // 
            this.txtExistenceProduct.Location = new System.Drawing.Point(351, 516);
            this.txtExistenceProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            // txtIdProduct
            // 
            this.txtIdProduct.Location = new System.Drawing.Point(261, 75);
            this.txtIdProduct.Multiline = true;
            this.txtIdProduct.Name = "txtIdProduct";
            this.txtIdProduct.Size = new System.Drawing.Size(146, 22);
            this.txtIdProduct.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código de Producto";
            // 
            // txtExistenceProduct
            // 
            this.txtExistenceProduct.Location = new System.Drawing.Point(261, 412);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.txtExistenceProduct.Multiline = true;
            this.txtExistenceProduct.Name = "txtExistenceProduct";
            this.txtExistenceProduct.Size = new System.Drawing.Size(193, 26);
            this.txtExistenceProduct.TabIndex = 55;
            this.txtExistenceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistenceProduct_KeyPress);
            // 
            // dtpDateProduct
            // 
<<<<<<< HEAD
            this.dtpDateProduct.Location = new System.Drawing.Point(351, 463);
            this.dtpDateProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.dtpDateProduct.Location = new System.Drawing.Point(261, 369);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.dtpDateProduct.Name = "dtpDateProduct";
            this.dtpDateProduct.Size = new System.Drawing.Size(193, 22);
            this.dtpDateProduct.TabIndex = 56;
            // 
            // cbDepartamentProduct
            // 
            this.cbDepartamentProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamentProduct.FormattingEnabled = true;
            this.cbDepartamentProduct.Items.AddRange(new object[] {
            "Frutería",
            "Carnes",
            "Lacteos",
            "Bebidas"});
<<<<<<< HEAD
            this.cbDepartamentProduct.Location = new System.Drawing.Point(351, 244);
            this.cbDepartamentProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.cbDepartamentProduct.Location = new System.Drawing.Point(261, 191);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.cbDepartamentProduct.Name = "cbDepartamentProduct";
            this.cbDepartamentProduct.Size = new System.Drawing.Size(193, 24);
            this.cbDepartamentProduct.TabIndex = 57;
            this.cbDepartamentProduct.SelectedIndexChanged += new System.EventHandler(this.cbDepartamentProduct_SelectedIndexChanged);
            // 
            // cbMeasureProduct
            // 
            this.cbMeasureProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeasureProduct.FormattingEnabled = true;
<<<<<<< HEAD
            this.cbMeasureProduct.Location = new System.Drawing.Point(351, 297);
            this.cbMeasureProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.cbMeasureProduct.Items.AddRange(new object[] {
            "Kilogramos",
            "Gramos",
            "Litros",
            "Mililitros",
            "Piezas"});
            this.cbMeasureProduct.Location = new System.Drawing.Point(261, 234);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.cbMeasureProduct.Name = "cbMeasureProduct";
            this.cbMeasureProduct.Size = new System.Drawing.Size(193, 24);
            this.cbMeasureProduct.TabIndex = 58;
            this.cbMeasureProduct.SelectedIndexChanged += new System.EventHandler(this.cbMeasureProduct_SelectedIndexChanged);
            // 
            // dtpChangeDateProduct
            // 
            this.dtpChangeDateProduct.Enabled = false;
<<<<<<< HEAD
            this.dtpChangeDateProduct.Location = new System.Drawing.Point(351, 630);
            this.dtpChangeDateProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.dtpChangeDateProduct.Location = new System.Drawing.Point(261, 505);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.dtpChangeDateProduct.Name = "dtpChangeDateProduct";
            this.dtpChangeDateProduct.Size = new System.Drawing.Size(193, 22);
            this.dtpChangeDateProduct.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label8.Location = new System.Drawing.Point(99, 628);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label8.Location = new System.Drawing.Point(72, 503);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 30);
            this.label8.TabIndex = 59;
            this.label8.Text = "Fecha de cambio";
            // 
<<<<<<< HEAD
=======
            // txtActiveProduct
            // 
            this.txtActiveProduct.Location = new System.Drawing.Point(261, 553);
            this.txtActiveProduct.Multiline = true;
            this.txtActiveProduct.Name = "txtActiveProduct";
            this.txtActiveProduct.Size = new System.Drawing.Size(146, 22);
            this.txtActiveProduct.TabIndex = 62;
            // 
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label13.Location = new System.Drawing.Point(113, 689);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label13.Location = new System.Drawing.Point(83, 553);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 30);
            this.label13.TabIndex = 61;
            this.label13.Text = "Producto Activo";
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dataGridProduct.Location = new System.Drawing.Point(607, 148);
            this.dataGridProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdProd,
            this.desProdu,
            this.DepInv,
            this.UniInv,
            this.CosInv,
            this.PreInv,
            this.fechProd,
            this.ExisInv,
            this.ReorProd,
            this.CambioPro,
            this.actiPro});
            this.dataGridProduct.Location = new System.Drawing.Point(455, 120);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersWidth = 51;
            this.dataGridProduct.Size = new System.Drawing.Size(603, 479);
            this.dataGridProduct.TabIndex = 98;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellClick);
            // 
<<<<<<< HEAD
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(351, 110);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameProduct.Multiline = true;
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(193, 26);
            this.txtNameProduct.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(65, 110);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(264, 30);
            this.label14.TabIndex = 99;
            this.label14.Text = "Nombre de Producto";
            // 
            // cbActiveProduct
            // 
            this.cbActiveProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActiveProduct.FormattingEnabled = true;
            this.cbActiveProduct.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbActiveProduct.Location = new System.Drawing.Point(351, 689);
            this.cbActiveProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbActiveProduct.Name = "cbActiveProduct";
            this.cbActiveProduct.Size = new System.Drawing.Size(193, 24);
            this.cbActiveProduct.TabIndex = 101;
            this.cbActiveProduct.SelectedIndexChanged += new System.EventHandler(this.cbActiveProduct_SelectedIndexChanged);
=======
            // codProdProd
            // 
            this.codProdProd.HeaderText = "Código del Producto";
            this.codProdProd.Name = "codProdProd";
            this.codProdProd.ReadOnly = true;
            // 
            // desProdu
            // 
            this.desProdu.HeaderText = "Descripción";
            this.desProdu.Name = "desProdu";
            this.desProdu.ReadOnly = true;
            // 
            // DepInv
            // 
            this.DepInv.HeaderText = "Departamento";
            this.DepInv.Name = "DepInv";
            this.DepInv.ReadOnly = true;
            // 
            // UniInv
            // 
            this.UniInv.HeaderText = "Unidad de Medida";
            this.UniInv.Name = "UniInv";
            this.UniInv.ReadOnly = true;
            // 
            // CosInv
            // 
            this.CosInv.HeaderText = "Costo";
            this.CosInv.Name = "CosInv";
            this.CosInv.ReadOnly = true;
            // 
            // PreInv
            // 
            this.PreInv.HeaderText = "Precio Unitario";
            this.PreInv.Name = "PreInv";
            this.PreInv.ReadOnly = true;
            // 
            // fechProd
            // 
            this.fechProd.HeaderText = "Fecha de alta";
            this.fechProd.Name = "fechProd";
            this.fechProd.ReadOnly = true;
            // 
            // ExisInv
            // 
            this.ExisInv.HeaderText = "Existencia";
            this.ExisInv.Name = "ExisInv";
            this.ExisInv.ReadOnly = true;
            // 
            // ReorProd
            // 
            this.ReorProd.HeaderText = "Punto de Reorden";
            this.ReorProd.Name = "ReorProd";
            this.ReorProd.ReadOnly = true;
            // 
            // CambioPro
            // 
            this.CambioPro.HeaderText = "Fecha de cambio";
            this.CambioPro.Name = "CambioPro";
            this.CambioPro.ReadOnly = true;
            // 
            // actiPro
            // 
            this.actiPro.HeaderText = "Producto Activo";
            this.actiPro.Name = "actiPro";
            this.actiPro.ReadOnly = true;
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            // 
            // productsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1245, 777);
            this.Controls.Add(this.cbActiveProduct);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.label14);
=======
            this.ClientSize = new System.Drawing.Size(934, 631);
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpChangeDateProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbMeasureProduct);
            this.Controls.Add(this.cbDepartamentProduct);
            this.Controls.Add(this.dtpDateProduct);
            this.Controls.Add(this.txtExistenceProduct);
            this.Controls.Add(this.txtFilterProduct);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtReOrdProduct);
            this.Controls.Add(this.txtPriceProduct);
            this.Controls.Add(this.txtCostProduct);
            this.Controls.Add(this.txtDesProduct);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "productsScreen";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.productsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtReOrdProduct;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtCostProduct;
        private System.Windows.Forms.TextBox txtDesProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExistenceProduct;
        private System.Windows.Forms.DateTimePicker dtpDateProduct;
        private System.Windows.Forms.ComboBox cbMeasureProduct;
        private System.Windows.Forms.DateTimePicker dtpChangeDateProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridProduct;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbActiveProduct;
        private System.Windows.Forms.ComboBox cbDepartamentProduct;
=======
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn desProdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CosInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExisInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CambioPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn actiPro;
>>>>>>> parent of a78bc4f (Listo, espero jsjsjs)
    }
}