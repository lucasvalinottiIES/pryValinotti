using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace pryValinotti
{
    public class clsMySQL
    {
        string cadena = "Server=localhost;Database=dbmonstruos;Uid=root;Pwd=;";
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataAdapter adaptador;

        public clsMySQL()
        {
            conexion = new MySqlConnection(cadena);
        }

        public void listarTipos(TreeView arbol)
        {
            string consulta = "SELECT type FROM monstruario WHERE type != '' GROUP BY type";
            DataTable tabla = new DataTable();
            adaptador = new MySqlDataAdapter(consulta, cadena);
            adaptador.Fill(tabla);
            TreeNode raiz = arbol.Nodes.Add("Tipos");
            foreach (DataRow tipo in tabla.Rows)
            {
                TreeNode hijo = raiz.Nodes.Add(tipo["type"].ToString());
                string tipoMonstruo = tipo["type"].ToString();
                listarNombres(hijo, tipoMonstruo);
            }
        }

        public void listarNombres(TreeNode nodo, string tipo)
        {
            string consulta = $"SELECT name FROM monstruario WHERE type = '{tipo}'";
            DataTable tabla = new DataTable();
            adaptador = new MySqlDataAdapter(consulta, cadena);
            adaptador.Fill(tabla);
            foreach (DataRow nombre in tabla.Rows)
            {
                nodo.Nodes.Add(nombre["name"].ToString());
            }
        }

        public void listarInfo(DataGridView dgvInfo, string nombre)
        {
            string consulta = $"SELECT name, size, type, alignment, armor_class, hit_points, hit_dice, strength, intelligence FROM `monstruario` WHERE name = '{nombre}'";
            DataTable tabla = new DataTable();
            adaptador = new MySqlDataAdapter(consulta, cadena);
            adaptador.Fill(tabla);
            dgvInfo.DataSource = tabla;
        }

    }
}
