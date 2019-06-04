using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Biologia.Controllers
{
    public class Insectos
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Este Campo es obligatorio")]
        [Display(Name = "Nombre Cientifico")]
        
        public String Taxa {get; set;}
        [Required(ErrorMessage = "Este Campo es obligatorio")]
        public String Morfoespecie {get; set;}
        [Required(ErrorMessage = "Este Campo es obligatorio")]
        public String Abundancia { get; set; }
        [Required(ErrorMessage = "Este Campo es obligatorio")]
        [Display (Name = "Numero de Frasco")]
        
        public int NumFrasco {get; set; }
        [Required(ErrorMessage = "Este Campo es obligatorio")]
        [Display(Name = "Tipo de Vegetacion")]
        public String TipoVegetacion { get; set; }
        [Required(ErrorMessage = "Este Campo es obligatorio")]
        [Display(Name = "Metodo de Colecta")]
        public String MetodoColecta { get; set; }
        [Required(ErrorMessage = "Este Campo es obligatorio")]
        public String Sustrato { get; set; }
        [Required(ErrorMessage = "Este Campo es obligatorio")]
        public String Localidad { get; set; }
        [Required(ErrorMessage = "Este Campo es obligatorio")]
        [RegularExpression("00°00'00\"")]
        public String Longitud { get; set; }
        [Required(ErrorMessage = "Este Campo obligatorio")]
        [RegularExpression("00°00'00\"")]
        public String Altitud { get; set; }

    }
}
