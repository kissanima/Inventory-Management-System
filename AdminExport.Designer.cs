namespace Inventory_Management_System
{
    partial class AdminExport
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_SelectCategories = new System.Windows.Forms.Label();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.comboBox_FileType = new System.Windows.Forms.ComboBox();
            this.label_FileType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(15, 12);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(84, 32);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Export";
            // 
            // label_SelectCategories
            // 
            this.label_SelectCategories.AutoSize = true;
            this.label_SelectCategories.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectCategories.Location = new System.Drawing.Point(107, 190);
            this.label_SelectCategories.Name = "label_SelectCategories";
            this.label_SelectCategories.Size = new System.Drawing.Size(157, 25);
            this.label_SelectCategories.TabIndex = 1;
            this.label_SelectCategories.Text = "Select Categories";
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Items.AddRange(new object[] {
            "Select All"});
            this.comboBox_Categories.Location = new System.Drawing.Point(126, 218);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Categories.TabIndex = 2;
            this.comboBox_Categories.SelectedIndexChanged += new System.EventHandler(this.comboBox_Categories_SelectedIndexChanged);
            // 
            // comboBox_FileType
            // 
            this.comboBox_FileType.FormattingEnabled = true;
            this.comboBox_FileType.Items.AddRange(new object[] {
            "Excel",
            "PDF"});
            this.comboBox_FileType.Location = new System.Drawing.Point(327, 218);
            this.comboBox_FileType.Name = "comboBox_FileType";
            this.comboBox_FileType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_FileType.TabIndex = 4;
            this.comboBox_FileType.SelectedIndexChanged += new System.EventHandler(this.comboBox_FileType_SelectedIndexChanged);
            // 
            // label_FileType
            // 
            this.label_FileType.AutoSize = true;
            this.label_FileType.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FileType.Location = new System.Drawing.Point(322, 190);
            this.label_FileType.Name = "label_FileType";
            this.label_FileType.Size = new System.Drawing.Size(139, 25);
            this.label_FileType.TabIndex = 3;
            this.label_FileType.Text = "Select File Type";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(562, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_FileType);
            this.Controls.Add(this.label_FileType);
            this.Controls.Add(this.comboBox_Categories);
            this.Controls.Add(this.label_SelectCategories);
            this.Controls.Add(this.label_Title);
            this.Name = "AdminExport";
            this.Size = new System.Drawing.Size(769, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_SelectCategories;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.ComboBox comboBox_FileType;
        private System.Windows.Forms.Label label_FileType;
        private System.Windows.Forms.Button button1;
    }
}
