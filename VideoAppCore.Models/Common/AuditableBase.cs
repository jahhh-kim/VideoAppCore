using System;

namespace VideoAppCore.Models
{
    /// <summary>
    /// AuditableBase : 레코드에 대한 상태 추적을 위한 4개의 속성 제공
    /// ex)  Dul.dll -> Dul.Domiain.Common.AuditableBase
    /// </summary>
    public class AuditableBase
    {
        /// <summary>
        /// 등록자
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 등록일
        /// </summary>
        //public DateTimeOffset Created { get; set; }
        public DateTime Created { get; set; }

        /// <summary>
        /// 수정자 : LastModifieBy , ModifieBy
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// 수정일 : LastModified, Modified
        /// </summary>
        public DateTime Modified { get; set; }
    }
}
