namespace SaiDevaCraker
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
            this.BillNoLabel = new System.Windows.Forms.Label();
            this.billNoBox = new System.Windows.Forms.TextBox();
            this.BillDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custNametextBox = new System.Windows.Forms.TextBox();
            this.mobileNolabel = new System.Windows.Forms.Label();
            this.mobileNoBox = new System.Windows.Forms.TextBox();
            this.ProductGBox = new System.Windows.Forms.GroupBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PayableAmountTextBox = new System.Windows.Forms.TextBox();
            this.PayableAmontlbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalPricetextBox = new System.Windows.Forms.TextBox();
            this.QtytextBox = new System.Windows.Forms.TextBox();
            this.ProductIDtextBox = new System.Windows.Forms.TextBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ProductNametextBox = new System.Windows.Forms.TextBox();
            this.UnitPricetextBox = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.billInfogroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNEW = new System.Windows.Forms.Button();
            this.btnPRINT = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ProductGBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.billInfogroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BillNoLabel
            // 
            this.BillNoLabel.AutoSize = true;
            this.BillNoLabel.Location = new System.Drawing.Point(5, 21);
            this.BillNoLabel.Name = "BillNoLabel";
            this.BillNoLabel.Size = new System.Drawing.Size(49, 15);
            this.BillNoLabel.TabIndex = 0;
            this.BillNoLabel.Text = "Bill no. :";
            this.BillNoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // billNoBox
            // 
            this.billNoBox.Location = new System.Drawing.Point(60, 18);
            this.billNoBox.Name = "billNoBox";
            this.billNoBox.Size = new System.Drawing.Size(100, 23);
            this.billNoBox.TabIndex = 1;
            this.billNoBox.TextChanged += new System.EventHandler(this.billNoBox_TextChanged);
            // 
            // BillDateLabel
            // 
            this.BillDateLabel.AutoSize = true;
            this.BillDateLabel.Location = new System.Drawing.Point(601, 24);
            this.BillDateLabel.Name = "BillDateLabel";
            this.BillDateLabel.Size = new System.Drawing.Size(61, 15);
            this.BillDateLabel.TabIndex = 2;
            this.BillDateLabel.Text = "Bill-Date : ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(658, 21);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(104, 23);
            this.dateTimePicker.TabIndex = 3;
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(2, 19);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(100, 15);
            this.custNameLabel.TabIndex = 4;
            this.custNameLabel.Text = "Customer Name: ";
            // 
            // custNametextBox
            // 
            this.custNametextBox.Location = new System.Drawing.Point(99, 16);
            this.custNametextBox.Name = "custNametextBox";
            this.custNametextBox.Size = new System.Drawing.Size(311, 23);
            this.custNametextBox.TabIndex = 5;
            // 
            // mobileNolabel
            // 
            this.mobileNolabel.AutoSize = true;
            this.mobileNolabel.Location = new System.Drawing.Point(479, 19);
            this.mobileNolabel.Name = "mobileNolabel";
            this.mobileNolabel.Size = new System.Drawing.Size(69, 15);
            this.mobileNolabel.TabIndex = 6;
            this.mobileNolabel.Text = "Mobile No: ";
            this.mobileNolabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // mobileNoBox
            // 
            this.mobileNoBox.Location = new System.Drawing.Point(543, 16);
            this.mobileNoBox.Name = "mobileNoBox";
            this.mobileNoBox.Size = new System.Drawing.Size(216, 23);
            this.mobileNoBox.TabIndex = 7;
            this.mobileNoBox.TextChanged += new System.EventHandler(this.mobileNoBox_TextChanged);
            // 
            // ProductGBox
            // 
            this.ProductGBox.Controls.Add(this.SubTotalTextBox);
            this.ProductGBox.Controls.Add(this.SubTotalLbl);
            this.ProductGBox.Controls.Add(this.label3);
            this.ProductGBox.Controls.Add(this.DiscountTextBox);
            this.ProductGBox.Controls.Add(this.label2);
            this.ProductGBox.Controls.Add(this.PayableAmountTextBox);
            this.ProductGBox.Controls.Add(this.PayableAmontlbl);
            this.ProductGBox.Controls.Add(this.tableLayoutPanel1);
            this.ProductGBox.Location = new System.Drawing.Point(13, 151);
            this.ProductGBox.Name = "ProductGBox";
            this.ProductGBox.Size = new System.Drawing.Size(776, 433);
            this.ProductGBox.TabIndex = 8;
            this.ProductGBox.TabStop = false;
            this.ProductGBox.Text = "Product Details";
            this.ProductGBox.Leave += new System.EventHandler(this.ProductGBox_Leave);
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(585, 335);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(173, 23);
            this.SubTotalTextBox.TabIndex = 17;
            this.SubTotalTextBox.Leave += new System.EventHandler(this.SubTotalTextBox_Leave);
            // 
            // SubTotalLbl
            // 
            this.SubTotalLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubTotalLbl.AutoSize = true;
            this.SubTotalLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubTotalLbl.Location = new System.Drawing.Point(499, 337);
            this.SubTotalLbl.Name = "SubTotalLbl";
            this.SubTotalLbl.Size = new System.Drawing.Size(80, 21);
            this.SubTotalLbl.TabIndex = 18;
            this.SubTotalLbl.Text = "Sub Total :";
            this.SubTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(729, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(586, 364);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(137, 23);
            this.DiscountTextBox.TabIndex = 17;
            this.DiscountTextBox.Leave += new System.EventHandler(this.DiscountTextBox_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(501, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Discount :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PayableAmountTextBox
            // 
            this.PayableAmountTextBox.Location = new System.Drawing.Point(585, 393);
            this.PayableAmountTextBox.Name = "PayableAmountTextBox";
            this.PayableAmountTextBox.Size = new System.Drawing.Size(173, 23);
            this.PayableAmountTextBox.TabIndex = 12;
            this.PayableAmountTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PayableAmontlbl
            // 
            this.PayableAmontlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PayableAmontlbl.AutoSize = true;
            this.PayableAmontlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PayableAmontlbl.Location = new System.Drawing.Point(445, 391);
            this.PayableAmontlbl.Name = "PayableAmontlbl";
            this.PayableAmontlbl.Size = new System.Drawing.Size(134, 21);
            this.PayableAmontlbl.TabIndex = 15;
            this.PayableAmontlbl.Text = "Payable  Amount :";
            this.PayableAmontlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PayableAmontlbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.42424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.57576F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.TotalPricetextBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.QtytextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProductIDtextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TotalPriceLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.UnitPriceLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.QtyLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProductNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProductIdLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProductNametextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UnitPricetextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnADD, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCLEAR, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(755, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // TotalPricetextBox
            // 
            this.TotalPricetextBox.Location = new System.Drawing.Point(489, 31);
            this.TotalPricetextBox.Name = "TotalPricetextBox";
            this.TotalPricetextBox.Size = new System.Drawing.Size(94, 23);
            this.TotalPricetextBox.TabIndex = 11;
            // 
            // QtytextBox
            // 
            this.QtytextBox.Location = new System.Drawing.Point(333, 31);
            this.QtytextBox.Name = "QtytextBox";
            this.QtytextBox.Size = new System.Drawing.Size(47, 23);
            this.QtytextBox.TabIndex = 11;
            this.QtytextBox.TextChanged += new System.EventHandler(this.QtytextBox_TextChanged);
            // 
            // ProductIDtextBox
            // 
            this.ProductIDtextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProductIDtextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProductIDtextBox.Location = new System.Drawing.Point(3, 31);
            this.ProductIDtextBox.Name = "ProductIDtextBox";
            this.ProductIDtextBox.Size = new System.Drawing.Size(100, 23);
            this.ProductIDtextBox.TabIndex = 4;
            this.ProductIDtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductIDtextBox_KeyDown);
            this.ProductIDtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductIDtextBox_KeyPress);
            this.ProductIDtextBox.Leave += new System.EventHandler(this.ProductIDtextBox_Leave);
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceLabel.Location = new System.Drawing.Point(496, 3);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(80, 21);
            this.TotalPriceLabel.TabIndex = 4;
            this.TotalPriceLabel.Text = "Total Price";
            this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitPriceLabel.Location = new System.Drawing.Point(396, 3);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(77, 21);
            this.UnitPriceLabel.TabIndex = 3;
            this.UnitPriceLabel.Text = "Unit Price";
            this.UnitPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QtyLabel
            // 
            this.QtyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QtyLabel.Location = new System.Drawing.Point(339, 3);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(35, 21);
            this.QtyLabel.TabIndex = 3;
            this.QtyLabel.Text = "Qty";
            this.QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductNameLabel.Location = new System.Drawing.Point(163, 3);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(110, 21);
            this.ProductNameLabel.TabIndex = 2;
            this.ProductNameLabel.Text = "Product Name";
            this.ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductIdLabel.Location = new System.Drawing.Point(12, 3);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(83, 21);
            this.ProductIdLabel.TabIndex = 1;
            this.ProductIdLabel.Text = "Product ID";
            this.ProductIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductNametextBox
            // 
            this.ProductNametextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProductNametextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProductNametextBox.Location = new System.Drawing.Point(110, 31);
            this.ProductNametextBox.Name = "ProductNametextBox";
            this.ProductNametextBox.Size = new System.Drawing.Size(217, 23);
            this.ProductNametextBox.TabIndex = 5;
            this.ProductNametextBox.TextChanged += new System.EventHandler(this.ProductNametextBox_TextChanged);
            this.ProductNametextBox.Enter += new System.EventHandler(this.ProductNametextBox_Enter);
            this.ProductNametextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductNametextBox_KeyDown);
            this.ProductNametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductNametextBox_KeyPress);
            this.ProductNametextBox.Leave += new System.EventHandler(this.ProductNametextBox_Leave);
            // 
            // UnitPricetextBox
            // 
            this.UnitPricetextBox.Location = new System.Drawing.Point(386, 31);
            this.UnitPricetextBox.Name = "UnitPricetextBox";
            this.UnitPricetextBox.Size = new System.Drawing.Size(97, 23);
            this.UnitPricetextBox.TabIndex = 12;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(589, 31);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(82, 23);
            this.btnADD.TabIndex = 13;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.Location = new System.Drawing.Point(677, 31);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(75, 23);
            this.btnCLEAR.TabIndex = 14;
            this.btnCLEAR.Text = "CLEAR";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // billInfogroupBox
            // 
            this.billInfogroupBox.Controls.Add(this.dateTimePicker);
            this.billInfogroupBox.Controls.Add(this.BillDateLabel);
            this.billInfogroupBox.Controls.Add(this.billNoBox);
            this.billInfogroupBox.Controls.Add(this.BillNoLabel);
            this.billInfogroupBox.Location = new System.Drawing.Point(12, 12);
            this.billInfogroupBox.Name = "billInfogroupBox";
            this.billInfogroupBox.Size = new System.Drawing.Size(773, 61);
            this.billInfogroupBox.TabIndex = 9;
            this.billInfogroupBox.TabStop = false;
            this.billInfogroupBox.Text = "Bill Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mobileNoBox);
            this.groupBox1.Controls.Add(this.mobileNolabel);
            this.groupBox1.Controls.Add(this.custNametextBox);
            this.groupBox1.Controls.Add(this.custNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 54);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataSrNo,
            this.dataProductID,
            this.dataProductName,
            this.dataQty,
            this.dataUnitPrice,
            this.dataTotalPrice,
            this.dataDelete});
            this.dataGridView1.Location = new System.Drawing.Point(19, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(755, 214);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // dataSrNo
            // 
            this.dataSrNo.HeaderText = "Sr. No.";
            this.dataSrNo.Name = "dataSrNo";
            // 
            // dataProductID
            // 
            this.dataProductID.HeaderText = "Product ID";
            this.dataProductID.Name = "dataProductID";
            // 
            // dataProductName
            // 
            this.dataProductName.HeaderText = "Product Name";
            this.dataProductName.Name = "dataProductName";
            // 
            // dataQty
            // 
            this.dataQty.HeaderText = "Qty";
            this.dataQty.Name = "dataQty";
            // 
            // dataUnitPrice
            // 
            this.dataUnitPrice.HeaderText = "Unit Price";
            this.dataUnitPrice.Name = "dataUnitPrice";
            // 
            // dataTotalPrice
            // 
            this.dataTotalPrice.HeaderText = "Total Price";
            this.dataTotalPrice.Name = "dataTotalPrice";
            // 
            // dataDelete
            // 
            this.dataDelete.HeaderText = "Delete";
            this.dataDelete.Name = "dataDelete";
            this.dataDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataDelete.Text = "Delete";
            this.dataDelete.UseColumnTextForButtonValue = true;
            // 
            // btnNEW
            // 
            this.btnNEW.Location = new System.Drawing.Point(18, 590);
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(97, 23);
            this.btnNEW.TabIndex = 14;
            this.btnNEW.Text = "NEW";
            this.btnNEW.UseVisualStyleBackColor = true;
            this.btnNEW.Click += new System.EventHandler(this.btnNEW_Click);
            // 
            // btnPRINT
            // 
            this.btnPRINT.Location = new System.Drawing.Point(121, 590);
            this.btnPRINT.Name = "btnPRINT";
            this.btnPRINT.Size = new System.Drawing.Size(97, 23);
            this.btnPRINT.TabIndex = 16;
            this.btnPRINT.Text = "PRINT";
            this.btnPRINT.UseVisualStyleBackColor = true;
            this.btnPRINT.Click += new System.EventHandler(this.btnPRINT_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 628);
            this.Controls.Add(this.btnPRINT);
            this.Controls.Add(this.btnNEW);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.billInfogroupBox);
            this.Controls.Add(this.ProductGBox);
            this.Name = "Form1";
            this.Text = "Sai Deva Creakers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ProductGBox.ResumeLayout(false);
            this.ProductGBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.billInfogroupBox.ResumeLayout(false);
            this.billInfogroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label BillNoLabel;
        private TextBox billNoBox;
        private Label BillDateLabel;
        private DateTimePicker dateTimePicker;
        private Label custNameLabel;
        private TextBox custNametextBox;
        private Label mobileNolabel;
        private TextBox mobileNoBox;
        private GroupBox ProductGBox;
        private GroupBox billInfogroupBox;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ProductIdLabel;
        private Label UnitPriceLabel;
        private Label QtyLabel;
        private Label ProductNameLabel;
        private Label TotalPriceLabel;
        private TextBox PayableAmountTextBox;
        private Label PayableAmontlbl;
        private TextBox TotalPricetextBox;
        private TextBox QtytextBox;
        private TextBox ProductIDtextBox;
        private TextBox ProductNametextBox;
        private TextBox UnitPricetextBox;
        private Button btnADD;
        private Button btnCLEAR;
        private DataGridView dataGridView1;
        private Button btnNEW;
        private Button btnPRINT;
        private Label label3;
        private TextBox DiscountTextBox;
        private Label label2;
        private TextBox SubTotalTextBox;
        private Label SubTotalLbl;
        private DataGridViewTextBoxColumn dataSrNo;
        private DataGridViewTextBoxColumn dataProductID;
        private DataGridViewTextBoxColumn dataProductName;
        private DataGridViewTextBoxColumn dataQty;
        private DataGridViewTextBoxColumn dataUnitPrice;
        private DataGridViewTextBoxColumn dataTotalPrice;
        private DataGridViewButtonColumn dataDelete;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }

    
}