using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoTccDoacaoDeSangue.Models
{
    public class TipoSanguineo
    {
        [Display(Name = "Sangue")]

        [Key]
        public int SangueID { get; set; }



        [MaxLength(20)]
        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "O Tipo Sanguineo é obrigatório")]
        [Display(Name = "Tipo Sanguineo")]
        public string TipoDeSangue { get; set; }

        public virtual Cliente ObjCliente { get; set; }

        public virtual ICollection<Cliente> ListaClientes { get; set; }


    }
}