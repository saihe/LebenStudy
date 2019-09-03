using System;
using System.IO;
using static System.Console;
using static Study201908.Consts;

namespace Study201908
{
    class Exercises : AbstractClass
    {
        /* 課題01*/
        public int exercise01()
        {
            // 商品マスタファイル名
            String fileNameProductMaster = "syohin.mst";
            String filePath = Path.Combine(InputDirPath, fileNameProductMaster);
            WriteLine("ファイルパス：[{0}]", filePath);
            StreamReader streamReader = File.OpenText(filePath);
            while(streamReader.Peek() > -1)
            {
                WriteLine(streamReader.ReadLine());
            }
            streamReader.Close();
            ReadKey();
            return SUCCESS;
        }

        /* 課題02 */
        public int exercise02()
        {
            WriteLine("入力ファイル名を入力して[Enter]キーを押してください。");
            string inputFileName = ReadLine();
            WriteLine("出力ファイル名を入力して[Enter]キーを押してください。");
            string outputFileName = ReadLine();
            try
            {
                string inputFilePath = Path.Combine(InputDirPath, inputFileName);
                string outputFilePath = Path.Combine(OutputDirPath, outputFileName);

                File.WriteAllLines(
                    outputFilePath
                    , File.ReadAllLines(inputFilePath)
                );
            } catch(Exception e)
            {
                WriteLine("指定されたファイルが見つかりませんでした。");
                WriteLine(e.StackTrace);
                return FAILUE;
            }
            return SUCCESS;
        }

        /** 課題03 */
        public int exercise03()
        {
            string masterFileName = "syohin.mst";
            WriteLine("未実装です。");
            WriteLine("商品マスタ-へのレコード追加を行います。（{0}）", masterFileName);

            // コード,商品名,単価
            WriteLine("商品コードを入力して[Enter]キーを押してください。");
            string productCode = ReadLine();
            WriteLine("商品名を入力して[Enter]キーを押してください。");
            string productName = ReadLine();
            WriteLine("商品単価を入力して[Enter]キーを押してください。");
            string productUnitPrice = ReadLine();
            string recordString = string.Join(",", productCode, productName, productUnitPrice);
            try
            {
                WriteLine("出力行：[{0}]", recordString);
                File.WriteAllText(Path.Combine(OutputDirPath, masterFileName), recordString);
            } catch (Exception e)
            {
                WriteLine("ファイルの書き込みに失敗しました。（ファイルパス：[{0}]）", Path.Combine(OutputDirPath, masterFileName));
            }
            return SUCCESS;
        }

        /** 課題04 */
        public int exercise04()
        {
            WriteLine("未実装です。");
            return SUCCESS;
        }

        /** 課題05 */
        public int exercise05()
        {
            WriteLine("未実装です。");
            return SUCCESS;
        }

        /** 課題06 */
        public int exercise06()
        {
            WriteLine("未実装です。");
            return SUCCESS;
        }

        /** 課題07 */
        public int exercise07()
        {
            WriteLine("未実装です。");
            return SUCCESS;
        }

        /** 課題08 */
        public int exercise08()
        {
            WriteLine("未実装です。");
            return SUCCESS;
        }

        /** 課題09 */
        public int exercise09()
        {
            WriteLine("未実装です。");
            return SUCCESS;
        }

        /** 課題10 */
        public int exercise10()
        {
            WriteLine("未実装です。");
            return SUCCESS;
        }
    }
}
