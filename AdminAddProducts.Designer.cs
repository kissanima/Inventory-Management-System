namespace Inventory_Management_System
{
    partial class AdminAddProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddProducts));
            this.addProducts_status = new System.Windows.Forms.ComboBox();
            this.addProducts_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addProducts_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addProducts_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addProducts_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProducts_prodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.brn_UpdateProducts = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.button_AddProducts = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.addProducts_imageView = new System.Windows.Forms.PictureBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProducts_imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProducts_status
            // 
            this.addProducts_status.FormattingEnabled = true;
            this.addProducts_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.addProducts_status.Location = new System.Drawing.Point(430, 549);
            this.addProducts_status.Name = "addProducts_status";
            this.addProducts_status.Size = new System.Drawing.Size(121, 21);
            this.addProducts_status.TabIndex = 49;
            // 
            // addProducts_category
            // 
            this.addProducts_category.FormattingEnabled = true;
            this.addProducts_category.Items.AddRange(new object[] {
            "Gadgets",
            "Appliances",
            "Tools",
            "Computer Accessories"});
            this.addProducts_category.Location = new System.Drawing.Point(161, 552);
            this.addProducts_category.Name = "addProducts_category";
            this.addProducts_category.Size = new System.Drawing.Size(121, 21);
            this.addProducts_category.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Status:";
            // 
            // addProducts_stock
            // 
            this.addProducts_stock.Location = new System.Drawing.Point(430, 511);
            this.addProducts_stock.Name = "addProducts_stock";
            this.addProducts_stock.Size = new System.Drawing.Size(117, 20);
            this.addProducts_stock.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Stock:";
            // 
            // addProducts_price
            // 
            this.addProducts_price.Location = new System.Drawing.Point(430, 470);
            this.addProducts_price.Name = "addProducts_price";
            this.addProducts_price.Size = new System.Drawing.Size(117, 20);
            this.addProducts_price.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Price (₱):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Categories:";
            // 
            // addProducts_name
            // 
            this.addProducts_name.Location = new System.Drawing.Point(161, 511);
            this.addProducts_name.Name = "addProducts_name";
            this.addProducts_name.Size = new System.Drawing.Size(117, 20);
            this.addProducts_name.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Product name: ";
            // 
            // addProducts_prodID
            // 
            this.addProducts_prodID.Location = new System.Drawing.Point(161, 470);
            this.addProducts_prodID.Name = "addProducts_prodID";
            this.addProducts_prodID.Size = new System.Drawing.Size(117, 20);
            this.addProducts_prodID.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Product ID: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(35, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 346);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "All Products";
            // 
            // brn_UpdateProducts
            // 
            this.brn_UpdateProducts.Location = new System.Drawing.Point(403, 33);
            this.brn_UpdateProducts.Name = "brn_UpdateProducts";
            this.brn_UpdateProducts.Size = new System.Drawing.Size(102, 33);
            this.brn_UpdateProducts.TabIndex = 50;
            this.brn_UpdateProducts.Text = "Update";
            this.brn_UpdateProducts.UseVisualStyleBackColor = true;
            this.brn_UpdateProducts.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(511, 33);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(102, 33);
            this.btn_Delete.TabIndex = 51;
            this.btn_Delete.Text = "Remove";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_AddProducts
            // 
            this.button_AddProducts.Location = new System.Drawing.Point(617, 537);
            this.button_AddProducts.Name = "button_AddProducts";
            this.button_AddProducts.Size = new System.Drawing.Size(102, 33);
            this.button_AddProducts.TabIndex = 52;
            this.button_AddProducts.Text = "Add";
            this.button_AddProducts.UseVisualStyleBackColor = true;
            this.button_AddProducts.Click += new System.EventHandler(this.button_AddProducts_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Click to Import";
            // 
            // addProducts_imageView
            // 
            this.addProducts_imageView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addProducts_imageView.BackgroundImage")));
            this.addProducts_imageView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addProducts_imageView.InitialImage = null;
            this.addProducts_imageView.Location = new System.Drawing.Point(619, 458);
            this.addProducts_imageView.Name = "addProducts_imageView";
            this.addProducts_imageView.Size = new System.Drawing.Size(100, 50);
            this.addProducts_imageView.TabIndex = 55;
            this.addProducts_imageView.TabStop = false;
            this.addProducts_imageView.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(619, 33);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(102, 33);
            this.btn_Clear.TabIndex = 56;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // AdminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.addProducts_imageView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_AddProducts);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.brn_UpdateProducts);
            this.Controls.Add(this.addProducts_status);
            this.Controls.Add(this.addProducts_category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addProducts_stock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addProducts_price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addProducts_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addProducts_prodID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "AdminAddProducts";
            this.Size = new System.Drawing.Size(769, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProducts_imageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox addProducts_status;
        private System.Windows.Forms.ComboBox addProducts_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addProducts_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addProducts_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addProducts_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addProducts_prodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button brn_UpdateProducts;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button button_AddProducts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox addProducts_imageView;
        private System.Windows.Forms.Button btn_Clear;
    }
}
