
namespace WindowsFormsApp14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sell_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.Sale_btn = new System.Windows.Forms.Button();
            this.DiscBox = new System.Windows.Forms.ComboBox();
            this.Count_box = new System.Windows.Forms.Label();
            this.Bank_lbl = new System.Windows.Forms.Label();
            this.Cost_lbl = new System.Windows.Forms.Label();
            this.ResultOfSearchTree = new System.Windows.Forms.TreeView();
            this.serch_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WithSaleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sell_Button
            // 
            this.Sell_Button.Location = new System.Drawing.Point(93, 286);
            this.Sell_Button.Name = "Sell_Button";
            this.Sell_Button.Size = new System.Drawing.Size(75, 23);
            this.Sell_Button.TabIndex = 0;
            this.Sell_Button.Text = "Sell";
            this.Sell_Button.UseVisualStyleBackColor = true;
            this.Sell_Button.Click += new System.EventHandler(this.Sell_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(12, 286);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.Location = new System.Drawing.Point(12, 315);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(75, 23);
            this.Remove_btn.TabIndex = 2;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.UseVisualStyleBackColor = true;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.Location = new System.Drawing.Point(93, 315);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(75, 23);
            this.Edit_btn.TabIndex = 3;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Sale_btn
            // 
            this.Sale_btn.Location = new System.Drawing.Point(42, 344);
            this.Sale_btn.Name = "Sale_btn";
            this.Sale_btn.Size = new System.Drawing.Size(94, 23);
            this.Sale_btn.TabIndex = 4;
            this.Sale_btn.Text = "Add discount";
            this.Sale_btn.UseVisualStyleBackColor = true;
            this.Sale_btn.Click += new System.EventHandler(this.Sale_btn_Click);
            // 
            // DiscBox
            // 
            this.DiscBox.FormattingEnabled = true;
            this.DiscBox.Location = new System.Drawing.Point(12, 12);
            this.DiscBox.Name = "DiscBox";
            this.DiscBox.Size = new System.Drawing.Size(146, 23);
            this.DiscBox.TabIndex = 6;
            this.DiscBox.SelectedIndexChanged += new System.EventHandler(this.DiscBox_SelectedIndexChanged);
            // 
            // Count_box
            // 
            this.Count_box.AutoSize = true;
            this.Count_box.Location = new System.Drawing.Point(164, 15);
            this.Count_box.Name = "Count_box";
            this.Count_box.Size = new System.Drawing.Size(13, 15);
            this.Count_box.TabIndex = 7;
            this.Count_box.Text = "0";
            // 
            // Bank_lbl
            // 
            this.Bank_lbl.AutoSize = true;
            this.Bank_lbl.Location = new System.Drawing.Point(732, 37);
            this.Bank_lbl.Name = "Bank_lbl";
            this.Bank_lbl.Size = new System.Drawing.Size(19, 15);
            this.Bank_lbl.TabIndex = 8;
            this.Bank_lbl.Text = "0$";
            // 
            // Cost_lbl
            // 
            this.Cost_lbl.AutoSize = true;
            this.Cost_lbl.Location = new System.Drawing.Point(558, 378);
            this.Cost_lbl.Name = "Cost_lbl";
            this.Cost_lbl.Size = new System.Drawing.Size(19, 15);
            this.Cost_lbl.TabIndex = 9;
            this.Cost_lbl.Text = "0$";
            // 
            // ResultOfSearchTree
            // 
            this.ResultOfSearchTree.Location = new System.Drawing.Point(406, 37);
            this.ResultOfSearchTree.Name = "ResultOfSearchTree";
            this.ResultOfSearchTree.Size = new System.Drawing.Size(121, 97);
            this.ResultOfSearchTree.TabIndex = 10;
            this.ResultOfSearchTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ResultOfSearchTree_NodeMouseDoubleClick);
            // 
            // serch_box
            // 
            this.serch_box.Location = new System.Drawing.Point(281, 37);
            this.serch_box.Name = "serch_box";
            this.serch_box.Size = new System.Drawing.Size(119, 23);
            this.serch_box.TabIndex = 11;
            this.serch_box.TextChanged += new System.EventHandler(this.serch_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search";
            // 
            // WithSaleLbl
            // 
            this.WithSaleLbl.AutoSize = true;
            this.WithSaleLbl.Location = new System.Drawing.Point(488, 351);
            this.WithSaleLbl.Name = "WithSaleLbl";
            this.WithSaleLbl.Size = new System.Drawing.Size(0, 15);
            this.WithSaleLbl.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.WithSaleLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serch_box);
            this.Controls.Add(this.ResultOfSearchTree);
            this.Controls.Add(this.Cost_lbl);
            this.Controls.Add(this.Bank_lbl);
            this.Controls.Add(this.Count_box);
            this.Controls.Add(this.DiscBox);
            this.Controls.Add(this.Sale_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Sell_Button);
            this.Name = "Form1";
            this.Text = "X";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sell_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button Sale_btn;
        private System.Windows.Forms.ComboBox DiscBox;
        private System.Windows.Forms.Label Count_box;
        private System.Windows.Forms.Label Bank_lbl;
        private System.Windows.Forms.Label Cost_lbl;
        private System.Windows.Forms.TreeView ResultOfSearchTree;
        private System.Windows.Forms.TextBox serch_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WithSaleLbl;
    }
}

