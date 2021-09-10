
namespace RealEstateAgent
{
    partial class MainForm
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
            this.txt_dynamic1 = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_dynamic2 = new System.Windows.Forms.TextBox();
            this.lbl_dynamic1 = new System.Windows.Forms.Label();
            this.lbl_dynamic2 = new System.Windows.Forms.Label();
            this.lbl_dynamic3 = new System.Windows.Forms.Label();
            this.txt_dynamic3 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_northwest = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_estateType = new System.Windows.Forms.Label();
            this.lbl_buildingType = new System.Windows.Forms.Label();
            this.lbl_legalForm = new System.Windows.Forms.Label();
            this.cmb_legalForm = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_uploadImage = new System.Windows.Forms.Label();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBox_estateImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_southwest.SuspendLayout();
            this.pnl_northwest.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_estateImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_southwest, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_northwest, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox_estateImage, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 552);
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
            this.pnl_southwest.Controls.Add(this.txt_dynamic1, 1, 5);
            this.pnl_southwest.Controls.Add(this.txt_price, 1, 4);
            this.pnl_southwest.Controls.Add(this.txt_dynamic2, 1, 6);
            this.pnl_southwest.Controls.Add(this.lbl_dynamic1, 0, 5);
            this.pnl_southwest.Controls.Add(this.lbl_dynamic2, 0, 6);
            this.pnl_southwest.Controls.Add(this.lbl_dynamic3, 0, 7);
            this.pnl_southwest.Controls.Add(this.txt_dynamic3, 1, 7);
            this.pnl_southwest.Controls.Add(this.btn_save, 1, 8);
            this.pnl_southwest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_southwest.Location = new System.Drawing.Point(3, 228);
            this.pnl_southwest.Name = "pnl_southwest";
            this.pnl_southwest.RowCount = 10;
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_southwest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_southwest.Size = new System.Drawing.Size(473, 321);
            this.pnl_southwest.TabIndex = 0;
            this.pnl_southwest.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // lbl_streetAddress
            // 
            this.lbl_streetAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_streetAddress.AutoSize = true;
            this.lbl_streetAddress.Location = new System.Drawing.Point(3, 6);
            this.lbl_streetAddress.Name = "lbl_streetAddress";
            this.lbl_streetAddress.Size = new System.Drawing.Size(230, 20);
            this.lbl_streetAddress.TabIndex = 2;
            this.lbl_streetAddress.Text = "Street address:";
            // 
            // txt_streetAddress
            // 
            this.txt_streetAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_streetAddress.Location = new System.Drawing.Point(239, 3);
            this.txt_streetAddress.Name = "txt_streetAddress";
            this.txt_streetAddress.Size = new System.Drawing.Size(231, 27);
            this.txt_streetAddress.TabIndex = 3;
            // 
            // lbl_zipCode
            // 
            this.lbl_zipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_zipCode.AutoSize = true;
            this.lbl_zipCode.Location = new System.Drawing.Point(3, 39);
            this.lbl_zipCode.Name = "lbl_zipCode";
            this.lbl_zipCode.Size = new System.Drawing.Size(230, 20);
            this.lbl_zipCode.TabIndex = 4;
            this.lbl_zipCode.Text = "Zip code:";
            // 
            // txt_zipCode
            // 
            this.txt_zipCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_zipCode.Location = new System.Drawing.Point(239, 36);
            this.txt_zipCode.Name = "txt_zipCode";
            this.txt_zipCode.Size = new System.Drawing.Size(231, 27);
            this.txt_zipCode.TabIndex = 5;
            // 
            // lbl_city
            // 
            this.lbl_city.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(3, 72);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(230, 20);
            this.lbl_city.TabIndex = 6;
            this.lbl_city.Text = "City:";
            // 
            // txt_city
            // 
            this.txt_city.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_city.Location = new System.Drawing.Point(239, 69);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(231, 27);
            this.txt_city.TabIndex = 7;
            // 
            // lbl_country
            // 
            this.lbl_country.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(3, 106);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(230, 20);
            this.lbl_country.TabIndex = 8;
            this.lbl_country.Text = "Country:";
            this.lbl_country.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_country
            // 
            this.cmb_country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_country.FormattingEnabled = true;
            this.cmb_country.Location = new System.Drawing.Point(239, 102);
            this.cmb_country.Name = "cmb_country";
            this.cmb_country.Size = new System.Drawing.Size(231, 28);
            this.cmb_country.TabIndex = 9;
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(3, 139);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(230, 20);
            this.lbl_price.TabIndex = 10;
            this.lbl_price.Text = "Price: ";
            this.lbl_price.Click += new System.EventHandler(this.lbl_price_Click);
            // 
            // txt_dynamic1
            // 
            this.txt_dynamic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_dynamic1.Location = new System.Drawing.Point(239, 169);
            this.txt_dynamic1.Name = "txt_dynamic1";
            this.txt_dynamic1.Size = new System.Drawing.Size(231, 27);
            this.txt_dynamic1.TabIndex = 11;
            // 
            // txt_price
            // 
            this.txt_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_price.Location = new System.Drawing.Point(239, 136);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(231, 27);
            this.txt_price.TabIndex = 12;
            // 
            // txt_dynamic2
            // 
            this.txt_dynamic2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_dynamic2.Location = new System.Drawing.Point(239, 202);
            this.txt_dynamic2.Name = "txt_dynamic2";
            this.txt_dynamic2.Size = new System.Drawing.Size(231, 27);
            this.txt_dynamic2.TabIndex = 13;
            // 
            // lbl_dynamic1
            // 
            this.lbl_dynamic1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dynamic1.AutoSize = true;
            this.lbl_dynamic1.Location = new System.Drawing.Point(3, 172);
            this.lbl_dynamic1.Name = "lbl_dynamic1";
            this.lbl_dynamic1.Size = new System.Drawing.Size(230, 20);
            this.lbl_dynamic1.TabIndex = 14;
            this.lbl_dynamic1.Text = "DynamicLabel1";
            // 
            // lbl_dynamic2
            // 
            this.lbl_dynamic2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dynamic2.AutoSize = true;
            this.lbl_dynamic2.Location = new System.Drawing.Point(3, 205);
            this.lbl_dynamic2.Name = "lbl_dynamic2";
            this.lbl_dynamic2.Size = new System.Drawing.Size(230, 20);
            this.lbl_dynamic2.TabIndex = 15;
            this.lbl_dynamic2.Text = "DynamicLabel2";
            // 
            // lbl_dynamic3
            // 
            this.lbl_dynamic3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dynamic3.AutoSize = true;
            this.lbl_dynamic3.Location = new System.Drawing.Point(3, 238);
            this.lbl_dynamic3.Name = "lbl_dynamic3";
            this.lbl_dynamic3.Size = new System.Drawing.Size(230, 20);
            this.lbl_dynamic3.TabIndex = 16;
            this.lbl_dynamic3.Text = "DynamicLabel3";
            // 
            // txt_dynamic3
            // 
            this.txt_dynamic3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_dynamic3.Location = new System.Drawing.Point(239, 235);
            this.txt_dynamic3.Name = "txt_dynamic3";
            this.txt_dynamic3.Size = new System.Drawing.Size(231, 27);
            this.txt_dynamic3.TabIndex = 17;
            // 
            // btn_save
            // 
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save.Location = new System.Drawing.Point(239, 268);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(231, 50);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // pnl_northwest
            // 
            this.pnl_northwest.ColumnCount = 2;
            this.pnl_northwest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_northwest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_northwest.Controls.Add(this.lbl_estateType, 0, 0);
            this.pnl_northwest.Controls.Add(this.lbl_buildingType, 0, 1);
            this.pnl_northwest.Controls.Add(this.lbl_legalForm, 0, 2);
            this.pnl_northwest.Controls.Add(this.cmb_legalForm, 1, 2);
            this.pnl_northwest.Controls.Add(this.comboBox1, 1, 1);
            this.pnl_northwest.Controls.Add(this.comboBox2, 1, 0);
            this.pnl_northwest.Controls.Add(this.lbl_uploadImage, 0, 3);
            this.pnl_northwest.Controls.Add(this.btn_uploadImage, 1, 3);
            this.pnl_northwest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_northwest.Location = new System.Drawing.Point(3, 3);
            this.pnl_northwest.Name = "pnl_northwest";
            this.pnl_northwest.RowCount = 5;
            this.pnl_northwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_northwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_northwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_northwest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_northwest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_northwest.Size = new System.Drawing.Size(473, 219);
            this.pnl_northwest.TabIndex = 1;
            // 
            // lbl_estateType
            // 
            this.lbl_estateType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estateType.AutoSize = true;
            this.lbl_estateType.Location = new System.Drawing.Point(3, 7);
            this.lbl_estateType.Name = "lbl_estateType";
            this.lbl_estateType.Size = new System.Drawing.Size(230, 20);
            this.lbl_estateType.TabIndex = 0;
            this.lbl_estateType.Text = "Estate type:";
            this.lbl_estateType.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_buildingType
            // 
            this.lbl_buildingType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_buildingType.AutoSize = true;
            this.lbl_buildingType.Location = new System.Drawing.Point(3, 41);
            this.lbl_buildingType.Name = "lbl_buildingType";
            this.lbl_buildingType.Size = new System.Drawing.Size(230, 20);
            this.lbl_buildingType.TabIndex = 1;
            this.lbl_buildingType.Text = "Building type:";
            // 
            // lbl_legalForm
            // 
            this.lbl_legalForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_legalForm.AutoSize = true;
            this.lbl_legalForm.Location = new System.Drawing.Point(3, 75);
            this.lbl_legalForm.Name = "lbl_legalForm";
            this.lbl_legalForm.Size = new System.Drawing.Size(230, 20);
            this.lbl_legalForm.TabIndex = 2;
            this.lbl_legalForm.Text = "Legal form:";
            // 
            // cmb_legalForm
            // 
            this.cmb_legalForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_legalForm.FormattingEnabled = true;
            this.cmb_legalForm.Location = new System.Drawing.Point(239, 71);
            this.cmb_legalForm.Name = "cmb_legalForm";
            this.cmb_legalForm.Size = new System.Drawing.Size(231, 28);
            this.cmb_legalForm.TabIndex = 3;
            this.cmb_legalForm.SelectedIndexChanged += new System.EventHandler(this.cmb_legalForm_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(239, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 28);
            this.comboBox2.TabIndex = 5;
            // 
            // lbl_uploadImage
            // 
            this.lbl_uploadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_uploadImage.AutoSize = true;
            this.lbl_uploadImage.Location = new System.Drawing.Point(3, 109);
            this.lbl_uploadImage.Name = "lbl_uploadImage";
            this.lbl_uploadImage.Size = new System.Drawing.Size(230, 20);
            this.lbl_uploadImage.TabIndex = 6;
            this.lbl_uploadImage.Text = "Image:";
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_uploadImage.Location = new System.Drawing.Point(239, 105);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(231, 29);
            this.btn_uploadImage.TabIndex = 7;
            this.btn_uploadImage.Text = "Upload Image";
            this.btn_uploadImage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_edit, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_remove, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(482, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(473, 219);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Location = new System.Drawing.Point(3, 182);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(230, 29);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.Location = new System.Drawing.Point(239, 182);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(231, 29);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.address});
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(467, 169);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Street address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // pBox_estateImage
            // 
            this.pBox_estateImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pBox_estateImage.Location = new System.Drawing.Point(482, 261);
            this.pBox_estateImage.Name = "pBox_estateImage";
            this.pBox_estateImage.Size = new System.Drawing.Size(473, 254);
            this.pBox_estateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_estateImage.TabIndex = 2;
            this.pBox_estateImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_southwest.ResumeLayout(false);
            this.pnl_southwest.PerformLayout();
            this.pnl_northwest.ResumeLayout(false);
            this.pnl_northwest.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_estateImage)).EndInit();
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
        private System.Windows.Forms.TextBox txt_dynamic1;
        private System.Windows.Forms.PictureBox pBox_estateImage;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.TextBox txt_dynamic2;
        private System.Windows.Forms.Label lbl_dynamic1;
        private System.Windows.Forms.Label lbl_dynamic2;
        private System.Windows.Forms.Label lbl_dynamic3;
        private System.Windows.Forms.TextBox txt_dynamic3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_uploadImage;
        private System.Windows.Forms.Button btn_uploadImage;
    }
}

