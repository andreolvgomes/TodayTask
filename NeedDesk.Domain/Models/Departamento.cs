﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedDesk.Domain.Models
{
    public class Departamento : EntityBase
    {
        public Int64 Dep_id { get; set; }
        public string Dep_descricao { get; set; }
        public bool Dep_inativo { get; set; }
    }
}