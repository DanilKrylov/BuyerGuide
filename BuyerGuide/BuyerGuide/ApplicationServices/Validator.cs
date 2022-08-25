using BuyerGuide.ApplicationInterfaces;
using System.Linq;
using System.Threading.Tasks;

namespace BuyerGuide.ApplicationServices
{
    public class Validator : IValidator
    {
        private readonly ApplicationContext _db;
        public Validator(ApplicationContext db)
        {
            _db = db;
        }

        public bool EmailIsUnique(string email)
        {
            var user = _db.Users.FirstOrDefault(c => c.Email == email);
            if (user is null)
            {
                return true;
            }

            return false;
        }
    }
}
