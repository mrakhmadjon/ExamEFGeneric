using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEFGeneric.Service.ViewModels
{
    public class MusicViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Length { get; set; }

        public DateTime CreatedDate { get; set; } 

        public string SingerName { get; set; }

        public string PlaylistName { get; set; }
    }
}
