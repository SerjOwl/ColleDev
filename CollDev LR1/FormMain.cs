using CollDev_LR1;
using IS.database;
using System.Data;
using System.IO;

namespace CollDev_LR1
{
    public partial class FormMain : Form
    {
        List<string> tableNames = new List<string>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            DataTable dt = DataBase.GetFromChosenTable(TableComboBox.Text);
            dataGridView1.DataSource = dt;
        }

        private void OnTableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void Form1_onLoad(object sender, EventArgs e)
        {
            tableNames = DataBase.GetTableNames();
            TableComboBox.DataSource = tableNames;
        }

        private void InsertBTN_onClick(object sender, EventArgs e)
        {
            switch (TableComboBox.Text)
            {
                case ("Worker"):
                    {
                        FormWorker temp = new FormWorker();
                        temp.ShowDialog(this);
                    }
                    break;
                case ("Job"):
                    {
                        FormJob temp = new FormJob();
                        temp.ShowDialog(this);
                    }
                    break;
            }
            Refresh();
        }

        private void CreateDocBTN_onClick(object sender, EventArgs e)
        {
            DataTable dtData = DataBase.GetDocData();
            DataTable dtInfo = DataBase.GetDocAddInfo();
            int counter = 0;
            decimal summaryPay = 0;
            string text = "ќтчет о выплатах сотрудникам за мес€ц\n";
            text +=       "-------------------------------------\n";
            for (int i = 0; i < dtInfo.Rows.Count; i++)
            {
                decimal departmentPay = 0;
                text += $"{dtInfo.Rows[i].Field<string>(0)}\n";
                for (int j = 0; j < dtInfo.Rows[i].Field<long>(1); j++)
                {
                    departmentPay += dtData.Rows[j + counter].Field<decimal>(1);
                    text += $"{dtData.Rows[j + counter].Field<string>(0)} - {dtData.Rows[j + counter].Field<decimal>(1)}\n";
                }
                counter += Convert.ToInt32( dtInfo.Rows[i].Field<long>(1));
                text += $"—уммарные расходы по отделу: {departmentPay}\n";
                text += "-------------------------------------\n";
                summaryPay += departmentPay;
            }
            text += $"—уммарные расходы по всем отделам: {summaryPay}";
            MessageBox.Show(text);
        }
    }
}