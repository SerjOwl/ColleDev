using IS.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollDev_LR1
{
    public partial class FormJob : Form
    {
        public FormJob()
        {
            InitializeComponent();
        }

        private void ConfirmBTN_onClick(object sender, EventArgs e)
        {
            DataBase.CreateNewJob(textBox1.Text, Convert.ToDecimal(textBox2.Text));
            this.Close();
        }

        private void CancelBTN_onClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
