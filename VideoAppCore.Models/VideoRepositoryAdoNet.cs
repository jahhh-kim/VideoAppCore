﻿using System;
using System.Collections.Generic;

namespace VideoAppCore.Models
{
    /// <summary>
    /// [4][1][1] 리포지토리 클래스 : 
    /// 순수 ADO.NET 사용하여 CRUD 구현
    /// </summary>
    public class VideoRepositoryAdoNet : IVideoRepository
    {
        public Video AddVedio(Video model)
        {
            throw new NotImplementedException();
        }

        public Video GetVideoById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Video> GetVideos()
        {
            throw new NotImplementedException();
        }

        public void RemoveVideo(int id)
        {
            throw new NotImplementedException();
        }

        public Video UpdateVideo(Video model)
        {
            throw new NotImplementedException();
        }
    }
}

