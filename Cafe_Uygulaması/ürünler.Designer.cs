namespace Cafe_Uygulaması
{
    partial class ürünler
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
            label4 = new Label();
            uruntext = new TextBox();
            katagoritext = new TextBox();
            fiyattext = new TextBox();
            eklebutton = new Button();
            silbutton = new Button();
            güncelle = new Button();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1008, 290);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 1;
            label1.Text = "ÜRÜN ADI : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 1;
            label2.Text = "KATAGORİ : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 169);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 1;
            label3.Text = "FİYATI         : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 220);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 1;
            label4.Text = "TARİH         : ";
            // 
            // uruntext
            // 
            uruntext.Location = new Point(136, 31);
            uruntext.Name = "uruntext";
            uruntext.Size = new Size(139, 27);
            uruntext.TabIndex = 2;
            // 
            // katagoritext
            // 
            katagoritext.Location = new Point(136, 89);
            katagoritext.Name = "katagoritext";
            katagoritext.Size = new Size(139, 27);
            katagoritext.TabIndex = 2;
            // 
            // fiyattext
            // 
            fiyattext.Location = new Point(136, 170);
            fiyattext.Name = "fiyattext";
            fiyattext.Size = new Size(139, 27);
            fiyattext.TabIndex = 2;
            // 
            // eklebutton
            // 
            eklebutton.Location = new Point(318, 31);
            eklebutton.Name = "eklebutton";
            eklebutton.Size = new Size(146, 70);
            eklebutton.TabIndex = 3;
            eklebutton.Text = "EKLE";
            eklebutton.UseVisualStyleBackColor = true;
            eklebutton.Click += button1_Click;
            // 
            // silbutton
            // 
            silbutton.Location = new Point(470, 31);
            silbutton.Name = "silbutton";
            silbutton.Size = new Size(146, 70);
            silbutton.TabIndex = 3;
            silbutton.Text = "SİL";
            silbutton.UseVisualStyleBackColor = true;
            silbutton.Click += silbutton_Click;
            // 
            // güncelle
            // 
            güncelle.Location = new Point(622, 31);
            güncelle.Name = "güncelle";
            güncelle.Size = new Size(146, 70);
            güncelle.TabIndex = 3;
            güncelle.Text = "GÜNCELLE";
            güncelle.UseVisualStyleBackColor = true;
            güncelle.Click += güncelle_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(136, 220);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(139, 27);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // ürünler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 543);
            Controls.Add(maskedTextBox1);
            Controls.Add(güncelle);
            Controls.Add(silbutton);
            Controls.Add(eklebutton);
            Controls.Add(fiyattext);
            Controls.Add(katagoritext);
            Controls.Add(uruntext);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ürünler";
            Text = "ürünler";
            Load += ürünler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox uruntext;
        private TextBox katagoritext;
        private TextBox fiyattext;
        private Button eklebutton;
        private Button silbutton;
        private Button güncelle;
        private MaskedTextBox maskedTextBox1;
    }
}