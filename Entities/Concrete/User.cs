﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int positionId { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public bool? Satis { get; set; }
        public bool? Rapor { get; set; }
        public bool? Stok { get; set; }
        public bool? UrunGiris { get; set; }
        public bool? Ayarlar { get; set; }        
        public bool? Yedekleme { get; set; }
        public bool IsActive { get; set; } = true;


    }
}
