using ExamEFGeneric.Data.IRepositories;
using ExamEFGeneric.Data.Repositories;
using ExamEFGeneric.Domain.Models;
using ExamEFGeneric.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamEFGeneric.Service.Services
{
    public class SingerService : ISingerService
    {

        private ISingerRepository singerRepository;

        public SingerService()
        {
            singerRepository = new SingerRepository();
        }
        public Task<Singer> GetAsync(Expression<Func<Singer, bool>> predicate)
        {
           return singerRepository.GetAsync(predicate);
        }
    }
}
