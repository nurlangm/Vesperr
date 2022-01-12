using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesterrCFDatabase.Models
{
    public class ServiceIcon
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public int ServiceCardId { get; set; }
    }
}
