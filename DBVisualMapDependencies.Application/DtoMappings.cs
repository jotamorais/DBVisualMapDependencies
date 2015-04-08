using AutoMapper;
using DBVisualMapDependencies.Dtos;

namespace DBVisualMapDependencies
{
	internal static class DtoMappings
	{
		public static void Map()
		{
			Mapper.CreateMap<DBVisualMapObject, DBObjectDto>();
		}
	}
}
