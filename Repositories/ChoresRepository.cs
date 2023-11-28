


namespace ChoreScore.Repositories
{
    public class ChoresRepository
    {
        private List<Chore> _chores;

        public ChoresRepository()
        {
            _chores = [
                new Chore (1,"Clean Bathroom",15,false),
                new Chore (2,"Clean Bedroom",15,false),
                new Chore (3,"Clean Kitchen",60,false),
            ];
        }
        internal List<Chore> GetChores()
        {
            return _chores;
        }

        internal Chore GetChoresById(int choreId)
        {
            Chore foundChore = _chores.Find(chore => chore.Id == choreId);
            return foundChore;
        }
    }
}