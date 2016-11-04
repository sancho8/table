//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Table.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Tasks = new HashSet<Task>();
        }
    
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<bool> NeedDelivery { get; set; }
        public Nullable<bool> IsSocialProfile { get; set; }

        public User(int id, string login, string password, string email, Nullable<bool> needDelivery)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
            this.Email = email;
            this.NeedDelivery = NeedDelivery;
        }

        public User(int id, string login, string password, string email, Nullable<bool> needDelivery, Nullable<bool> isSocial)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
            this.Email = email;
            this.NeedDelivery = NeedDelivery;
            this.IsSocialProfile = isSocial;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
