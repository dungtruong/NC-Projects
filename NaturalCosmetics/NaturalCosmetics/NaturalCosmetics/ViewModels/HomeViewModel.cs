﻿
using NaturalCosmetics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cosmetics> HotItem { get; set; }
    }
}
