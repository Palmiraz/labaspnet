using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace ShoeEcommers.LogicLayer.Entities
{
    [MetadataType(typeof(ContactUsMetaData))]
    public partial class ContactUs
    {
    }

    public class ContactUsMetaData
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        public string FullName;
        [Required(ErrorMessage = "El correo es requerido")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "formato de correo incorrecto")]
        public string Email;
        [Required(ErrorMessage = "Los comentarios son requeridos")]
        [MaxLength(500, ErrorMessage = "Longitud Máxima de 500")]
        public string Comments;
    }
}
