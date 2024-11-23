public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    // Marks the goal as complete
    protected void MarkComplete()
    {
        _isCompleted = true;
    }

    // Returns the points for the goal
    public int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent(ref int score)
    {
        if (!_isCompleted)
        {
            MarkComplete();
            score += GetPoints();
        }
    }

    public virtual string Display()
    {
        return $"{(_isCompleted ? "[X]" : "[ ]")} {_name} ({_description})";
    }

    public bool IsComplete() => _isCompleted;
}
