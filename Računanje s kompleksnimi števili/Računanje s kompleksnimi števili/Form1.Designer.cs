namespace Računanje_s_kompleksnimi_števili
{
    partial class Form1
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
            prvoR = new TextBox();
            drugoR = new TextBox();
            drugoI = new TextBox();
            prvoI = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonTimes = new Button();
            label7 = new Label();
            textRezultat = new Label();
            SuspendLayout();
            // 
            // prvoR
            // 
            prvoR.Font = new Font("Microsoft Sans Serif", 15.75F);
            prvoR.Location = new Point(128, 116);
            prvoR.Name = "prvoR";
            prvoR.Size = new Size(129, 31);
            prvoR.TabIndex = 0;
            // 
            // drugoR
            // 
            drugoR.Font = new Font("Microsoft Sans Serif", 15.75F);
            drugoR.Location = new Point(128, 301);
            drugoR.Name = "drugoR";
            drugoR.Size = new Size(129, 31);
            drugoR.TabIndex = 1;
            // 
            // drugoI
            // 
            drugoI.Font = new Font("Microsoft Sans Serif", 15.75F);
            drugoI.Location = new Point(413, 301);
            drugoI.Name = "drugoI";
            drugoI.Size = new Size(129, 31);
            drugoI.TabIndex = 3;
            // 
            // prvoI
            // 
            prvoI.Font = new Font("Microsoft Sans Serif", 15.75F);
            prvoI.Location = new Point(413, 116);
            prvoI.Name = "prvoI";
            prvoI.Size = new Size(129, 31);
            prvoI.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 4;
            label1.Text = "Prvo število";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F);
            label2.Location = new Point(21, 201);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 5;
            label2.Text = "Drugo število";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F);
            label3.Location = new Point(103, 78);
            label3.Name = "label3";
            label3.Size = new Size(204, 25);
            label3.TabIndex = 6;
            label3.Text = "Realna komponenta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F);
            label4.Location = new Point(380, 78);
            label4.Name = "label4";
            label4.Size = new Size(242, 25);
            label4.TabIndex = 7;
            label4.Text = "Imaginarna komponenta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F);
            label5.Location = new Point(380, 243);
            label5.Name = "label5";
            label5.Size = new Size(242, 25);
            label5.TabIndex = 9;
            label5.Text = "Imaginarna komponenta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F);
            label6.Location = new Point(103, 243);
            label6.Name = "label6";
            label6.Size = new Size(204, 25);
            label6.TabIndex = 8;
            label6.Text = "Realna komponenta";
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Microsoft Sans Serif", 15.75F);
            buttonPlus.Location = new Point(128, 399);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(83, 44);
            buttonPlus.TabIndex = 10;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Microsoft Sans Serif", 15.75F);
            buttonMinus.Location = new Point(293, 399);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(83, 44);
            buttonMinus.TabIndex = 11;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonTimes
            // 
            buttonTimes.Font = new Font("Microsoft Sans Serif", 15.75F);
            buttonTimes.Location = new Point(459, 399);
            buttonTimes.Name = "buttonTimes";
            buttonTimes.Size = new Size(83, 44);
            buttonTimes.TabIndex = 12;
            buttonTimes.Text = "x";
            buttonTimes.UseVisualStyleBackColor = true;
            buttonTimes.Click += buttonTimes_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F);
            label7.Location = new Point(21, 489);
            label7.Name = "label7";
            label7.Size = new Size(219, 25);
            label7.TabIndex = 13;
            label7.Text = "Rezultat v obliki a+i*b";
            // 
            // textRezultat
            // 
            textRezultat.AutoSize = true;
            textRezultat.Font = new Font("Microsoft Sans Serif", 15.75F);
            textRezultat.Location = new Point(293, 562);
            textRezultat.Name = "textRezultat";
            textRezultat.Size = new Size(219, 25);
            textRezultat.TabIndex = 14;
            textRezultat.Text = "Rezultat v obliki a+i*b";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 627);
            Controls.Add(textRezultat);
            Controls.Add(label7);
            Controls.Add(buttonTimes);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(drugoI);
            Controls.Add(prvoI);
            Controls.Add(drugoR);
            Controls.Add(prvoR);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox prvoR;
        private TextBox drugoR;
        private TextBox drugoI;
        private TextBox prvoI;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonTimes;
        private Label label7;
        private Label textRezultat;
    }
}
