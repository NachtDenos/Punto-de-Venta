﻿
namespace Punto_de_Venta
{
    partial class InventaryScreen
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridInventary = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInventaryExiste = new System.Windows.Forms.TextBox();
            this.cbInventaryDepart = new System.Windows.Forms.ComboBox();
            this.cbInventaryProduct = new System.Windows.Forms.ComboBox();
            this.cbInventaryMerma = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventary)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 22);
            this.label4.TabIndex = 100;
            this.label4.Text = "Cantidad de existencia mínima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 99;
            this.label3.Text = "Departamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 22);
            this.label12.TabIndex = 98;
            this.label12.Text = "Filtros:";
            // 
            // dataGridInventary
            // 
            this.dataGridInventary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventary.Location = new System.Drawing.Point(86, 194);
            this.dataGridInventary.Name = "dataGridInventary";
            this.dataGridInventary.Size = new System.Drawing.Size(758, 362);
            this.dataGridInventary.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 44);
            this.label2.TabIndex = 96;
            this.label2.Text = "Inventario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "Productos agotados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(778, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 105;
            this.label5.Text = "Con merma";
            // 
            // txtInventaryExiste
            // 
            this.txtInventaryExiste.Location = new System.Drawing.Point(282, 142);
            this.txtInventaryExiste.Multiline = true;
            this.txtInventaryExiste.Name = "txtInventaryExiste";
            this.txtInventaryExiste.Size = new System.Drawing.Size(144, 22);
            this.txtInventaryExiste.TabIndex = 107;
            // 
            // cbInventaryDepart
            // 
            this.cbInventaryDepart.FormattingEnabled = true;
            this.cbInventaryDepart.Items.AddRange(new object[] {
            "Frutería",
            "Carnes",
            "Lacteos",
            "Bebidas",
            "Todos los departamentos"});
            this.cbInventaryDepart.Location = new System.Drawing.Point(28, 143);
            this.cbInventaryDepart.Name = "cbInventaryDepart";
            this.cbInventaryDepart.Size = new System.Drawing.Size(144, 21);
            this.cbInventaryDepart.TabIndex = 108;
            this.cbInventaryDepart.Text = "Seleccionar";
            // 
            // cbInventaryProduct
            // 
            this.cbInventaryProduct.FormattingEnabled = true;
            this.cbInventaryProduct.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbInventaryProduct.Location = new System.Drawing.Point(551, 143);
            this.cbInventaryProduct.Name = "cbInventaryProduct";
            this.cbInventaryProduct.Size = new System.Drawing.Size(144, 21);
            this.cbInventaryProduct.TabIndex = 109;
            this.cbInventaryProduct.Text = "Seleccionar";
            // 
            // cbInventaryMerma
            // 
            this.cbInventaryMerma.FormattingEnabled = true;
            this.cbInventaryMerma.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbInventaryMerma.Location = new System.Drawing.Point(768, 143);
            this.cbInventaryMerma.Name = "cbInventaryMerma";
            this.cbInventaryMerma.Size = new System.Drawing.Size(144, 21);
            this.cbInventaryMerma.TabIndex = 110;
            this.cbInventaryMerma.Text = "Seleccionar";
            // 
            // InventaryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.cbInventaryMerma);
            this.Controls.Add(this.cbInventaryProduct);
            this.Controls.Add(this.cbInventaryDepart);
            this.Controls.Add(this.txtInventaryExiste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridInventary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InventaryScreen";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridInventary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInventaryExiste;
        private System.Windows.Forms.ComboBox cbInventaryDepart;
        private System.Windows.Forms.ComboBox cbInventaryProduct;
        private System.Windows.Forms.ComboBox cbInventaryMerma;
    }
}