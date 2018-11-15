using System.ComponentModel.DataAnnotations;

namespace MiniMarket.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Не указано имя пользователя")]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}