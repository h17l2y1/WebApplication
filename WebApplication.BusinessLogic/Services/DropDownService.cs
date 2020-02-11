using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.BusinessLogic.Services.Interfaces;
using WebApplication.DataAccess.Repositories.Interfaces;
using WebApplication.Entities.Entities;
using WebApplication.ViewModels.Category.Response;

namespace WebApplication.BusinessLogic.Services
{
	public class DropDownService : IDropDownService
	{
		private readonly IMapper _mapper;
		private readonly ICategoryRepository _categoryRepository;

		public DropDownService(IMapper mapper, ICategoryRepository categoryRepository)
		{
			_mapper = mapper;
			_categoryRepository = categoryRepository;
		}

		public async Task<GetAllCategoryResponse> GetAllCategories()
		{
			IEnumerable<Category> categories = await _categoryRepository.GetAll();
			var response = new GetAllCategoryResponse();
			response.Categories = _mapper.Map<IEnumerable<GetAllCategoryItem>>(categories);
			return response;
		}
	}
}
