using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace DBVisualMapDependencies.Dtos
{
	public class GetDependenciesOutput : IOutputDto
	{
		public List<DBObjectDto> DBObjectDependencies { get; set; }
	}
}
