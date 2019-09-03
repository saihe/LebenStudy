using System;
using static System.Console;
using static Study201908.Consts;

namespace Study201908
{
    class Program
    {
        enum Mode
        {
            Exercise01 = 1,
            Exercise02 = 2,
            Exercise03 = 3,
            Exercise04 = 4,
            Exercise05 = 5,
            Exercise06 = 6,
            Exercise07 = 7,
            Exercise08 = 8,
            Exercise09 = 9,
            Exercise10 = 10,
            Exit = 99,
        }

        static void Main(string[] args)
        {
            Exercises exercises = new Exercises();
            while (true)
            {
                WriteLine("課題番号を入力して[Enter]キーを押してください。課題内容は以下の通り");
                WriteLine("1：{0}", "テキストファイルのオープン、クローズができること。");
                WriteLine("2：{0}", "ファイルが存在しない場合のエラー処理ができること。テキストファイルの書き込みができること。");
                WriteLine("3：{0}", "テキストファイルの追加書き込みができること。");
                WriteLine("4：{0}", "データの探索ができること。配列に格納できること。");
                WriteLine("5：{0}", "ArrayListが使えること。");
                WriteLine("6：{0}", "データの探索ができること。ArrayListが使えること。");
                WriteLine("7：{0}", "グループトータルにより集計表が作成できること。コントロールブレイク処理ができること。");
                WriteLine("8：{0}", "グループトータルにより集計表が作成できること。コントロールブレイク処理ができること。グループインジケートができること。");
                WriteLine("9：{0}", "グループトータルにより集計表が作成できること。コントロールブレイク処理ができること。グループインジケートができること。");
                WriteLine("10：{0}", "グループトータルにより集計表が作成できること。コントロールブレイク処理ができること。グループインジケートができること。");
                WriteLine("99：{0}", "アプリケーションの終了");
                try
                {
                    int exercieseNumber = int.Parse(ReadLine());
                    switch((Mode)Enum.ToObject(typeof(Mode), exercieseNumber))
                    {
                        case Mode.Exercise01:
                            // 問題01
                            exercises.exercise01();
                            break;
                        case Mode.Exercise02:
                            // 問題02
                            exercises.exercise02();
                            break;
                        case Mode.Exercise03:
                            // 問題03
                            exercises.exercise03();
                            break;
                        case Mode.Exercise04:
                            // 問題04
                            exercises.exercise04();
                            break;
                        case Mode.Exercise05:
                            // 問題05
                            exercises.exercise05();
                            break;
                        case Mode.Exercise06:
                            // 問題06
                            exercises.exercise06();
                            break;
                        case Mode.Exercise07:
                            // 問題7
                            exercises.exercise07();
                            break;
                        case Mode.Exercise08:
                            // 問題08
                            exercises.exercise08();
                            break;
                        case Mode.Exercise09:
                            // 問題09
                            exercises.exercise09();
                            break;
                        case Mode.Exercise10:
                            // 問題10
                            exercises.exercise10();
                            break;
                        case Mode.Exit:
                            // 終了
                            WriteLine("アプリケーションを終了します。");
                            Environment.Exit(SUCCESS);
                            break;
                        default:
                            WriteLine("指定された課題は存在しません。");
                            break;
                    }
                } catch (ArgumentException e)
                {
                    WriteLine("課題番号が入力されていません。");
                } catch (FormatException e)
                {
                    WriteLine("課題番号が不正です。");
                } catch (OverflowException e)
                {
                    WriteLine("課題番号が不正です。");
                }
            }
        }
    }
}
