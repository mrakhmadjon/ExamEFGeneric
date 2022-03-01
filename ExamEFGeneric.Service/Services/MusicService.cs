using ExamEFGeneric.Data.IRepositories;
using ExamEFGeneric.Data.Repositories;
using ExamEFGeneric.Domain.Models;
using ExamEFGeneric.Service.Interfaces;
using ExamEFGeneric.Service.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamEFGeneric.Service.Services
{
    public class MusicService : IMusicService
    {
        private IMusicRepository musicRepository;

        public MusicService()
        {
            musicRepository = new MusicRepository();
        }

        public Task<Music> CreateAsync(Music entity)
        {
            return musicRepository.CreateAsync(entity);
        }

        public Task<bool> DeleteAsync(Expression<Func<Music, bool>> predicate)
        {
            return musicRepository.DeleteAsync(predicate);
        }

        public async Task<IEnumerable<Music>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Music, bool>> predicate = null)
        {
            IQueryable<Music> music = await musicRepository.GetAllAsync(predicate);

             music.Include(p => p.Singer).Include(p => p.Playlist).ToList();

            return  music.Skip(pageSize * (pageIndex - 1)).Take(pageIndex);
        }

        public async Task<Music> GetAsync(Expression<Func<Music, bool>> predicate)
        {
            return  await musicRepository.GetAsync(predicate);
        }

        public async Task<Music> UpdateAsync(Music entity)
        {
            return await musicRepository.UpdateAsync(entity);

        }
    }
}
