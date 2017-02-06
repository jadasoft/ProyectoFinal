using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsconsum
{
    class contacte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contacte()
        {
            this.emails = new HashSet<email>();
            this.telefons = new HashSet<telefon>();
        }

        public int contacteId { get; set; }
        public string nom { get; set; }
        public string cognoms { get; set; }

        public bool telefonsTot { get; set; }


        public bool emailsTot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<email> emails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<telefon> telefons { get; set; }





        //     <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-WebServicePt2a-20161216035501.mdf;Initial Catalog=aspnet-WebServicePt2a-20161216035501;Integrated Security=True" providerName="System.Data.SqlClient" />
        //<add name="contactesEntities" connectionString="metadata=res://*/
        //    Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=BARRIKADA17;initial catalog=contactes;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
        //<add name = "ContactesEntities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=PCPIKIWIKI;initial catalog=Contactes;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
        //<add name = "ContactesEntities1" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=PCPIKIWIKI;initial catalog=Contactes;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />


    }
}