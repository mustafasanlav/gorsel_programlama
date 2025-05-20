namespace Cafe_Uygulaması
{
    partial class Kullanicilarcs
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            adTexbox = new TextBox();
            sifreTexbox = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            guncelleButton = new Button();
            ekleButton = new Button();
            silButton = new Button();
            araButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 314);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(965, 201);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 41);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 133);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 2;
            label2.Text = "Şifre                :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 211);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 3;
            label3.Text = "Kayıt Tarihi     :";
            // 
            // adTexbox
            // 
            adTexbox.Location = new Point(215, 45);
            adTexbox.Name = "adTexbox";
            adTexbox.Size = new Size(125, 27);
            adTexbox.TabIndex = 4;
            // 
            // sifreTexbox
            // 
            sifreTexbox.Location = new Point(215, 133);
            sifreTexbox.Name = "sifreTexbox";
            sifreTexbox.Size = new Size(125, 27);
            sifreTexbox.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(215, 215);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // guncelleButton
            // 
            guncelleButton.Location = new Point(673, 63);
            guncelleButton.Name = "guncelleButton";
            guncelleButton.Size = new Size(109, 84);
            guncelleButton.TabIndex = 7;
            guncelleButton.Text = "GÜNCELLE";
            guncelleButton.UseVisualStyleBackColor = true;
            guncelleButton.Click += guncelleButton_Click;
            // 
            // ekleButton
            // 
            ekleButton.Location = new Point(538, 63);
            ekleButton.Name = "ekleButton";
            ekleButton.Size = new Size(108, 84);
            ekleButton.TabIndex = 8;
            ekleButton.Text = "EKLE";
            ekleButton.UseVisualStyleBackColor = true;
            ekleButton.Click += ekleButton_Click;
            // 
            // silButton
            // 
            silButton.Location = new Point(538, 169);
            silButton.Name = "silButton";
            silButton.Size = new Size(108, 95);
            silButton.TabIndex = 9;
            silButton.Text = "SİL";
            silButton.UseVisualStyleBackColor = true;
            silButton.Click += silButton_Click;
            // 
            // araButton
            // 
            araButton.Location = new Point(673, 169);
            araButton.Name = "araButton";
            araButton.Size = new Size(109, 95);
            araButton.TabIndex = 10;
            araButton.Text = "ARA";
            araButton.UseVisualStyleBackColor = true;
            araButton.Click += araButton_Click;
            // 
            // Kullanicilarcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 515);
            Controls.Add(araButton);
            Controls.Add(silButton);
            Controls.Add(ekleButton);
            Controls.Add(guncelleButton);
            Controls.Add(maskedTextBox1);
            Controls.Add(sifreTexbox);
            Controls.Add(adTexbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kullanicilarcs";
            Text = "Kullanicilarcs";
            Load += Kullanicilarcs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox adTexbox;
        private TextBox sifreTexbox;
        private MaskedTextBox maskedTextBox1;
        private Button guncelleButton;
        private Button ekleButton;
        private Button silButton;
        private Button araButton;
    }
}