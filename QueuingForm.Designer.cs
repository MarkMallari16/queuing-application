namespace QueuingApplication
{
    partial class QueuingForm
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
            btnCashier = new Button();
            label1 = new Label();
            label2 = new Label();
            lblQueue = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Poppins SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(31, 52);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(202, 178);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 52);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 1;
            label1.Text = "Position in Queue";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(31, 245);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 3;
            label2.Text = "*Click to get number";
            // 
            // lblQueue
            // 
            lblQueue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(265, 101);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(390, 65);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "-------";
            lblQueue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 308);
            Controls.Add(label2);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label label1;
        private Label label2;
        private Label lblQueue;
    }
}
