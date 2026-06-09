using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRO203_Unidad_1.DataAccess.Entities
{
    public class Videojuego
    {
        [Key]
        public int Identificador { get; set; }

        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int HorasJugadas { get; set; }
        public bool FlagBorrado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        

    }
}
