using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{

    /**
     * This entity ensures the data binding between the 'contacte' and the data grid.
     */
    public class ContactDTO : DTO<contacte>
    {

        public int ID { get; set; }
        public String Name { get; set; }

        public ContactDTO(contacte src)
        {
            this.ID = src.id;
            this.Name = src.nom;
        }

        public ContactDTO(int ID, String Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public contacte castFrom(IEnumerable<contacte> src)
        {
            return src.Where((ctc) => ctc.id == this.ID).FirstOrDefault();
        }

        public static ContactDTO castFromRow(DataGridViewCellCollection row)
        {
            return new ContactDTO((int)row["ID"].Value, (String)row["Name"].Value);
        }

    }
}
