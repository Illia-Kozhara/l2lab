namespace L2Lab.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly L2LabDbContext _context;

        public InitialHostDbBuilder(L2LabDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
