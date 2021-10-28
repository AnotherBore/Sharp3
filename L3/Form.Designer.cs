
namespace L3
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.cmbOp = new System.Windows.Forms.ComboBox();
            this.answ3 = new System.Windows.Forms.TextBox();
            this.answ2 = new System.Windows.Forms.TextBox();
            this.answ1 = new System.Windows.Forms.TextBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(78, 167);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(60, 28);
            this.txt6.TabIndex = 17;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 56);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(64, 28);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(82, 40);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(60, 28);
            this.txt2.TabIndex = 2;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(12, 145);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(60, 28);
            this.txt4.TabIndex = 3;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(82, 75);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(60, 28);
            this.txt3.TabIndex = 4;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(78, 133);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(60, 28);
            this.txt5.TabIndex = 5;
            // 
            // cmbOp
            // 
            this.cmbOp.FormattingEnabled = true;
            this.cmbOp.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*",
            "Сравнение"});
            this.cmbOp.Location = new System.Drawing.Point(179, 71);
            this.cmbOp.Name = "cmbOp";
            this.cmbOp.Size = new System.Drawing.Size(112, 30);
            this.cmbOp.TabIndex = 6;
            this.cmbOp.Text = "+";
            // 
            // answ3
            // 
            this.answ3.Location = new System.Drawing.Point(404, 109);
            this.answ3.Name = "answ3";
            this.answ3.ReadOnly = true;
            this.answ3.Size = new System.Drawing.Size(64, 28);
            this.answ3.TabIndex = 8;
            // 
            // answ2
            // 
            this.answ2.Location = new System.Drawing.Point(404, 75);
            this.answ2.Name = "answ2";
            this.answ2.ReadOnly = true;
            this.answ2.Size = new System.Drawing.Size(64, 28);
            this.answ2.TabIndex = 9;
            // 
            // answ1
            // 
            this.answ1.Location = new System.Drawing.Point(334, 96);
            this.answ1.Name = "answ1";
            this.answ1.ReadOnly = true;
            this.answ1.Size = new System.Drawing.Size(64, 28);
            this.answ1.TabIndex = 10;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(244, 44);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(0, 24);
            this.lblOperation.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(190, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Операция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Первая дробь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Вторая дробь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(411, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ответ";
            // 
            // mainButton
            // 
            this.mainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainButton.Location = new System.Drawing.Point(164, 133);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(143, 61);
            this.mainButton.TabIndex = 16;
            this.mainButton.Text = "Сократить и вычислить";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 223);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.answ1);
            this.Controls.Add(this.answ2);
            this.Controls.Add(this.answ3);
            this.Controls.Add(this.cmbOp);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.86096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Калькулятор дробей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.ComboBox cmbOp;
        private System.Windows.Forms.TextBox answ3;
        private System.Windows.Forms.TextBox answ2;
        private System.Windows.Forms.TextBox answ1;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainButton;
    }
}

