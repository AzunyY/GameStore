using PetaPoco;

public class DatabaseContext
{
    public static Database Create()
    {
        var connectionString = "_connectionString";
        var db = new Database(connectionString);
        return db;
    }
}
