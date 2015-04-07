using Abp.Application.Services;
using AutoMapper;
using DBVisualMapDependencies.Dtos;
using System.Collections.Generic;

namespace DBVisualMapDependencies
{
	/// <summary>
	/// Implements <see cref="IDBObjectService"/> to perform task related application functionality.
	/// 
	/// Inherits from <see cref="ApplicationService"/>.
	/// <see cref="ApplicationService"/> contains some basic functionality common for application services (such as logging and localization).
	/// </summary>
	public class DBObjectService : DBVisualMapDependenciesAppServiceBase, IDBObjectService
	{
		//These members set in constructor using constructor injection.

		private readonly IDBObjectRepository _dbObjectRepository;

		/// <summary>
		///In constructor, we can get needed classes/interfaces.
		///They are sent here by dependency injection system automatically.
		/// </summary>
		public DBObjectService(IDBObjectRepository dbObjectRepository)
		{
			_dbObjectRepository = dbObjectRepository;
		}

		public GetDependenciesOutput GetDependencies(GetDependenciesInput input)
		{
			//Called specific GetAllWithChildrens method of DBObject repository.
			var dbObjectDependencies = _dbObjectRepository.GetAllWithChildrens(input.DbObjectId);

			//Used AutoMapper to automatically convert List<DBVisualMapDependencies> to List<DBOjectDTO>.
			return new GetDependenciesOutput
				   {
					   DBObjectDependencies = Mapper.Map<List<DBObjectDto>>(dbObjectDependencies)
				   };
		}

	}
}
