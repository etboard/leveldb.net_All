using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LevelDB;

namespace test_leveldb_nf472
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            

            Console.WriteLine("Hello, World!");

            // db 경로를 찾아서 LevelDB로 열기
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string levelDBPath = Path.Combine(appDataPath, "arduino-ide", "Local Storage", "leveldb");

            if (!Directory.Exists(levelDBPath))
            {
                throw new DirectoryNotFoundException($"Arduino IDE v2의 LevelDB 경로를 찾을 수 없습니다: {levelDBPath}");
            }

            // LevelDB로부터 데이터 읽기
            var options = new Options { CreateIfMissing = false, ErrorIfExists = false };
            var db = new DB(options, levelDBPath);

            // LevelDB의 모든 데이터를 읽어서 출력
            var iterator = db.CreateIterator(new ReadOptions());
            iterator.SeekToFirst();
            while (iterator.IsValid())
            {
                string key = iterator.KeyAsString();
                string value = iterator.ValueAsString();
                Console.WriteLine($"Key: {key}, Value: {value}");
                iterator.Next();
            }
        }
    }
}
