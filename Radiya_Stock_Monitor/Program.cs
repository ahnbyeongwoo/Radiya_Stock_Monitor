using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Radiya_Stock_Monitor
{
    internal static class Program
    {
        // 윈도우 OS의 DPI 인식 기능을 제어하는 외부 함수 선언
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main()
        {
            // 프로그램 시작 시 DPI 인식을 강제로 비활성화 (100% 비율 고정)
            SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}