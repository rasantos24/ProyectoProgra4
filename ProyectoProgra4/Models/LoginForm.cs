using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoProgra4.Models
{
    public class LoginForm
    {
        [Required(ErrorMessage = "El campo es requerido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Correo invalido o denegado")]
        public string username { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string password { get; set; }
    }
}