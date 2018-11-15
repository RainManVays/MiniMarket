using System.ComponentModel.DataAnnotations;

namespace MiniMarket.Areas.Admin.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Не указано имя пользователя")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
