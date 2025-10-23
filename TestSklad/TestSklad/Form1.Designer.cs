namespace TestSklad
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
            label1 = new Label();
            lblStatus = new Label();
            txtVnos = new TextBox();
            btnPush = new Button();
            btnPop = new Button();
            btnPeek = new Button();
            btnPrazen = new Button();
            btnIšči = new Button();
            btnIzpis = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 45);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 0;
            label1.Text = "Vnesi niz:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(95, 299);
            lblStatus.Margin = new Padding(5, 0, 5, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 30);
            lblStatus.TabIndex = 1;
            // 
            // txtVnos
            // 
            txtVnos.Location = new Point(138, 45);
            txtVnos.Name = "txtVnos";
            txtVnos.Size = new Size(183, 35);
            txtVnos.TabIndex = 4;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(449, 41);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(119, 39);
            btnPush.TabIndex = 5;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(574, 42);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(119, 38);
            btnPop.TabIndex = 6;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(449, 86);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(119, 38);
            btnPeek.TabIndex = 7;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnPrazen
            // 
            btnPrazen.Location = new Point(574, 86);
            btnPrazen.Name = "btnPrazen";
            btnPrazen.Size = new Size(119, 38);
            btnPrazen.TabIndex = 8;
            btnPrazen.Text = "Je prazen?";
            btnPrazen.UseVisualStyleBackColor = true;
            btnPrazen.Click += btnPrazen_Click;
            // 
            // btnIšči
            // 
            btnIšči.Location = new Point(449, 130);
            btnIšči.Name = "btnIšči";
            btnIšči.Size = new Size(119, 38);
            btnIšči.TabIndex = 9;
            btnIšči.Text = "Išči";
            btnIšči.UseVisualStyleBackColor = true;
            btnIšči.Click += btnIšči_Click;
            // 
            // btnIzpis
            // 
            btnIzpis.Location = new Point(574, 130);
            btnIzpis.Name = "btnIzpis";
            btnIzpis.Size = new Size(119, 38);
            btnIzpis.TabIndex = 10;
            btnIzpis.Text = "Izpis";
            btnIzpis.UseVisualStyleBackColor = true;
            btnIzpis.Click += btnIzpis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 453);
            Controls.Add(btnIzpis);
            Controls.Add(btnIšči);
            Controls.Add(btnPrazen);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(txtVnos);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStatus;
        private TextBox txtVnos;
        private Button btnPush;
        private Button btnPop;
        private Button btnPeek;
        private Button btnPrazen;
        private Button btnIšči;
        private Button btnIzpis;
    }
}
