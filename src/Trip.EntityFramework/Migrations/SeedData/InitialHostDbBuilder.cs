using Trip.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Trip.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TripDbContext _context;

        public InitialHostDbBuilder(TripDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
