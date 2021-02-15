
namespace WindowsFormsApp14
{
    partial class SaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gener_Box = new System.Windows.Forms.ComboBox();
            this.Band_box = new System.Windows.Forms.ComboBox();
            this.Discount_txtBox = new System.Windows.Forms.TextBox();
            this.GenerCansel = new System.Windows.Forms.Button();
            this.BandCansel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gener_Box
            // 
            this.Gener_Box.FormattingEnabled = true;
            this.Gener_Box.Location = new System.Drawing.Point(12, 31);
            this.Gener_Box.Name = "Gener_Box";
            this.Gener_Box.Size = new System.Drawing.Size(146, 23);
            this.Gener_Box.TabIndex = 7;
            this.Gener_Box.SelectedIndexChanged += new System.EventHandler(this.Gener_Box_SelectedIndexChanged);
            // 
            // Band_box
            // 
            this.Band_box.FormattingEnabled = true;
            this.Band_box.Location = new System.Drawing.Point(246, 31);
            this.Band_box.Name = "Band_box";
            this.Band_box.Size = new System.Drawing.Size(146, 23);
            this.Band_box.TabIndex = 8;
            // 
            // Discount_txtBox
            // 
            this.Discount_txtBox.Location = new System.Drawing.Point(116, 86);
            this.Discount_txtBox.Name = "Discount_txtBox";
            this.Discount_txtBox.Size = new System.Drawing.Size(119, 23);
            this.Discount_txtBox.TabIndex = 12;
            this.Discount_txtBox.TextChanged += new System.EventHandler(this.Discount_txtBox_TextChanged);
            // 
            // GenerCansel
            // 
            this.GenerCansel.Location = new System.Drawing.Point(165, 30);
            this.GenerCansel.Name = "GenerCansel";
            this.GenerCansel.Size = new System.Drawing.Size(21, 23);
            this.GenerCansel.TabIndex = 13;
            this.GenerCansel.Text = "X";
            this.GenerCansel.UseVisualStyleBackColor = true;
            this.GenerCansel.Click += new System.EventHandler(this.GenerCansel_Click);
            // 
            // BandCansel
            // 
            this.BandCansel.Location = new System.Drawing.Point(398, 31);
            this.BandCansel.Name = "BandCansel";
            this.BandCansel.Size = new System.Drawing.Size(19, 23);
            this.BandCansel.TabIndex = 14;
            this.BandCansel.Text = "X";
            this.BandCansel.UseVisualStyleBackColor = true;
            this.BandCansel.Click += new System.EventHandler(this.BandCansel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(146, 137);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(69, 34);
            this.buttonOk.TabIndex = 15;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.Location = new System.Drawing.Point(256, 139);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(73, 32);
            this.buttonCansel.TabIndex = 16;
            this.buttonCansel.Text = "Cansel";
            this.buttonCansel.UseVisualStyleBackColor = true;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 183);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.BandCansel);
            this.Controls.Add(this.GenerCansel);
            this.Controls.Add(this.Discount_txtBox);
            this.Controls.Add(this.Band_box);
            this.Controls.Add(this.Gener_Box);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Gener_Box;
        private System.Windows.Forms.ComboBox Band_box;
        private System.Windows.Forms.TextBox Discount_txtBox;
        private System.Windows.Forms.Button GenerCansel;
        private System.Windows.Forms.Button BandCansel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCansel;
    }
}