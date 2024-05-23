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

        public void atacar(string[] ataques, clsPersonaje enemigo)
        {
            Random r = new Random();
            int repeticiones = Convert.ToInt32(ataques[0]);
            List<int> listaAtaquesParciales = new List<int>();
            int dano = Convert.ToInt32(ataques[1]);
            int danoTotal = 0;
            for (int i = 0; i < repeticiones; i++)
            {
                int danoRepeticion = r.Next(1, dano + 1);
                danoTotal += danoRepeticion;
                listaAtaquesParciales.Add(danoRepeticion);
            }
            string cadenaAtaquesParciales = ataquesParciales(listaAtaquesParciales);
            MessageBox.Show($@"ATACANTE: {this.Nombre}
DAÑO REALIZADO EN LA RONDA: {danoTotal}
DAÑOS PARCIALES: {cadenaAtaquesParciales}");
            enemigo.Vida -= danoTotal;
            if (enemigo.Vida <= 0)
            {
                MessageBox.Show($"HA GANADO: {this.Nombre}");
            }
        }

        private string ataquesParciales(List<int> ataquesParciales)
        {
            string ataques = "[";
            foreach (int ataque in ataquesParciales)
            {
                ataques += ataque.ToString() + ",";
            }
            ataques = ataques.TrimEnd(',');
            ataques += "]";
            return ataques;
        }
    }
}
