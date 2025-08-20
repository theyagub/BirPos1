using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DbModelEF
{
    [Table("Role")]
    public class Role : BaseObject
    {
        public int Id { get; set; }
        public string Name { get; set; } // Məsələn: "Admin", "Cashier"

        //public ICollection<UserRole> UserRoles { get; set; }
        //public ICollection<RolePermission> RolePermissions { get; set; }
    }

}
