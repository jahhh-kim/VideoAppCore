using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VideoAppCore.Models
{
    /// <summary>
    /// [4][2][2] 리포지토리 클래스(비동기) : Micro ORM Dapper 사용 CRUD 구현
    /// </summary>
    public class VideoRepositoryDapperAsync : IVideoRepositoryAsync
    {
        Task<Video> IVideoRepositoryAsync.AddVedioAsync(Video model)
        {
            throw new NotImplementedException();
        }

        Task<Video> IVideoRepositoryAsync.GetVideoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Video>> IVideoRepositoryAsync.GetVideosAsync()
        {
            throw new NotImplementedException();
        }

        Task IVideoRepositoryAsync.RemoveVideoAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Video> IVideoRepositoryAsync.UpdateVideoAsync(Video model)
        {
            throw new NotImplementedException();
        }
    }
}

