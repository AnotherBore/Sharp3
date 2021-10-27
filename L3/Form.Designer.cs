
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
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.cmbOp = new System.Windows.Forms.ComboBox();
            this.answ3 = new System.Windows.Forms.TextBox();
            this.answ2 = new System.Windows.Forms.TextBox();
            this.answ1 = new System.Windows.Forms.TextBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(126, 340);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 48);
            this.txt6.TabIndex = 0;
            this.txt6.TextChanged += new System.EventHandler(this.txt6_TextChanged);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(20, 310);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 48);
            this.txt4.TabIndex = 1;
            this.txt4.TextChanged += new System.EventHandler(this.txt4_TextChanged);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(126, 286);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 48);
            this.txt5.TabIndex = 2;
            this.txt5.TextChanged += new System.EventHandler(this.txt5_TextChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(20, 100);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 48);
            this.txt1.TabIndex = 3;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(126, 130);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 48);
            this.txt3.TabIndex = 4;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(126, 76);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 48);
            this.txt2.TabIndex = 5;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
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
            this.cmbOp.Location = new System.Drawing.Point(306, 183);
            this.cmbOp.Name = "cmbOp";
            this.cmbOp.Size = new System.Drawing.Size(114, 48);
            this.cmbOp.TabIndex = 6;
            this.cmbOp.Text = "+";
            // 
            // answ3
            // 
            this.answ3.Location = new System.Drawing.Point(637, 214);
            this.answ3.Name = "answ3";
            this.answ3.ReadOnly = true;
            this.answ3.Size = new System.Drawing.Size(100, 48);
            this.answ3.TabIndex = 8;
            // 
            // answ2
            // 
            this.answ2.Location = new System.Drawing.Point(637, 160);
            this.answ2.Name = "answ2";
            this.answ2.ReadOnly = true;
            this.answ2.Size = new System.Drawing.Size(100, 48);
            this.answ2.TabIndex = 9;
            // 
            // answ1
            // 
            this.answ1.Location = new System.Drawing.Point(531, 183);
            this.answ1.Name = "answ1";
            this.answ1.ReadOnly = true;
            this.answ1.Size = new System.Drawing.Size(100, 48);
            this.answ1.TabIndex = 10;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(244, 44);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(0, 40);
            this.lblOperation.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(284, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Операция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Первая дробь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "Вторая дробь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(637, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ответ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.answ1);
            this.Controls.Add(this.answ2);
            this.Controls.Add(this.answ3);
            this.Controls.Add(this.cmbOp);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
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
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.ComboBox cmbOp;
        private System.Windows.Forms.TextBox answ3;
        private System.Windows.Forms.TextBox answ2;
        private System.Windows.Forms.TextBox answ1;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

