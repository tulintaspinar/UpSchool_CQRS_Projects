﻿namespace UpSchool_CQRS_Projects.CQRS.Results.ProductResults
{
    public class GetProductAccounterQeuryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public int Tax { get; set; }
        public decimal PurchasePirce { get; set; }
        public decimal SalePrice { get; set; }

    }
}
