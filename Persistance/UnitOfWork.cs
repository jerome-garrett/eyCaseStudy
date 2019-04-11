using System.Threading.Tasks;
using EYCaseStudy.API.Core;

namespace EYCaseStudy.API.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext context;

        public UnitOfWork(DataContext context)
        {
            this.context = context;
        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}