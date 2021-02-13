using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp14.Models;


namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {

        decimal money=0;
        static void DiscStoreInsert()
        {
            using (DBContext dB = new DBContext())
            {
                if (dB.discs.Count<Disc>()==0)
                {

              
                    Genre g1 = new Genre { name = "Heavy Metal" };
                    Genre g2 = new Genre { name = "Hard Rock" };
                    Genre g3 = new Genre { name = "Blues" };
                    Genre g4 = new Genre { name = "Jazz" };

                    dB.genres.AddRange(new List<Genre> { g1, g2, g3, g4 });
                    dB.SaveChanges();

                    Band b1 = new Band { name = "Black Sabbath" };
                    Band b2 = new Band { name = "Metallica" };
                    Band b3 = new Band { name = "Joan Jett & The Blackhearts" };
                    Band b4 = new Band { name = "Robert Johnson" };
                    Band b5 = new Band { name = " Louis Armstrong" };

                    dB.bands.AddRange(new List<Band> { b1, b2, b3, b4 });
                    dB.SaveChanges();

                    Publisher p1 = new Publisher { name = "Vertigo Records" };
                    Publisher p2 = new Publisher { name = "Sec Label" };
                    Publisher p3 = new Publisher { name = "3rd Label" };
                    dB.publishers.AddRange(new List<Publisher> { p1, p2, p3 });
                    dB.SaveChanges();

                    Disc d1 = new Disc
                    {
                        name = "Paranoid",
                        band = b1,
                        publisher = p1,
                        realiseDate = new DateTime(1970, 9, 10, 6, 6, 6),
                        selfCost = 10,
                        sellPrice = 100,
                        treckCount = 12,
                        genre = g1
                    };
                    Disc d2 = new Disc
                    {
                        name = "Master of Pupets",
                        band = b2,
                        publisher = p1,
                        realiseDate = new DateTime(1986, 3, 11, 5, 2, 5),
                        selfCost = 13,
                        sellPrice = 200,
                        treckCount = 8,
                        genre = g1
                    
                    };


                    dB.discs.Add(d1);
               
                
                    dB.SaveChanges();
                }


            }




        }


        AddForm addForm;
        public Form1()
        {

            DiscStoreInsert();
            InitializeComponent();
            DiskBoxInit();

        }

        protected void DiskBoxInit()
        {
            DiscBox.Items.Clear();
            using (DBContext dB = new DBContext())
            {
                foreach (Disc item in dB.discs)
                    DiscBox.Items.Add(item);
               
            }
           

        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            if (DiscBox.Items.Count!=0)
            {
                DiscBox.Items.RemoveAt(DiscBox.SelectedIndex);
                DiscBox.Text = "";
                RefreshCountBox();
            }
        }

        private void Sell_Button_Click(object sender, EventArgs e)
        {
            if (DiscBox.SelectedItem != null)
            {
                using (DBContext dB = new DBContext())
                {

                    foreach (Disc item in dB.discs)
                    {
                        if (item.name == DiscBox.SelectedItem.ToString())
                        {
                            item.discCount--;
                            
                            dB.SaveChanges();
                            AddMoney(item.sellPrice);
                            RefreshCountBox();
                        }
                    }
                }
            }
        }
        private void AddMoney(decimal m)
        {
            money += m;
            Bank_lbl.Text = money.ToString()+"$";
        }

        private void RefreshCountBox()
        {
            if (DiscBox.SelectedItem!=null)
            {
                using (DBContext dB = new DBContext())
                {
                    foreach (Disc item in dB.discs)
                    {
                        if (item.name == DiscBox.SelectedItem.ToString())
                        {
                            Count_box.Text = item.discCount.ToString();
                        }

                        else if (DiscBox.SelectedItem == null)
                            Count_box.Text = 0.ToString();

                    }
                }
            }
           
        }

        private void DiscBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCountBox();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            addForm = new AddForm();
            addForm.ShowDialog();
            DiskBoxInit();
        }
    }
}
