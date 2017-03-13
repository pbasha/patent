
using System.ComponentModel.DataAnnotations;

namespace patent.DAL.EFModels
{
    class User
    {
        [Key]
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
