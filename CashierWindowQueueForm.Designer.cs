namespace QueuingApplication
{
    partial class CashierWindowQueue
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
            airForm1 = new ReaLTaiizor.Forms.AirForm();
            listCashierQueue = new ReaLTaiizor.Controls.RoyalListBox();
            button2 = new ReaLTaiizor.Controls.Button();
            button1 = new ReaLTaiizor.Controls.Button();
            airForm1.SuspendLayout();
            SuspendLayout();
            // 
            // airForm1
            // 
            airForm1.BackColor = Color.White;
            airForm1.BorderStyle = FormBorderStyle.None;
            airForm1.Controls.Add(listCashierQueue);
            airForm1.Controls.Add(button2);
            airForm1.Controls.Add(button1);
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
            airForm1.Size = new Size(547, 486);
            airForm1.SmartBounds = true;
            airForm1.StartPosition = FormStartPosition.CenterScreen;
            airForm1.TabIndex = 0;
            airForm1.Text = "CashierWindowQueueForm";
            airForm1.TransparencyKey = Color.Fuchsia;
            airForm1.Transparent = false;
            // 
            // listCashierQueue
            // 
            listCashierQueue.Font = new Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listCashierQueue.HotLightColor = Color.FromArgb(221, 221, 221);
            listCashierQueue.HotLightedIndex = -1;
            listCashierQueue.ItemHeight = 30;
            listCashierQueue.Location = new Point(214, 48);
            listCashierQueue.MultiSelection = false;
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.SelectedColor = Color.FromArgb(51, 102, 255);
            listCashierQueue.SelectedIndex = -1;
            listCashierQueue.Size = new Size(321, 426);
            listCashierQueue.TabIndex = 8;
            listCashierQueue.Text = "royalListBox1";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.FromArgb(32, 34, 37);
            button2.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button2.EnteredColor = Color.FromArgb(32, 34, 37);
            button2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = null;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.InactiveColor = Color.FromArgb(32, 34, 37);
            button2.Location = new Point(23, 94);
            button2.Name = "button2";
            button2.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button2.PressedColor = Color.FromArgb(165, 37, 37);
            button2.Size = new Size(172, 40);
            button2.TabIndex = 7;
            button2.Text = "Next";
            button2.TextAlignment = StringAlignment.Center;
            button2.Click += btnNext_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(23, 48);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(172, 40);
            button1.TabIndex = 6;
            button1.Text = "Refresh";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += btnRefresh_Click;
            // 
            // CashierWindowQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 486);
            Controls.Add(airForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierWindowQueue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierWindowQueueForm";
            TransparencyKey = Color.Fuchsia;
            airForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.RoyalListBox listCashierQueue;
    }
}