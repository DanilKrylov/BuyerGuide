using BuyerGuide.ApplicationInterfaces;
using BuyerGuide.Models;
using System.Collections.Generic;
using System.Linq;

namespace BuyerGuide.ApplicationServices
{
    public class OutletService : IOutletService
    {
        private readonly ApplicationContext _database;
        public OutletService(ApplicationContext database)
        {
            _database = database;
        }

        public void Add(Outlet outlet)
        {
            _database.Outlets.Add(outlet);
            _database.SaveChanges();
        }

        public Outlet Get(int id)
        {
            return _database.Outlets.First(i => i.Id == id);
        }

        public List<Outlet> GetAll()
        {
            return _database.Outlets.ToList();
        }

        public List<Outlet> GetAll(string searchString, TypeOfOwnership typeOfOwnership, Specialization specialization)
        {
            var result = new List<Outlet>();
           
            if(searchString != null && searchString != string.Empty)
            {
                result = result.Where(i => i.Name.ToLower().Contains(searchString.ToLower())).ToList();
            }

            if(typeOfOwnership != TypeOfOwnership.Any)
            {
                result = result.Where(c => c.TypeOfOwnership == typeOfOwnership || c.TypeOfOwnership == TypeOfOwnership.Any).ToList();
            }

            if (specialization != Specialization.Any)
            {
                result = result.Where(c => c.Specialization == specialization || c.Specialization == Specialization.Any).ToList();
            }

            return result;
        }

        public void Remove(int id)
        {
            _database.Outlets.Remove(Get(id));
            _database.SaveChanges();
        }

        public void Update(Outlet outlet)
        {
            _database.Outlets.Update(outlet);
            _database.SaveChanges();
        }
    }
}
