using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1.Models
{
    internal class Model
    {
        public Model(int id, string name, string compania, DateTime date, int gen)
        {
            this.Id_consola =id;
            this.Nombre_consola =name;
            this.Compania =compania;
            this.Anio_lanzamiento =date;
            this.Generacion =gen;
        }

        public int Id_consola { get; set; }
        public string Nombre_consola{ get; set; }
        public string Compania{ get; set; }
        public DateTime Anio_lanzamiento{ get; set; }
        public int Generacion { get; set; }

    }
}
