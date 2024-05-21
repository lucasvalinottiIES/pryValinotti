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
        MySqlDataAdapter adaptador;

        public clsMySQL()
        {
            conexion = new MySqlConnection(cadena);
        }

        public void listarTipos(TreeView arbol)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void listarNombres(TreeNode nodo, string tipo)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void listarInfo(string nombre, Label lblTamano, Label lblTipo, Label lblFuerza, Label lblInteligencia, Label lblExp, Label lblDano)
        {
            try
            {
                string consulta = $"SELECT size as Tamaño, type as Tipo, strength as Fuerza, intelligence as Inteligencia, xp as Experiencia, hit_points as Daño FROM `monstruario` WHERE name = '{nombre}'";
                DataTable tabla = new DataTable();
                adaptador = new MySqlDataAdapter(consulta, cadena);
                adaptador.Fill(tabla);
                if(tabla.Rows.Count > 0)
                {
                    lblTamano.Text = "Tamaño: " + tabla.Rows[0]["Tamaño"].ToString();
                    lblTipo.Text = "Tipo: " + tabla.Rows[0]["Tipo"].ToString();
                    lblFuerza.Text = "Fuerza: " + tabla.Rows[0]["Fuerza"].ToString();
                    lblInteligencia.Text = "Inteligencia: " + tabla.Rows[0]["Inteligencia"].ToString();
                    lblExp.Text = "Experiencia: " + tabla.Rows[0]["Experiencia"].ToString();
                    lblDano.Text = "Daño: " + tabla.Rows[0]["Daño"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string buscarIndice(string nombre)
        {
            try
            {
                string consulta = $"SELECT * FROM `monstruario` WHERE name = '{nombre}'";
                DataTable tabla = new DataTable();
                adaptador = new MySqlDataAdapter(consulta, cadena);
                adaptador.Fill(tabla);
                if (tabla.Rows.Count == 1)
                {
                    return tabla.Rows[0]["index"].ToString();
                }
                else return "";
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message);
            }
        }

    }
}
