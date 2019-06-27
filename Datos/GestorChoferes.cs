    public class GestorChoferes
    {
        public static List<Choferes> GetAll()
        {
            using(EgeoEntity db = new EgeoEntity())
            {
                return db.Choferes.ToList();
            }
        }
    }