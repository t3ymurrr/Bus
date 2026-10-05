namespace Bus
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHaradan = new System.Windows.Forms.ComboBox();
            this.cmbHaraya = new System.Windows.Forms.ComboBox();
            this.mtxtTarix = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.txtYer = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();

            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtFIN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnBiletAl = new System.Windows.Forms.Button();

            this.listBoxBiletler = new System.Windows.Forms.ListBox();
            this.btnBiletiSil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(750, 480);
            this.BackColor = System.Drawing.Color.Gray;
            this.Text = "Travel Ticket";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.lblTitle.Text = "BMU TRAVEL";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(300, 15);
            this.lblTitle.AutoSize = true;

            this.groupBox1.Text = "Travel information";
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Size = new System.Drawing.Size(350, 230);

            this.label1.Text = "Haradan:";
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.cmbHaradan.Location = new System.Drawing.Point(100, 22);
            this.cmbHaradan.Size = new System.Drawing.Size(150, 25);

            this.btnSwap.Text = "<\n>";
            this.btnSwap.BackColor = System.Drawing.Color.Maroon;
            this.btnSwap.ForeColor = System.Drawing.Color.White;
            this.btnSwap.Location = new System.Drawing.Point(260, 22);
            this.btnSwap.Size = new System.Drawing.Size(60, 60);
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);

            this.label2.Text = "Haraya:";
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.cmbHaraya.Location = new System.Drawing.Point(100, 57);
            this.cmbHaraya.Size = new System.Drawing.Size(150, 25);

            this.label3.Text = "Tarix:";
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.mtxtTarix.Mask = "00/00/0000";
            this.mtxtTarix.Location = new System.Drawing.Point(100, 92);
            this.mtxtTarix.Size = new System.Drawing.Size(150, 25);

            this.label4.Text = "Saat:";
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.mtxtSaat.Mask = "00:00";
            this.mtxtSaat.Location = new System.Drawing.Point(100, 127);
            this.mtxtSaat.Size = new System.Drawing.Size(150, 25);

            this.label5.Text = "Yer:";
            this.label5.Location = new System.Drawing.Point(10, 165);
            this.txtYer.Location = new System.Drawing.Point(100, 162);
            this.txtYer.Size = new System.Drawing.Size(150, 25);

            this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.label1, this.cmbHaradan, this.btnSwap,
                this.label2, this.cmbHaraya,
                this.label3, this.mtxtTarix,
                this.label4, this.mtxtSaat,
                this.label5, this.txtYer
            });

            this.groupBox2.Text = "Person information";
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(380, 60);
            this.groupBox2.Size = new System.Drawing.Size(350, 230);

            this.label6.Text = "Ad ve soyad:";
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.txtAdSoyad.Location = new System.Drawing.Point(110, 22);
            this.txtAdSoyad.Size = new System.Drawing.Size(180, 25);

            this.label7.Text = "FIN:";
            this.label7.Location = new System.Drawing.Point(10, 60);
            this.txtFIN.Location = new System.Drawing.Point(110, 57);
            this.txtFIN.Size = new System.Drawing.Size(180, 25);

            this.label8.Text = "Email:";
            this.label8.Location = new System.Drawing.Point(10, 95);
            this.txtEmail.Location = new System.Drawing.Point(110, 92);
            this.txtEmail.Size = new System.Drawing.Size(180, 25);

            this.label9.Text = "Telefon:";
            this.label9.Location = new System.Drawing.Point(10, 130);
            this.mtxtTelefon.Mask = "(000) 000-00-00";
            this.mtxtTelefon.Location = new System.Drawing.Point(110, 127);
            this.mtxtTelefon.Size = new System.Drawing.Size(180, 25);

            this.btnBiletAl.Text = "Bilet al";
            this.btnBiletAl.BackColor = System.Drawing.Color.Green;
            this.btnBiletAl.ForeColor = System.Drawing.Color.White;
            this.btnBiletAl.Location = new System.Drawing.Point(110, 170);
            this.btnBiletAl.Size = new System.Drawing.Size(180, 35);
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);

            this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.label6, this.txtAdSoyad,
                this.label7, this.txtFIN,
                this.label8, this.txtEmail,
                this.label9, this.mtxtTelefon,
                this.btnBiletAl
            });

            this.listBoxBiletler.Location = new System.Drawing.Point(15, 300);
            this.listBoxBiletler.Size = new System.Drawing.Size(715, 100);

            this.btnBiletiSil.Text = "Bileti sil";
            this.btnBiletiSil.BackColor = System.Drawing.Color.Teal;
            this.btnBiletiSil.ForeColor = System.Drawing.Color.White;
            this.btnBiletiSil.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnBiletiSil.Location = new System.Drawing.Point(15, 415);
            this.btnBiletiSil.Size = new System.Drawing.Size(180, 35);
            this.btnBiletiSil.Click += new System.EventHandler(this.btnBiletiSil_Click);

            this.button3.Text = "Proqram çıx";
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(550, 415);
            this.button3.Size = new System.Drawing.Size(180, 35);
            this.button3.Click += new System.EventHandler(this.button3_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxBiletler);
            this.Controls.Add(this.btnBiletiSil);
            this.Controls.Add(this.button3);

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHaradan;
        private System.Windows.Forms.ComboBox cmbHaraya;
        private System.Windows.Forms.MaskedTextBox mtxtTarix;
        private System.Windows.Forms.MaskedTextBox mtxtSaat;
        private System.Windows.Forms.TextBox txtYer;
        private System.Windows.Forms.Button btnSwap;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtFIN;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.Button btnBiletAl;

        private System.Windows.Forms.ListBox listBoxBiletler;
        private System.Windows.Forms.Button btnBiletiSil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTitle;
    }
}