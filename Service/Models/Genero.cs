﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
        public override string ToString()
        {
            return Nombre;
        }
    }
}
