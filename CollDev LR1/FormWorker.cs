using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IS.database;

namespace CollDev_LR1
{
    public partial class FormWorker : Form
    {
        public FormWorker()
        {
            InitializeComponent();
        }

        private void ConfirmBTN_OnClick(object sender, EventArgs e)
        {
            DataBase.CreateNewWorker(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
            this.Close();
        }

        private void CancelBTN_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
