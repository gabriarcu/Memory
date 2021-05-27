
namespace Memory
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Giocatore = new System.Windows.Forms.Label();
            this.btn_esci = new System.Windows.Forms.Button();
            this.btn_punteggi = new System.Windows.Forms.Button();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_aggiungiGiocatore = new System.Windows.Forms.Button();
            this.txt_newGiocatore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_player = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_giocatore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livelloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giocatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxAggiungiGiocatore = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAggiungiGiocatore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btn_esci);
            this.panel1.Controls.Add(this.btn_punteggi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_newGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 557);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Giocatore);
            this.groupBox2.Location = new System.Drawing.Point(4, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // lbl_Giocatore
            // 
            this.lbl_Giocatore.AutoSize = true;
            this.lbl_Giocatore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Giocatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Giocatore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Giocatore.Location = new System.Drawing.Point(3, 16);
            this.lbl_Giocatore.Name = "lbl_Giocatore";
            this.lbl_Giocatore.Size = new System.Drawing.Size(60, 24);
            this.lbl_Giocatore.TabIndex = 4;
            this.lbl_Giocatore.Text = "label4";
            this.lbl_Giocatore.Click += new System.EventHandler(this.lbl_Giocatore_Click);
            // 
            // btn_esci
            // 
            this.btn_esci.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_esci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_esci.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_esci.Location = new System.Drawing.Point(3, 269);
            this.btn_esci.Name = "btn_esci";
            this.btn_esci.Size = new System.Drawing.Size(127, 40);
            this.btn_esci.TabIndex = 3;
            this.btn_esci.Text = "Esci";
            this.btn_esci.UseVisualStyleBackColor = false;
            this.btn_esci.Click += new System.EventHandler(this.btn_esci_Click);
            // 
            // btn_punteggi
            // 
            this.btn_punteggi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_punteggi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_punteggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_punteggi.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_punteggi.Location = new System.Drawing.Point(3, 214);
            this.btn_punteggi.Name = "btn_punteggi";
            this.btn_punteggi.Size = new System.Drawing.Size(127, 40);
            this.btn_punteggi.TabIndex = 2;
            this.btn_punteggi.Text = "Punteggi";
            this.btn_punteggi.UseVisualStyleBackColor = false;
            this.btn_punteggi.Click += new System.EventHandler(this.btn_punteggi_Click);
            // 
            // btn_newGame
            // 
            this.btn_newGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newGame.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_newGame.Location = new System.Drawing.Point(3, 159);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(127, 40);
            this.btn_newGame.TabIndex = 0;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = false;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(134, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 557);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 533);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1088, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1088, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(561, 501);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giocatore";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Punteggio";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tempo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mosse";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data Ora";
            this.columnHeader4.Width = 156;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.lbl_player);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cbo_giocatore);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.pictureBoxAggiungiGiocatore);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1088, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_aggiungiGiocatore);
            this.groupBox1.Controls.Add(this.txt_newGiocatore);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(454, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 185);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aggiungi giocatore";
            this.groupBox1.Visible = false;
            // 
            // btn_aggiungiGiocatore
            // 
            this.btn_aggiungiGiocatore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_aggiungiGiocatore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aggiungiGiocatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aggiungiGiocatore.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_aggiungiGiocatore.Location = new System.Drawing.Point(124, 117);
            this.btn_aggiungiGiocatore.Name = "btn_aggiungiGiocatore";
            this.btn_aggiungiGiocatore.Size = new System.Drawing.Size(127, 40);
            this.btn_aggiungiGiocatore.TabIndex = 5;
            this.btn_aggiungiGiocatore.Text = "Aggiungi";
            this.btn_aggiungiGiocatore.UseVisualStyleBackColor = false;
            this.btn_aggiungiGiocatore.Click += new System.EventHandler(this.btn_aggiungiGiocatore_Click);
            // 
            // txt_newGiocatore
            // 
            this.txt_newGiocatore.Location = new System.Drawing.Point(170, 44);
            this.txt_newGiocatore.Name = "txt_newGiocatore";
            this.txt_newGiocatore.Size = new System.Drawing.Size(182, 29);
            this.txt_newGiocatore.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome Giocatore";
            // 
            // lbl_player
            // 
            this.lbl_player.AutoSize = true;
            this.lbl_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_player.Location = new System.Drawing.Point(206, 119);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Size = new System.Drawing.Size(62, 24);
            this.lbl_player.TabIndex = 3;
            this.lbl_player.Text = "Scegli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(84, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player scelto";
            // 
            // cbo_giocatore
            // 
            this.cbo_giocatore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_giocatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbo_giocatore.FormattingEnabled = true;
            this.cbo_giocatore.Location = new System.Drawing.Point(206, 60);
            this.cbo_giocatore.Name = "cbo_giocatore";
            this.cbo_giocatore.Size = new System.Drawing.Size(121, 32);
            this.cbo_giocatore.TabIndex = 1;
            this.cbo_giocatore.SelectedIndexChanged += new System.EventHandler(this.cbo_giocatore_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scegli il giocatore";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opzioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opzioniToolStripMenuItem
            // 
            this.opzioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livelloToolStripMenuItem,
            this.giocatoriToolStripMenuItem});
            this.opzioniToolStripMenuItem.Name = "opzioniToolStripMenuItem";
            this.opzioniToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.opzioniToolStripMenuItem.Text = "Opzioni";
            // 
            // livelloToolStripMenuItem
            // 
            this.livelloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facileToolStripMenuItem,
            this.medioToolStripMenuItem,
            this.difficileToolStripMenuItem});
            this.livelloToolStripMenuItem.Name = "livelloToolStripMenuItem";
            this.livelloToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.livelloToolStripMenuItem.Text = "Livello";
            // 
            // facileToolStripMenuItem
            // 
            this.facileToolStripMenuItem.Name = "facileToolStripMenuItem";
            this.facileToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.facileToolStripMenuItem.Text = "Facile";
            this.facileToolStripMenuItem.Click += new System.EventHandler(this.facileToolStripMenuItem_Click);
            // 
            // medioToolStripMenuItem
            // 
            this.medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            this.medioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.medioToolStripMenuItem.Text = "Medio";
            this.medioToolStripMenuItem.Click += new System.EventHandler(this.medioToolStripMenuItem_Click);
            // 
            // difficileToolStripMenuItem
            // 
            this.difficileToolStripMenuItem.Name = "difficileToolStripMenuItem";
            this.difficileToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.difficileToolStripMenuItem.Text = "Difficile";
            this.difficileToolStripMenuItem.Click += new System.EventHandler(this.difficileToolStripMenuItem_Click);
            // 
            // giocatoriToolStripMenuItem
            // 
            this.giocatoriToolStripMenuItem.Name = "giocatoriToolStripMenuItem";
            this.giocatoriToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.giocatoriToolStripMenuItem.Text = "Gestione Giocatori";
            this.giocatoriToolStripMenuItem.Click += new System.EventHandler(this.giocatoriToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 750;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBoxAggiungiGiocatore
            // 
            this.pictureBoxAggiungiGiocatore.Location = new System.Drawing.Point(333, 60);
            this.pictureBoxAggiungiGiocatore.Name = "pictureBoxAggiungiGiocatore";
            this.pictureBoxAggiungiGiocatore.Size = new System.Drawing.Size(38, 32);
            this.pictureBoxAggiungiGiocatore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAggiungiGiocatore.TabIndex = 4;
            this.pictureBoxAggiungiGiocatore.TabStop = false;
            this.pictureBoxAggiungiGiocatore.Click += new System.EventHandler(this.pictureBoxAggiungiGiocatore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Memory.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAggiungiGiocatore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_esci;
        private System.Windows.Forms.Button btn_punteggi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opzioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livelloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficileToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem giocatoriToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxAggiungiGiocatore;
        private System.Windows.Forms.Label lbl_player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_giocatore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_aggiungiGiocatore;
        private System.Windows.Forms.TextBox txt_newGiocatore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Giocatore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Timer timer2;
    }
}

