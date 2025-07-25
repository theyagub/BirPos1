using System.ComponentModel.DataAnnotations.Schema;

namespace BirPos1.DbModelEF
{
    [Table("UserRole")]
    public class UserRole
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}