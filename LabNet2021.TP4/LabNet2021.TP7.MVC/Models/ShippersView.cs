using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabNet2021.TP7.MVC.Models
{
    public class ShippersView
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(40, ErrorMessage = "Longitud máxima {1} caracteres.")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [StringLength(24, ErrorMessage = "Longitud máxima {1} caracteres.")]
        public string Phone { get; set; }
    }
}
