using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Abstracts
{
    public interface IGenericService<T> where T : class , IEntity, new()
    {

        IDataResult<List<T>> GetAll();

        IDataResult<T> GetById(int Id);

        IResult Add(T entity);

        IResult Update(T entity);

        IResult Delete(T entity);
    }
}
