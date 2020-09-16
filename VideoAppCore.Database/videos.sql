
-- [1] 테이블: 비디오 테이블 : 강좌에 대한 리스트 제공

CREATE TABLE [dbo].[videos]
(
	[Id] INT NOT NULL Identity(1,1) Primary Key,

	[Title] NVarChar(Max) Not Null,  --제목
	[Url] NVarChar(Max) Null,        --URL
	 
	[Name] NVARCHAR(50) NULL,   
	[Company] NVarChar(255) Null,  --회사
 
 
    --Created DateTimeOffset(7) 
	--Default(SysDateTimeOffset() AT TIME ZONE 'korea Standard Time'),
	[CreatedBy] NVarChar(255) Null,   --  등록자
	[Created] DateTime Default(GetDate()), -- 생성일
	[ModifiedBy] NVARcHAR(255) Null,
	[Modified] DateTime Null, -- 수정일

)
GO
