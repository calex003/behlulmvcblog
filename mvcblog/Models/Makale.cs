//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcblog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Makale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Makale()
        {
            this.Yorums = new HashSet<Yorum>();
            this.Etikets = new HashSet<Etiket>();
        }
    
        public int MakaleId { get; set; }
        public string Baslik { get; set; }
        public string İcerik { get; set; }
        public string Foto { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> KategoriId { get; set; }
        public Nullable<int> UyeId { get; set; }
        public Nullable<int> Okunma { get; set; }
    
        public virtual Kategori Kategori { get; set; }
        public virtual Uye Uye { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorums { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etiket> Etikets { get; set; }
    }
}
