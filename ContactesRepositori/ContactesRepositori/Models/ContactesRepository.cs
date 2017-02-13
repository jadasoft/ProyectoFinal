using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ContactesRepositori.Models
{
    public class ContactesRepository
    {
        private static contactesEntities dataContext = new contactesEntities();
        public static List<contacte> GetAllContactes()
        {
            var query = from c in dataContext.contacte
                        select c;
            return query.ToList();
        }

        public static contacte GetContacte(int contacteID)
        {
            var query = from c in dataContext.contacte
                        where c.contacteId == contacteID
                        select c;
            return query.SingleOrDefault();
        }

        public static List<contacte> SearchContactesByName(string contacteName)
        {
            var query = from c in dataContext.contacte
                        where (c.nom.Contains(contacteName) || c.cognoms.Contains(contacteName))
                        select c;
            return query.ToList();
        }
        public static contacte InsertContacte(contacte c)
        {
            try
            {
                dataContext.contacte.Add(c);
                dataContext.SaveChanges();
                return GetContacte(c.contacteId);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static contacte UpdateContacte(int id, contacte c)
        {
            contacte c0;
            try
            {
                var query = from cAux in dataContext.contacte
                            where cAux.contacteId == id
                            select cAux;
                c0 = query.SingleOrDefault();
                if (c.nom != null) c0.nom = c.nom;
                if (c.cognoms != null) c0.cognoms = c.cognoms;

                dataContext.SaveChanges();
                return GetContacte(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void DeleteContacte(int id)
        {
            var query = from c in dataContext.contacte
                        where c.contacteId == id
                        select c;
            contacte q = query.SingleOrDefault();
            if (q != null)
            {
                dataContext.contacte.Remove(q);
                dataContext.SaveChanges();
            }
        }
    }
}
    