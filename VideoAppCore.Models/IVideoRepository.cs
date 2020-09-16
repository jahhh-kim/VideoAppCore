using System.Collections.Generic;
using System.Text;

namespace VideoAppCore.Models
{
    /// <summary>
    /// [3][1] 인터페이스(동기방식) : videos 테이블에 대한 CRUD API 명세서 작성
    /// </summary>
    public interface IVideoRepository
    {
        Video AddVedio(Video model); // 입력 : T Add (T model)
        List<Video> GetVideos();   // 출력 List<T> GetAll()
        Video GetVideoById(int id);  // 상세 GetById(int id);
        Video UpdateVideo(Video model); //수정 : T Edit (T model)
        void RemoveVideo(int id);       //삭제 : void Delet(int id);
    }


}
    
