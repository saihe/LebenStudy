using System;
namespace Study201907
{
    /*
     * コンソール出力を行う演習
     */
    public class Exercises
    {
        //　出力文字列
        private const string OUTPUT_CHAR = "*";

        /*
         * 演習問題01
         * 出力内容
         * *
         * **
         * ***
         * ****
         * *****        
         */       
        public void Exercise01()
        {
            Console.WriteLine("演習問題 01");
            int limitRowCount = 5; // 最大出力行数

            for (int rowCount = 0; rowCount < limitRowCount; rowCount++)
            {
                for(int colCount = 0; colCount < rowCount + 1; colCount++)
                {
                    Console.Write(OUTPUT_CHAR);
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
        }

        /*
         * 演習問題02
         * 出力内容
         * *****
         * ****
         * ***
         * **
         * *
         */
        public void Exercise02()
        {
            Console.WriteLine("演習問題 02");
            int limitRowCount = 5; // 最大出力行数
            int limitColCount = 5; // 最大出力列数

            for (int rowCount = 0; rowCount < limitRowCount; rowCount++)
            {
                for (int colCount = rowCount; colCount < limitColCount; colCount++)
                {
                    Console.Write(OUTPUT_CHAR);
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
        }

        /*
         * 演習問題03
         * 出力内容
         *     *
         *    **
         *   ***
         *  ****
         * *****        
         */
        public void Exercise03()
        {
            Console.WriteLine("演習問題 03");
            int limitRowCount = 5; // 最大出力行数
            int limitColCount = 5; // 最大出力列数

            for (int rowCount = 0; rowCount < limitRowCount; rowCount++)
            {
                for (int colCount = rowCount + 1; colCount < limitColCount; colCount++)
                {
                    Console.Write(" ");
                }
                for (int colCount = 0; colCount < rowCount + 1; colCount++)
                {
                    Console.Write(OUTPUT_CHAR);
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
        }

        /*
         * 演習問題04
         * 出力内容
         *     *
         *    ***
         *   *****
         *  *******
         * *********       
         */
        public void Exercise04()
        {
            Console.WriteLine("演習問題 04");
            int limitRowCount = 5; // 最大出力行数
            int limitColCount = 5; // 最大出力列数

            for (int rowCount = 0; rowCount < limitRowCount; rowCount++)
            {
                for (int colCount = rowCount + 1; colCount < limitColCount; colCount++)
                {
                    Console.Write(" ");
                }
                for (int colCount = 0; colCount < rowCount + 1; colCount++)
                {
                    Console.Write(OUTPUT_CHAR);
                }
                for (int colCount = 0; colCount < rowCount; colCount++)
                {
                    Console.Write(OUTPUT_CHAR);
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
        }

        /*
         * 演習問題05
         * 出力内容
         *     *
         *    ***
         *   *****
         *  *******
         * *********
         *  *******
         *   *****
         *    ***
         *     *
         */
        public void Exercise05()
        {
            Console.WriteLine("演習問題 05");
            int limitRowCount = 5; // 最大出力行数
            int limitColCount = 5; // 最大出力列数

            for (int rowCount = 0; rowCount < limitRowCount; rowCount++)
            {
                for (int colCount = rowCount + 1; colCount < limitColCount; colCount++)
                {
                    Console.Write(" ");
                }
                for (int colCount = 0; colCount < rowCount + 1; colCount++)
                {
                    Console.Write(OUTPUT_CHAR);
                }
                for (int colCount = 0; colCount < rowCount; colCount++)
                {
                    Console.Write(OUTPUT_CHAR);
                }
                Console.Write(Environment.NewLine);
            }
            for (int rowCount = 1; rowCount < limitRowCount; rowCount++)
            {
                for (int colCount = 0; colCount < rowCount; colCount++)
                {
                    Console.Write(" ");
                }
                for (int colCount = rowCount; colCount < limitColCount; colCount++)
                {
                    Console.Write(OUTPUT_CHAR);
                }
                for (int colCount = rowCount + 1; colCount < limitColCount; colCount++)
                {
                    Console.Write(OUTPUT_CHAR);
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
        }
    }
}
