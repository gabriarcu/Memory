using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
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
            int x = 1;

            int cy = 18;
            int cy2 = 18;
            int cy3 = 18;
            while (x < 10)
            {
                PictureBox t1 = new PictureBox();
                t1.Name = $"carta_{x + 1}";
                if (x < 4)
                {
                    t1.Location = new Point((cy), 15);
                    cy = cy + 131;
                }

                if (x > 3 && x < 7)
                {
                    t1.Location = new Point(cy2, 157);
                    cy2 = cy2 + 131;
                }

                if (x > 6 && x < 10)
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
                tabControl1.TabPages[0].Controls.Add(t1);

                GroupBox t2 = new GroupBox();
                t2.Location=new Point((18), 420);
                t2.Width = 950;
                t2.Text = "Dati";
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
            int x = 1;
           
            int cy = 18;
            int cy2 = 18;
            int cy3 = 18;
            while (x<10)
            {
                PictureBox t1 = new PictureBox();
                t1.Name = $"carta_{x + 1}";
                if(x<4)
                {
                    t1.Location = new Point((cy),15);
                    cy = cy + 131;
                }
                
                if (x > 3 && x < 7)
                {
                    t1.Location = new Point(cy2, 157);
                    cy2 = cy2 + 131;
                }
               
                if (x > 6 && x < 10)
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
                tabControl1.TabPages[0].Controls.Add(t1);

                GroupBox t2 = new GroupBox();
                t2.Location = new Point((18), 420);
                t2.Width = 950;
                t2.Text = "Dati";
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
            int x = 1;

            int cy = 18;
            int cy2 = 18;
            int cy3 = 18;
            while (x < 16)
            {
                PictureBox t1 = new PictureBox();
                t1.Name = $"carta_{x + 1}";
                if (x < 6)
                {
                    t1.Location = new Point((cy), 15);
                    cy = cy + 131;
                }

                if (x > 5 && x < 11)
                {
                    t1.Location = new Point(cy2, 157);
                    cy2 = cy2 + 131;
                }

                if (x > 10 && x < 16)
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
                tabControl1.TabPages[0].Controls.Add(t1);

                GroupBox t2 = new GroupBox();
                t2.Location = new Point((18), 420);
                t2.Width = 950;
                t2.Text = "Dati";
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
            int x = 1;

            int cy = 18;
            int cy2 = 18;
            int cy3 = 18;
            while (x < 22)
            {
                PictureBox t1 = new PictureBox();
                t1.Name = $"carta_{x + 1}";
                if (x < 8)
                {
                    t1.Location = new Point((cy), 15);
                    cy = cy + 131;
                }

                if (x > 7 && x < 15)
                {
                    t1.Location = new Point(cy2, 157);
                    cy2 = cy2 + 131;
                }

                if (x > 14 && x < 22)
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
                tabControl1.TabPages[0].Controls.Add(t1);

                GroupBox t2 = new GroupBox();
                t2.Location = new Point((18), 420);
                t2.Width = 950;
                t2.Text = "Dati";
                tabControl1.TabPages[0].Controls.Add(t2);


                x = x + 1;
            }
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btn_punteggi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btn_esci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
