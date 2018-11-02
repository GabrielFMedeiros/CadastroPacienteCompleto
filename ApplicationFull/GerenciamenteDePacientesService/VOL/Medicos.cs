using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDePacientesService.VOL
{
    public class Medicos : Pessoas
    {
        [Key]
        public int idmedico { get; set; }
        public int CRM { get; set; }
    }
}
