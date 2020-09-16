using System.Collections.Generic;
using System.Threading.Tasks;

namespace VideoAppCore.Models
{
    /// <summary>
    /// [3][2] 인터페이스(동기방식) : videos 테이블에 대한 CRUD API 명세서 작성
    /// </summary>
    public interface IVideoRepositoryAsync
    {
        Task<Video> AddVedioAsync(Video model); // 입력 : T Add (T model)
        Task<List<Video>> GetVideosAsync();   // 출력 List<T> GetAll()
        Task<Video> GetVideoByIdAsync(int id);  // 상세 GetById(int id);
        Task<Video> UpdateVideoAsync(Video model); //수정 : T Edit (T model)
        Task RemoveVideoAsync(int id);       //삭제 : void Delet(int id);
    }


}
    
