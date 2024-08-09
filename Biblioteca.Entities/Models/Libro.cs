using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Titulo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Fecha de publicacion")]
        public DateTime FechaPublicacion { get; set; }

        [Required]
        public int? AutorId { get; set; }
        public Autor? Autor { get; set; }

        [Required]
        public int? CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
