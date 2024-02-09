namespace Connect_four.Services;

public class ScoreService
{
    
    private readonly ScoreContext _db = new ScoreContext();

    public int Persist(int userId, int score, bool againstAI = false)
    {
        var s = new Score
        {
            UserId = userId,
            Result = score,
            IsAgainstAI = againstAI
        };
        
        _db.Add(s);
        return _db.SaveChanges();
    }
    
}