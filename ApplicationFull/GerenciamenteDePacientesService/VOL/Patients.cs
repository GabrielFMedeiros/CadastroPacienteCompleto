using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDePacientesService.VOL
{
    public class Patients
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório!", AllowEmptyStrings = true)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        [Display(Name = "Nome do Paciente:")]
        public String name { get; set; }
        [Required]
        [Range(0, 135, ErrorMessage = "Digite uma idade valida!")]
        public int age { get; set; }
        [Required]
        public String gender { get; set; }

        [Required(ErrorMessage ="Telefone é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10,MinimumLength = 10)]
        public String telphone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(11, MinimumLength = 11)]
        public String smartphone { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório")]
        [DataType(DataType.EmailAddress)]
        public String email { get; set; }
        public String answerable { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Senha:")]
        [DataType(DataType.Password)]
        [StringLength(8, MinimumLength = 8)]
        public String password { get; set; }
        [Key]
        public int iddoctor { get; set; }
    }
}