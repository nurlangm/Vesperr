using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesterrCFDatabase.Models
{
    public class ServiceCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ServiceIcon ServiceIcon { get; set; }
    }
}
