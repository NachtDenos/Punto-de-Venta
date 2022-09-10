
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
            this.NoArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.NoPRod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProCarr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarritoSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProductSales
            // 
            this.dataGridProductSales.AllowUserToDeleteRows = false;
            this.dataGridProductSales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridProductSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoArt,
            this.Pro});
            this.dataGridProductSales.Location = new System.Drawing.Point(223, 115);
            this.dataGridProductSales.Name = "dataGridProductSales";
            this.dataGridProductSales.ReadOnly = true;
            this.dataGridProductSales.Size = new System.Drawing.Size(244, 349);
            this.dataGridProductSales.TabIndex = 0;
            // 
            // dataGridCarritoSales
            // 
            this.dataGridCarritoSales.AllowUserToDeleteRows = false;
            this.dataGridCarritoSales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridCarritoSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarritoSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoPRod,
            this.ProCarr});
            this.dataGridCarritoSales.Location = new System.Drawing.Point(495, 115);
            this.dataGridCarritoSales.Name = "dataGridCarritoSales";
            this.dataGridCarritoSales.ReadOnly = true;
            this.dataGridCarritoSales.Size = new System.Drawing.Size(244, 349);
            this.dataGridCarritoSales.TabIndex = 1;
            // 
            // btnAddSales
            // 
            this.btnAddSales.BackColor = System.Drawing.Color.Green;
            this.btnAddSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSales.Location = new System.Drawing.Point(269, 470);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(139, 51);
            this.btnAddSales.TabIndex = 23;
            this.btnAddSales.Text = "Agregar";
            this.btnAddSales.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSales
            // 
            this.btnDeleteSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteSales.Location = new System.Drawing.Point(538, 470);
            this.btnDeleteSales.Name = "btnDeleteSales";
            this.btnDeleteSales.Size = new System.Drawing.Size(139, 51);
            this.btnDeleteSales.TabIndex = 25;
            this.btnDeleteSales.Text = "Eliminar";
            this.btnDeleteSales.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Carrito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "No. de producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre del";
            // 
            // txtNumberSales
            // 
            this.txtNumberSales.Location = new System.Drawing.Point(25, 165);
            this.txtNumberSales.Multiline = true;
            this.txtNumberSales.Name = "txtNumberSales";
            this.txtNumberSales.Size = new System.Drawing.Size(146, 22);
            this.txtNumberSales.TabIndex = 31;
            // 
            // txtQuantitySales
            // 
            this.txtQuantitySales.Location = new System.Drawing.Point(25, 360);
            this.txtQuantitySales.Multiline = true;
            this.txtQuantitySales.Name = "txtQuantitySales";
            this.txtQuantitySales.Size = new System.Drawing.Size(146, 22);
            this.txtQuantitySales.TabIndex = 32;
            // 
            // txtNameSales
            // 
            this.txtNameSales.Location = new System.Drawing.Point(25, 238);
            this.txtNameSales.Multiline = true;
            this.txtNameSales.Name = "txtNameSales";
            this.txtNameSales.Size = new System.Drawing.Size(146, 22);
            this.txtNameSales.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 580);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "$ 00.00";
            // 
            // btnPaySales
            // 
            this.btnPaySales.BackColor = System.Drawing.Color.Green;
            this.btnPaySales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaySales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaySales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPaySales.Location = new System.Drawing.Point(769, 551);
            this.btnPaySales.Name = "btnPaySales";
            this.btnPaySales.Size = new System.Drawing.Size(139, 51);
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
            this.btnQuickSearchSales.Location = new System.Drawing.Point(407, 551);
            this.btnQuickSearchSales.Name = "btnQuickSearchSales";
            this.btnQuickSearchSales.Size = new System.Drawing.Size(139, 51);
            this.btnQuickSearchSales.TabIndex = 37;
            this.btnQuickSearchSales.Text = "Consulta rápida";
            this.btnQuickSearchSales.UseVisualStyleBackColor = false;
            this.btnQuickSearchSales.Click += new System.EventHandler(this.btnQuickSearchSales_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 44);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ventas";
            // 
            // txtQuantityDeleteSales
            // 
            this.txtQuantityDeleteSales.Location = new System.Drawing.Point(745, 360);
            this.txtQuantityDeleteSales.Multiline = true;
            this.txtQuantityDeleteSales.Name = "txtQuantityDeleteSales";
            this.txtQuantityDeleteSales.Size = new System.Drawing.Size(163, 22);
            this.txtQuantityDeleteSales.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(741, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 22);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cantidad a eliminar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 41;
            this.label10.Text = "Filtros:";
            // 
            // NoArt
            // 
            this.NoArt.HeaderText = "No. de Producto";
            this.NoArt.Name = "NoArt";
            this.NoArt.ReadOnly = true;
            // 
            // Pro
            // 
            this.Pro.HeaderText = "Producto";
            this.Pro.Name = "Pro";
            this.Pro.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 22);
            this.label11.TabIndex = 42;
            this.label11.Text = "producto";
            // 
            // NoPRod
            // 
            this.NoPRod.HeaderText = "No. de Producto";
            this.NoPRod.Name = "NoPRod";
            this.NoPRod.ReadOnly = true;
            // 
            // ProCarr
            // 
            this.ProCarr.HeaderText = "Producto";
            this.ProCarr.Name = "ProCarr";
            this.ProCarr.ReadOnly = true;
            // 
            // SalesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPRod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCarr;
    }
}