using System.Collections.ObjectModel;

namespace EPI_Manager.Models
{
    public class VendorManager
    {
        public static ObservableCollection<Vendor> Vendors = new ObservableCollection<Vendor>()
        {
            new Vendor(){VendorCode ="3333",VendorName="밸류엔지니어링", VendorPerson="양영철", VendorPersonCellPhone="010-2590-0000", VendorProduct="MO부품", VendorNote="빠름"},
            new Vendor(){VendorCode ="3334",VendorName="에바라", VendorPerson="양영철", VendorPersonCellPhone="010-2590-0000", VendorProduct="MO부품", VendorNote="빠름"},
            new Vendor(){VendorCode ="3335",VendorName="밸류엔지니어링", VendorPerson="양영철", VendorPersonCellPhone="010-2590-0000", VendorProduct="MO부품", VendorNote="빠름"},
            new Vendor(){VendorCode ="3336",VendorName="밸류엔지니어링", VendorPerson="양영철", VendorPersonCellPhone="010-2590-0000", VendorProduct="MO부품", VendorNote="빠름"},
            new Vendor(){VendorCode ="3337",VendorName="밸류엔지니어링", VendorPerson="양영철", VendorPersonCellPhone="010-2590-0000", VendorProduct="MO부품", VendorNote="빠름"},
        };

        public static ObservableCollection<Vendor> GetVendors()
        {
            return Vendors;
        }
        public static void AddVendors(Vendor vendor)
        {
            Vendors.Add(vendor);
        }
    }
}
