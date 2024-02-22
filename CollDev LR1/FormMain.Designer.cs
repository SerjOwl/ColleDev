namespace CollDev_LR1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            TableComboBox = new ComboBox();
            InsertBTN = new Button();
            CreateDocBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(172, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(738, 428);
            dataGridView1.TabIndex = 0;
            // 
            // TableComboBox
            // 
            TableComboBox.FormattingEnabled = true;
            TableComboBox.Location = new Point(10, 9);
            TableComboBox.Margin = new Padding(3, 2, 3, 2);
            TableComboBox.Name = "TableComboBox";
            TableComboBox.Size = new Size(157, 23);
            TableComboBox.TabIndex = 1;
            TableComboBox.SelectedIndexChanged += OnTableComboBox_SelectedIndexChanged;
            // 
            // InsertBTN
            // 
            InsertBTN.Location = new Point(10, 305);
            InsertBTN.Margin = new Padding(3, 2, 3, 2);
            InsertBTN.Name = "InsertBTN";
            InsertBTN.Size = new Size(157, 23);
            InsertBTN.TabIndex = 2;
            InsertBTN.Text = "Добавить запись";
            InsertBTN.UseVisualStyleBackColor = true;
            InsertBTN.Click += InsertBTN_onClick;
            // 
            // CreateDocBTN
            // 
            CreateDocBTN.Location = new Point(10, 341);
            CreateDocBTN.Margin = new Padding(3, 2, 3, 2);
            CreateDocBTN.Name = "CreateDocBTN";
            CreateDocBTN.Size = new Size(157, 22);
            CreateDocBTN.TabIndex = 3;
            CreateDocBTN.Text = "Создать отчет";
            CreateDocBTN.UseVisualStyleBackColor = true;
            CreateDocBTN.Click += CreateDocBTN_onClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 446);
            Controls.Add(CreateDocBTN);
            Controls.Add(InsertBTN);
            Controls.Add(TableComboBox);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_onLoad;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox TableComboBox;
        private Button InsertBTN;
        private Button CreateDocBTN;
    }
}