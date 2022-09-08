namespace Punto_de_Venta
{
    partial class LoginScreenWnD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreenWnD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameSQLSideTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassawordUSRsql = new System.Windows.Forms.TextBox();
            this.LoginSQLbutton = new System.Windows.Forms.Button();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 466);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.8F);
            this.label1.Location = new System.Drawing.Point(408, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // UserNameSQLSideTextBox
            // 
            this.UserNameSQLSideTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UserNameSQLSideTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameSQLSideTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameSQLSideTextBox.Location = new System.Drawing.Point(267, 161);
            this.UserNameSQLSideTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserNameSQLSideTextBox.Multiline = true;
            this.UserNameSQLSideTextBox.Name = "UserNameSQLSideTextBox";
            this.UserNameSQLSideTextBox.Size = new System.Drawing.Size(479, 60);
            this.UserNameSQLSideTextBox.TabIndex = 3;
            this.UserNameSQLSideTextBox.Text = "Introduzca el Usuario";
            this.UserNameSQLSideTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // PassawordUSRsql
            // 
            this.PassawordUSRsql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PassawordUSRsql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassawordUSRsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassawordUSRsql.Location = new System.Drawing.Point(267, 272);
            this.PassawordUSRsql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassawordUSRsql.Multiline = true;
            this.PassawordUSRsql.Name = "PassawordUSRsql";
            this.PassawordUSRsql.PasswordChar = '*';
            this.PassawordUSRsql.Size = new System.Drawing.Size(479, 60);
            this.PassawordUSRsql.TabIndex = 5;
            this.PassawordUSRsql.Text = "Contraseña";
            this.PassawordUSRsql.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginSQLbutton
            // 
            this.LoginSQLbutton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LoginSQLbutton.FlatAppearance.BorderSize = 0;
            this.LoginSQLbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginSQLbutton.Location = new System.Drawing.Point(267, 370);
            this.LoginSQLbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginSQLbutton.Name = "LoginSQLbutton";
            this.LoginSQLbutton.Size = new System.Drawing.Size(479, 50);
            this.LoginSQLbutton.TabIndex = 6;
            this.LoginSQLbutton.Text = "Iniciar Sesion";
            this.LoginSQLbutton.UseVisualStyleBackColor = false;
            this.LoginSQLbutton.Click += new System.EventHandler(this.LoginSQLbutton_Click);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.comboBoxUser.Location = new System.Drawing.Point(416, 71);
            this.comboBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(215, 24);
            this.comboBoxUser.TabIndex = 7;
            this.comboBoxUser.Text = "Seleccione su puesto";
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // LoginScreenWnD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 466);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.LoginSQLbutton);
            this.Controls.Add(this.PassawordUSRsql);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserNameSQLSideTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginScreenWnD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginScreenWnD_FormClosed);
            this.Load += new System.EventHandler(this.LoginScreenWnd_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameSQLSideTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassawordUSRsql;
        private System.Windows.Forms.Button LoginSQLbutton;
        private System.Windows.Forms.ComboBox comboBoxUser;
    }
}