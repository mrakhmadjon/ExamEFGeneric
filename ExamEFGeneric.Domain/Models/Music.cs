using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEFGeneric.Domain.Models
{
    public class Music : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Length { get; set; }

        [ForeignKey(nameof(Singer))]
        public int SingerId { get; set; }

        public Singer Singer { get; set; }


        [ForeignKey(nameof(Playlist))]
        public int PlaylistId { get; set; }

        public Playlist Playlist { get; set; }


    }
}
