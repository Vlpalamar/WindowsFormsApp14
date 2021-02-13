using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp14.Models;


namespace WindowsFormsApp14
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            Initialize();
            AcceptButton = buttonOk;
            Controls.Add(buttonOk);
            CancelButton = button2;
            Controls.Add(button2);
        }

       private void Initialize()
        {
            using (DBContext dB = new DBContext())
            {
                foreach (Band item in dB.bands)
                {
                    BandName_cmbBox.Items.Add(item.name);
                }
                foreach (Genre item in dB.genres)
                {
                    Geners_cmbBox.Items.Add(item.name);
                }
                foreach (Publisher item in dB.publishers)
                {
                    Publisher_cmbBox.Items.Add(item.name);
                }

            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            using (DBContext dB = new DBContext())
            {

                Disc d = new Disc
                {
                    name = NameTxt_box.Text,
                    discCount = Convert.ToInt32(DiscsCount_txtBox.Text),
                    treckCount = Convert.ToInt32(TreckCount_textBox.Text),
                   
                    selfCost = Convert.ToDecimal(SelfCost_txtBox.Text), 
                     sellPrice  = Convert.ToDecimal(SellPrice_txtBox.Text)
                       


                };

                if (NewBand_txtBox.Text==null || NewBand_txtBox.Text == "")
                {
                    foreach (Band item in dB.bands)
                        if (item.name == BandName_cmbBox.Text)
                            d.band = item;
                }
                else
                {
                    Band b = new Band { name=NewBand_txtBox.Text };
                    d.band = b;
                    dB.bands.Add(b);
                }

                if (NewPublisher_txtBox.Text==null|| NewPublisher_txtBox.Text=="")
                {
                    foreach (Publisher item in dB.publishers)
                        if (item.name == Publisher_cmbBox.Text)
                            d.publisher = item;
                }
                else
                {
                    Publisher p = new Publisher { name=NewPublisher_txtBox.Text };
                    d.publisher = p;
                    dB.publishers.Add(p);
                }

                if (NewGeners_txtBox.Text==null|| NewGeners_txtBox.Text=="")
                {
                    foreach (Genre item in dB.genres)
                        if (item.name == Geners_cmbBox.Text)
                            d.genre = item;
                }
                else
                {
                    Genre g = new Genre { name = NewGeners_txtBox.Text };
                    d.genre = g;
                    dB.genres.Add(g);

                }

                dB.discs.Add(d);
                dB.SaveChanges();
                
                Hide();
                
                



            }
        }
    }
}
