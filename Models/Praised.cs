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
    
    public partial class Praised
    {
        public int PraisedID { get; set; }
        public int User_Id { get; set; }
        public Nullable<int> Com_Id { get; set; }
        public Nullable<int> Rep_Id { get; set; }
    
        public virtual Comment Comment { get; set; }
        public virtual Replys Replys { get; set; }
        public virtual User User { get; set; }
    }
}
