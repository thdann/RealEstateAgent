
namespace RealEstateAgent
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_southwest = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_streetAddress = new System.Windows.Forms.Label();
            this.txt_streetAddress = new System.Windows.Forms.TextBox();
            this.lbl_zipCode = new System.Windows.Forms.Label();
            this.txt_zipCode = new System.Windows.Forms.TextBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.cmb_country = new System.Windows.Forms.ComboBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_tba = new System.Windows.Forms.TextBox();
            this.pnl_northwest = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_estateType = new System.Windows.Forms.Label();
            this.lbl_buildingType = new System.Windows.Forms.Label();
            this.lbl_legalForm = new System.Windows.Forms.Label();
            this.cmb_legalForm = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_southwest.SuspendLayout();
            this.pnl_northwest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_southwest, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_northwest, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnl_southwest
            // 
            this.pnl_southwest.ColumnCount = 2;
            this.pnl_southwest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_southwest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_southwest.Controls.Add(this.lbl_streetAddress, 0, 0);
            this.pnl_southwest.Controls.Add(this.txt_streetAddress, 1, 0);
            this.pnl_southwest.Controls.Add(this.lbl_zipCode, 0, 1);
            this.pnl_southwest.Controls.Add(this.txt_zipCode, 1, 1);
            this.pnl_southwest.Controls.Add(this.lbl_city, 0, 2);
            this.pnl_southwest.Controls.Add(this.txt_city, 1, 2);
            this.pnl_southwest.Controls.Add(this.lbl_country, 0, 3);
            this.pnl_southwest.Controls.Add(this.cmb_country, 1, 3);
            this.pnl_southwest.Controls.Add(this.lbl_price, 0, 4);
            this.pnl_southwest.Controls.Add(this.txt_tba, 1, 5);
            this.pnl_southwest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_southwest.Location = new System.Drawing.Point(3, 228);
            this.pnl_southwest.Name = "pnl_southwest";
            this.pnl_southwest.RowCount = 6;
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_southwest.Size = new System.Drawing.Size(394, 219);
            this.pnl_southwest.TabIndex = 0;
            this.pnl_southwest.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // lbl_streetAddress
            // 
            this.lbl_streetAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_streetAddress.AutoSize = true;
            this.lbl_streetAddress.Location = new System.Drawing.Point(3, 6);
            this.lbl_streetAddress.Name = "lbl_streetAddress";
            this.lbl_streetAddress.Size = new System.Drawing.Size(191, 20);
            this.lbl_streetAddress.TabIndex = 2;
            this.lbl_streetAddress.Text = "Street address:";
            // 
            // txt_streetAddress
            // 
            this.txt_streetAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_streetAddress.Location = new System.Drawing.Point(200, 3);
            this.txt_streetAddress.Name = "txt_streetAddress";
            this.txt_streetAddress.Size = new System.Drawing.Size(191, 27);
            this.txt_streetAddress.TabIndex = 3;
            // 
            // lbl_zipCode
            // 
            this.lbl_zipCode.AutoSize = true;
            this.lbl_zipCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_zipCode.Location = new System.Drawing.Point(3, 33);
            this.lbl_zipCode.Name = "lbl_zipCode";
            this.lbl_zipCode.Size = new System.Drawing.Size(191, 33);
            this.lbl_zipCode.TabIndex = 4;
            this.lbl_zipCode.Text = "Zip code:";
            // 
            // txt_zipCode
            // 
            this.txt_zipCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_zipCode.Location = new System.Drawing.Point(200, 36);
            this.txt_zipCode.Name = "txt_zipCode";
            this.txt_zipCode.Size = new System.Drawing.Size(191, 27);
            this.txt_zipCode.TabIndex = 5;
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_city.Location = new System.Drawing.Point(3, 66);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(191, 33);
            this.lbl_city.TabIndex = 6;
            this.lbl_city.Text = "City:";
            // 
            // txt_city
            // 
            this.txt_city.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_city.Location = new System.Drawing.Point(200, 69);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(191, 27);
            this.txt_city.TabIndex = 7;
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_country.Location = new System.Drawing.Point(3, 99);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(191, 34);
            this.lbl_country.TabIndex = 8;
            this.lbl_country.Text = "Country:";
            this.lbl_country.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_country
            // 
            this.cmb_country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_country.FormattingEnabled = true;
            this.cmb_country.Location = new System.Drawing.Point(200, 102);
            this.cmb_country.Name = "cmb_country";
            this.cmb_country.Size = new System.Drawing.Size(191, 28);
            this.cmb_country.TabIndex = 9;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_price.Location = new System.Drawing.Point(3, 133);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(191, 20);
            this.lbl_price.TabIndex = 10;
            this.lbl_price.Text = "Price: ";
            this.lbl_price.Click += new System.EventHandler(this.lbl_price_Click);
            // 
            // txt_tba
            // 
            this.txt_tba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tba.Location = new System.Drawing.Point(200, 156);
            this.txt_tba.Name = "txt_tba";
            this.txt_tba.Size = new System.Drawing.Size(191, 27);
            this.txt_tba.TabIndex = 11;
            // 
            // pnl_northwest
            // 
            this.pnl_northwest.ColumnCount = 2;
            this.pnl_northwest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_northwest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl_northwest.Controls.Add(this.lbl_estateType, 0, 0);
            this.pnl_northwest.Controls.Add(this.lbl_buildingType, 0, 1);
            this.pnl_northwest.Controls.Add(this.lbl_legalForm, 0, 2);
            this.pnl_northwest.Controls.Add(this.cmb_legalForm, 1, 2);
            this.pnl_northwest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_northwest.Location = new System.Drawing.Point(3, 3);
            this.pnl_northwest.Name = "pnl_northwest";
            this.pnl_northwest.RowCount = 5;
            this.pnl_northwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_northwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_northwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_northwest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_northwest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_northwest.Size = new System.Drawing.Size(394, 219);
            this.pnl_northwest.TabIndex = 1;
            // 
            // lbl_estateType
            // 
            this.lbl_estateType.AutoSize = true;
            this.lbl_estateType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_estateType.Location = new System.Drawing.Point(3, 0);
            this.lbl_estateType.Name = "lbl_estateType";
            this.lbl_estateType.Size = new System.Drawing.Size(191, 20);
            this.lbl_estateType.TabIndex = 0;
            this.lbl_estateType.Text = "Estate type:";
            this.lbl_estateType.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_buildingType
            // 
            this.lbl_buildingType.AutoSize = true;
            this.lbl_buildingType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_buildingType.Location = new System.Drawing.Point(3, 20);
            this.lbl_buildingType.Name = "lbl_buildingType";
            this.lbl_buildingType.Size = new System.Drawing.Size(191, 20);
            this.lbl_buildingType.TabIndex = 1;
            this.lbl_buildingType.Text = "Building type:";
            // 
            // lbl_legalForm
            // 
            this.lbl_legalForm.AutoSize = true;
            this.lbl_legalForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_legalForm.Location = new System.Drawing.Point(3, 40);
            this.lbl_legalForm.Name = "lbl_legalForm";
            this.lbl_legalForm.Size = new System.Drawing.Size(191, 34);
            this.lbl_legalForm.TabIndex = 2;
            this.lbl_legalForm.Text = "Legal form:";
            // 
            // cmb_legalForm
            // 
            this.cmb_legalForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_legalForm.FormattingEnabled = true;
            this.cmb_legalForm.Location = new System.Drawing.Point(200, 43);
            this.cmb_legalForm.Name = "cmb_legalForm";
            this.cmb_legalForm.Size = new System.Drawing.Size(191, 28);
            this.cmb_legalForm.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(403, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_southwest.ResumeLayout(false);
            this.pnl_southwest.PerformLayout();
            this.pnl_northwest.ResumeLayout(false);
            this.pnl_northwest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pnl_southwest;
        private System.Windows.Forms.Label lbl_streetAddress;
        private System.Windows.Forms.TextBox txt_streetAddress;
        private System.Windows.Forms.Label lbl_zipCode;
        private System.Windows.Forms.TextBox txt_zipCode;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.ComboBox cmb_country;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TableLayoutPanel pnl_northwest;
        private System.Windows.Forms.Label lbl_estateType;
        private System.Windows.Forms.Label lbl_buildingType;
        private System.Windows.Forms.Label lbl_legalForm;
        private System.Windows.Forms.ComboBox cmb_legalForm;
        private System.Windows.Forms.TextBox txt_tba;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

