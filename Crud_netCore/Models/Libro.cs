using System;
using System.ComponentModel.DataAnnotations;

namespace Crud_netCore.Models
{
    public class Libro
    {
        //si es key y tiene un nombre llamado 'Id' la variable ya es autoincremental
        //por defecto
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Campo es obligario")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "la Descripcion es un campo obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "La Fecha es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [Required(ErrorMessage = "El autor es un campo obligatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "El Precio es un campo obligatorio")]
        public int Precio { get; set; }
         
    }
}