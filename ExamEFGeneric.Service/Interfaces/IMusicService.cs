using ExamEFGeneric.Domain.Models;
using ExamEFGeneric.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamEFGeneric.Service.Interfaces
{
    public interface IMusicService 
    {
        Task<Music> GetAsync(Expression<Func<Music, bool>> predicate);

        Task<IEnumerable<Music>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Music, bool>> predicate = null);


        Task<Music> CreateAsync(Music entity);

        Task<Music> UpdateAsync(Music entity);

        Task<bool> DeleteAsync(Expression<Func<Music, bool>> predicate);

    }
}
