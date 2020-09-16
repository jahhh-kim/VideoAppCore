﻿using System.Collections.Generic;
using System.Text;

namespace VideoAppCore.Models
{
    /// <summary>
    /// [2] 모델 클래스 : Video 모델 클래스 == Videos 테이블과 일대일로 매핑
    /// Videos => video VideoModel, VidoBaes, VideoDto, VideiEntity,...
    /// </summary>
    public class Video : AuditableBase
    {
        /// <summary>
        /// 일련번호
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 동영상 제목
        /// </summary>
        public string Title  { get; set; }
        /// <summary>
        /// 제공 url
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 작성자
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 회사
        /// </summary>
        public string Company { get; set; }

    }
}
