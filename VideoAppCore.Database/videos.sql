
--비디오 테이블
CREATE TABLE [dbo].[videos]
(
	[Id] INT NOT NULL Identity(1,1) Primary Key,
	Created DateTimeOffset(7) 
	Default(SysDateTimeOffset() AT TIME ZONE 'korea Standard Time'),
	[Title] NVarChar(Max) Not Null,  --제목
	[Url] NVarChar(Max) Null,        --URL
	 
	[Name] NVARCHAR(50) NULL,   
	[Company] NVarChar(255) Null,  --회사

)
GO
