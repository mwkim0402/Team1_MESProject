﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldOperationForm
{
    public partial class CreatePalette : Form
    {
        Main_P main;

        public CreatePalette(Main_P main1)
        {
            InitializeComponent();
            main = main1;
        }
    }
}
