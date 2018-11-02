using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDePacientesService.VOL
{
    public class Doctors
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório!", AllowEmptyStrings = true)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        [Display(Name = "Nome do Doutor:")]
        public String name { get; set; }

        [Required(ErrorMessage = "CRM é obrigatório!", AllowEmptyStrings = false)]
        [Display(Name = "CRM do Doutor:")]
        [StringLength(7, MinimumLength = 7)]
        public int CRM { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Senha do Doutor:")]
        [DataType(DataType.Password)]
        [StringLength(8,MinimumLength = 8)]
        public String password { get; set; }
    }
}