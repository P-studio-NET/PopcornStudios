//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aspirecn.Entities.DownloadCenter
{
    using System;
    using System.Collections.Generic;
    
    public partial class DownloadCenterRequest
    {
        public int ID { get; set; }
        public string ContentID { get; set; }
        public string Msisdn { get; set; }
        public string PushID { get; set; }
        public string DestMsisdn { get; set; }
        public string OnDemandType { get; set; }
        public string SCode { get; set; }
        public string Notify { get; set; }
        public string DeviceId { get; set; }
    }
}
