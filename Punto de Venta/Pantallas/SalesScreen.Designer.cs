﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarritoSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProductSales
            // 
            this.dataGridProductSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductSales.Location = new System.Drawing.Point(228, 115);
            this.dataGridProductSales.Name = "dataGridProductSales";
            this.dataGridProductSales.Size = new System.Drawing.Size(244, 349);
            this.dataGridProductSales.TabIndex = 0;
            // 
            // dataGridCarritoSales
            // 
            this.dataGridCarritoSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarritoSales.Location = new System.Drawing.Point(525, 115);
            this.dataGridCarritoSales.Name = "dataGridCarritoSales";
            this.dataGridCarritoSales.Size = new System.Drawing.Size(244, 349);
            this.dataGridCarritoSales.TabIndex = 1;
            // 
            // btnAddSales
            // 
            this.btnAddSales.BackColor = System.Drawing.Color.Green;
            this.btnAddSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSales.Location = new System.Drawing.Point(281, 470);
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
            this.btnDeleteSales.Location = new System.Drawing.Point(574, 470);
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
            this.label1.Location = new System.Drawing.Point(301, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Carrito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "No. de Artículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre del artículo";
            // 
            // txtNumberSales
            // 
            this.txtNumberSales.Location = new System.Drawing.Point(36, 150);
            this.txtNumberSales.Multiline = true;
            this.txtNumberSales.Name = "txtNumberSales";
            this.txtNumberSales.Size = new System.Drawing.Size(146, 22);
            this.txtNumberSales.TabIndex = 31;
            // 
            // txtQuantitySales
            // 
            this.txtQuantitySales.Location = new System.Drawing.Point(36, 228);
            this.txtQuantitySales.Multiline = true;
            this.txtQuantitySales.Name = "txtQuantitySales";
            this.txtQuantitySales.Size = new System.Drawing.Size(146, 22);
            this.txtQuantitySales.TabIndex = 32;
            // 
            // txtNameSales
            // 
            this.txtNameSales.Location = new System.Drawing.Point(36, 301);
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
            // 
            // btnQuickSearchSales
            // 
            this.btnQuickSearchSales.BackColor = System.Drawing.Color.Navy;
            this.btnQuickSearchSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickSearchSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickSearchSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuickSearchSales.Location = new System.Drawing.Point(420, 551);
            this.btnQuickSearchSales.Name = "btnQuickSearchSales";
            this.btnQuickSearchSales.Size = new System.Drawing.Size(139, 51);
            this.btnQuickSearchSales.TabIndex = 37;
            this.btnQuickSearchSales.Text = "Consulta rápida";
            this.btnQuickSearchSales.UseVisualStyleBackColor = false;
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
            // SalesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 631);
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
    }
}