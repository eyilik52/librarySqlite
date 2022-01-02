using Core.Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Student : Reader, IEntity
    {
        public int ClassRoomId { get; set; }
    }
}
