using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ACH.Domain
{
    public class Video
    {
        public string Title { get; set; }
        public string YoutubeSource { get; set; }
        public DateTime PostDate { get; set; }
        [XmlIgnore]
        public string VideoId { get; set; }
        [XmlIgnore]
        public string Url { get; set; }
        [XmlIgnore]
        public string Caption { get; set; }
        [XmlIgnore]
        public long Id { get; set; }
        [XmlIgnore]
        public VideoDetails Details { get; set; }
        public Video()
        {
            Details = new VideoDetails();
        }
    }
    public class VideoDetails
    {
        public List<Image> ThumbnailImage { get; set; }
        public VideoStats Statistics { get; set; }
        public string Teaser { get; set; }
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
        public VideoDetails()
        {
            ThumbnailImage = new List<Image>();
            Statistics = new VideoStats();
        }

    }

    public class VideoStats
    {
        public ulong? CommentCount { get; set; }
        public ulong? DislikeCount { get; set; }
        public ulong? LikeCount { get; set; }
        public ulong? FavCount { get; set; }
        public ulong? ViewCount { get; set; }
        public string Etags { get; set; }
    }
}
