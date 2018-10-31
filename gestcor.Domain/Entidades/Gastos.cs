using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace gestcor.Domain.Entidades
{
    public class Gastos
    {
        public Gastos(int id,string gasto)
        {
            IdGasto = id;
            Gasto = gasto;
        }
        protected Gastos() { }
        [Key]
        public int IdGasto { get; set; }
        public string Gasto { get; set; }

    }
}
