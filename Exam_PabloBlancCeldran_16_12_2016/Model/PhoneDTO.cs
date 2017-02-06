using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{

    /**
     * This entity ensures the proper data binding between 'telefon' and the data grid.
     */
    public class PhoneDTO : DTO<telefon>
    {

        public int ID { get; set; }
        public int UserID { get; set; }
        public String Desc { get; set; }
        public String Phone { get; set; }

        public PhoneDTO(telefon src)
        {
            this.ID = src.id;
            this.Phone = src.telefon1;
            this.Desc = src.descripcio;
            this.UserID = src.idcontacte;
        }

        public PhoneDTO(int ID, int UserID, String Desc, String Phone)
        {
            this.ID = ID;
            this.Desc = Desc;
            this.Phone = Phone;
            this.UserID = UserID;
        }

        public telefon castFrom(IEnumerable<telefon> src)
        {
            return src.Where((tlf) => tlf.id == this.ID).FirstOrDefault();
        }

        public static PhoneDTO castFromRow(DataGridViewCellCollection row)
        {
            return new PhoneDTO((int)row["ID"].Value, (int)row["UserID"].Value, (String)row["Desc"].Value, (String)row["Phone"].Value);
        }

    }
}
