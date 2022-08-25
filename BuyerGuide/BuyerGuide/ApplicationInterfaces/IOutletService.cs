using BuyerGuide.Models;
using System.Collections.Generic;

namespace BuyerGuide.ApplicationInterfaces
{
    public interface IOutletService
    {
        void Add(Outlet outlet);

        void Remove(int id);

        void Update(Outlet outlet);

        Outlet Get(int id);

        List<Outlet> GetAll();

        List<Outlet> GetAll(string searchString, TypeOfOwnership typeOfOwnership, Specialization specialization);
    }
}
