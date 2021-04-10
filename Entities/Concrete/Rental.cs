using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental : IEntitiy
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalBackDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
