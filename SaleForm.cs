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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
            Initialize();
            AcceptButton = buttonOk;
            Controls.Add(buttonOk);
            CancelButton = buttonCansel;
            Controls.Add(buttonCansel);
        }

        private void Initialize()
        {
            using (DBContext dB = new DBContext())
            {
                foreach (Genre item in dB.genres)
                {
                    Gener_Box.Items.Add(item);
                    
                }
               
            }
            using (DBContext dB = new DBContext())
            {
                foreach (Band band in dB.bands)
                {
                    Band_box.Items.Add(band);
                }
            }

        }

        

        private void SaleForm_Load(object sender, EventArgs e)
        {

        }

        private void Gener_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenerCansel_Click(object sender, EventArgs e)
        {
            Gener_Box.SelectedIndex = -1;
        }

        private void BandCansel_Click(object sender, EventArgs e)
        {
            Band_box.SelectedIndex = -1;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool HasNoLetters = false;
            for (int i = 0; i < Discount_txtBox.Text.Length; i++)
            {
                if (Discount_txtBox.Text[i]<47 && Discount_txtBox.Text[i] >58 )
                {
                    HasNoLetters = true;
                }
            }
            if (HasNoLetters==false)
            {
                if (Band_box.SelectedIndex!=-1)
                {
                    BandDiscount();
                }
                if (Gener_Box.SelectedIndex!=-1)
                {
                    GenerDiscount();
                }
            }
            Hide();
        }

        private void BandDiscount()
        {
            using (DBContext dB = new DBContext())
            {
                foreach (Band item in dB.bands.Include(d=>d.discs))
                {
                    foreach (Disc disc in item.discs)
                    {
                        if (disc.band.name==(Band_box.SelectedItem as Band).name)
                        {
                            disc.discount = Convert.ToInt32(Discount_txtBox.Text);

                        }
                        
                       
                    }
                }
                dB.SaveChanges();
            }
        }

        private void GenerDiscount()
        {
            using (DBContext dB = new DBContext())
            {
                foreach (Genre item in dB.genres.Include(d => d.discs))
                {
                    foreach (Disc disc in item.discs)
                    {
                        if (disc.genre.name==(Gener_Box.SelectedItem as Genre).name)
                        {
                            disc.discount = Convert.ToInt32(Discount_txtBox.Text);
                        }
                        
                    }
                }
                dB.SaveChanges();
            }
        }

        private void Discount_txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
