namespace Connect_four.Services;

public class UserService
{
    private readonly UserContext _db = new UserContext();

    /// <summary>
    /// Créer un utilisateur
    /// </summary>
    /// <param name="username">Nom d'utilisateur</param>
    /// <param name="password">Mot de passe</param>
    public int Persist(string username, string password)
    {
        var user = new User
        {
            UserName = username,
            UserPassword = password,
            UserUUID = Guid.NewGuid().ToString()
        };

        _db.Add(user);
        return _db.SaveChanges();
    }
    
}