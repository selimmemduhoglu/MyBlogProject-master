using Entity.Concrete;


namespace Business.Abstract
{
    public interface IBlogService
    {
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(Blog blog);
        List<Blog> GetListAllBlog();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();  
        
    }
}
