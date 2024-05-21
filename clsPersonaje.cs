using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryValinotti
{
    public class clsPersonaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public string Dano { get; set; }
        public string Imagen { get; set; }

        public clsPersonaje crearEnemigo()
        {
            clsMySQL BD = new clsMySQL();
            List<clsPersonaje> listaEnemigos = BD.cargarEnemigos();
            Random r = new Random();
            clsPersonaje enemigo = listaEnemigos[r.Next(1, listaEnemigos.Count)];
            enemigo.Imagen = $"./assets/JuegoRol/{r.Next(1,11)}.png";
            return enemigo;
        }
    }
}
