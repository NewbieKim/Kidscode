//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Product_Detail
    {
        public int Order_Product_Detail_ID { get; set; }
        public int Product_ID { get; set; }
        public int Pro_Num { get; set; }
        public string Pro_Norms { get; set; }
        public int Cart_ID { get; set; }
        public int Order_ID { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
