﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAPI.Domain.DTOS
{
    public class BannersReadDTO
    {
        public int Id { get; set; }
        public String ImageUrl { get; set; }
        public String Name { get; set; }
    }
}