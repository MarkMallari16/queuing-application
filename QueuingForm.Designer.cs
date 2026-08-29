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
            airForm1 = new ReaLTaiizor.Forms.AirForm();
            lblQueue = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCashier = new ReaLTaiizor.Controls.HopeButton();
            airForm1.SuspendLayout();
            SuspendLayout();
            // 
            // airForm1
            // 
            airForm1.BackColor = Color.White;
            airForm1.BorderStyle = FormBorderStyle.None;
            airForm1.Controls.Add(lblQueue);
            airForm1.Controls.Add(label2);
            airForm1.Controls.Add(label1);
            airForm1.Controls.Add(btnCashier);
            airForm1.Customization = "AAAA/1paWv9ycnL/";
            airForm1.Dock = DockStyle.Fill;
            airForm1.Font = new Font("Segoe UI", 9F);
            airForm1.Image = null;
            airForm1.Location = new Point(0, 0);
            airForm1.MinimumSize = new Size(112, 35);
            airForm1.Movable = true;
            airForm1.Name = "airForm1";
            airForm1.NoRounding = false;
            airForm1.Sizable = true;
            airForm1.Size = new Size(650, 308);
            airForm1.SmartBounds = true;
            airForm1.StartPosition = FormStartPosition.CenterScreen;
            airForm1.TabIndex = 0;
            airForm1.Text = "QueuingForm";
            airForm1.TransparencyKey = Color.Fuchsia;
            airForm1.Transparent = false;
            // 
            // lblQueue
            // 
            lblQueue.Font = new Font("Poppins", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(289, 120);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(361, 87);
            lblQueue.TabIndex = 3;
            lblQueue.Text = "-------";
            lblQueue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(374, 70);
            label2.Name = "label2";
            label2.Size = new Size(179, 34);
            label2.TabIndex = 2;
            label2.Text = "Position in Queue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(40, 224);
            label1.Name = "label1";
            label1.Size = new Size(131, 22);
            label1.TabIndex = 1;
            label1.Text = "*Click to get number";
            // 
            // btnCashier
            // 
            btnCashier.BorderColor = Color.FromArgb(220, 223, 230);
            btnCashier.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCashier.DangerColor = Color.FromArgb(245, 108, 108);
            btnCashier.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCashier.Font = new Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCashier.InfoColor = Color.FromArgb(144, 147, 153);
            btnCashier.Location = new Point(40, 70);
            btnCashier.Name = "btnCashier";
            btnCashier.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnCashier.Size = new Size(216, 151);
            btnCashier.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.TextColor = Color.White;
            btnCashier.WarningColor = Color.FromArgb(230, 162, 60);
            btnCashier.Click += btnCashier_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 308);
            Controls.Add(airForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QueuingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QueuingForm";
            TransparencyKey = Color.Fuchsia;
            airForm1.ResumeLayout(false);
            airForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private Label lblQueue;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.HopeButton btnCashier;
    }
}
