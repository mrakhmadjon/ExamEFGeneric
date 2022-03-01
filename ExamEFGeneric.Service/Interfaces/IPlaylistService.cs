using ExamEFGeneric.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEFGeneric.Service.Interfaces
{
    public interface IPlaylistService
    {
        IEnumerable<Playlist> GetAllPlaylist();

    }
}
