using BuyerGuide.Models;
using System.ComponentModel.DataAnnotations;

namespace BuyerGuide.ModelsForView
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Довжина повинна бути від 5 до 20 символів")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Довжина повинна бути від 5 до 20 символів")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [StringLength(12, MinimumLength = 5, ErrorMessage = "Довжина повинна бути  12 цифр")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Довжина повинна бути від 5 до 20 символів")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Compare("Password", ErrorMessage = "Паролі не співпадают")]
        public string PasswordConfirm { get; set; }

        public User GetUserModel()
        {
            return new User()
            {
                UserName = Email,
                Email = Email,
                Name = Name,
                Surname = Surname,
            };
        }
    }
}
