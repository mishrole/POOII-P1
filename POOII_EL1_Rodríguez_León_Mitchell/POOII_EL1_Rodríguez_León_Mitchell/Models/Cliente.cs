using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace POOII_EL1_Rodríguez_León_Mitchell.Models
{
    public class Cliente
    {
        [Display(Name = "Código de Cliente")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "Ingrese el Código de Cliente")]
        [RegularExpression(@"CLI\d{3}", ErrorMessage = "Formato: CLI999")]
        public string codigoCliente { get; set; }

        [Display(Name = "Razón Social")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "Ingrese una Razón Social")]
        public string razonSocial { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(100, ErrorMessage = "Longitud máxima: 100 caracteres")]
        public string direccion { get; set; }

        [Display(Name = "Fecha de Inicio de Actividades")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "Ingrese una fecha")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string fechaInicio { get; set; }

        [Display(Name = "Página Web")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "Ingrese una URL")]
        [Url()]
        public string paginaWeb { get; set; }

        [Display(Name = "Rubro de Negocio")]
        [MaxLength(500, ErrorMessage = "Longitud máxima: 500 caracteres")]
        public string rubroNegocio { get; set; }
    }
}