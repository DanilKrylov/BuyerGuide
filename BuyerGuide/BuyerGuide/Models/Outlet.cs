using System;

namespace BuyerGuide.Models
{
    public class Outlet
    {
        public int Id { get; set; } 
        public string Name { get; set; } 

        public string Address {  get; set; }

        public string Phone { get; set; }

        public Specialization Specialization { get; set; }

        public TypeOfOwnership TypeOfOwnership { get; set; }

        public DateTime Open { get; set; }

        public DateTime Close { get; set; }
    }
}
