namespace EPI_Manager.Models
{
    public class Vendor
    {
        #region 업체코드 - VendorCode

        /// <summary>
        /// ID
        /// </summary>
        public string VendorCode { get; set; }

        #endregion
        #region 업체명 - VendorName

        /// <summary>
        /// 성명
        /// </summary>
        public string VendorName { get; set; }

        #endregion
        #region 담당자- VendorPerson

        /// <summary>
        /// 성명
        /// </summary>
        public string VendorPerson { get; set; }

        #endregion
        #region 연락처 - VendorPersonCellPhone

        /// <summary>
        /// 성명
        /// </summary>
        public string VendorPersonCellPhone { get; set; }

        #endregion
        #region 업체취급품목 - VendorProduct

        /// <summary>
        /// 성명
        /// </summary>
        public string VendorProduct { get; set; }

        #endregion
        #region 업체내용 - VendorNote

        /// <summary>
        /// 성명
        /// </summary>
        public string VendorNote { get; set; }

        #endregion
    }
}
