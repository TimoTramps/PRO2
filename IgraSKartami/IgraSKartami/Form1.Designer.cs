namespace IgraSKartami
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
            lstCel = new ListBox();
            lstNak = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnPonastavi1 = new Button();
            btnPonastavi2 = new Button();
            btnMesaj1 = new Button();
            btnMesaj2 = new Button();
            SuspendLayout();
            // 
            // lstCel
            // 
            lstCel.FormattingEnabled = true;
            lstCel.ItemHeight = 15;
            lstCel.Location = new Point(351, 104);
            lstCel.Name = "lstCel";
            lstCel.Size = new Size(264, 304);
            lstCel.TabIndex = 0;
            // 
            // lstNak
            // 
            lstNak.FormattingEnabled = true;
            lstNak.ItemHeight = 15;
            lstNak.Location = new Point(41, 104);
            lstNak.Name = "lstNak";
            lstNak.Size = new Size(250, 304);
            lstNak.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 53);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Kup #1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 53);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Kup #2";
            // 
            // btnPonastavi1
            // 
            btnPonastavi1.Location = new Point(41, 414);
            btnPonastavi1.Name = "btnPonastavi1";
            btnPonastavi1.Size = new Size(250, 23);
            btnPonastavi1.TabIndex = 4;
            btnPonastavi1.Text = "Ponastavi kup #1";
            btnPonastavi1.UseVisualStyleBackColor = true;
            btnPonastavi1.Click += btnPonastavi1_Click;
            // 
            // btnPonastavi2
            // 
            btnPonastavi2.Location = new Point(351, 414);
            btnPonastavi2.Name = "btnPonastavi2";
            btnPonastavi2.Size = new Size(264, 23);
            btnPonastavi2.TabIndex = 5;
            btnPonastavi2.Text = "Ponastavi kup #2";
            btnPonastavi2.UseVisualStyleBackColor = true;
            btnPonastavi2.Click += btnPonastavi2_Click;
            // 
            // btnMesaj1
            // 
            btnMesaj1.Location = new Point(41, 443);
            btnMesaj1.Name = "btnMesaj1";
            btnMesaj1.Size = new Size(250, 23);
            btnMesaj1.TabIndex = 6;
            btnMesaj1.Text = "Mešaj #1";
            btnMesaj1.UseVisualStyleBackColor = true;
            btnMesaj1.Click += btnMesaj1_Click;
            // 
            // btnMesaj2
            // 
            btnMesaj2.Location = new Point(351, 443);
            btnMesaj2.Name = "btnMesaj2";
            btnMesaj2.Size = new Size(264, 23);
            btnMesaj2.TabIndex = 7;
            btnMesaj2.Text = "Mešaj #2";
            btnMesaj2.UseVisualStyleBackColor = true;
            btnMesaj2.Click += btnMesaj2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 507);
            Controls.Add(btnMesaj2);
            Controls.Add(btnMesaj1);
            Controls.Add(btnPonastavi2);
            Controls.Add(btnPonastavi1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstNak);
            Controls.Add(lstCel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCel;
        private ListBox lstNak;
        private Label label1;
        private Label label2;
        private Button btnPonastavi1;
        private Button btnPonastavi2;
        private Button btnMesaj1;
        private Button btnMesaj2;
    }
}
