using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EscrowBookDetail:IEntity
    {
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public bool IsActive { get; set; } = true;
        public string Ozet { get; set; }
        public string AnaFikir { get; set; }
    }
}
