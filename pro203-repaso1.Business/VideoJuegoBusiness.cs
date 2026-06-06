using PRO203_Unidad_1.Support;
using System;
using System.Collections.Generic;
using System.Text;
using PRO203_Unidad_1.DataAccess;

namespace pro203_repaso1.Business
{
    public class VideoJuegoBusiness
    {
        VideojuegoDataAccess dataAccess;

        public VideoJuegoBusiness() {
            dataAccess = new VideojuegoDataAccess();
        }

        public List<Videojuego> ObtenerTodos() {
            return dataAccess.ObtenerTodos();
        }

        public int Crear(Videojuego juego) {
            return dataAccess.Crear(juego);
        }

        public int Modificar(Videojuego juego)
        {
            return dataAccess.Modificar(juego);
        }

        public Videojuego ObtenerPorId(int id)
        {
            return dataAccess.ObtenerPorId(id);
        }

    }
}
