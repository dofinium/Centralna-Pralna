//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PralnaDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PublicImage
    {
        public PublicImage()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
        }
    
        public long Id { get; set; }
        public string FileName { get; set; }
        public string OriginalFile { get; set; }
        public string BigFile { get; set; }
        public string MediumFile { get; set; }
        public string SmallFile { get; set; }
        public string IconFile { get; set; }
        public string IdControl { get; set; }
        public string LocalFolder { get; set; }
        public string FolderForDownload { get; set; }
        public string ParentId { get; set; }
        public string Description { get; set; }
        public Nullable<short> ResourceType { get; set; }
        public Nullable<int> Index { get; set; }
    
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
