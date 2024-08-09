﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities.Models
{
    [DisplayColumn("Nombre")]
    public class Autor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nombre { get; set; }

        [Required]
        [StringLength (100, MinimumLength = 2)]
        public string Apellido { get; set; }

        public ICollection<Libro>? Libros { get; set; }
    }
}
