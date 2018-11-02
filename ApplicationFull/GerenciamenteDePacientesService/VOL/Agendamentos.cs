using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDePacientesService.VOL
{
    public class Agendamentos
    {
        [Key]
        public int id { get; set; }
        public DateTime dataagendamento { get; set; }
        public DateTime datarealizacao { get; set; }
        public int idpaciente { get; set; }
        public int idmedico { get; set; }

        [Key]
        public String CID { get; set; }
    }
}
