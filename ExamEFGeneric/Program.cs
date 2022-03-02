using ExamEFGeneric.Data.IRepositories;
using ExamEFGeneric.Data.Repositories;
using ExamEFGeneric.Domain.Models;
using ExamEFGeneric.Service.Interfaces;
using ExamEFGeneric.Service.Services;
using ExamEFGeneric.Service.ViewModels;
using System;
using System.Threading.Tasks;

namespace ExamEFGeneric
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
       
           IMusicService musicService = new MusicService();

           var musics = await musicService.GetAllAsync(1,1);

            foreach (var mus in musics)
            {
                Console.WriteLine(mus.Singer.Id);
            }
          
        }
    }
}
