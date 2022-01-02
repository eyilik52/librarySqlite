using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Reader
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public string Tc { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
