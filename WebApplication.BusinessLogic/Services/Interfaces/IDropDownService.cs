using System.Threading.Tasks;
using WebApplication.ViewModels.Category.Response;

namespace WebApplication.BusinessLogic.Services.Interfaces
{
	public interface IDropDownService
	{
		Task<GetAllCategoryResponse> GetAllCategories();
	}
}
