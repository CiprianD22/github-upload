using System;
using System.Runtime.InteropServices;

namespace AppliConsoleCSharp
{
    class Program
    {
        [DllImport("DLLSimpleNonManage.dll", CharSet = CharSet.Ansi,
        CallingConvention = CallingConvention.Cdecl)]
        internal static extern int intNext(int i);

        [DllImport("DLLSimpleNonManage.dll", CharSet = CharSet.Ansi,
        CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr testString();

        [DllImport("DLLSimpleNonManage.dll", CharSet = CharSet.Ansi,
        CallingConvention = CallingConvention.Cdecl)]
        internal static extern void remplirMemoireChaine(IntPtr mem, int nbCar);

        [DllImport("DLLFreeNonManage.dll", CharSet = CharSet.Ansi,
        CallingConvention = CallingConvention.Cdecl)]
        internal static extern void freeNonManage(IntPtr bloc);

        static void Main(string[] args)
        {
            int i = intNext(5);
            IntPtr ptrChars = testString();
            String s = Marshal.PtrToStringAnsi(ptrChars);
            freeNonManage(ptrChars);
            IntPtr mem = Marshal.AllocHGlobal(sizeof(char) * 22);
            remplirMemoireChaine(mem, 22);
            String s2 = Marshal.PtrToStringAnsi(mem);
            Marshal.FreeHGlobal(mem);
            Console.WriteLine("Hello World! " + i);
            Console.WriteLine(s);
            Console.WriteLine(s2);
        }
    }
}
