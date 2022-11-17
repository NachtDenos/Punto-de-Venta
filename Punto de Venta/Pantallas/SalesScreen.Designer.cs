
namespace Punto_de_Venta
{
    partial class SalesScreen
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
            this.dataGridProductSales = new System.Windows.Forms.DataGridView();
            this.dataGridCarritoSales = new System.Windows.Forms.DataGridView();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.btnDeleteSales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberSales = new System.Windows.Forms.TextBox();
            this.txtQuantitySales = new System.Windows.Forms.TextBox();
            this.txtNameSales = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPaySales = new System.Windows.Forms.Button();
            this.btnQuickSearchSales = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantityDeleteSales = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFilterSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarritoSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProductSales
            // 
            this.dataGridProductSales.AllowUserToAddRows = false;
            this.dataGridProductSales.AllowUserToDeleteRows = false;
            this.dataGridProductSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProductSales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridProductSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductSales.Location = new System.Drawing.Point(297, 142);
            this.dataGridProductSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridProductSales.Name = "dataGridProductSales";
            this.dataGridProductSales.ReadOnly = true;
            this.dataGridProductSales.RowHeadersWidth = 51;
            this.dataGridProductSales.Size = new System.Drawing.Size(325, 430);
            this.dataGridProductSales.TabIndex = 0;
            this.dataGridProductSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductSales_CellClick);
            // 
            // dataGridCarritoSales
            // 
            this.dataGridCarritoSales.AllowUserToAddRows = false;
            this.dataGridCarritoSales.AllowUserToDeleteRows = false;
            this.dataGridCarritoSales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridCarritoSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarritoSales.Location = new System.Drawing.Point(660, 142);
            this.dataGridCarritoSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridCarritoSales.Name = "dataGridCarritoSales";
            this.dataGridCarritoSales.ReadOnly = true;
            this.dataGridCarritoSales.RowHeadersWidth = 51;
            this.dataGridCarritoSales.Size = new System.Drawing.Size(325, 430);
            this.dataGridCarritoSales.TabIndex = 1;
            // 
            // btnAddSales
            // 
            this.btnAddSales.BackColor = System.Drawing.Color.Green;
            this.btnAddSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSales.Location = new System.Drawing.Point(359, 578);
            this.btnAddSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(185, 63);
            this.btnAddSales.TabIndex = 23;
            this.btnAddSales.Text = "Agregar";
            this.btnAddSales.UseVisualStyleBackColor = false;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // btnDeleteSales
            // 
            this.btnDeleteSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteSales.Location = new System.Drawing.Point(717, 578);
            this.btnDeleteSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteSales.Name = "btnDeleteSales";
            this.btnDeleteSales.Size = new System.Drawing.Size(185, 63);
            this.btnDeleteSales.TabIndex = 25;
            this.btnDeleteSales.Text = "Eliminar";
            this.btnDeleteSales.UseVisualStyleBackColor = false;
            this.btnDeleteSales.Click += new System.EventHandler(this.btnDeleteSales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(781, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Carrito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "No. de producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 460);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre del";
            // 
            // txtNumberSales
            // 
            this.txtNumberSales.Location = new System.Drawing.Point(33, 203);
            this.txtNumberSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumberSales.Multiline = true;
            this.txtNumberSales.Name = "txtNumberSales";
            this.txtNumberSales.Size = new System.Drawing.Size(193, 26);
            this.txtNumberSales.TabIndex = 31;
            this.txtNumberSales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberSales_KeyPress);
            // 
            // txtQuantitySales
            // 
            this.txtQuantitySales.Location = new System.Drawing.Point(33, 505);
            this.txtQuantitySales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantitySales.Multiline = true;
            this.txtQuantitySales.Name = "txtQuantitySales";
            this.txtQuantitySales.Size = new System.Drawing.Size(193, 26);
            this.txtQuantitySales.TabIndex = 32;
            this.txtQuantitySales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantitySales_KeyPress);
            // 
            // txtNameSales
            // 
            this.txtNameSales.Location = new System.Drawing.Point(33, 293);
            this.txtNameSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameSales.Multiline = true;
            this.txtNameSales.Name = "txtNameSales";
            this.txtNameSales.Size = new System.Drawing.Size(193, 26);
            this.txtNameSales.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 678);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 61);
            this.label6.TabIndex = 34;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 681);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 61);
            this.label7.TabIndex = 35;
            this.label7.Text = "$ 00.00";
            // 
            // btnPaySales
            // 
            this.btnPaySales.BackColor = System.Drawing.Color.Green;
            this.btnPaySales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaySales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaySales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPaySales.Location = new System.Drawing.Point(1025, 678);
            this.btnPaySales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaySales.Name = "btnPaySales";
            this.btnPaySales.Size = new System.Drawing.Size(185, 63);
            this.btnPaySales.TabIndex = 36;
            this.btnPaySales.Text = "Pagar";
            this.btnPaySales.UseVisualStyleBackColor = false;
            this.btnPaySales.Click += new System.EventHandler(this.btnPaySales_Click);
            // 
            // btnQuickSearchSales
            // 
            this.btnQuickSearchSales.BackColor = System.Drawing.Color.Navy;
            this.btnQuickSearchSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickSearchSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickSearchSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuickSearchSales.Location = new System.Drawing.Point(543, 678);
            this.btnQuickSearchSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuickSearchSales.Name = "btnQuickSearchSales";
            this.btnQuickSearchSales.Size = new System.Drawing.Size(185, 63);
            this.btnQuickSearchSales.TabIndex = 37;
            this.btnQuickSearchSales.Text = "Consulta rápida";
            this.btnQuickSearchSales.UseVisualStyleBackColor = false;
            this.btnQuickSearchSales.Click += new System.EventHandler(this.btnQuickSearchSales_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 56);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ventas";
            // 
            // txtQuantityDeleteSales
            // 
            this.txtQuantityDeleteSales.Location = new System.Drawing.Point(993, 443);
            this.txtQuantityDeleteSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantityDeleteSales.Multiline = true;
            this.txtQuantityDeleteSales.Name = "txtQuantityDeleteSales";
            this.txtQuantityDeleteSales.Size = new System.Drawing.Size(216, 26);
            this.txtQuantityDeleteSales.TabIndex = 40;
            this.txtQuantityDeleteSales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityDeleteSales_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(988, 399);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 30);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cantidad a eliminar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 30);
            this.label10.TabIndex = 41;
            this.label10.Text = "Filtros:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 262);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 30);
            this.label11.TabIndex = 42;
            this.label11.Text = "producto";
            // 
            // btnFilterSales
            // 
            this.btnFilterSales.BackColor = System.Drawing.Color.Navy;
            this.btnFilterSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilterSales.Location = new System.Drawing.Point(53, 358);
            this.btnFilterSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilterSales.Name = "btnFilterSales";
            this.btnFilterSales.Size = new System.Drawing.Size(149, 48);
            this.btnFilterSales.TabIndex = 43;
            this.btnFilterSales.Text = "Filtrar";
            this.btnFilterSales.UseVisualStyleBackColor = false;
            this.btnFilterSales.Click += new System.EventHandler(this.btnFilterSales_Click);
            // 
            // SalesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1245, 777);
            this.Controls.Add(this.btnFilterSales);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQuantityDeleteSales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnQuickSearchSales);
            this.Controls.Add(this.btnPaySales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNameSales);
            this.Controls.Add(this.txtQuantitySales);
            this.Controls.Add(this.txtNumberSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteSales);
            this.Controls.Add(this.btnAddSales);
            this.Controls.Add(this.dataGridCarritoSales);
            this.Controls.Add(this.dataGridProductSales);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalesScreen";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarritoSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProductSales;
        private System.Windows.Forms.DataGridView dataGridCarritoSales;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.Button btnDeleteSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberSales;
        private System.Windows.Forms.TextBox txtQuantitySales;
        private System.Windows.Forms.TextBox txtNameSales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPaySales;
        private System.Windows.Forms.Button btnQuickSearchSales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantityDeleteSales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFilterSales;
    }
}