using ExamEFGeneric.Data.IRepositories;
using ExamEFGeneric.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamEFGeneric.Service.Interfaces
{
    public interface ISingerService 
    {
        Task<Singer> GetAsync(Expression<Func<Singer, bool>> predicate);    
    }
}
