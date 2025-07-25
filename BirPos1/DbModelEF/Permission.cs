using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DbModelEF
{
    [Table("Permission")]
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; } // Məsələn: "CanMakeSale", "CanAccessSettings"

        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
