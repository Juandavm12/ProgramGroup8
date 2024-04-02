using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de Mascota")]
        [MaxLength(50, ErrorMessage = "No se permiten mas de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Foto de Mascota")]
        public string ImageUrl { get; set; }

        [Display(Name = "Raza")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Race { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime Born { get; set; }

        public string Remarks { get; set; }

        //Relaciones
        public Owner Owners { get; set; }
        public PetType PetTypes { get; set; }

        //Relacion muchos a muchos, se la manda a History

        [JsonIgnore]
        public ICollection<History> Histories { get; set; }

        [JsonIgnore]
        public ICollection<Agenda> Agendas { get; set; }

    }
}
