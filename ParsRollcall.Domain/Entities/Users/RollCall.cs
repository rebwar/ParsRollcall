using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsRollcall.Domain.Entities.Users
{
   public class RollCall
    {
        public int Id { get; set; }
        public DateTime In { get; set; }
        public DateTime Out { get; set; }
        public string Ip { get; set; }
    }
}
