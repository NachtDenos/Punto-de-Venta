﻿namespace Punto_de_Venta.Pantallas
{
    partial class CashRegisterToUseWND
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseRegisterToUserWnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterToUseCB = new System.Windows.Forms.ComboBox();
            this.GoToSellerScreenbUTTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.CloseRegisterToUserWnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 76);
            this.panel1.TabIndex = 0;
            // 
            // CloseRegisterToUserWnd
            // 
            this.CloseRegisterToUserWnd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CloseRegisterToUserWnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseRegisterToUserWnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseRegisterToUserWnd.Location = new System.Drawing.Point(738, 3);
            this.CloseRegisterToUserWnd.Name = "CloseRegisterToUserWnd";
            this.CloseRegisterToUserWnd.Size = new System.Drawing.Size(59, 42);
            this.CloseRegisterToUserWnd.TabIndex = 1;
            this.CloseRegisterToUserWnd.Text = "X";
            this.CloseRegisterToUserWnd.UseVisualStyleBackColor = true;
            this.CloseRegisterToUserWnd.Click += new System.EventHandler(this.CloseRegisterToUserWnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja a cobrar";
            // 
            // RegisterToUseCB
            // 
            this.RegisterToUseCB.FormattingEnabled = true;
            this.RegisterToUseCB.Items.AddRange(new object[] {
            "Caja 1",
            "Caja 2",
            "Caja 3"});
            this.RegisterToUseCB.Location = new System.Drawing.Point(295, 104);
            this.RegisterToUseCB.Name = "RegisterToUseCB";
            this.RegisterToUseCB.Size = new System.Drawing.Size(220, 24);
            this.RegisterToUseCB.TabIndex = 1;
            this.RegisterToUseCB.Text = "Seleccione la caja a cobrar";
            this.RegisterToUseCB.SelectedIndexChanged += new System.EventHandler(this.RegisterToUseCB_SelectedIndexChanged);
            // 
            // GoToSellerScreenbUTTN
            // 
            this.GoToSellerScreenbUTTN.BackColor = System.Drawing.SystemColors.Info;
            this.GoToSellerScreenbUTTN.FlatAppearance.BorderSize = 0;
            this.GoToSellerScreenbUTTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToSellerScreenbUTTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GoToSellerScreenbUTTN.Location = new System.Drawing.Point(340, 218);
            this.GoToSellerScreenbUTTN.Name = "GoToSellerScreenbUTTN";
            this.GoToSellerScreenbUTTN.Size = new System.Drawing.Size(141, 56);
            this.GoToSellerScreenbUTTN.TabIndex = 2;
            this.GoToSellerScreenbUTTN.Text = "Listo";
            this.GoToSellerScreenbUTTN.UseVisualStyleBackColor = false;
            this.GoToSellerScreenbUTTN.Click += new System.EventHandler(this.GoToSellerScreenbUTTN_Click);
            // 
            // CashRegisterToUseWND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.GoToSellerScreenbUTTN);
            this.Controls.Add(this.RegisterToUseCB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashRegisterToUseWND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashRegisterToUseWND";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RegisterToUseCB;
        private System.Windows.Forms.Button GoToSellerScreenbUTTN;
        private System.Windows.Forms.Button CloseRegisterToUserWnd;
    }
}