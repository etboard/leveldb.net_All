# LevelDB.NET_All #
- ���� LevelDB.Standard ������Ʈ�� �����Ͽ� ���� ������Ʈ
- LevelDB.Standard ������Ʈ�� .NET 6 �̻󿡼��� warning�� �߻�
- LevelDB.NET_All ������Ʈ�� .NET 6 �̻� �� �����ϵ��� Ÿ�� �����ӿ�ũ�� ������
- Arduino IDE V2������ LevelDB�� �����. �� ����ϴ����� �𸣰���. JSON ����ص� �� �� ������.
- LevelDB�� ���� ���� �Ұ� -> Arduino IDE�� ���� �Ŀ� �����ؾ� ��

# Projects #
- DotNetFrameworkTests : tests for the .NET
- LevelDB.NET_All      : ��¥ LevelDB.NET_All ������Ʈ
- leveldb.x64          : LevelDB.NET_All���� �����ϴ� ��¥ leveldb
- leveldb.x86          : LevelDB.NET_All���� �����ϴ� ��¥ leveldb
- test_leveldb_net6     : LevelDB.NET_All�� �׽�Ʈ�ϴ� ������Ʈ

# Folders #
- examples : LevelDB.NET_All�� ����ϴ� ���� ������Ʈ, test_leveldb_net6
- Package  : LevelDB.NET_All�� NuGet���� �����ϱ� ���� ��Ű�� ���� ����, ���⿡ �ִ� �� ���ε��ϸ� ��
- runtimes : leveldb.x64, leveldb.x86 ������Ʈ���� ������ ���ϵ��� �����ϴ� ����

# Files # 
nuget.ext  : NuGet ��Ű���� ����� ����
build_nuget.bat : NeGet ��Ű���� ���� ����� ���� batch ����, �Ķ���ͷ� nuget ����
    ����) build_nuget.bat 2.2.0.0
LevelDB.Standard.nuspec : NuGet ��Ű���� ����� ���� nuspec ����
LevelDB.Standard.targets : ����. 

# How to build #
1. leveldb.x64, leveldb.x86 ������Ʈ�� �����Ѵ�.(���������� �� ���� ������ �� �ʿ� ����)
2. LevelDB.NET_All ������Ʈ�� �����Ѵ�.(LevelDB.NET_All.dll ����)
3. build_nuget.bat�� �����Ѵ�. (nuget.ext ������ �ִ� �������� ����), vs���� �����ϸ� �ȵ� & ������
	- �Ķ���ͷ� nuget ������ �־��ش�.
4. test_leveldb_net ������Ʈ�� �����Ѵ�.(LevelDB.NET_All.dll ����)  
5. �ַ�ǿ� nuget ��Ű�� ������ -> Local ��Ű�� �ҽ� �߰��� ���� -> Package ���� �߰� : �ѹ� �� �ϸ� ��
6. test_leveldb_net ������Ʈ���� Local ��Ű���� �߰� -> �׽�Ʈ
7. Package ������ �ִ� ������ NuGet�� ���ε�(cli push api �ʿ��Ͽ� ����Ʈ�� ���� ���� ���ε�)
8. 1�ð� ���� ������ NuGet ����Ʈ�� ���ε�� ��Ű���� �˻����� ����
    
----------
