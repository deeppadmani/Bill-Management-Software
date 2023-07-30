using ExcelSaiDevaCraker;

namespace DatabaseSaiDevaCraker
{
    class classDadabase
    {
        public string productId = "";
        public string productName = "";
        public int productUnitPrice;


        public void SetData(int iteamIdx,string data)
        {
            switch (iteamIdx)
            {
                case 1:
                    {
                        this.productId = data;
                 //       MessageBox.Show(this.productId);
                    }
                    break;

                case 2:
                    {
                        this.productName = data;
              //          MessageBox.Show(this.productName);
                    }
                    break;
            }
        }
        public void SetData(int data)
        {
            this.productUnitPrice = data;
    //        MessageBox.Show(this.productUnitPrice.ToString());
        }

        public void GetData()
        {
           // this.productUnitPrice = data;
            //        MessageBox.Show(this.productUnitPrice.ToString());
        }
    };
}