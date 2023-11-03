namespace PrivatnaOrdinacija_WindowsForms
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonIzadji = new System.Windows.Forms.Button();
            this.buttonDodajPosetu = new System.Windows.Forms.Button();
            this.buttonIzvestaj = new System.Windows.Forms.Button();
            this.buttonPretrazi = new System.Windows.Forms.Button();
            this.buttonSpisak = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonPocetna = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.naslov = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.panelMenu.Controls.Add(this.buttonIzadji);
            this.panelMenu.Controls.Add(this.buttonDodajPosetu);
            this.panelMenu.Controls.Add(this.buttonIzvestaj);
            this.panelMenu.Controls.Add(this.buttonPretrazi);
            this.panelMenu.Controls.Add(this.buttonSpisak);
            this.panelMenu.Controls.Add(this.buttonDodaj);
            this.panelMenu.Controls.Add(this.buttonPocetna);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 572);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonIzadji
            // 
            this.buttonIzadji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIzadji.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonIzadji.FlatAppearance.BorderSize = 0;
            this.buttonIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIzadji.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzadji.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonIzadji.Image = global::PrivatnaOrdinacija_WindowsForms.Properties.Resources.download__7_;
            this.buttonIzadji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIzadji.Location = new System.Drawing.Point(0, 512);
            this.buttonIzadji.Name = "buttonIzadji";
            this.buttonIzadji.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonIzadji.Size = new System.Drawing.Size(220, 60);
            this.buttonIzadji.TabIndex = 7;
            this.buttonIzadji.Text = "  Izadji";
            this.buttonIzadji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIzadji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonIzadji.UseVisualStyleBackColor = true;
            this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
            // 
            // buttonDodajPosetu
            // 
            this.buttonDodajPosetu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajPosetu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDodajPosetu.FlatAppearance.BorderSize = 0;
            this.buttonDodajPosetu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajPosetu.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajPosetu.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDodajPosetu.Image = global::PrivatnaOrdinacija_WindowsForms.Properties.Resources.download__6_;
            this.buttonDodajPosetu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDodajPosetu.Location = new System.Drawing.Point(0, 380);
            this.buttonDodajPosetu.Name = "buttonDodajPosetu";
            this.buttonDodajPosetu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDodajPosetu.Size = new System.Drawing.Size(220, 60);
            this.buttonDodajPosetu.TabIndex = 6;
            this.buttonDodajPosetu.Text = "  Dodaj Posetu";
            this.buttonDodajPosetu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDodajPosetu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDodajPosetu.UseVisualStyleBackColor = true;
            this.buttonDodajPosetu.Click += new System.EventHandler(this.buttonDodajPosetu_Click);
            // 
            // buttonIzvestaj
            // 
            this.buttonIzvestaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIzvestaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIzvestaj.FlatAppearance.BorderSize = 0;
            this.buttonIzvestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIzvestaj.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzvestaj.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonIzvestaj.Image = global::PrivatnaOrdinacija_WindowsForms.Properties.Resources.download__5_;
            this.buttonIzvestaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIzvestaj.Location = new System.Drawing.Point(0, 320);
            this.buttonIzvestaj.Name = "buttonIzvestaj";
            this.buttonIzvestaj.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonIzvestaj.Size = new System.Drawing.Size(220, 60);
            this.buttonIzvestaj.TabIndex = 5;
            this.buttonIzvestaj.Text = "  Izveštaji";
            this.buttonIzvestaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIzvestaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonIzvestaj.UseVisualStyleBackColor = true;
            this.buttonIzvestaj.Click += new System.EventHandler(this.buttonIzvestaj_Click);
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPretrazi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPretrazi.FlatAppearance.BorderSize = 0;
            this.buttonPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPretrazi.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPretrazi.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPretrazi.Image = global::PrivatnaOrdinacija_WindowsForms.Properties.Resources.download__4_;
            this.buttonPretrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPretrazi.Location = new System.Drawing.Point(0, 260);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPretrazi.Size = new System.Drawing.Size(220, 60);
            this.buttonPretrazi.TabIndex = 4;
            this.buttonPretrazi.Text = "  Pretraži";
            this.buttonPretrazi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPretrazi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            this.buttonPretrazi.Click += new System.EventHandler(this.buttonPretrazi_Click);
            // 
            // buttonSpisak
            // 
            this.buttonSpisak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpisak.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSpisak.FlatAppearance.BorderSize = 0;
            this.buttonSpisak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpisak.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpisak.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSpisak.Image = global::PrivatnaOrdinacija_WindowsForms.Properties.Resources.download__3_;
            this.buttonSpisak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSpisak.Location = new System.Drawing.Point(0, 200);
            this.buttonSpisak.Name = "buttonSpisak";
            this.buttonSpisak.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonSpisak.Size = new System.Drawing.Size(220, 60);
            this.buttonSpisak.TabIndex = 3;
            this.buttonSpisak.Text = "  Spisak pacijenata";
            this.buttonSpisak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSpisak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSpisak.UseVisualStyleBackColor = true;
            this.buttonSpisak.Click += new System.EventHandler(this.buttonSpisak_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDodaj.FlatAppearance.BorderSize = 0;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDodaj.Image = global::PrivatnaOrdinacija_WindowsForms.Properties.Resources.download__2_;
            this.buttonDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDodaj.Location = new System.Drawing.Point(0, 140);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDodaj.Size = new System.Drawing.Size(220, 60);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "  Dodaj Pacijenta";
            this.buttonDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonPocetna
            // 
            this.buttonPocetna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPocetna.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPocetna.FlatAppearance.BorderSize = 0;
            this.buttonPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPocetna.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPocetna.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPocetna.Image = global::PrivatnaOrdinacija_WindowsForms.Properties.Resources.download__1_;
            this.buttonPocetna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPocetna.Location = new System.Drawing.Point(0, 80);
            this.buttonPocetna.Name = "buttonPocetna";
            this.buttonPocetna.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPocetna.Size = new System.Drawing.Size(220, 60);
            this.buttonPocetna.TabIndex = 1;
            this.buttonPocetna.Text = "  Početna";
            this.buttonPocetna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPocetna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPocetna.UseVisualStyleBackColor = true;
            this.buttonPocetna.Click += new System.EventHandler(this.buttonPocetna_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.panelHeader.Controls.Add(this.naslov);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(813, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // naslov
            // 
            this.naslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.ForeColor = System.Drawing.Color.Gainsboro;
            this.naslov.Location = new System.Drawing.Point(321, 31);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(80, 21);
            this.naslov.TabIndex = 0;
            this.naslov.Text = "  Početna";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(813, 492);
            this.panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 572);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonPocetna;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonDodajPosetu;
        private System.Windows.Forms.Button buttonPretrazi;
        private System.Windows.Forms.Button buttonSpisak;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzadji;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonIzvestaj;
    }
}

