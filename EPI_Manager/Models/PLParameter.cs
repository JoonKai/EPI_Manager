using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI_Manager.Models
{
    public class PLParameter
    {
        #region 측정시간-MeasureTime
        public DateTime MeasureTime { get; set; }
        #endregion
        #region MOCVD 아이디 - MOCVDID
        public string MOCVDID { get; set; }
        #endregion
        #region PL아이디 - PLID
        public string PLID { get; set; }
        #endregion
        #region PL레피시 - PLRECIPE
        public string PLRECIPE { get; set; }
        #endregion
        #region 웨이퍼번호 - WAFERNO
        public int WAFERNO { get; set; }
        #endregion
        #region 웨이퍼아이디 - WAFERID
        public string WAFERID { get; set; }
        #endregion
        #region MES아이디 - MESID
        public string MESID { get; set; }
        #endregion
        #region EPI아이디 - EPIID
        public string EPIID { get; set; }
        #endregion
        #region 파장편균 - PWAVR
        public double PWAVR { get; set; }
        #endregion
        #region 파장표준편차 - PWSTD
        public double PWSTD { get; set; }
        #endregion
        #region Intensity 평균 - IIAVR
        public double IIAVR { get; set; }
        #endregion
        #region PhotoDetector평균 - PDAVR
        public double PDAVR { get; set; }
        #endregion
        #region Reflection평균 - RFAVR
        public double RFAVR { get; set; }
        #endregion
        #region 두께평균 - THAVR
        public double THAVR { get; set; }
        #endregion
        #region 이미지주소 - IMGPATH
        public string IMGPATH { get; set; }
        #endregion
    }
}
