﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class DiscountsScreen : Form
    {
        public DiscountsScreen()
        {
            InitializeComponent();
            dataGridDiscounts.Rows[0].Cells[0].Value = "Agua Mineral 100ml";
            dataGridDiscounts.Rows[0].Cells[1].Value = "10%";
            dataGridDiscounts.Rows[0].Cells[2].Value = "08/09/2022";
            dataGridDiscounts.Rows[0].Cells[3].Value = "10/09/2022";
        }
    }
}
