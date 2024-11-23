public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent(ref int score)
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            score += GetPoints();

            if (_currentCount == _targetCount)
            {
                score += _bonusPoints;
                MarkComplete();
            }
        }
    }

    public override string Display()
    {
        return $"{base.Display()} - Completed {_currentCount}/{_targetCount}";
    }
}
