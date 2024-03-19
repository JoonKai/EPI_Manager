using System;

namespace EPI_Manager.Models
{
    public class CostCategory
    {
        public int No { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Department { get; set; }
        public int Costcenter { get; set; }
        public int Stock { get; set; }
        public int SafetyStock { get; set; }
        public int YearPurchaseQuantity { get; set; }
        public string ApprovalNumber { get; set; }
        public string Note { get; set; }
        public int VendorCode { get; set; }
        public int PurchaseMaterialCode { get; set; }
        public string Maker { get; set; }
        public string MaterialName { get; set; }
        public string Standard { get; set; }
        public int Quantity { get; set; }
        public int MonetaryFund { get; set; }
        public string UnitCost { get; set; }
        public string TotalCost { get; set; }
        public string Quotation { get; set; }
        public string RepairReport { get; set; }
        public string ComparativeVendor { get; set; }
        public string ComparativeUnitCost { get; set; }
        public string ComparativeQuotation { get; set; }
        public string Etc { get; set; }

    }
}
