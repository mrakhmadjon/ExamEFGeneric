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
            IMusicRepository musicRepository = new MusicRepository();

            ISingerRepository singerRepository = new SingerRepository();

            IPlaylistRepository playlistRepository = new PlaylistRepository();


            Singer singer = new Singer()
            {
                FullName =  "Ali Jorayev"

            };

            Playlist playlist = new Playlist()
            {
                Name = "Hard Times"
            };


            //singerRepository.CreateAsync(singer);

            //playlistRepository.CreateAsync(playlist);


            Music music = new Music()
            {
                Title = "Today is Exam",
                Description = "It is hard",
                Length = "5-hours",
                PlaylistId = 1, 
                SingerId = 1
            };

            // musicRepository.CreateAsync(music);

            Singer singer1 = new Singer();


            IMusicService musicService = new MusicService();

           var musics = await musicService.GetAllAsync(1,1);

            foreach (var mus in musics)
            {
                Console.WriteLine(mus.Singer.Id);
            }
          
        }
    }
}
