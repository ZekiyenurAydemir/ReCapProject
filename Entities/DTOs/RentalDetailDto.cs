﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto
    {
        public int RentalId { get; set; }
        public string CarName { get; set; }
        public string UserName { get; set; }
        public string ComponeyName { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalBackDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
