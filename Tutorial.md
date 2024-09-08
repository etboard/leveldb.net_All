# LevelDB.NET_All #
- 기존 LevelDB.Standard 프로젝트를 수정하여 만든 프로젝트
- LevelDB.Standard 프로젝트는 .NET 6 이상에서는 warning이 발생
- LevelDB.NET_All 프로젝트는 .NET 6 이상도 잘 동작하도록 타켓 프레임워크만 수정함
- Arduino IDE V2에서는 LevelDB를 사용함. 왜 사용하는지는 모르겠음. JSON 사용해도 될 것 같은데.
- LevelDB는 공유 접근 불가 -> Arduino IDE를 종료 후에 접근해야 함

# Projects #
- DotNetFrameworkTests : tests for the .NET
- LevelDB.NET_All      : 진짜 LevelDB.NET_All 프로젝트
- leveldb.x64          : LevelDB.NET_All에서 참조하는 진짜 leveldb
- leveldb.x86          : LevelDB.NET_All에서 참조하는 진짜 leveldb
- test_leveldb_net6     : LevelDB.NET_All를 테스트하는 프로젝트

# Folders #
- examples : LevelDB.NET_All을 사용하는 예제 프로젝트, test_leveldb_net6
- Package  : LevelDB.NET_All을 NuGet으로 배포하기 위한 패키지 저장 폴더, 여기에 있는 것 업로드하면 됨
- runtimes : leveldb.x64, leveldb.x86 프로젝트에서 생성된 파일들을 저장하는 폴더

# Files # 
nuget.ext  : NuGet 패키지를 만드는 파일
build_nuget.bat : NeGet 패키지를 쉽게 만들기 위한 batch 파일, 파라매터로 nuget 버전
    예시) build_nuget.bat 2.2.0.0
LevelDB.Standard.nuspec : NuGet 패키지를 만들기 위한 nuspec 파일
LevelDB.Standard.targets : 몰라. 

# How to build #
1. leveldb.x64, leveldb.x86 프로젝트를 빌드한다.(로직수정한 것 없기 때문에 할 필요 없음)
2. LevelDB.NET_All 프로젝트를 빌드한다.(LevelDB.NET_All.dll 생성)
3. build_nuget.bat를 실행한다. (nuget.ext 파일이 있는 폴더에서 실행), vs에서 실행하면 안됨 & 복잡함
	- 파라매터로 nuget 버전을 넣어준다.
4. test_leveldb_net 프로젝트를 빌드한다.(LevelDB.NET_All.dll 참조)  
5. 솔루션용 nuget 패키지 관리자 -> Local 패키지 소스 추가로 만듦 -> Package 폴더 추가 : 한번 만 하면 됨
6. test_leveldb_net 프로젝트에서 Local 패키지를 추가 -> 테스트
7. Package 폴더에 있는 파일을 NuGet에 업로드(cli push api 필요하여 사이트에 가서 직접 업로드)
8. 1시간 정도 지나면 NuGet 사이트에 업로드된 패키지가 검색에서 보임
    
----------
