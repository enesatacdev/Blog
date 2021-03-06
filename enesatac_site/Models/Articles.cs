//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace enesatac_site.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articles()
        {
            this.Tags = new HashSet<Tags>();
            this.Comments1 = new HashSet<Comments>();
        }
    
        public int Article_Id { get; set; }
        public string Article_Title { get; set; }
        public string Article_Content { get; set; }
        public System.DateTime Article_Date { get; set; }
        public int Category_Id { get; set; }
        public int Article_View_Count { get; set; }
        public int Article_Like_Count { get; set; }
        public int Author_Id { get; set; }
        public bool Is_Active { get; set; }
        public bool Article_Is_Active_On_Last_Artices { get; set; }
        public string Article_Meta_Tags { get; set; }
        public string Article_Meta_Description { get; set; }
        public string Article_Cover_Image { get; set; }
    
        public virtual Authors Authors { get; set; }
        public virtual Categorys Categorys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tags> Tags { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments1 { get; set; }
    }
}
