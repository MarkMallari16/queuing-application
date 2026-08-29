namespace QueuingApplication
{
    partial class CustomerView
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
            components = new System.ComponentModel.Container();
            airForm1 = new ReaLTaiizor.Forms.AirForm();
            label1 = new Label();
            lblFirstServe = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            airForm1.SuspendLayout();
            SuspendLayout();
            // 
            // airForm1
            // 
            airForm1.BackColor = Color.WhiteSmoke;
            airForm1.BorderStyle = FormBorderStyle.None;
            airForm1.Controls.Add(label1);
            airForm1.Controls.Add(lblFirstServe);
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
            airForm1.Size = new Size(665, 359);
            airForm1.SmartBounds = true;
            airForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            airForm1.TabIndex = 0;
            airForm1.Text = "Customer View";
            airForm1.TransparencyKey = Color.Fuchsia;
            airForm1.Transparent = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(141, 34);
            label1.TabIndex = 1;
            label1.Text = "*Now Serving";
            // 
            // lblFirstServe
            // 
            lblFirstServe.Font = new Font("Poppins", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstServe.Location = new Point(38, 90);
            lblFirstServe.Name = "lblFirstServe";
            lblFirstServe.Size = new Size(592, 192);
            lblFirstServe.TabIndex = 0;
            lblFirstServe.Text = "label1";
            lblFirstServe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 359);
            Controls.Add(airForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerView";
            Text = "CustomerView";
            TransparencyKey = Color.Fuchsia;
            airForm1.ResumeLayout(false);
            airForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private Label label1;
        private Label lblFirstServe;
        private System.Windows.Forms.Timer timer1;
    }
}