using System;
using System.Drawing;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        int secondo = 0;
        DateTime dt = new DateTime();
        string[] carte = new string[25];

        string[] facile = new string[13];
        string[] medio = new string[19];
        string[] difficile = new string[25];
        string livello = "facile";
        int coppie = 0;
        int conta = 0;
        int mosse = 0;

        string carta1 = default;
        string carta2 = default;
        public Form1()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            facileToolStripMenuItem.Checked = true;
            facileToolStripMenuItem.Checked = true;
            medioToolStripMenuItem.Checked = false;
            difficileToolStripMenuItem.Checked = false;
            tabControl1.TabPages[0].Controls.Clear();
            MyFunz.CaricaFacile(facile);
            MyFunz.CaricaMedio(medio);
            MyFunz.CaricaDifficile(difficile);
            MyFunz.MischiaCarte(facile);
            MyFunz.MischiaCarte(medio);
            MyFunz.MischiaCarte(difficile);


            int x = 1;

            int cy = 18;
            int cy2 = 18;
            int cy3 = 18;

            while (x < 13)
            {
                PictureBox t1 = new PictureBox();

                t1.Name = facile[x];
                if (x < 5)
                {
                    t1.Location = new Point((cy), 15);
                    cy = cy + 131;
                }

                if (x > 4 && x < 9)
                {
                    t1.Location = new Point(cy2, 157);
                    cy2 = cy2 + 131;
                }

                if (x > 8 && x < 17)
                {
                    t1.Location = new Point((cy3), 295);
                    cy3 = cy3 + 131;
                }

                t1.ImageLocation = (@"..\..\Resources\dorso.png");

                t1.BackgroundImageLayout = ImageLayout.Stretch;
                t1.SizeMode = PictureBoxSizeMode.StretchImage;
                t1.AutoSize = false;
                t1.Width = 114;
                t1.Height = 122;

                t1.Visible = true;
                t1.Enabled = false;
                tabControl1.TabPages[0].Controls.Add(t1);
                
                t1.Click += (s, args) =>
                {
                    conta = conta + 1;
                    switch (conta)
                    {
                        case 1:
                            carta1 = "";
                            carta1 = t1.Name;

                            
                            break;
                        case 2:
                            carta2 = "";
                            carta2 = t1.Name;
                            if (carta2.Substring(0,1)!= carta1.Substring(0, 1))
                            {
                                MessageBox.Show("Diversi");
                            }
                            else
                            {
                                coppie = coppie + 1;
                                if (coppie==6)
                                {
                                    timer1.Stop();
                                    MessageBox.Show("Vinto");
                                }

                                MessageBox.Show("Uguali");
                            }


                            conta = 0;
                            break;
                        
                    }
                    string car = default; ;
                    string[] a = (t1.Name).Split('.');
                    string b = a[0].Substring(1);
                    string c = a[0].Substring(0, 1);
                    if (b == "a")
                    {
                        car = facile[int.Parse(c)];
                    }
                    else
                        car = facile[(int.Parse(c)) + 6];

                    t1.ImageLocation = (@"..\..\Resources\Carte\" + car);
                    mosse = mosse + 1;
                    (this.Controls.Find("lbl_mosse", true)[0] as Label).Text = mosse.ToString();

                };


                GroupBox t2 = new GroupBox();
                t2.Location = new Point((18), 420);
                t2.Name = "groupBox_Dati";
                t2.Width = 950;
                t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t2.ForeColor = System.Drawing.Color.Black;
                t2.Text = "Dati";

                Label t3 = new Label();
                t3.AutoSize = true;
                t3.Location = new Point((5), 40);
                t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t3.ForeColor = System.Drawing.Color.SteelBlue;
                // t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t3.Text = "Mosse";
                t2.Controls.Add(t3);

                Label t4 = new Label();
                // t4.AutoSize = true;
                t4.Name = "lbl_mosse";
                t4.Location = new Point((100), 40);
                t4.Height = 27;
                t4.Width = 55;
                t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t4.ForeColor = System.Drawing.Color.SteelBlue;
                t4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                t4.Text = "0";
                t2.Controls.Add(t4);

                Label t5 = new Label();
                t5.AutoSize = true;
                t5.Location = new Point((200), 40);
                t5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t5.ForeColor = System.Drawing.Color.SteelBlue;
                // t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t5.Text = "Timer";
                t2.Controls.Add(t5);

                Label t6 = new Label();
                // t4.AutoSize = true;
                t6.Name = "lbl_timer";
                t6.Location = new Point((280), 40);
                t6.Height = 27;
                t6.Width = 110;
                t6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t6.ForeColor = System.Drawing.Color.SteelBlue;
                t6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                t6.Text = "00:00:00";
                t2.Controls.Add(t6);

                tabControl1.TabPages[0].Controls.Add(t2);

                x = x + 1;
            }
        }

        private void facileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facileToolStripMenuItem.Checked = true;
            medioToolStripMenuItem.Checked = false;
            difficileToolStripMenuItem.Checked = false;
            tabControl1.TabPages[0].Controls.Clear();
            livello = "facile";

            int x = 1;

            int cy = 18;
            int cy2 = 18;
            int cy3 = 18;
            while (x < 13)
            {
                PictureBox t1 = new PictureBox();

                t1.Name = facile[x];
                if (x < 5)
                {
                    t1.Location = new Point((cy), 15);
                    cy = cy + 131;
                }

                if (x > 4 && x < 9)
                {
                    t1.Location = new Point(cy2, 157);
                    cy2 = cy2 + 131;
                }

                if (x > 8 && x < 17)
                {
                    t1.Location = new Point((cy3), 295);
                    cy3 = cy3 + 131;
                }

                t1.ImageLocation = (@"..\..\Resources\dorso.png");

                t1.BackgroundImageLayout = ImageLayout.Stretch;
                t1.SizeMode = PictureBoxSizeMode.StretchImage;
                t1.AutoSize = false;
                t1.Width = 114;
                t1.Height = 122;
                t1.Enabled = false;
                t1.Visible = true;
                tabControl1.TabPages[0].Controls.Add(t1);
                t1.Click += (s, args) =>
                {
                    string car = default; ;
                    string[] a = (t1.Name).Split('.');
                    string b = a[0].Substring(1);
                    string c = a[0].Substring(0, 1);
                    if (b == "a")
                    {
                        car = facile[int.Parse(c)];
                    }
                    else
                        car = facile[(int.Parse(c)) + 6];

                    t1.ImageLocation = (@"..\..\Resources\Carte\" + car);
                };


                GroupBox t2 = new GroupBox();
                t2.Location = new Point((18), 420);
                t2.Width = 950;
                t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t2.ForeColor = System.Drawing.Color.Black;
                t2.Text = "Dati";

                Label t3 = new Label();
                t3.AutoSize = true;
                t3.Location = new Point((5), 40);
                t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t3.ForeColor = System.Drawing.Color.SteelBlue;
                // t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t3.Text = "Mosse";
                t2.Controls.Add(t3);

                Label t4 = new Label();
                // t4.AutoSize = true;
                t4.Name = "lbl_mosse";
                t4.Location = new Point((100), 40);
                t4.Height = 27;
                t4.Width = 55;
                t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t4.ForeColor = System.Drawing.Color.SteelBlue;
                t4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                t4.Text = "999";
                t2.Controls.Add(t4);

                Label t5 = new Label();
                t5.AutoSize = true;
                t5.Location = new Point((200), 40);
                t5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t5.ForeColor = System.Drawing.Color.SteelBlue;
                // t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t5.Text = "Timer";
                t2.Controls.Add(t5);

                Label t6 = new Label();
                // t4.AutoSize = true;
                t6.Name = "lbl_timer";
                t6.Location = new Point((280), 40);
                t6.Height = 27;
                t6.Width = 110;
                t6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t6.ForeColor = System.Drawing.Color.SteelBlue;
                t6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                t6.Text = "00:00:00";
                t2.Controls.Add(t6);

                tabControl1.TabPages[0].Controls.Add(t2);

                x = x + 1;
            }

        }
        private void medioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].Controls.Clear();
            medioToolStripMenuItem.Checked = true;
            facileToolStripMenuItem.Checked = false;
            difficileToolStripMenuItem.Checked = false;
            livello = "medio";
            int x = 1;

            int cy = 18;
            int cy2 = 18;
            int cy3 = 18;
            while (x < 19)
            {
                PictureBox t1 = new PictureBox();
                t1.Name = medio[x];
                if (x < 7)
                {
                    t1.Location = new Point((cy), 15);
                    cy = cy + 131;
                }

                if (x > 6 && x < 13)
                {
                    t1.Location = new Point(cy2, 157);
                    cy2 = cy2 + 131;
                }

                if (x > 12 && x < 19)
                {
                    t1.Location = new Point((cy3), 295);
                    cy3 = cy3 + 131;
                }

                t1.ImageLocation = (@"..\..\Resources\dorso.png");

                t1.BackgroundImageLayout = ImageLayout.Stretch;
                t1.SizeMode = PictureBoxSizeMode.StretchImage;
                t1.AutoSize = false;
                t1.Width = 114;
                t1.Height = 122;
                t1.Enabled = false;
                t1.Visible = true;
                tabControl1.TabPages[0].Controls.Add(t1);
                t1.Click += (s, args) =>
                {
                    string car = default; ;
                    string[] a = (t1.Name).Split('.');
                    string b = a[0].Substring(1);
                    string c = a[0].Substring(0, 1);
                    if (b == "a")
                    {
                        car = medio[int.Parse(c)];
                    }
                    else
                        car = medio[(int.Parse(c)) + 9];

                    t1.ImageLocation = (@"..\..\Resources\Carte\" + car);
                };

                GroupBox t2 = new GroupBox();
                t2.Location = new Point((18), 420);
                t2.Width = 950;
                t2.Text = "Dati";

                Label t3 = new Label();
                t3.AutoSize = true;
                t3.Location = new Point((5), 40);
                t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t3.ForeColor = System.Drawing.Color.SteelBlue;
                // t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t3.Text = "Mosse";
                t2.Controls.Add(t3);

                Label t4 = new Label();
                // t4.AutoSize = true;
                t4.Name = "lbl_mosse";
                t4.Location = new Point((100), 40);
                t4.Height = 27;
                t4.Width = 55;
                t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t4.ForeColor = System.Drawing.Color.SteelBlue;
                t4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                t4.Text = "999";
                t2.Controls.Add(t4);

                Label t5 = new Label();
                t5.AutoSize = true;
                t5.Location = new Point((200), 40);
                t5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t5.ForeColor = System.Drawing.Color.SteelBlue;
                // t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t5.Text = "Timer";
                t2.Controls.Add(t5);

                Label t6 = new Label();
                // t4.AutoSize = true;
                t6.Name = "lbl_timer";
                t6.Location = new Point((280), 40);
                t6.Height = 27;
                t6.Width = 110;
                t6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t6.ForeColor = System.Drawing.Color.SteelBlue;
                t6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                t6.Text = "00:00:00";
                t2.Controls.Add(t6);

                tabControl1.TabPages[0].Controls.Add(t2);


                x = x + 1;
            }
        }

        private void difficileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].Controls.Clear();
            medioToolStripMenuItem.Checked = false;
            facileToolStripMenuItem.Checked = false;
            difficileToolStripMenuItem.Checked = true;
            livello = "difficile";
            int x = 1;

            int cy = 18;
            int cy2 = 18;
            int cy3 = 18;
            while (x < 25)
            {
                PictureBox t1 = new PictureBox();
                t1.Name = difficile[x];
                if (x < 9)
                {
                    t1.Location = new Point((cy), 15);
                    cy = cy + 131;
                }

                if (x > 8 && x < 17)
                {
                    t1.Location = new Point(cy2, 157);
                    cy2 = cy2 + 131;
                }

                if (x > 16 && x < 25)
                {
                    t1.Location = new Point((cy3), 295);
                    cy3 = cy3 + 131;
                }

                t1.ImageLocation = (@"..\..\Resources\dorso.png");

                t1.BackgroundImageLayout = ImageLayout.Stretch;
                t1.SizeMode = PictureBoxSizeMode.StretchImage;
                t1.AutoSize = false;
                t1.Width = 114;
                t1.Height = 122;

                t1.Visible = true;
                t1.Click += (s, args) =>
                {
                    string car = default; ;
                    string b, c;
                    string[] a = (t1.Name).Split('.');
                    if (a[0].Length == 2)
                    {
                        b = a[0].Substring(1);
                        c = a[0].Substring(0, 1);
                    }
                    else
                    {
                        b = a[0].Substring(2);
                        c = a[0].Substring(0, 2);
                    }


                    if (b == "a")
                    {
                        car = difficile[int.Parse(c)];
                    }
                    else
                        car = difficile[(int.Parse(c)) + 12];

                    t1.ImageLocation = (@"..\..\Resources\Carte\" + car);
                };
                tabControl1.TabPages[0].Controls.Add(t1);

                GroupBox t2 = new GroupBox();
                t2.Location = new Point((18), 420);
                t2.Width = 950;
                t2.Text = "Dati";
                t1.Enabled = false;
                Label t3 = new Label();
                t3.AutoSize = true;
                t3.Location = new Point((5), 40);
                t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t3.ForeColor = System.Drawing.Color.SteelBlue;
                // t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t3.Text = "Mosse";
                t2.Controls.Add(t3);

                Label t4 = new Label();
                // t4.AutoSize = true;
                t4.Name = "lbl_mosse";
                t4.Location = new Point((100), 40);
                t4.Height = 27;
                t4.Width = 55;
                t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t4.ForeColor = System.Drawing.Color.SteelBlue;
                t4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                t4.Text = "999";
                t2.Controls.Add(t4);

                Label t5 = new Label();
                t5.AutoSize = true;
                t5.Location = new Point((200), 40);
                t5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t5.ForeColor = System.Drawing.Color.SteelBlue;
                // t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t5.Text = "Timer";
                t2.Controls.Add(t5);

                Label t6 = new Label();
                // t4.AutoSize = true;
                t6.Name = "lbl_timer";
                t6.Location = new Point((280), 40);
                t6.Height = 27;
                t6.Width = 110;
                t6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t6.ForeColor = System.Drawing.Color.SteelBlue;
                t6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                t6.Text = "00:00:00";
                t2.Controls.Add(t6);

                tabControl1.TabPages[0].Controls.Add(t2);


                x = x + 1;
            }
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);

            switch (livello)
            {
                case "facile":
                    MyFunz.MischiaCarte(facile);
                    break;
                case "medio":
                    MyFunz.MischiaCarte(medio);
                    break;
                case "difficile":
                    MyFunz.MischiaCarte(difficile);
                    break;
            }
            foreach (Control x in tabControl1.TabPages[0].Controls)
            {
                if (x.GetType() == typeof(PictureBox))
                {
                    ((PictureBox)x).ImageLocation = (@"..\..\Resources\dorso.png");
                    x.Enabled = true;
                }
            }

            (this.Controls.Find("lbl_mosse", true)[0] as Label).Text = "0";
            (this.Controls.Find("lbl_timer", true)[0] as Label).Text = "00:00:00";

            secondo = 0;
            timer1.Start();
        }

        private void btn_punteggi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btn_esci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondo++;
            (this.Controls.Find("lbl_timer", true)[0] as Label).Text = dt.AddSeconds(secondo).ToString("HH:mm:ss");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
