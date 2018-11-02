using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDePacientesService.VOL
{
    public class Pacientes : Pessoas
    {
        [Key]
        public int idpaciente { get; set; }
        public String responsavel { get; set; }
    }
}
