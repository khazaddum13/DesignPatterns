namespace DesignPatterns.Model
{
    public class Product : Base
    {
        public Product()
        {
        }

        public long? m_ProductId { get; set; }
        public string m_ProductCd { get; set; }
        public string m_ProductName { get; set; }
        public string m_ProductDescription { get; set; }
    }
}
