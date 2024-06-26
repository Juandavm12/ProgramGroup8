﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
        //Attributes
        public int Id { get; set; }

        //Las data anotations se ponen encima del campo
        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "No se permiten mas de 20 digitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "No se permiten mas de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "No se permiten mas de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "No se permiten mas de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "Digite un email valido")]
        public string Email { get; set; }
        public string FixedPhone { get; set; }
        public string CellPhone { get; set; }
        public string Address { get; set; }
        public string FullName => $"{FirstName}{LastName}";

        //Envia la foreign key a una tabla intermedia con una coleccion

        [JsonIgnore]
        public ICollection<Agenda> Agendas { get; set; }


    }
}
