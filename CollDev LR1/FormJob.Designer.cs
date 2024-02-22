namespace CollDev_LR1
{
    partial class FormJob
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ConfirmBTN = new Button();
            CancelBTN = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Зарплата";
            // 
            // ConfirmBTN
            // 
            ConfirmBTN.Location = new Point(12, 151);
            ConfirmBTN.Name = "ConfirmBTN";
            ConfirmBTN.Size = new Size(134, 29);
            ConfirmBTN.TabIndex = 4;
            ConfirmBTN.Text = "Подтвердить";
            ConfirmBTN.UseVisualStyleBackColor = true;
            ConfirmBTN.Click += ConfirmBTN_onClick;
            // 
            // CancelBTN
            // 
            CancelBTN.Location = new Point(173, 151);
            CancelBTN.Name = "CancelBTN";
            CancelBTN.Size = new Size(142, 29);
            CancelBTN.TabIndex = 5;
            CancelBTN.Text = "Отмена";
            CancelBTN.UseVisualStyleBackColor = true;
            CancelBTN.Click += CancelBTN_onClick;
            // 
            // FormJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 213);
            Controls.Add(CancelBTN);
            Controls.Add(ConfirmBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormJob";
            Text = "FormJob";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button ConfirmBTN;
        private Button CancelBTN;
    }
}