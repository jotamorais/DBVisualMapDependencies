using Abp.Application.Services;
using DBVisualMapDependencies.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBVisualMapDependencies
{
	/// <summary>
	/// Defines an application service for <see cref="DBObject"/> operations.
	/// 
	/// It extends <see cref="IApplicationService"/>.
	/// Thus, ABP enables automatic dependency injection, validation and other benefits for it.
	/// 
	/// Application services works with DTOs (Data Transfer Objects).
	/// Service methods gets and returns DTOs.
	/// </summary>
	public interface IDBObjectService : IApplicationService
	{
		GetDependenciesOutput GetDependencies(GetDependenciesInput input);
	}
}
