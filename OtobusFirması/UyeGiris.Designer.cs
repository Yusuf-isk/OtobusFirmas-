namespace OtobusFirması
{
    partial class UyeGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeGiris));
            this.comboNereden = new System.Windows.Forms.ComboBox();
            this.labelNerden = new System.Windows.Forms.Label();
            this.labelNereye = new System.Windows.Forms.Label();
            this.comboNereye = new System.Windows.Forms.ComboBox();
            this.labelGün = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.labelTC = new System.Windows.Forms.Label();
            this.radioButtonE = new System.Windows.Forms.RadioButton();
            this.radioButtonK = new System.Windows.Forms.RadioButton();
            this.labelİsim = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.btnRezerve = new System.Windows.Forms.Button();
            this.labelSeferNo = new System.Windows.Forms.Label();
            this.labelNerdem = new System.Windows.Forms.Label();
            this.labelNereye2 = new System.Windows.Forms.Label();
            this.labelKalkis = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelKalanKoltuk = new System.Windows.Forms.Label();
            this.groupBoxUye = new System.Windows.Forms.GroupBox();
            this.groupKoltuk = new System.Windows.Forms.GroupBox();
            this.groupBoxUye.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboNereden
            // 
            this.comboNereden.FormattingEnabled = true;
            this.comboNereden.Location = new System.Drawing.Point(53, 124);
            this.comboNereden.Margin = new System.Windows.Forms.Padding(4);
            this.comboNereden.Name = "comboNereden";
            this.comboNereden.Size = new System.Drawing.Size(160, 24);
            this.comboNereden.TabIndex = 0;
            this.comboNereden.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelNerden
            // 
            this.labelNerden.AutoSize = true;
            this.labelNerden.Location = new System.Drawing.Point(49, 105);
            this.labelNerden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNerden.Name = "labelNerden";
            this.labelNerden.Size = new System.Drawing.Size(63, 17);
            this.labelNerden.TabIndex = 1;
            this.labelNerden.Text = "Nerden?";
            // 
            // labelNereye
            // 
            this.labelNereye.AutoSize = true;
            this.labelNereye.Location = new System.Drawing.Point(348, 105);
            this.labelNereye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNereye.Name = "labelNereye";
            this.labelNereye.Size = new System.Drawing.Size(62, 17);
            this.labelNereye.TabIndex = 2;
            this.labelNereye.Text = "Nereye?";
            // 
            // comboNereye
            // 
            this.comboNereye.FormattingEnabled = true;
            this.comboNereye.Location = new System.Drawing.Point(249, 124);
            this.comboNereye.Margin = new System.Windows.Forms.Padding(4);
            this.comboNereye.Name = "comboNereye";
            this.comboNereye.Size = new System.Drawing.Size(160, 24);
            this.comboNereye.TabIndex = 4;
            this.comboNereye.SelectedIndexChanged += new System.EventHandler(this.comboNereye_SelectedIndexChanged);
            // 
            // labelGün
            // 
            this.labelGün.AutoSize = true;
            this.labelGün.Location = new System.Drawing.Point(49, 55);
            this.labelGün.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGün.Name = "labelGün";
            this.labelGün.Size = new System.Drawing.Size(84, 17);
            this.labelGün.TabIndex = 5;
            this.labelGün.Text = "Gün Seçiniz";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 55);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(180, 158);
            this.btnSorgula.Margin = new System.Windows.Forms.Padding(4);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(100, 28);
            this.btnSorgula.TabIndex = 7;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(197, 33);
            this.textBoxTC.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(132, 22);
            this.textBoxTC.TabIndex = 62;
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Location = new System.Drawing.Point(6, 33);
            this.labelTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(134, 17);
            this.labelTC.TabIndex = 64;
            this.labelTC.Text = "T.C Kimlik Numarası";
            // 
            // radioButtonE
            // 
            this.radioButtonE.AutoSize = true;
            this.radioButtonE.Location = new System.Drawing.Point(31, 98);
            this.radioButtonE.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonE.Name = "radioButtonE";
            this.radioButtonE.Size = new System.Drawing.Size(53, 21);
            this.radioButtonE.TabIndex = 66;
            this.radioButtonE.TabStop = true;
            this.radioButtonE.Text = "Bay";
            this.radioButtonE.UseVisualStyleBackColor = true;
            // 
            // radioButtonK
            // 
            this.radioButtonK.AutoSize = true;
            this.radioButtonK.Location = new System.Drawing.Point(222, 98);
            this.radioButtonK.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonK.Name = "radioButtonK";
            this.radioButtonK.Size = new System.Drawing.Size(69, 21);
            this.radioButtonK.TabIndex = 67;
            this.radioButtonK.TabStop = true;
            this.radioButtonK.Text = "Bayan";
            this.radioButtonK.UseVisualStyleBackColor = true;
            // 
            // labelİsim
            // 
            this.labelİsim.AutoSize = true;
            this.labelİsim.Location = new System.Drawing.Point(7, 66);
            this.labelİsim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelİsim.Name = "labelİsim";
            this.labelİsim.Size = new System.Drawing.Size(32, 17);
            this.labelİsim.TabIndex = 68;
            this.labelİsim.Text = "İsim";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(197, 66);
            this.textBoxAd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(132, 22);
            this.textBoxAd.TabIndex = 69;
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Enabled = false;
            this.btnBiletAl.Location = new System.Drawing.Point(641, 266);
            this.btnBiletAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(100, 28);
            this.btnBiletAl.TabIndex = 70;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRezerve
            // 
            this.btnRezerve.Location = new System.Drawing.Point(818, 266);
            this.btnRezerve.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezerve.Name = "btnRezerve";
            this.btnRezerve.Size = new System.Drawing.Size(100, 28);
            this.btnRezerve.TabIndex = 71;
            this.btnRezerve.Text = "Rezerve Et";
            this.btnRezerve.UseVisualStyleBackColor = true;
            // 
            // labelSeferNo
            // 
            this.labelSeferNo.AutoSize = true;
            this.labelSeferNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSeferNo.Location = new System.Drawing.Point(1074, 90);
            this.labelSeferNo.Name = "labelSeferNo";
            this.labelSeferNo.Size = new System.Drawing.Size(60, 17);
            this.labelSeferNo.TabIndex = 72;
            this.labelSeferNo.Text = "SeferNo";
            // 
            // labelNerdem
            // 
            this.labelNerdem.AutoSize = true;
            this.labelNerdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNerdem.Location = new System.Drawing.Point(1160, 90);
            this.labelNerdem.Name = "labelNerdem";
            this.labelNerdem.Size = new System.Drawing.Size(55, 17);
            this.labelNerdem.TabIndex = 73;
            this.labelNerdem.Text = "Nerden";
            // 
            // labelNereye2
            // 
            this.labelNereye2.AutoSize = true;
            this.labelNereye2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNereye2.Location = new System.Drawing.Point(1253, 90);
            this.labelNereye2.Name = "labelNereye2";
            this.labelNereye2.Size = new System.Drawing.Size(54, 17);
            this.labelNereye2.TabIndex = 74;
            this.labelNereye2.Text = "Nereye";
            // 
            // labelKalkis
            // 
            this.labelKalkis.AllowDrop = true;
            this.labelKalkis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKalkis.Location = new System.Drawing.Point(1351, 90);
            this.labelKalkis.Name = "labelKalkis";
            this.labelKalkis.Size = new System.Drawing.Size(46, 17);
            this.labelKalkis.TabIndex = 75;
            this.labelKalkis.Text = "Kalkış";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyat.Location = new System.Drawing.Point(1438, 90);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(38, 17);
            this.labelFiyat.TabIndex = 76;
            this.labelFiyat.Text = "Fiyat";
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.Location = new System.Drawing.Point(1541, 90);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(41, 17);
            this.labelTarih.TabIndex = 77;
            this.labelTarih.Text = "Tarih";
            // 
            // labelKalanKoltuk
            // 
            this.labelKalanKoltuk.AutoSize = true;
            this.labelKalanKoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKalanKoltuk.Location = new System.Drawing.Point(1605, 90);
            this.labelKalanKoltuk.Name = "labelKalanKoltuk";
            this.labelKalanKoltuk.Size = new System.Drawing.Size(87, 17);
            this.labelKalanKoltuk.TabIndex = 78;
            this.labelKalanKoltuk.Text = "Kalan Koltuk";
            // 
            // groupBoxUye
            // 
            this.groupBoxUye.Controls.Add(this.radioButtonE);
            this.groupBoxUye.Controls.Add(this.textBoxTC);
            this.groupBoxUye.Controls.Add(this.labelTC);
            this.groupBoxUye.Controls.Add(this.labelİsim);
            this.groupBoxUye.Controls.Add(this.textBoxAd);
            this.groupBoxUye.Controls.Add(this.radioButtonK);
            this.groupBoxUye.Location = new System.Drawing.Point(610, 81);
            this.groupBoxUye.Name = "groupBoxUye";
            this.groupBoxUye.Size = new System.Drawing.Size(348, 124);
            this.groupBoxUye.TabIndex = 79;
            this.groupBoxUye.TabStop = false;
            this.groupBoxUye.Visible = false;
            // 
            // groupKoltuk
            // 
            this.groupKoltuk.Location = new System.Drawing.Point(64, 193);
            this.groupKoltuk.Name = "groupKoltuk";
            this.groupKoltuk.Size = new System.Drawing.Size(387, 583);
            this.groupKoltuk.TabIndex = 80;
            this.groupKoltuk.TabStop = false;
            this.groupKoltuk.Visible = false;
            // 
            // UyeGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 824);
            this.Controls.Add(this.groupKoltuk);
            this.Controls.Add(this.groupBoxUye);
            this.Controls.Add(this.labelKalanKoltuk);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.labelKalkis);
            this.Controls.Add(this.labelNereye2);
            this.Controls.Add(this.labelNerdem);
            this.Controls.Add(this.labelSeferNo);
            this.Controls.Add(this.btnRezerve);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelGün);
            this.Controls.Add(this.comboNereye);
            this.Controls.Add(this.labelNereye);
            this.Controls.Add(this.labelNerden);
            this.Controls.Add(this.comboNereden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UyeGiris";
            this.Text = "UyeGiris";
            this.Load += new System.EventHandler(this.AdminGiris_Load);
            this.groupBoxUye.ResumeLayout(false);
            this.groupBoxUye.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboNereden;
        private System.Windows.Forms.Label labelNerden;
        private System.Windows.Forms.Label labelNereye;
        private System.Windows.Forms.ComboBox comboNereye;
        private System.Windows.Forms.Label labelGün;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.RadioButton radioButtonE;
        private System.Windows.Forms.RadioButton radioButtonK;
        private System.Windows.Forms.Label labelİsim;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.Button btnRezerve;
        private System.Windows.Forms.Label labelSeferNo;
        private System.Windows.Forms.Label labelNerdem;
        private System.Windows.Forms.Label labelNereye2;
        private System.Windows.Forms.Label labelKalkis;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label labelKalanKoltuk;
        private System.Windows.Forms.GroupBox groupBoxUye;
        private System.Windows.Forms.GroupBox groupKoltuk;
    }
}