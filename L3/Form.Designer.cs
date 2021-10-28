
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
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.num3 = new System.Windows.Forms.NumericUpDown();
            this.num4 = new System.Windows.Forms.NumericUpDown();
            this.num5 = new System.Windows.Forms.NumericUpDown();
            this.num6 = new System.Windows.Forms.NumericUpDown();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.ch2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num6)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOp
            // 
            this.cmbOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbOp.FormattingEnabled = true;
            this.cmbOp.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cmbOp.Location = new System.Drawing.Point(228, 39);
            this.cmbOp.Name = "cmbOp";
            this.cmbOp.Size = new System.Drawing.Size(39, 28);
            this.cmbOp.TabIndex = 7;
            this.cmbOp.Text = "+";
            this.cmbOp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // answ3
            // 
            this.answ3.Location = new System.Drawing.Point(389, 74);
            this.answ3.Name = "answ3";
            this.answ3.ReadOnly = true;
            this.answ3.Size = new System.Drawing.Size(64, 28);
            this.answ3.TabIndex = 8;
            this.answ3.TabStop = false;
            this.answ3.Visible = false;
            // 
            // answ2
            // 
            this.answ2.Location = new System.Drawing.Point(389, 39);
            this.answ2.Name = "answ2";
            this.answ2.ReadOnly = true;
            this.answ2.Size = new System.Drawing.Size(64, 28);
            this.answ2.TabIndex = 9;
            this.answ2.TabStop = false;
            this.answ2.Visible = false;
            // 
            // answ1
            // 
            this.answ1.Location = new System.Drawing.Point(319, 55);
            this.answ1.Name = "answ1";
            this.answ1.ReadOnly = true;
            this.answ1.Size = new System.Drawing.Size(64, 28);
            this.answ1.TabIndex = 10;
            this.answ1.TabStop = false;
            this.answ1.Visible = false;
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
            this.label3.Location = new System.Drawing.Point(213, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Операция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(58, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Первая дробь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Вторая дробь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.93583F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ответ";
            // 
            // mainButton
            // 
            this.mainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainButton.Location = new System.Drawing.Point(217, 108);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(119, 57);
            this.mainButton.TabIndex = 8;
            this.mainButton.Text = "Сократить и вычислить";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            this.mainButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1.Location = new System.Drawing.Point(53, 55);
            this.num1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(58, 26);
            this.num1.TabIndex = 1;
            this.num1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2.Location = new System.Drawing.Point(117, 42);
            this.num2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(58, 26);
            this.num2.TabIndex = 2;
            this.num2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3.Location = new System.Drawing.Point(117, 76);
            this.num3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(58, 26);
            this.num3.TabIndex = 3;
            this.num3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4.Location = new System.Drawing.Point(53, 168);
            this.num4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(58, 26);
            this.num4.TabIndex = 4;
            this.num4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num5.Location = new System.Drawing.Point(117, 152);
            this.num5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(58, 26);
            this.num5.TabIndex = 5;
            this.num5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num6.Location = new System.Drawing.Point(117, 185);
            this.num6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(58, 26);
            this.num6.TabIndex = 6;
            this.num6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Location = new System.Drawing.Point(12, 53);
            this.ch1.Name = "ch1";
            this.ch1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch1.Size = new System.Drawing.Size(35, 28);
            this.ch1.TabIndex = 23;
            this.ch1.TabStop = false;
            this.ch1.Text = "-";
            this.ch1.UseVisualStyleBackColor = true;
            // 
            // ch2
            // 
            this.ch2.AccessibleDescription = "";
            this.ch2.AutoSize = true;
            this.ch2.Location = new System.Drawing.Point(12, 166);
            this.ch2.Name = "ch2";
            this.ch2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch2.Size = new System.Drawing.Size(35, 28);
            this.ch2.TabIndex = 24;
            this.ch2.TabStop = false;
            this.ch2.Text = "-";
            this.ch2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(349, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сравнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(217, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Очистить поля";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // lab
            // 
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab.Location = new System.Drawing.Point(317, 39);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(151, 63);
            this.lab.TabIndex = 27;
            this.lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 223);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.86096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Калькулятор дробей";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox answ3;
        private System.Windows.Forms.TextBox answ2;
        private System.Windows.Forms.TextBox answ1;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.NumericUpDown num3;
        private System.Windows.Forms.NumericUpDown num4;
        private System.Windows.Forms.NumericUpDown num5;
        private System.Windows.Forms.NumericUpDown num6;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.CheckBox ch2;
        private System.Windows.Forms.ComboBox cmbOp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lab;
    }
}

