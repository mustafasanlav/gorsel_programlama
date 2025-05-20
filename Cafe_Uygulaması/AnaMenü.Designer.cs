namespace Cafe_Uygulaması
{
    partial class AnaMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenü));
            button1 = new Button();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(0, 497);
            button1.Name = "button1";
            button1.Size = new Size(261, 80);
            button1.TabIndex = 0;
            button1.Text = "ÇIKIŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 577);
            panel2.TabIndex = 3;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Silver;
            button5.Location = new Point(0, 315);
            button5.Name = "button5";
            button5.Size = new Size(261, 57);
            button5.TabIndex = 0;
            button5.Text = "KULLANICILAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Silver;
            button4.Location = new Point(0, 249);
            button4.Name = "button4";
            button4.Size = new Size(261, 66);
            button4.TabIndex = 0;
            button4.Text = "MÜŞTERİLER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Silver;
            button3.Location = new Point(0, 169);
            button3.Name = "button3";
            button3.Size = new Size(261, 80);
            button3.TabIndex = 7;
            button3.Text = "ÜRÜNLER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(0, 89);
            button2.Name = "button2";
            button2.Size = new Size(261, 80);
            button2.TabIndex = 6;
            button2.Text = "ADİSYONLAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 89);
            panel3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(261, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 89);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(261, 89);
            panel4.Name = "panel4";
            panel4.Size = new Size(900, 488);
            panel4.TabIndex = 5;
            // 
            // AnaMenü
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 577);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaMenü";
            Text = "AnaMenü";
            WindowState = FormWindowState.Maximized;
            Load += AnaMenü_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button4;
        public Panel panel4;
        private Button button5;
    }
}