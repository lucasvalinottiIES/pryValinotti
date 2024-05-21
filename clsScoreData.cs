using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Microsoft.VisualBasic.ApplicationServices;

namespace pryValinotti
{
    public class clsScoreData
    {
        String cadena;
        SQLiteConnection conexion;
        SQLiteCommand comando;

        public clsScoreData()
        {
            cadena = "Data Source=./DBScore.db";

            conexion = new SQLiteConnection(cadena);
            comando = new SQLiteCommand();
        }

        public int getHighScore() 
        {
            DataTable tabla = new DataTable();
            string sql = $"SELECT max(Score) as HIGHSCORE FROM Scores";
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(sql, cadena);
            adaptador.Fill(tabla);
            try
            {
                if(tabla.Rows.Count > 0)
                {
                    DataRow scoreRow = tabla.Rows[0];
                    int score = Convert.ToInt32(scoreRow["HIGHSCORE"]);
                    return score;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return 0;
        }

        public void addScore(string player, int score)
        {
            DateTime date = DateTime.Now;
            try
            {
                string consulta = $"INSERT INTO Scores(Player, Score, Date) VALUES ('{player}', '{score}', '{date.ToString("dd/MM/yyyy")}')";
                comando = new SQLiteCommand(consulta, conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { conexion.Close(); }
        }
    }
}
