using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoTccDoacaoDeSangue.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }

        

        [Display(Name ="Clientes")]

        [MaxLength(100)]
        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [MaxLength(15)]
        [Column(TypeName = "VARCHAR")]
        public string Telefone { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Ja Doou Sangue?")]
        public bool Doador { get; set; }


        public virtual TipoSanguineo ObjTipoSanguineo { get; set; }

        public virtual ICollection<TipoSanguineo> Sangues { get; set; }

        public int SangueID { get; set; }

    }
}