using EPI_Manager.Models;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;

namespace EPI_Manager.Views.Layout
{
    /// <summary>
    /// EPI_Vendors.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPI_Vendors : UserControl
    {
        public EPI_Vendors()
        {
            InitializeComponent();
        }

        private void HeaderFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            string filter = textBox.Text;

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.vendorDG.ItemsSource);


            if(collectionView != null )
            {
                if (string.IsNullOrWhiteSpace(filter))
                {
                    collectionView.Filter = null;
                }
                else
                {
                    collectionView.Filter = item =>
                    {
                        Vendor vendor = item as Vendor;

                        switch (textBox.Name)
                        {
                            case "VendorCode_txt":
                                return (vendor.VendorCode.ToUpper().Contains(filter.ToUpper()));
                            case "VendorName_txt":
                                return (vendor.VendorName.ToUpper().Contains(filter.ToUpper()));
                            case "VendorPerson_txt":
                                return (vendor.VendorPerson.ToUpper().Contains(filter.ToUpper()));
                            case "VendorPersonCellPhone_txt":
                                return (vendor.VendorPersonCellPhone.ToUpper().Contains(filter.ToUpper()));
                            case "VendorProduct_txt":
                                return (vendor.VendorProduct.ToUpper().Contains(filter.ToUpper()));
                            case "VendorNote_txt":
                                return (vendor.VendorNote.ToUpper().Contains(filter.ToUpper()));
                        }
                        return (vendor.VendorCode.ToUpper().Contains(filter.ToUpper()));
                    };
                }
            }
        }

    }
}
