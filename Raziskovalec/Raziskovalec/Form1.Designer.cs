namespace Raziskovalec
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
            trvDrevo = new TreeView();
            label1 = new Label();
            label2 = new Label();
            txtA = new TextBox();
            txtUstvarjena = new TextBox();
            SuspendLayout();
            // 
            // trvDrevo
            // 
            trvDrevo.Dock = DockStyle.Top;
            trvDrevo.Location = new Point(0, 0);
            trvDrevo.Name = "trvDrevo";
            trvDrevo.Size = new Size(1043, 285);
            trvDrevo.TabIndex = 0;
            trvDrevo.BeforeExpand += trvDrevo_BeforeExpand;
            trvDrevo.AfterSelect += trvDrevo_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 350);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 1;
            label1.Text = "Atribut";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 407);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 2;
            label2.Text = "Ustvarjena";
            // 
            // txtA
            // 
            txtA.Location = new Point(184, 347);
            txtA.Name = "txtA";
            txtA.Size = new Size(400, 35);
            txtA.TabIndex = 3;
            // 
            // txtUstvarjena
            // 
            txtUstvarjena.Location = new Point(184, 404);
            txtUstvarjena.Name = "txtUstvarjena";
            txtUstvarjena.Size = new Size(400, 35);
            txtUstvarjena.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 676);
            Controls.Add(txtUstvarjena);
            Controls.Add(txtA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trvDrevo);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView trvDrevo;
        private Label label1;
        private Label label2;
        private TextBox txtA;
        private TextBox txtUstvarjena;
    }
}
