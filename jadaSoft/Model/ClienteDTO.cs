using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    class ClienteDTO : DTO<Cliente>
    {

        public int id { get; set; }
        public string nom { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string dni { get; set; }
        public string direccion { get; set; }
        public int id_paquete { get; set; }

        public ClienteDTO(Cliente src)
        {
            this.id = src.id;
            this.nom = src.nom;
            this.apellido1 = src.apellido1;
            this.apellido2 = src.apellido2;
            this.dni = src.dni;
            this.direccion = src.direccion;
        }

        public ClienteDTO(int id, String nom, String apellido1, String apellido2, String sni, String direccion)
        {
            this.id = id;
            this.nom = nom;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.dni = dni;
            this.direccion = direccion;
        }

        public static ClienteDTO castFromRow(DataGridViewCellCollection row)
        {
            return new ClienteDTO((int)row["id"].Value, (String)row["nom"].Value, (String)row["apellido1"].Value, (String)row["apellido2"].Value, (String)row["dni"].Value, (String)row["direccion"].Value);
        }

        Cliente DTO<Cliente>.castFrom(IEnumerable<Cliente> src)
        {
            return src.Where((cte) => cte.id == this.id).FirstOrDefault();
        }
    }
}

