namespace CollDev_LR1
{
    partial class FormWorker
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
            CancelBTN = new Button();
            ConfirmBTN = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // CancelBTN
            // 
            CancelBTN.Location = new Point(176, 261);
            CancelBTN.Name = "CancelBTN";
            CancelBTN.Size = new Size(142, 29);
            CancelBTN.TabIndex = 11;
            CancelBTN.Text = "Отмена";
            CancelBTN.UseVisualStyleBackColor = true;
            CancelBTN.Click += CancelBTN_OnClick;
            // 
            // ConfirmBTN
            // 
            ConfirmBTN.Location = new Point(25, 261);
            ConfirmBTN.Name = "ConfirmBTN";
            ConfirmBTN.Size = new Size(134, 29);
            ConfirmBTN.TabIndex = 10;
            ConfirmBTN.Text = "Подтвердить";
            ConfirmBTN.UseVisualStyleBackColor = true;
            ConfirmBTN.Click += ConfirmBTN_OnClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 57);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 9;
            label2.Text = "Дата рождения";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 8;
            label1.Text = "ФИО";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 123);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 15;
            label3.Text = "Адрес";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 90);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 14;
            label4.Text = "Пол";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(162, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(162, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 27);
            textBox4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 189);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 19;
            label5.Text = "Номер отдела";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 156);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 18;
            label6.Text = "Стаж";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(162, 153);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(162, 186);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(156, 27);
            textBox6.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 222);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 22;
            label8.Text = "Номер должности";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(162, 219);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(156, 27);
            textBox7.TabIndex = 20;
            // 
            // FormWorker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 305);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(CancelBTN);
            Controls.Add(ConfirmBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormWorker";
            Text = "FormWorker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelBTN;
        private Button ConfirmBTN;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox8;
        private TextBox textBox7;
    }
}