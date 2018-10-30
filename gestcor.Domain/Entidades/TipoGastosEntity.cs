using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace gestcor.Domain.Entidades
{
    public class TipoGastosEntity
    {
        [Key]
        public int IdTipoGasto { get; set; }
        public string TipoGasto { get; set; }

    }
}
