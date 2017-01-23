using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    class EstadoDTO : DTO<Estado>
    {
        public int id { get; set; }
        public string estado1 { get; set; }
        public string comentario { get; set; }

        public EstadoDTO(Estado src)
        {
            this.id = src.id;
            this.estado1 = src.estado1;
            this.comentario = src.comentario;
        }

        public EstadoDTO(int id, String estado, String comentario)
        {
            this.id = id;
            this.estado1 = estado1;
            this.comentario = comentario;
        }

        public static EstadoDTO castFromRow(DataGridViewCellCollection row)
        {
            return new EstadoDTO((int)row["id"].Value, (String)row["estado"].Value, (String)row["comentario"].Value);
        }

        public Estado castFrom(IEnumerable<Estado> src)
        {
            return src.Where((est) => est.id == this.id).FirstOrDefault();
        }
    }
}
