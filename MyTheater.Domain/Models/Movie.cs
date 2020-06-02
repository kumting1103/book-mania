using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyTheater.Domain.Models
{
    // Movie(Media Title) - Video(Media Content)
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public MovieGenre Genre { get; set; }
        public string DirectoryPath { get; set; }
        public int Rating { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<ActorMovie> ActorMovies { get; set; } = new List<ActorMovie>();

        public virtual ICollection<Video> Videos { get; set; } = new List<Video>();

        #region Lazy Loading 2
        //private ILazyLoader _lazyLoader { get; set; }

        //private ICollection<Video> _videos;
        //public virtual ICollection<Video> Videos
        //{
        //    get => _lazyLoader?.Load(this, ref _videos);
        //    set => _videos = value;
        //}

        //public Movie(ILazyLoader lazyLoader)
        //{
        //    _lazyLoader = lazyLoader;
        //}

        #endregion
    }




}
