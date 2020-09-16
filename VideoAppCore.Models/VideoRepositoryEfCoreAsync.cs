using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VideoAppCore.Models
{
    /// <summary>
    /// [4][3][2] 리포지토리 클래스(비동기박식) : Full ORM EfCore 사용하여 CRUD 구현
    /// </summary>
    public class VideoRepositoryEfCoreAsync : IVideoRepositoryAsync
    {
        public Task<Video> AddVedioAsync(Video model)
        {
            throw new NotImplementedException();
        }

        public Task<Video> GetVideoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Video>> GetVideosAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveVideoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Video> UpdateVideoAsync(Video model)
        {
            throw new NotImplementedException();
        }
    }



}

