

namespace ChoreScore.Models
{
    public class Chore(int id, string name, int earnedTime, bool completed)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public int EarnedTime { get; set; } = earnedTime;
        public bool Completed { get; set; } = completed;
    }
}