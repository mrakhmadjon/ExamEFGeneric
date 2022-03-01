using ExamEFGeneric.Data.IRepositories;
using ExamEFGeneric.Data.Repositories;
using ExamEFGeneric.Domain.Models;
using ExamEFGeneric.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEFGeneric.Service.Services
{
    internal class PlaylistService : IPlaylistService
    {
        private IPlaylistRepository playlistRepository;

        public PlaylistService()
        {
            playlistRepository = new PlaylistRepository();
        }
        public  IEnumerable<Playlist> GetAllPlaylist()
        {
            var playlists =  playlistRepository.GetAllAsync();
            return playlists.Result;
        }
    }
}
