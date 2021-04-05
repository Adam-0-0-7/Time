using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Time_and_Money.Models
{
    public class Activity : User
    {
        //fields
        public string activity { get; set; }
        [MaxLength(40, ErrorMessage = "Limitied to 40 characters")]
        DateTime dt1 = new DateTime();

    }
}
