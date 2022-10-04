using PI.Domain.Entities;
using PI.Domain.Interfaces;
using PI.Infra.Data.Context;

namespace PI.Infra.Data.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationContext applicationContext) : base(applicationContext)
    {
    }

    public Category GetByName(string nameOfcategory)
    {
        Category? firstOrDefault =  GetAll().Result.FirstOrDefault(category => category.Name == nameOfcategory);

        return firstOrDefault;
    }
}