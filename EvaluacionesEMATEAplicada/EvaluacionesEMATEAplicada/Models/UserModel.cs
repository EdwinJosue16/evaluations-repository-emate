﻿using System.ComponentModel.DataAnnotations;
namespace EvaluacionesEMATEAplicada.Models
{
    public class UserModel
    {

        [Required(ErrorMessage = "Es necesario que ingrese su correo")]
        [Display(Name = "Correo institucional: ")]
        public string email { set; get; }

        [Required(ErrorMessage = "Es necesario que ingrese su contraseña")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña: ")]
        public string password { set; get; }
        public string fullName { set; get; }

        /*
         Este modelo está pensado para que sea posible validar los usuarios con acceso a la plataforma
         y eventualmente para realizar el registro de nuevos usuarios
         */
    }
}
