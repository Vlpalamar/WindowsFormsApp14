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
    public partial class editForm : Form
    {
        string discSt;
        public editForm( string st)
        {
            discSt = st;
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

                foreach (Disc item in dB.discs)
                {
                    if (item.name == discSt)
                    {
                        NameTxt_box.Text = item.name;
                        BandName_cmbBox.SelectedItem = item.band.name;
                        Geners_cmbBox.SelectedItem = item.genre.name;
                        TreckCount_textBox.Text = item.treckCount.ToString();
                        Publisher_cmbBox.SelectedItem = item.publisher.name;
                        DiscsCount_txtBox.Text = item.discCount.ToString();
                        SelfCost_txtBox.Text = item.selfCost.ToString();
                        SellPrice_txtBox.Text = item.sellPrice.ToString();

                    }
                    
                }
            }
        }
        private void editForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            using (DBContext dB=new DBContext())
            {
                List<Band> bands1 = new List<Band>();
                foreach (Band item in dB.bands)
                {
                    bands1.Add(item);
                }
                foreach (Band item in dB.bands.Include(d=>d.discs))
                {

                    if (NewBand_txtBox.Text == null || NewBand_txtBox.Text == "")
                    {
                        foreach (Disc disc in item.discs)
                        {
                            if (disc.name == discSt)
                            {
                                foreach (Band band in bands1)
                                {
                                    if (band.name==BandName_cmbBox.Text)
                                    {
                                        disc.band = band;
                                    }
                                   
                                }
                                    
                            }
                        }
                        
                    }
                    else
                    {
                        foreach (Disc disc in item.discs)
                        {
                            if (disc.name == discSt)
                            {
                                Band b = new Band { name = NewBand_txtBox.Text };
                                disc.band = b;
                                dB.bands.Add(b);
                            }
                        }
                        
                    }

                       

                     


                    foreach (Disc disc in item.discs)
                    {
                        if (disc.name == discSt)
                        {
                            disc.name = NameTxt_box.Text;
                            disc.discCount = Convert.ToInt32(DiscsCount_txtBox.Text);
                            disc.sellPrice = Convert.ToDecimal(SellPrice_txtBox.Text);
                            disc.selfCost = Convert.ToDecimal(SelfCost_txtBox.Text);

                            disc.treckCount = Convert.ToInt32(TreckCount_textBox.Text);
                        }

                    }

                   
                    
                }
                dB.SaveChanges();



            }
            using (DBContext dB = new DBContext())
            {

                List<Genre> genres1= new List<Genre>();
                foreach (Genre item in dB.genres)
                {
                    genres1.Add(item);
                }
                foreach (Genre item in dB.genres.Include(g=>g.discs))
                {
                    if (NewGeners_txtBox.Text == null || NewGeners_txtBox.Text == "")
                    {
                        foreach (Disc disc in item.discs)
                        {
                            if (disc.name == discSt)
                            {
                                foreach (Genre genre in genres1)
                                {
                                    if (genre.name == Geners_cmbBox.Text)
                                    {
                                        disc.genre = genre;
                                    }

                                }

                            }
                        }
                    }
                    else
                    {
                        foreach (Disc disc in item.discs)
                        {
                            if (disc.name == discSt)
                            {
                                Genre g = new Genre { name = NewGeners_txtBox.Text };
                                disc.genre = g;
                                dB.genres.Add(g);
                            }
                        }
                    }
                }

                dB.SaveChanges();
            }
            using (DBContext dB = new DBContext())
            {

                List<Publisher>publishers1= new List<Publisher>();
                foreach (Publisher item in dB.publishers)
                {
                    publishers1.Add(item);
                }
                foreach (Publisher item in dB.publishers.Include(g => g.discs))
                {
                    if (NewPublisher_txtBox.Text == null || NewPublisher_txtBox.Text == "")
                    {
                        foreach (Disc disc in item.discs)
                        {
                            if (disc.name == discSt)
                            {
                                foreach (Publisher  publisher in publishers1)
                                {
                                    if (publisher.name == Publisher_cmbBox.Text)
                                    {
                                        disc.publisher = publisher;
                                    }

                                }

                            }
                        }
                    }
                    else
                    {
                        foreach (Disc disc in item.discs)
                        {
                            if (disc.name == discSt)
                            {
                                Publisher p = new  Publisher { name = NewPublisher_txtBox.Text };
                                disc.publisher = p;
                                dB.publishers.Add(p);
                            }
                        }
                    }
                }

                dB.SaveChanges();
            }


            Hide();
        }
    }
}
