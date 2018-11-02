using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDePacientesService.VOL
{
    public class Exams
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Nome é obrigatório", AllowEmptyStrings = true)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        [Display(Name = "Nome do exame: ")]
        public String name { get; set; }

        [Required(ErrorMessage ="Data de agendamento é obrigatório", AllowEmptyStrings = false)]
        [Display(Name ="Data de Agendamento:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="dd/mm/yy")]
        public DateTime datescheduling { get; set; }

        [Required(ErrorMessage = "Data de execução é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Data de Execução:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd/mm/yy")]
        public DateTime dateexecution { get; set; }

        [Key]
        public int idpatient { get; set; }

        [Key]
        public int iddoctor { get; set; }
    }
}