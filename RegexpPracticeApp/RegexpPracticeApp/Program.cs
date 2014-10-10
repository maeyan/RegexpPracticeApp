using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RegexpPracticeApp {
    static class Program {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {

            // Mutexインスタンスを生成する(識別子としてアセンブリ名でもつけておく)
            System.Threading.Mutex hMutex = new System.Threading.Mutex(false, Application.ProductName);

            if (hMutex.WaitOne(0, false)) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new RegexpPracticeApp());
            }

            //GC.KeepAliveメソッドが呼び出されるまで、GC対象から除外する
            GC.KeepAlive(hMutex);

            //Mutexを閉じる
            hMutex.Close();

        }
    }
}
