using System;
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
    public partial class JobOrderStatus : Form
    {
        Main_P main;

        public JobOrderStatus(Main_P main1)
        {
            InitializeComponent();
            main = main1;
        }

        private void JobOrderStatus_Load(object sender, EventArgs e)
        {
            main.lblChange.Text = "작업지시 현황";
        }
    }
}
