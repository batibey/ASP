//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_Project.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLSATIS
    {
        public int SATISID { get; set; }
        public Nullable<int> URUN { get; set; }
        public Nullable<byte> PERSONEL { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
    
        public virtual TBLMUSTERI TBLMUSTERI { get; set; }
        public virtual TBLPERSONEL TBLPERSONEL { get; set; }
        public virtual TBLURUNLER TBLURUNLER { get; set; }
    }
}
