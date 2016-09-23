/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System.Collections.Generic;
using Easy.Data;
using Easy.Web.CMS.Media;

namespace Easy.CMS.Common.ViewModels
{
    public class MediaViewModel
    {
        public string ParentID { get; set; }
        public List<MediaEntity> Parents { get; set; }
        public MediaEntity Parent { get; set; }
        public IEnumerable<MediaEntity> Medias { get; set; }
        public Pagination Pagin { get; set; }
    }
}