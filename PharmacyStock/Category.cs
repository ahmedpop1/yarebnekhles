﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStock
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        AddCategory add;
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (add == null)
            {
                add = new AddCategory();
            }
            add.ShowDialog(); 
        }
    }
}
