
namespace Punto_de_Venta
{
    partial class QuickSearchScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickSearchScreen));
            this.dataGridQuickSearch = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCashRegister = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codQuick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameQuick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceQuick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existQuick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuickSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQuickSearch
            // 
            this.dataGridQuickSearch.AllowUserToDeleteRows = false;
            this.dataGridQuickSearch.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridQuickSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuickSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codQuick,
            this.nameQuick,
            this.priceQuick,
            this.existQuick});
            this.dataGridQuickSearch.Location = new System.Drawing.Point(236, 85);
            this.dataGridQuickSearch.Name = "dataGridQuickSearch";
            this.dataGridQuickSearch.ReadOnly = true;
            this.dataGridQuickSearch.Size = new System.Drawing.Size(326, 458);
            this.dataGridQuickSearch.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Consulta Rápida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código del artículo";
            // 
            // txtIdCashRegister
            // 
            this.txtIdCashRegister.Location = new System.Drawing.Point(16, 120);
            this.txtIdCashRegister.Multiline = true;
            this.txtIdCashRegister.Name = "txtIdCashRegister";
            this.txtIdCashRegister.Size = new System.Drawing.Size(194, 22);
            this.txtIdCashRegister.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 196);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre del artículo";
            // 
            // codQuick
            // 
            this.codQuick.HeaderText = "Código";
            this.codQuick.Name = "codQuick";
            this.codQuick.ReadOnly = true;
            // 
            // nameQuick
            // 
            this.nameQuick.HeaderText = "Nombre";
            this.nameQuick.Name = "nameQuick";
            this.nameQuick.ReadOnly = true;
            // 
            // priceQuick
            // 
            this.priceQuick.HeaderText = "Precio";
            this.priceQuick.Name = "priceQuick";
            this.priceQuick.ReadOnly = true;
            // 
            // existQuick
            // 
            this.existQuick.HeaderText = "Existencia";
            this.existQuick.Name = "existQuick";
            this.existQuick.ReadOnly = true;
            // 
            // QuickSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(595, 586);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdCashRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridQuickSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuickSearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta rápida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuickSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridQuickSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCashRegister;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codQuick;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameQuick;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceQuick;
        private System.Windows.Forms.DataGridViewTextBoxColumn existQuick;
    }
}