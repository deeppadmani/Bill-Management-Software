using System;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using ExcelSaiDevaCraker;
using System.Data.Common;
using DatabaseSaiDevaCraker;
using ItemDatabaseSaiDevaCraker;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Runtime.Intrinsics.X86;
using Font = System.Drawing.Font;
using DGVPrinterHelper;
using System.Reflection;
using System.Windows.Forms;
using USB_Barcode_Scanner;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaiDevaCraker
{
    
    public partial class Form1 : Form
    {
        classDadabase[] fullProductData;
        ItemDadabase[] ItemList;
        int ItemListLen = 0;

        int totalProduct;
        int totalDataProduct;

        int TotalBillNo;
        string BillNo = "";
        public Form1()
        {
                InitializeComponent();


                classExcel excel = new classExcel(@"C:\\Users\\deepp\\OneDrive\\Desktop\\Sai\\All_Product.xlsx", 1);

                ReadAndSetBillNumber();
                int Fbillno = Convert.ToInt32(BillNo);
                billNoBox.Text = (Fbillno + 1).ToString();
            
                totalProduct = excel.FindLastRow();
                totalDataProduct = excel.FindLastColumn();
            
                fullProductData = new classDadabase[totalProduct];

                for (int RowIdx = 1; RowIdx < totalProduct; RowIdx++)
                {
                    fullProductData[RowIdx] = new classDadabase();
                }
                excel.CloseFile();
                ProductIDtextBox.Focus();
                BarcodeScanner barcodeScanner = new BarcodeScanner(ProductIDtextBox);
                barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            ProductIDtextBox.Text = e.Barcode;
            btnADD_Click(this, new EventArgs());
        }
        public void dataprint()
        {
            MessageBox.Show(fullProductData[1].productName);
            MessageBox.Show(fullProductData[1].productId);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void billNoBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(billNoBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                billNoBox.Text = billNoBox.Text.Remove(billNoBox.Text.Length - 1);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mobileNoBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(mobileNoBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                mobileNoBox.Text = mobileNoBox.Text.Remove(mobileNoBox.Text.Length - 1);
            }
            if (10 < mobileNoBox.Text.Length)
            {
                MessageBox.Show("More Then 10 Digits not allowed");
                mobileNoBox.Text = mobileNoBox.Text.Remove(mobileNoBox.Text.Length - 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show("totalProduct : " + totalProduct.ToString());
           // MessageBox.Show("totalDataProduct : " + totalDataProduct.ToString());
            ReadExcel();
           // MessageBox.Show(fullProductData[1].productName);
            //MessageBox.Show(fullProductData[1].productId);
            SetOnInit();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            AddIteminList();
        }

        public void AddIteminList()
        {
            if (0 != ItemListLen)
            {
                Array.Resize<ItemDadabase>(ref ItemList, ItemListLen + 1);
            }
            else
            {
                ItemList = new ItemDadabase[1];
            }
            int RowCnt = -1;

            if ((0 != ProductIDtextBox.Text.Length) &&
                (0 != ProductNametextBox.Text.Length) &&
                (0 != QtytextBox.Text.Length) &&
                (0 != UnitPricetextBox.Text.Length) &&
                (0 != TotalPricetextBox.Text.Length)
                )
            {
                int SearchIdx = SearchValueFromDataGridView(ProductIDtextBox.Text);
                if (SearchIdx != -1)
                {
                    ItemList[SearchIdx].productQty = ItemList[SearchIdx].productQty + Int32.Parse(QtytextBox.Text);
                    ItemList[SearchIdx].productTotalPrice = ItemList[SearchIdx].productTotalPrice + ((Int32.Parse(QtytextBox.Text)) * ItemList[SearchIdx].productUnitPrice);
                    dataGridView1.Rows[SearchIdx].Cells["dataQty"].Value = ItemList[SearchIdx].productQty;
                    dataGridView1.Rows[SearchIdx].Cells["dataTotalPrice"].Value = ItemList[SearchIdx].productTotalPrice;
                    RowCnt = ItemListLen - 1;
                }
                else
                {
                    ItemList[ItemListLen] = new ItemDadabase();
                    ItemList[ItemListLen].productId = ProductIDtextBox.Text;
                    ItemList[ItemListLen].productName = ProductNametextBox.Text;
                    ItemList[ItemListLen].productQty = Int32.Parse(QtytextBox.Text);
                    ItemList[ItemListLen].productUnitPrice = Int32.Parse(UnitPricetextBox.Text);
                    ItemList[ItemListLen].productTotalPrice = Int32.Parse(TotalPricetextBox.Text);

                    ItemListLen = ItemListLen + 1;
                    RowCnt = dataGridView1.Rows.Add();

                    dataGridView1.Rows[RowCnt].Cells["dataSrNo"].Value = RowCnt + 1;
                    dataGridView1.Rows[RowCnt].Cells["dataProductID"].Value = ItemList[RowCnt].productId;
                    dataGridView1.Rows[RowCnt].Cells["dataProductName"].Value = ItemList[RowCnt].productName;
                    dataGridView1.Rows[RowCnt].Cells["dataQty"].Value = ItemList[RowCnt].productQty;
                    dataGridView1.Rows[RowCnt].Cells["dataUnitPrice"].Value = ItemList[RowCnt].productUnitPrice;
                    dataGridView1.Rows[RowCnt].Cells["dataTotalPrice"].Value = ItemList[RowCnt].productTotalPrice;
                }
                     //MessageBox.Show(RowCnt.ToString());

                
                
                getTotalAmount(RowCnt);
            }
            else {
                MessageBox.Show("Enter Valid Entry");
            }
        }
        public void getTotalAmount(int RowCnt)
        {
            double tempPayableAmt = 0,subTotal = 0,Discount = 0;

            if(0 == RowCnt)
                DiscountTextBox.Text = "0.0";

            for (int Idx = 0; Idx <= RowCnt; Idx++)
            {
                subTotal = subTotal + Convert.ToDouble(dataGridView1.Rows[Idx].Cells["dataTotalPrice"].Value);
            }
            SubTotalTextBox.Text = subTotal.ToString();
            Discount = Convert.ToDouble(DiscountTextBox.Text);

            tempPayableAmt = subTotal - ((subTotal * Discount) / 100);
            PayableAmountTextBox.Text = tempPayableAmt.ToString();
        }

        public void RemoveIteminList(int rIndex)
        {
            dataGridView1.Rows.RemoveAt(rIndex);

            for (int Idx = rIndex; Idx < ItemListLen - 1; Idx++)
            {
                ItemList[Idx] = ItemList[Idx + 1];
                dataGridView1.Rows[Idx].Cells["dataSrNo"].Value = Idx+1;

            }
            ItemListLen = ItemListLen - 1;
            Array.Resize<ItemDadabase>(ref ItemList, ItemListLen);

        }

        public void ReadExcel()
        {
            classExcel excel = new classExcel(@"C:\\Users\\deepp\\OneDrive\\Desktop\\Sai\\All_Product.xlsx", 1);

            var tempProduct = "";


            for (int RowIdx = 1; RowIdx < totalProduct; RowIdx++)
            {
                for (int ColumnIdx = 1; ColumnIdx < this.totalDataProduct; ColumnIdx++)
                {
                    tempProduct = excel.ReadCell(RowIdx, ColumnIdx);
                    switch (ColumnIdx)
                    {
                        case 1:
                            {
                                (fullProductData[RowIdx]).SetData(ColumnIdx, tempProduct.ToString());
                                MessageBox.Show(tempProduct.ToString());
                            }
                            break;

                        case 2:
                            {
                                (fullProductData[RowIdx]).SetData(ColumnIdx, tempProduct.ToString());
                            }
                            break;

                        case 3:
                            {
                                (fullProductData[RowIdx]).SetData(Convert.ToInt32(tempProduct));
                            }
                            break;

                        default:
                            {
                                MessageBox.Show("Idx Error");
                            }
                            break;
                    }
                }
            }
            excel.CloseFile();
        }
        public void SetOnInit()
        {
            AutoCompleteStringCollection ProductIdSuggest = new AutoCompleteStringCollection();
            for (int Idx = 1; Idx < totalProduct; Idx++)
            {
                ProductIdSuggest.Add((fullProductData[Idx]).productId.ToString());
            }
            ProductIDtextBox.AutoCompleteCustomSource = ProductIdSuggest;

            AutoCompleteStringCollection ProductNameSuggest = new AutoCompleteStringCollection();
            for (int Idx = 1; Idx < totalProduct; Idx++)
            {
                ProductNameSuggest.Add((fullProductData[Idx]).productName.ToString());
            }
            ProductNametextBox.AutoCompleteCustomSource = ProductNameSuggest;
        }

        private void ProductNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductNametextBox_Enter(object sender, EventArgs e)
        {
            

        }

        private int FindProductFromDataBase(string tempProductStr, int searchViaF)
        {
            int Idx = 0;

            switch (searchViaF)
            {
                case 1:
                    {
                        for (Idx = 1; Idx < totalProduct; Idx++)
                        {
                            if (tempProductStr == fullProductData[Idx].productId)
                            {
                                break;
                            }
                        }
                    }
                    break;

                case 2:
                    {
                        for (Idx = 1; Idx < totalProduct; Idx++)
                        {
                            if (tempProductStr == fullProductData[Idx].productName)
                            {
                                break;
                            }
                        }
                    }
                    break;
            }

            return Idx;
        }

        private void ProductNametextBox_Leave(object sender, EventArgs e)
        {
            string tempProductName = ProductNametextBox.Text;
            int dataLocation = FindProductFromDataBase(tempProductName, 2);

            if (0 != dataLocation)
            {
                if (totalProduct == dataLocation)
                {
                    return;
                }
                ProductIDtextBox.Text = fullProductData[dataLocation].productId.ToString();
                UnitPricetextBox.Text = fullProductData[dataLocation].productUnitPrice.ToString();
                QtytextBox.Text = 1.ToString();
                ViewTotalPrice();
            }
            else
            {
                MessageBox.Show("Data on Available");
            }
        }

        private void ProductNametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ProductNametextBox_Leave(this, new EventArgs());
            }
        }

        private void ProductNametextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductNametextBox_Leave(this, new EventArgs());
            }
        }

        private void ProductIDtextBox_Leave(object sender, EventArgs e)
        {
            string tempProductID = ProductIDtextBox.Text;
            int dataLocation = FindProductFromDataBase(tempProductID, 1);

            if (0 != dataLocation)
            {
                if (totalProduct == dataLocation)
                {
                    return;
                }
                ProductNametextBox.Text = fullProductData[dataLocation].productName.ToString();
                UnitPricetextBox.Text = fullProductData[dataLocation].productUnitPrice.ToString();
                QtytextBox.Text = 1.ToString();
                ViewTotalPrice();
            }
            else
            {
                MessageBox.Show("Data on Available");
            }
        }
        private void ProductIDtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductIDtextBox_Leave(this, new EventArgs());
            }
        }

        private void ProductIDtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ProductIDtextBox_Leave(this, new EventArgs());
            }
        }

        private void QtytextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(QtytextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                QtytextBox.Text = QtytextBox.Text.Remove(QtytextBox.Text.Length - 1);
            }
            else
            {
                ViewTotalPrice();
            }
        }
        public void ViewTotalPrice()
        {
            int tempQtyBox = 0, tempUnitPrice = 0;
            if ((0 != QtytextBox.Text.Length) && (0 != UnitPricetextBox.Text.Length))
            {
                tempQtyBox = Int32.Parse(QtytextBox.Text);
                tempUnitPrice = Int32.Parse(UnitPricetextBox.Text); ;

                TotalPricetextBox.Text = (tempQtyBox * tempUnitPrice).ToString();
            }
            else
            {
                MessageBox.Show("Invalid Data!!");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ("dataDelete" == dataGridView1.Columns[e.ColumnIndex].Name)
            {
                RemoveIteminList(e.RowIndex);
            }
        }

        private void DiscountTextBox_Leave(object sender, EventArgs e)
        {
            double tempPayableAmt = 0, subTotal = 0, Discount = 0;

            if ((0 != SubTotalTextBox.Text.Length) && (0 != DiscountTextBox.Text.Length))
            {
                subTotal = Convert.ToDouble(SubTotalTextBox.Text);
                Discount = Convert.ToDouble(DiscountTextBox.Text);

                tempPayableAmt = subTotal - ((subTotal * Discount) / 100);
                PayableAmountTextBox.Text = tempPayableAmt.ToString();
            }
            else {
                MessageBox.Show("Invalid Data!!");
            }
        }

        private void ProductGBox_Leave(object sender, EventArgs e)
        {

        }

        private void SubTotalTextBox_Leave(object sender, EventArgs e)
        {
            DiscountTextBox_Leave(this, new EventArgs());
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            ProductIDtextBox.Clear();
            ProductNametextBox.Clear();
            QtytextBox.Clear();
            UnitPricetextBox.Clear();
            TotalPricetextBox.Clear();
        }

        private void btnPRINT_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();

            }

        }

        private void btnALLCLEAR_Click(object sender, EventArgs e)
        {
          //  billNoBox.Clear();
            custNametextBox.Clear();
            mobileNoBox.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            for(int Idx = 0;Idx < ItemListLen;Idx++)
                ItemList[Idx].Dispose();

            ItemListLen = 0;
            ProductIDtextBox.Clear();
            ProductNametextBox.Clear();
            QtytextBox.Clear();
            UnitPricetextBox.Clear();
            TotalPricetextBox.Clear();
            SubTotalTextBox.Clear();
            DiscountTextBox.Clear();
            PayableAmountTextBox.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "SAI DEVA CRACKERS";

            printer.SubTitle = "ARVINDBHAI: 9898402891              Krushnakunj S.M.C.Party Plot,Athwa,Surat             \r\nSANMUKHLAL: 9879908811\n\n" +
                            "----------------------------------------------------------------------------------------------------------------------------------\n\n" +
                            "BILL TO : " + custNametextBox.Text + "\r\n\r\n" +
                            "----------------------------------------------------------------------------------------------------------------------------------\n\n";

            printer.SubTitleAlignment = StringAlignment.Near;
            
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "Sub Total   : ₹ " + SubTotalTextBox.Text +
                "\r\nDiscount    : " + DiscountTextBox.Text + "%" +
                "\r\nGrand Total : ₹ " + PayableAmountTextBox.Text;
            printer.FooterAlignment = StringAlignment.Far;

            dataGridView1.Columns["dataDelete"].Visible = false;
            dataGridView1.Columns["dataProductID"].Visible = false;
            printer.PrintDataGridView(dataGridView1);
            dataGridView1.Columns["dataDelete"].Visible = true;
            dataGridView1.Columns["dataProductID"].Visible = true;

            writeBillingEntry();


        }

        public void writeBillingEntry()
        {
            classExcel writeexcel = new classExcel(@"C:\\Users\\deepp\\OneDrive\\Desktop\\Sai\\Bill.xlsx", 1);
            TotalBillNo = writeexcel.FindLastRow();
            writeexcel.WriteToCell(TotalBillNo, 0, billNoBox.Text);
            writeexcel.WriteToCell(TotalBillNo, 1, custNametextBox.Text);
            writeexcel.WriteToCell(TotalBillNo, 2, mobileNoBox.Text);
            writeexcel.WriteToCell(TotalBillNo, 3, PayableAmountTextBox.Text);
            writeexcel.Save();
            writeexcel.CloseFile();
        }

        public int SearchValueFromDataGridView(String searchValue)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["dataProductID"].Value.Equals(searchValue))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            return rowIndex;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int newvalue;
            if ("dataQty" == dataGridView1.Columns[e.ColumnIndex].Name)
            {
                newvalue = Convert.ToInt32(dataGridView1[e.ColumnIndex, e.RowIndex].Value);
                ItemList[e.RowIndex].productQty = newvalue;
                ItemList[e.RowIndex].productTotalPrice = newvalue * ItemList[e.RowIndex].productUnitPrice;
                dataGridView1.Rows[e.RowIndex].Cells["dataTotalPrice"].Value = ItemList[e.RowIndex].productTotalPrice;
                getTotalAmount(ItemListLen-1);
            }
        }

        public void ReadAndSetBillNumber()
        {
            classExcel writeexcel = new classExcel(@"C:\\Users\\deepp\\OneDrive\\Desktop\\Sai\\Bill.xlsx", 1);

            TotalBillNo = writeexcel.FindLastRow();
            BillNo = writeexcel.ReadCell(TotalBillNo - 1, 0);
            writeexcel.CloseFile();
        }
        private void btnNEW_Click(object sender, EventArgs e)
        {
            ReadAndSetBillNumber();
            int Fbillno = Convert.ToInt32(BillNo);
            billNoBox.Text = (Fbillno + 1).ToString();

            custNametextBox.Clear();
            mobileNoBox.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            for (int Idx = 0; Idx < ItemListLen; Idx++)
                ItemList[Idx].Dispose();

            ItemListLen = 0;
            ProductIDtextBox.Clear();
            ProductNametextBox.Clear();
            QtytextBox.Clear();
            UnitPricetextBox.Clear();
            TotalPricetextBox.Clear();
            SubTotalTextBox.Clear();
            DiscountTextBox.Clear();
            PayableAmountTextBox.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}