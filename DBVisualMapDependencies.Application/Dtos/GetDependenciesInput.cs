using Abp.Application.Services.Dto;

namespace DBVisualMapDependencies.Dtos
{
	public class GetDependenciesInput : IInputDto
	{
		//[Range(0, int.MaxValue)]
		public int? DbObjectId { get; set; }
	}
}
