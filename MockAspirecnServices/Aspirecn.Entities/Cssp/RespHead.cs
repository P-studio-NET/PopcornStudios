//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aspirecn.Entities.Cssp
{
    using System;
    
    public partial class RespHead
    {
        public RespHead()
        {
            this.Send_Address = new Address_Info_Schema();
            this.Dest_Address = new Address_Info_Schema();
        }
    
        public string TransactionID { get; set; }
        public string Version { get; set; }
    
        public Address_Info_Schema Send_Address { get; set; }
        public Address_Info_Schema Dest_Address { get; set; }
    }
}
