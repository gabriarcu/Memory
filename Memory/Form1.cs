using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        int secondo = 0;
        DateTime dt = new DateTime();
        MyFunz.Record[] r = new MyFunz.Record[100];
        string[] giocatori = new string[100];
        string[] carte = new string[25];

        string[] facile = new string[13];
        string[] medio = new string[19];
        string[] difficile = new string[25];
        string livello = "facile";
        int coppie = 0;
        int conta = 0;
        int mosse = 0;
        int punteggio = 0;
        int pos, pos2;
        //int punteggio = 0;
        PictureBox carta1 = new PictureBox();
        PictureBox carta2 = new PictureBox();

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
            //tabControl1.TabPages[0].Controls.Clear();
            MyFunz.CaricaFacile(facile);
            MyFunz.CaricaMedio(medio);
            MyFunz.CaricaDifficile(difficile);
            //MyFunz.MischiaCarte(facile);
            

            //MyFunz.MischiaCarte(medio);
            //MyFunz.MischiaCarte(difficile);
            lbl_Giocatore.Text = "Scegli Player";
            string line;
            pos = 0;
            try
            {

                StreamReader sr = new StreamReader(@"..\..\Resources\records.csv");

                line = sr.ReadLine();


                while (line != null)
                {

                    string[] i = line.Split(',');
                    r[pos].giocatore = (i[0]);
                    r[pos].punteggio = int.Parse(i[1]);
                    r[pos].tempo = (i[2]);
                    r[pos].mosse = int.Parse(i[3]);
                    r[pos].timestamp = DateTime.Parse(i[4]);



                    pos = pos + 1;
                    line = sr.ReadLine();
                }
                //close the file

                sr.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }

            string line2;
            pos2 = 0;
            try
            {

                StreamReader sr2 = new StreamReader(@"..\..\Resources\giocatori.csv");

                line2 = sr2.ReadLine();


                while (line2 != null)
                {
                    giocatori[pos2] = line2;
                    pos2 = pos2 + 1;
                    line2 = sr2.ReadLine();
                }
                //close the file

                sr2.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
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

                t1.Visible = true;
                t1.Enabled = false;
                tabControl1.TabPages[0].Controls.Add(t1);

                t1.Click += (s, args) =>
                {
                    conta = conta + 1;
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

                    // t1.ImageLocation = (@"..\..\Resources\Carte\" + car);
                    switch (conta)
                    {
                        case 1:

                            t1.ImageLocation = (@"..\..\Resources\Carte\" + car);
                            carta1 = t1;
                            MessageBox.Show(carta1.Name);


                            break;
                        case 2:

                            t1.ImageLocation = (@"..\..\Resources\Carte\" + car);

                            carta2 = t1;
                            //var delay = Task.Run(async () =>
                            //{
                            //    Stopwatch sw = Stopwatch.StartNew();
                            //    await Task.Delay(5000);

                            //    sw.Stop();


                            //});



                            MessageBox.Show(carta2.Name);

                            string c1 = (carta1.Name.Substring(0, 1));
                            string c2 = (carta2.Name.Substring(0, 1));

                            if (c1 != c2)
                            {


                                (this.Controls.Find($"{carta1.Name}", true)[0] as PictureBox).ImageLocation = (@"..\..\Resources\dorso.png");


                                (this.Controls.Find($"{carta2.Name}", true)[0] as PictureBox).ImageLocation = (@"..\..\Resources\dorso.png"); ;
                                mosse = mosse + 1;
                            }
                            else
                            {
                                coppie = coppie + 1;
                                mosse = mosse + 1;
                                (this.Controls.Find("lbl_indovinate", true)[0] as Label).Text = $"{coppie}/6";
                                if (coppie == 6)
                                {

                                    timer1.Stop();

                                    MessageBox.Show("Hai Vinto");

                                    punteggio = (mosse * 100 / secondo);
                                    label2.Text = punteggio.ToString();
                                    coppie = 0;

                                    r[pos].giocatore = lbl_Giocatore.Text;
                                    r[pos].punteggio = punteggio;
                                    r[pos].tempo = (this.Controls.Find("lbl_timer", true)[0] as Label).Text;
                                    r[pos].mosse = mosse;
                                    r[pos].timestamp = DateTime.Now;

                                    StreamWriter sww = File.AppendText(@"..\..\Resources\records.csv");
                                    //Write a line of text
                                    string lineaRecord = $"{r[pos].giocatore},{r[pos].punteggio},{r[pos].tempo},{r[pos].mosse},{r[pos].timestamp}";

                                    sww.WriteLine(lineaRecord);

                                    //Close the file
                                    sww.Close();
                                    pos = pos + 1;
                                }

                                // MessageBox.Show("Uguali");
                            }


                            conta = 0;
                            break;

                    }


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

                Label t7 = new Label();
                t7.AutoSize = true;
                t7.Location = new Point((440), 40);
                t7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t7.ForeColor = System.Drawing.Color.SteelBlue;
                // t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t7.Text = "Indovinate";
                t2.Controls.Add(t7);

                Label t8 = new Label();
                // t4.AutoSize = true;
                t8.Name = "lbl_indovinate";
                t8.Location = new Point((580), 40);
                t8.Height = 27;
                t8.Width = 60;
                t8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                t8.ForeColor = System.Drawing.Color.SteelBlue;
                t8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                t8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                t8.Text = "0/6";
                t2.Controls.Add(t8);

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
            if (lbl_Giocatore.Text == "Scegli Player")
            {
                tabControl1.SelectTab(2);
            }
            switch (livello)
            {
                case "facile":
                    MyFunz.MischiaCarte(facile);
                    tabControl1.TabPages[0].Controls.Clear();
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
                            string car = default; ;
                            //string[] a = (t1.Name).Split('.');
                            //string b = a[0].Substring(1);
                            //string c = a[0].Substring(0, 1);
                            car = t1.Name;
                            

                            t1.ImageLocation = (@"..\..\Resources\Carte\" + car);
                            switch (conta)
                            {
                                case 1:

                                    t1.ImageLocation = (@"..\..\Resources\Carte\" + car);
                                    carta1 = t1;
                                   //MessageBox.Show(carta1.ImageLocation);


                                    break;
                                case 2:

                                    t1.ImageLocation = (@"..\..\Resources\Carte\" + car);

                                    carta2 = t1;
                                    string c1 = (carta1.Name.Substring(0, 1));
                                    string c2 = (carta2.Name.Substring(0, 1));

                                    if (c1 != c2)
                                    {
                                        //var delay = Task.Run(async () =>
                                        //{
                                        //    Stopwatch sw = Stopwatch.StartNew();
                                        //    await Task.Delay(5000);

                                        //    sw.Stop();


                                        //});
                                        //MessageBox.Show("Errato");
                                        timer2.Start();

                                        //(this.Controls.Find($"{carta1.Name}", true)[0] as PictureBox).ImageLocation = (@"..\..\Resources\dorso.png");


                                        //(this.Controls.Find($"{carta2.Name}", true)[0] as PictureBox).ImageLocation = (@"..\..\Resources\dorso.png"); ;
                                        //mosse = mosse + 1;
                                    }
                                    else
                                    {
                                        coppie = coppie + 1;
                                        mosse = mosse + 1;
                                        (this.Controls.Find("lbl_indovinate", true)[0] as Label).Text = $"{coppie}/6";
                                        if (coppie == 6)
                                        {

                                            timer1.Stop();

                                            MessageBox.Show("Hai Vinto");

                                            punteggio = (mosse * 100 / secondo);
                                            label2.Text = punteggio.ToString();
                                            coppie = 0;

                                            r[pos].giocatore = lbl_Giocatore.Text;
                                            r[pos].punteggio = punteggio;
                                            r[pos].tempo = (this.Controls.Find("lbl_timer", true)[0] as Label).Text;
                                            r[pos].mosse = mosse;
                                            r[pos].timestamp = DateTime.Now;

                                            StreamWriter sww = File.AppendText(@"..\..\Resources\records.csv");
                                            //Write a line of text
                                            string lineaRecord = $"{r[pos].giocatore},{r[pos].punteggio},{r[pos].tempo},{r[pos].mosse},{r[pos].timestamp}";

                                            sww.WriteLine(lineaRecord);

                                            //Close the file
                                            sww.Close();
                                            pos = pos + 1;
                                        }

                                        // MessageBox.Show("Uguali");
                                    }


                                    conta = 0;
                                    break;

                            }


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

                        Label t7 = new Label();
                        t7.AutoSize = true;
                        t7.Location = new Point((440), 40);
                        t7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        t7.ForeColor = System.Drawing.Color.SteelBlue;
                        // t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        t7.Text = "Indovinate";
                        t2.Controls.Add(t7);

                        Label t8 = new Label();
                        // t4.AutoSize = true;
                        t8.Name = "lbl_indovinate";
                        t8.Location = new Point((580), 40);
                        t8.Height = 27;
                        t8.Width = 60;
                        t8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        t8.ForeColor = System.Drawing.Color.SteelBlue;
                        t8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        t8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        t8.Text = "0/6";
                        t2.Controls.Add(t8);

                        tabControl1.TabPages[0].Controls.Add(t2);

                        x = x + 1;
                    }
                
                    
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
            mosse = 0;
            punteggio = 0;
            timer1.Start();
        }

        private void btn_punteggi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);

            int y = 0;

            ListViewItem Riga;
            listView1.Items.Clear();

            while (y < pos)
            {
                Riga = new ListViewItem(new string[]
                {
                    r[y].giocatore,
                    r[y].punteggio.ToString(),
                    r[y].tempo,
                    r[y].mosse.ToString(),
                    r[y].timestamp.ToString("g")

                }

                );

                listView1.Items.Add(Riga);


                y++;
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void giocatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            cbo_giocatore.Items.Clear();
            int x = 0;
            while (x < pos2)
            {
                cbo_giocatore.Items.Add(giocatori[x]);
                x = x + 1;
            }
        }

        private void pictureBoxAggiungiGiocatore_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btn_aggiungiGiocatore_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            if (cbo_giocatore.Items.Contains(txt_newGiocatore.Text))
            {
                MessageBox.Show("Giocatore gia presente");
                return;
            }
            cbo_giocatore.Items.Add(txt_newGiocatore.Text);
            cbo_giocatore.Text = (txt_newGiocatore.Text);

            lbl_player.Text = cbo_giocatore.Text;
            giocatori[pos2] = lbl_player.Text;
            pos2 = pos2 + 1;
            StreamWriter swww = File.AppendText(@"..\..\Resources\giocatori.csv");
            //Write a line of text

            string linea = txt_newGiocatore.Text;

            swww.WriteLine(linea);

            //Close the file
            swww.Close();
            txt_newGiocatore.Clear();
        }

        private void lbl_Giocatore_Click(object sender, EventArgs e)
        {
            if (lbl_Giocatore.Text == "Scegli Player")
            {
                tabControl1.SelectTab(2);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                cbo_giocatore.Items.Clear();
                int x = 0;
                while (x < pos2)
                {
                    cbo_giocatore.Items.Add(giocatori[x]);
                    x = x + 1;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            (this.Controls.Find($"{carta1.Name}", true)[0] as PictureBox).ImageLocation = (@"..\..\Resources\dorso.png");


            (this.Controls.Find($"{carta2.Name}", true)[0] as PictureBox).ImageLocation = (@"..\..\Resources\dorso.png"); ;
            mosse = mosse + 1;
        }

        private void cbo_giocatore_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scelta = cbo_giocatore.SelectedItem.ToString();
            lbl_player.Text = scelta;
            lbl_Giocatore.Text = lbl_player.Text;
            tabControl1.SelectTab(0);
        }
    }
}
