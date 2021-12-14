namespace UserTable
{
    partial class Form1
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
            this.id = new System.Windows.Forms.Label();
            this.login_name = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.login_name_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.ime_tb = new System.Windows.Forms.TextBox();
            this.prezime_tb = new System.Windows.Forms.TextBox();
            this.tip_tb = new System.Windows.Forms.TextBox();
            this.unesi = new System.Windows.Forms.Button();
            this.izmeni = new System.Windows.Forms.Button();
            this.izbrisi = new System.Windows.Forms.Button();
            this.pocetak = new System.Windows.Forms.Button();
            this.levo = new System.Windows.Forms.Button();
            this.desno = new System.Windows.Forms.Button();
            this.kraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(155, 37);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            // 
            // login_name
            // 
            this.login_name.AutoSize = true;
            this.login_name.Location = new System.Drawing.Point(155, 82);
            this.login_name.Name = "login_name";
            this.login_name.Size = new System.Drawing.Size(52, 13);
            this.login_name.TabIndex = 1;
            this.login_name.Text = "Login ime";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(155, 124);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(44, 13);
            this.pass.TabIndex = 2;
            this.pass.Text = "Lozinka";
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(155, 163);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(24, 13);
            this.ime.TabIndex = 3;
            this.ime.Text = "Ime";
            // 
            // prezime
            // 
            this.prezime.AutoSize = true;
            this.prezime.Location = new System.Drawing.Point(155, 203);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(44, 13);
            this.prezime.TabIndex = 4;
            this.prezime.Text = "Prezime";
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Location = new System.Drawing.Point(155, 242);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(67, 13);
            this.tip.TabIndex = 5;
            this.tip.Text = "Tip korisnika";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(226, 34);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(81, 20);
            this.id_tb.TabIndex = 6;
            // 
            // login_name_tb
            // 
            this.login_name_tb.Location = new System.Drawing.Point(226, 79);
            this.login_name_tb.Name = "login_name_tb";
            this.login_name_tb.Size = new System.Drawing.Size(81, 20);
            this.login_name_tb.TabIndex = 7;
            // 
            // pass_tb
            // 
            this.pass_tb.Location = new System.Drawing.Point(226, 121);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(81, 20);
            this.pass_tb.TabIndex = 8;
            // 
            // ime_tb
            // 
            this.ime_tb.Location = new System.Drawing.Point(226, 160);
            this.ime_tb.Name = "ime_tb";
            this.ime_tb.Size = new System.Drawing.Size(81, 20);
            this.ime_tb.TabIndex = 9;
            // 
            // prezime_tb
            // 
            this.prezime_tb.Location = new System.Drawing.Point(226, 200);
            this.prezime_tb.Name = "prezime_tb";
            this.prezime_tb.Size = new System.Drawing.Size(81, 20);
            this.prezime_tb.TabIndex = 10;
            // 
            // tip_tb
            // 
            this.tip_tb.Location = new System.Drawing.Point(226, 239);
            this.tip_tb.Name = "tip_tb";
            this.tip_tb.Size = new System.Drawing.Size(81, 20);
            this.tip_tb.TabIndex = 11;
            // 
            // unesi
            // 
            this.unesi.Location = new System.Drawing.Point(226, 305);
            this.unesi.Name = "unesi";
            this.unesi.Size = new System.Drawing.Size(75, 23);
            this.unesi.TabIndex = 12;
            this.unesi.Text = "Unesi";
            this.unesi.UseVisualStyleBackColor = true;
            this.unesi.Click += new System.EventHandler(this.Unesi_Click);
            // 
            // izmeni
            // 
            this.izmeni.Location = new System.Drawing.Point(349, 305);
            this.izmeni.Name = "izmeni";
            this.izmeni.Size = new System.Drawing.Size(75, 23);
            this.izmeni.TabIndex = 13;
            this.izmeni.Text = "Izmeni";
            this.izmeni.UseVisualStyleBackColor = true;
            this.izmeni.Click += new System.EventHandler(this.Izmeni_Click);
            // 
            // izbrisi
            // 
            this.izbrisi.Location = new System.Drawing.Point(477, 305);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(75, 23);
            this.izbrisi.TabIndex = 14;
            this.izbrisi.Text = "Izbrisi";
            this.izbrisi.UseVisualStyleBackColor = true;
            this.izbrisi.Click += new System.EventHandler(this.Izbrisi_Click);
            // 
            // pocetak
            // 
            this.pocetak.Location = new System.Drawing.Point(158, 352);
            this.pocetak.Name = "pocetak";
            this.pocetak.Size = new System.Drawing.Size(75, 51);
            this.pocetak.TabIndex = 15;
            this.pocetak.Text = "Idi na pocetak";
            this.pocetak.UseVisualStyleBackColor = true;
            this.pocetak.Click += new System.EventHandler(this.Pocetak_Click);
            // 
            // levo
            // 
            this.levo.Location = new System.Drawing.Point(282, 352);
            this.levo.Name = "levo";
            this.levo.Size = new System.Drawing.Size(75, 51);
            this.levo.TabIndex = 16;
            this.levo.Text = "Idi levo";
            this.levo.UseVisualStyleBackColor = true;
            this.levo.Click += new System.EventHandler(this.Levo_Click);
            // 
            // desno
            // 
            this.desno.Location = new System.Drawing.Point(410, 352);
            this.desno.Name = "desno";
            this.desno.Size = new System.Drawing.Size(75, 51);
            this.desno.TabIndex = 17;
            this.desno.Text = "Idi desno";
            this.desno.UseVisualStyleBackColor = true;
            this.desno.Click += new System.EventHandler(this.Desno_Click);
            // 
            // kraj
            // 
            this.kraj.Location = new System.Drawing.Point(542, 352);
            this.kraj.Name = "kraj";
            this.kraj.Size = new System.Drawing.Size(75, 51);
            this.kraj.TabIndex = 18;
            this.kraj.Text = "Idi na kraj";
            this.kraj.UseVisualStyleBackColor = true;
            this.kraj.Click += new System.EventHandler(this.Kraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kraj);
            this.Controls.Add(this.desno);
            this.Controls.Add(this.levo);
            this.Controls.Add(this.pocetak);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.izmeni);
            this.Controls.Add(this.unesi);
            this.Controls.Add(this.tip_tb);
            this.Controls.Add(this.prezime_tb);
            this.Controls.Add(this.ime_tb);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.login_name_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login_name);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label login_name;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox login_name_tb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.TextBox ime_tb;
        private System.Windows.Forms.TextBox prezime_tb;
        private System.Windows.Forms.TextBox tip_tb;
        private System.Windows.Forms.Button unesi;
        private System.Windows.Forms.Button izmeni;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button pocetak;
        private System.Windows.Forms.Button levo;
        private System.Windows.Forms.Button desno;
        private System.Windows.Forms.Button kraj;
    }
}

