using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace gestcor.Domain.Entidades
{
    public class GastosEntity
    {
        [Key]
        public int IdGasto { get; set; }
        public string Gasto { get; set; }

    }
}
