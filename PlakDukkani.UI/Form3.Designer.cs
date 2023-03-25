namespace PlakDukkani.UI
{
    partial class Form3
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvPlak = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSanatci = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBitti = new System.Windows.Forms.RadioButton();
            this.rbDevam = new System.Windows.Forms.RadioButton();
            this.dgvSatisYok = new System.Windows.Forms.DataGridView();
            this.dgvSatisDevam = new System.Windows.Forms.DataGridView();
            this.dgvSonOn = new System.Windows.Forms.DataGridView();
            this.dgvIndirim = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvIndirimli = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnListGuncelle = new System.Windows.Forms.Button();
            this.btnTextDoldur = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlak)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisYok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisDevam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(576, 81);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(220, 35);
            this.btnGuncelle.TabIndex = 41;
            this.btnGuncelle.Text = "UPDATE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListele.Location = new System.Drawing.Point(807, 81);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(222, 35);
            this.btnListele.TabIndex = 40;
            this.btnListele.Text = "GET ALL";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(807, 9);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(222, 35);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "DELETE";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(576, 9);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(220, 35);
            this.btnEkle.TabIndex = 38;
            this.btnEkle.Text = "ADD";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvPlak
            // 
            this.dgvPlak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlak.Location = new System.Drawing.Point(19, 369);
            this.dgvPlak.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlak.Name = "dgvPlak";
            this.dgvPlak.RowHeadersWidth = 62;
            this.dgvPlak.RowTemplate.Height = 33;
            this.dgvPlak.Size = new System.Drawing.Size(1022, 173);
            this.dgvPlak.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 18);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(426, 23);
            this.txtName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Musician:";
            // 
            // txtSanatci
            // 
            this.txtSanatci.Location = new System.Drawing.Point(120, 70);
            this.txtSanatci.Margin = new System.Windows.Forms.Padding(2);
            this.txtSanatci.Name = "txtSanatci";
            this.txtSanatci.Size = new System.Drawing.Size(426, 23);
            this.txtSanatci.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(120, 165);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(426, 23);
            this.txtPrice.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(420, 23);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Discount:";
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(120, 202);
            this.txtIndirim.Margin = new System.Windows.Forms.Padding(2);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(426, 23);
            this.txtIndirim.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBitti);
            this.groupBox1.Controls.Add(this.rbDevam);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(37, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 61);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Status:";
            // 
            // rbBitti
            // 
            this.rbBitti.AutoSize = true;
            this.rbBitti.Location = new System.Drawing.Point(213, 26);
            this.rbBitti.Name = "rbBitti";
            this.rbBitti.Size = new System.Drawing.Size(108, 21);
            this.rbBitti.TabIndex = 1;
            this.rbBitti.TabStop = true;
            this.rbBitti.Text = "Discontinued";
            this.rbBitti.UseVisualStyleBackColor = true;
            // 
            // rbDevam
            // 
            this.rbDevam.AutoSize = true;
            this.rbDevam.Location = new System.Drawing.Point(66, 26);
            this.rbDevam.Name = "rbDevam";
            this.rbDevam.Size = new System.Drawing.Size(82, 21);
            this.rbDevam.TabIndex = 0;
            this.rbDevam.TabStop = true;
            this.rbDevam.Text = "Continue";
            this.rbDevam.UseVisualStyleBackColor = true;
            // 
            // dgvSatisYok
            // 
            this.dgvSatisYok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatisYok.Location = new System.Drawing.Point(19, 585);
            this.dgvSatisYok.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSatisYok.Name = "dgvSatisYok";
            this.dgvSatisYok.RowHeadersWidth = 62;
            this.dgvSatisYok.RowTemplate.Height = 33;
            this.dgvSatisYok.Size = new System.Drawing.Size(511, 173);
            this.dgvSatisYok.TabIndex = 37;
            // 
            // dgvSatisDevam
            // 
            this.dgvSatisDevam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatisDevam.Location = new System.Drawing.Point(553, 585);
            this.dgvSatisDevam.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSatisDevam.Name = "dgvSatisDevam";
            this.dgvSatisDevam.RowHeadersWidth = 62;
            this.dgvSatisDevam.RowTemplate.Height = 33;
            this.dgvSatisDevam.Size = new System.Drawing.Size(488, 173);
            this.dgvSatisDevam.TabIndex = 37;
            // 
            // dgvSonOn
            // 
            this.dgvSonOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonOn.Location = new System.Drawing.Point(19, 798);
            this.dgvSonOn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSonOn.Name = "dgvSonOn";
            this.dgvSonOn.RowHeadersWidth = 62;
            this.dgvSonOn.RowTemplate.Height = 33;
            this.dgvSonOn.Size = new System.Drawing.Size(511, 173);
            this.dgvSonOn.TabIndex = 37;
            // 
            // dgvIndirim
            // 
            this.dgvIndirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndirim.Location = new System.Drawing.Point(553, 798);
            this.dgvIndirim.Margin = new System.Windows.Forms.Padding(2);
            this.dgvIndirim.Name = "dgvIndirim";
            this.dgvIndirim.RowHeadersWidth = 62;
            this.dgvIndirim.RowTemplate.Height = 33;
            this.dgvIndirim.Size = new System.Drawing.Size(488, 173);
            this.dgvIndirim.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Discontinued Albums/Satışı Durmuş Albümler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(553, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "Continued Albums/Satışı Devam Eden Albümler";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(14, 775);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(366, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "Last 10 Albums/Sisteme Son Eklenen 10 Albüm";
            // 
            // dgvIndirimli
            // 
            this.dgvIndirimli.AutoSize = true;
            this.dgvIndirimli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvIndirimli.Location = new System.Drawing.Point(553, 775);
            this.dgvIndirimli.Name = "dgvIndirimli";
            this.dgvIndirimli.Size = new System.Drawing.Size(315, 21);
            this.dgvIndirimli.TabIndex = 44;
            this.dgvIndirimli.Text = "Discount Albums/ İndirimdeki Albümler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(31, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 45;
            this.label8.Text = "Album List:";
            // 
            // btnListGuncelle
            // 
            this.btnListGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListGuncelle.Location = new System.Drawing.Point(816, 300);
            this.btnListGuncelle.Name = "btnListGuncelle";
            this.btnListGuncelle.Size = new System.Drawing.Size(213, 50);
            this.btnListGuncelle.TabIndex = 46;
            this.btnListGuncelle.Text = "Update All Tables";
            this.btnListGuncelle.UseVisualStyleBackColor = true;
            this.btnListGuncelle.Click += new System.EventHandler(this.btnListGuncelle_Click);
            // 
            // btnTextDoldur
            // 
            this.btnTextDoldur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTextDoldur.Location = new System.Drawing.Point(576, 154);
            this.btnTextDoldur.Name = "btnTextDoldur";
            this.btnTextDoldur.Size = new System.Drawing.Size(453, 43);
            this.btnTextDoldur.TabIndex = 47;
            this.btnTextDoldur.Text = "Fill the choosed item data to Form";
            this.btnTextDoldur.UseVisualStyleBackColor = true;
            this.btnTextDoldur.Click += new System.EventHandler(this.btnTextDoldur_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(578, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 117);
            this.label10.TabIndex = 48;
            this.label10.Text = "*Album List\'den satır seçilerek Update/Delete/Fill işlemleri uygulanabilir.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 1019);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTextDoldur);
            this.Controls.Add(this.btnListGuncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvIndirimli);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvIndirim);
            this.Controls.Add(this.dgvSonOn);
            this.Controls.Add(this.dgvSatisDevam);
            this.Controls.Add(this.dgvSatisYok);
            this.Controls.Add(this.dgvPlak);
            this.Controls.Add(this.txtIndirim);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtSanatci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlak)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisYok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisDevam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuncelle;
        private Button btnListele;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dgvPlak;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtSanatci;
        private Label label3;
        private Label label4;
        private TextBox txtPrice;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox txtIndirim;
        private GroupBox groupBox1;
        private RadioButton rbBitti;
        private RadioButton rbDevam;
        private DataGridView dgvSatisYok;
        private DataGridView dgvSatisDevam;
        private DataGridView dgvSonOn;
        private DataGridView dgvIndirim;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label dgvIndirimli;
        private Label label8;
        private Button btnListGuncelle;
        private Button btnTextDoldur;
        private Label label10;
    }
}