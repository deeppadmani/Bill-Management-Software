using ExcelSaiDevaCraker;

namespace ItemDatabaseSaiDevaCraker
{
    public class ItemDadabase
    {
        public string productId = "";
        public string productName = "";
        public int productUnitPrice;
        public int productQty;
        public int productTotalPrice;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}