using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Study201908
{
    /**
     * 基底クラス
     */
    public abstract class AbstractClass
    {
        /**
         * configから値を取得
         * @param key アプリ設定キー
         */
        protected string getConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /**
         * 入力ディレクトリパスを取得
         */
        protected string InputDirPath
        {
            get
            {
                return ConfigurationManager.AppSettings["inputDir"];
            }
        }

        /**
         * 出力ディレクトリパスを取得
         */
        protected string OutputDirPath
        {
            get
            {
                return ConfigurationManager.AppSettings["outputDir"];
            }
        }
    }
}
