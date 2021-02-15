using Microsoft.EntityFrameworkCore;
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
                if (dB.discs.Count() == 0)
                {


                    Genre g1 = new Genre { name = "Heavy Metal" };
                    Genre g5 = new Genre { name = "Trash Metal" };
                    Genre g2 = new Genre { name = "Hard Rock" };
                    Genre g3 = new Genre { name = "Blues" };
                    Genre g4 = new Genre { name = "Jazz" };

                    dB.genres.AddRange(new List<Genre> { g1, g2, g3, g4, g5 });
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
                        treckCount = 12
                       ,
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
                        genre = g5
                    };


                    dB.discs.Add(d1);
                    dB.discs.Add(d2);

                    dB.SaveChanges();
                }

            }




        }


        AddForm addForm;
        editForm editForm;
        SaleForm saleForm;
        public Form1()
        {
             addForm = new AddForm();

            InitializeComponent();
            DiscStoreInsert();
            DiskBoxInit();

        }

        void DiskBoxInit()
        {
            DiscBox.Items.Clear();
            using (DBContext dB = new DBContext())
            {
                foreach (Disc item in dB.discs)
                    DiscBox.Items.Add(item);
               
            }
           

        }

        private void DiscountLbl()
        {
            using (DBContext dB = new DBContext())
            {
                foreach (Disc item in dB.discs)
                {
                    if (item.name==DiscBox.Text)
                    {
                        if (item.discount != 0)
                        {
                            WithSaleLbl.Text = $"-{item.discount.ToString()}%";
                        }
                        else
                        {
                            WithSaleLbl.Text = null;
                        }
                    }
                    
                }
                
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
            if (DiscBox.Items.Count>0)
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
                        if (item.name == DiscBox.SelectedItem.ToString() && item.discCount>0)
                        {
                            item.discCount--;
                            AddMoney(Convert.ToDecimal(Cost_lbl.Text.Remove(Cost_lbl.Text.Length-1))-item.selfCost);
                        }
                    }
                    dB.SaveChanges();
                    RefreshCountBox();
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
            if (DiscBox.SelectedItem!=null)
            {
                RefreshCountBox();
                DiscCost();
                DiscountLbl();
            }
           
        }

        private void DiscCost()
        {
            using (DBContext dB = new DBContext())
            {
                foreach (Disc item in dB.discs)
                {
                    if (item.name== DiscBox.SelectedItem.ToString())
                    {
                        if (item.discount!=0)
                        {
                            Cost_lbl.Text = (item.sellPrice-item.sellPrice / 100 * item.discount).ToString() + "$";
                        }
                        else
                        {
                            Cost_lbl.Text= item.sellPrice.ToString() + "$";
                        }
                        
                    }
                }
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            addForm = new AddForm();
            addForm.ShowDialog();
            DiskBoxInit();
            
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (DiscBox.Text!="" && DiscBox.SelectedItem != null)
            {
                editForm = new editForm(DiscBox.SelectedItem.ToString());
                editForm.ShowDialog();
                DiskBoxInit();
            }
            
        }

        private void serch_box_TextChanged(object sender, EventArgs e)
        {
            if (serch_box.Text!=null)
            {
                ResultOfSearchTree.Nodes.Clear();
                SerchGener();
            }
        }

        private void SerchGener()
        {
            using (DBContext dB = new DBContext())
            {
                int i = 0;
                foreach (Genre item in dB.genres.Include(g=>g.discs).Where(g=>EF.Functions.Like(g.name,$"%{serch_box.Text}%")))
                {             
                        TreeNode GenerNode = new TreeNode(item.name);
                        ResultOfSearchTree.Nodes.Add(GenerNode);
                    foreach (Disc disc in item.discs)
                    {
                      
                            TreeNode AlbomNode = new TreeNode(disc.name);
                           ResultOfSearchTree.Nodes[i].Nodes.Add(AlbomNode);
                    }

                    i++;
                }
                if (ResultOfSearchTree.Nodes.Count == 0)
                {
                    SerchAlbum();
                }
            }
        }
        private void SerchAlbum()
        {
            using (DBContext dB = new DBContext())
            {
                
                foreach (Disc item in dB.discs.Where(g => EF.Functions.Like(g.name, $"%{serch_box.Text}%")))
                {


                    TreeNode GenerNode = new TreeNode(item.name);
                    ResultOfSearchTree.Nodes.Add(GenerNode);
                    

                    
                }
            }
        }

        private void ResultOfSearchTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int i= 0;
            foreach (Disc item in DiscBox.Items)
            {
                if (ResultOfSearchTree.SelectedNode.Text ==item.ToString() && ResultOfSearchTree.SelectedNode!=null)
                {
                    DiscBox.SelectedIndex = i;
                }
                i++;
            }
            
        }

        private void Sale_btn_Click(object sender, EventArgs e)
        {
            saleForm = new SaleForm();
            saleForm.ShowDialog();
        }
    }
}
