using System.ComponentModel.DataAnnotations;

namespace BuyerGuide.ModelsForView
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        public string Password {  get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        public string Email { get; set; }
    }
}
