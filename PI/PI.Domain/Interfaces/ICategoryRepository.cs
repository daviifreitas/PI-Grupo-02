using PI.Domain.Entities;

namespace PI.Domain.Interfaces;

public interface ICategoryRepository : IBaseRepository<Category>
{
    Category GetByName(string nameOfcategory);
}