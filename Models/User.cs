using System.ComponentModel.DataAnnotations;

namespace MiniMarket.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Не указано имя пользователя")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public int AuthorizeCount { get; set; }
        public bool IsActive { get; set; }
    }
}