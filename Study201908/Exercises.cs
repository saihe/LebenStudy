using System;
using System.IO;

namespace Study201908
{
    class Exercises
    {
        private int SUCCESS = 0;
        private int FAILUE = 9;
        // マスタファイル格納ディレクトリパス
        private String masterDirectoryPath = @"C:\Users\ksaito\Documents\LebenStudy\Study201908\files";

        /* 問題01*/
        public void exercise01()
        {
            // 商品マスタファイル名
            String fileNameProductMaster = "syohin.mst";
            String filePath = Path.Combine(masterDirectoryPath, fileNameProductMaster);
            Console.WriteLine("ファイルパス：[{0}]", filePath);
            StreamReader streamReader = File.OpenText(filePath);
            while(streamReader.Peek() > -1)
            {
                Console.WriteLine(streamReader.ReadLine());
            }
            streamReader.Close();
            Console.ReadKey();
            Environment.Exit(SUCCESS);
        }

        /* 問題02 */
        public void exercise02()
        {
            Console.Write("入力ファイル名を入力してEnterキーを押してください。");
            string inputFileName = Console.ReadLine();
            Console.Write("出力ファイル名を入力してEnterキーを押してください。");
            string outputFileName = Console.ReadLine();
            try
            {
                string inputFilePath = Path.Combine(masterDirectoryPath, inputFileName);
                string outputFilePath = Path.Combine(masterDirectoryPath, outputFileName);

                File.WriteAllLines(
                    outputFilePath
                    , File.ReadAllLines(inputFilePath)
                );
            } catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Environment.Exit(FAILUE);
            }
            Environment.Exit(SUCCESS);
        }
    }
}
