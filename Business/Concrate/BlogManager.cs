using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}
		public void AddBlog(Blog blog)
		{
			_blogDal.Insert(blog);
		}

		public void DeleteBlog(Blog blog)
		{
			_blogDal.Delete(blog);
		}

		public List<Blog> GetAllCategory()
		{
			return _blogDal.GetAll(); 
		}

		public Blog GetById(int id)
		{
			return _blogDal.GetById(id);
		}

		public void UpdateBlog(Blog blog)
		{
			_blogDal.Update(blog);
		}
	}
}
