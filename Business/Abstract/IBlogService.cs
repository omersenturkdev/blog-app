using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	interface IBlogService
	{
		void AddBlog(Blog blog);
		void DeleteBlog(Blog blog);
		void UpdateBlog(Blog blog);
		List<Blog> GetAllCategory();
		Blog GetById(int id);
	}
}
