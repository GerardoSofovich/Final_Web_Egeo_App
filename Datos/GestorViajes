public class GestorViajes 
{
	static void main(){}
	public static List<Trips> GetAll()
	{
		using (EgeoEntity db = new EgeoEntity())
		{
			return db.Trips.ToList();
		}
			
	}
	public static Trips GetById(int id)
	{
		try
		{
			using (EgeoEntity db = new EgeoEntity())
			{
					return db.Trips.Find(id);
			}
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}
	public static bool DeleteByID(int Vid)
	{
		try
		{
			using(EgeoEntity db = new EgeoEntity())
			{
				Trips borrar = db.Trips.Where(v=> v.id == Vid).Single();
				db.Trips.Remove(borrar);
				db.SaveChanges();
			}
			return true;
		}
		catch (Exception ex)
		{
			return false;
		}
	}
	public static bool Modificar(Trips vi)
	{
		try
		{
			using(EgeoEntity db = new EgeoEntity())
			{
				db.Entry(vi).State=System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
			return true;
		}
		catch(Exception ex)
		{
			return false;
		}
	}
	public static bool Nuevo(Trips vi)
	{
		try 
		{
			using (EgeoEntity db = new EgeoEntity())
			{
				db.Trips.Add(vi);
				db.SaveChanges();
			}
			return true;
		}
		catch (Exception ex)
		{
			return false;
			throw ex;
		}
	}
				
}


