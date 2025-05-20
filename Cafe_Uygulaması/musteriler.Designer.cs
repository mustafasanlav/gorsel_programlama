namespace Cafe_Uygulaması
{
    partial class musteriler
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
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            ekleButton = new Button();
            silButton = new Button();
            guncelleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(998, 233);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 27);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 1;
            label1.Text = "MÜŞTERİ ADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 138);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 2;
            label3.Text = "UNVANI         :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 80);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 3;
            label2.Text = "SOYADI          :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 200);
            label4.Name = "label4";
            label4.Size = new Size(134, 28);
            label4.TabIndex = 4;
            label4.Text = "TARİH             :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(204, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(204, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(204, 204);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // ekleButton
            // 
            ekleButton.Location = new Point(408, 27);
            ekleButton.Name = "ekleButton";
            ekleButton.Size = new Size(145, 66);
            ekleButton.TabIndex = 9;
            ekleButton.Text = "EKLE";
            ekleButton.UseVisualStyleBackColor = true;
            ekleButton.Click += ekleButton_Click;
            // 
            // silButton
            // 
            silButton.Location = new Point(577, 27);
            silButton.Name = "silButton";
            silButton.Size = new Size(140, 66);
            silButton.TabIndex = 10;
            silButton.Text = "SİL";
            silButton.UseVisualStyleBackColor = true;
            silButton.Click += silButton_Click;
            // 
            // guncelleButton
            // 
            guncelleButton.Location = new Point(737, 27);
            guncelleButton.Name = "guncelleButton";
            guncelleButton.Size = new Size(150, 66);
            guncelleButton.TabIndex = 11;
            guncelleButton.Text = "GÜNCELLE";
            guncelleButton.UseVisualStyleBackColor = true;
            guncelleButton.Click += guncelleButton_Click;
            // 
            // musteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 515);
            Controls.Add(guncelleButton);
            Controls.Add(silButton);
            Controls.Add(ekleButton);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "musteriler";
            Text = "musteriler";
            Load += musteriler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox1;
        private Button ekleButton;
        private Button silButton;
        private Button guncelleButton;
    }
}