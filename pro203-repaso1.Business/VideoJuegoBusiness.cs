using PRO203_Unidad_1.DataAccess;
using PRO203_Unidad_1.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace pro203_repaso1.Business
{
    public class VideoJuegoBusiness
    {
        public VideoJuegoBusiness() {
        }

        public List<Videojuego> ObtenerTodos() {

            List<Videojuego> videojuegos = new List<Videojuego>();

            using (var context = new AppDbContext()) { 
                var listaVideojuegos = context.Videojuegos.ToList();
                foreach (var juegoDb in listaVideojuegos) 
                {
                    Videojuego juego = new Videojuego();
                    juego.HorasJugadas = juegoDb.HorasJugadas;
                    juego.Identificador = juegoDb.Identificador;
                    juego.Nombre = juegoDb.Nombre;
                    juego.Categoria = juegoDb.Categoria;
                    videojuegos.Add(juego);
                }
            }
            return videojuegos;

           // return dataAccess.ObtenerTodos();
        }

        public int Crear(Videojuego juego) {

            PRO203_Unidad_1.DataAccess.Entities.Videojuego juegoDb = new PRO203_Unidad_1.DataAccess.Entities.Videojuego();
            juegoDb.UsuarioCreacion = "SYSTEM";
            juegoDb.FechaCreacion = DateTime.Now;
            juegoDb.FechaModificacion = DateTime.Now;
            juegoDb.Categoria = juego.Categoria;
            juegoDb.FlagBorrado = false;
            juegoDb.UsuarioModificacion = "SYSTEM";
            juegoDb.HorasJugadas = juego.HorasJugadas;
            juegoDb.Nombre = juego.Nombre;

            using (var context = new AppDbContext())
            {
                context.Videojuegos.Add(juegoDb);
                context.SaveChanges();
            }

            return juegoDb.Identificador;
        }

        public int Modificar(Videojuego juego)
        {
            using (var context = new AppDbContext())
            {
                var juegoDb = context.Videojuegos.Where(x => x.Identificador == juego.Identificador).First();
                juegoDb.Nombre = juego.Nombre;
                juegoDb.Categoria = juego.Categoria;
                juegoDb.HorasJugadas = juego.HorasJugadas;
                juegoDb.FechaModificacion = DateTime.Now;
                juegoDb.UsuarioModificacion = "SYSTEM";

                context.SaveChanges(); 
            }
            return juego.Identificador;
        }

        public Videojuego ObtenerPorId(int id)
        {
            Videojuego juego = new Videojuego();
            using (var context = new AppDbContext())
            {
                var juegoDb = context.Videojuegos.Where(x => x.Identificador == id).First();

                juego.Nombre = juegoDb.Nombre;
                juego.Categoria = juegoDb.Categoria;
                juego.HorasJugadas = juegoDb.HorasJugadas;
                juego.Identificador = juegoDb.Identificador;
            }
            return juego;


            //return dataAccess.ObtenerPorId(id.ToString());
        }

    }
}
