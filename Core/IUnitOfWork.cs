using System.Threading.Tasks;

namespace EYCaseStudy.API.Core
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}