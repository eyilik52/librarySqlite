﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Reader:IEntity
    {
        public int Id { get; set; }
        //public int SchoolId { get; set; }
        public string Tc { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int ClassRoomId { get; set; }
        public char ClassRoombranch { get; set; }
        public DateTime DateOfRegistration { get; set; }//Kayıt tarihi
        public bool IsActive { get; set; } = true;
    }
}
