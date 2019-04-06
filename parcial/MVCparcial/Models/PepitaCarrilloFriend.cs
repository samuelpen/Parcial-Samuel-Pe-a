using System;
using System.ComponentModel.DataAnnotations;

namespace MVCparcial.Models
{
    public enum UniType
    {
        Conocido,
        CompañeroEstudio,
        ColegadeTrabajo,
        Amigo,
        AmigodeInfancia,
        Pariente

    }
    public enum StatusType
    {
        Activo,
        Inactivo
    }

    public class PepitaCarrilloFriend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthdate { get; set; } //cambiar entero

        [Required]
        public UniType Unit { get; set; }
        public StatusType Status { get; set; }



    }
}