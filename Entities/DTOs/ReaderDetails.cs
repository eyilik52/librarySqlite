﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   public  class ReaderDetails:IDto
    {
        public int ReaderId { get; set; }
        public string TCKN { get; set; }
        public string ReaderName { get; set; }
        public string TelefonNO { get; set; }
        public string ReaderSurname { get; set; }
        public int ClassRoom { get; set; }
        public char Branch { get; set; }        
    }
}
