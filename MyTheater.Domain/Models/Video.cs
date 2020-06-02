using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyTheater.Domain.Models
{
    //public enum MovieAssetType
    //{
    //    kScreenShot,
    //    kSubtitle,
    //    kSource
    //}

    public class Video
    {
        public int VideoId { get; set; }
        public string RelativeFilePath { get; set; }
        public string VideoFileName { get; set; }
        public string SubtitleFileName { get; set; }
        public string CoverFileName { get; set; }

        //[ForeignKey("MovieId")]
        //public virtual Movie Movie { get; set; }

        #region Lazy Loading 2

        //private ILazyLoader _lazyLoader { get; set; }

        //private Movie _movie;
        //public Movie Movie
        //{
        //    get => _lazyLoader?.Load(this, ref _movie);
        //    set => _movie = value;
        //}

        //public Video(ILazyLoader lazyLoader)
        //{
        //    _lazyLoader = lazyLoader;
        //}
        #endregion
    }
}
