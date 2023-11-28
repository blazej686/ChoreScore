



namespace ChoreScore.Services
{
    public class ChoresService
    {
        private readonly ChoresRepository _choreRepository;

        public ChoresService(ChoresRepository choresRepository)
        {
            _choreRepository = choresRepository;
        }

        internal List<Chore> GetChores()
        {
            List<Chore> chores = _choreRepository.GetChores();
            return chores;
        }

        internal Chore GetChoresById(int choreId)
        {
            Chore chore = _choreRepository.GetChoresById(choreId);
            if (chore == null)
            {
                throw new Exception($"Invalid Id {choreId}");
            }
            return chore;
        }
    }
}