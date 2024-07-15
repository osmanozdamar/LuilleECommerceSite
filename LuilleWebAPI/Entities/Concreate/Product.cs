namespace LuilleWebAPI.Entities.Concreate
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID{ get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public string Color { get; set; }
        public Int16 UnitsOnOrder { get; set; }
        public bool IsActive { get; set; }


    }
}
