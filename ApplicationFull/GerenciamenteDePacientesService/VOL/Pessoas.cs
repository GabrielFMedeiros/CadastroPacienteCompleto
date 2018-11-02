using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDePacientesService.VOL
{
    public class Pessoas
    {
        [Key]
        public int id { get; set; }
        public String nome { get; set; }
        public int idade { get; set; }
        public String sexo { get; set; }
        public String email { get; set; }
        public String telefone { get; set; }
        public String celular { get; set; }
        public String senha { get; set; }

        [Key]
        public int idtipoacesso { get; set; }
    }
}
