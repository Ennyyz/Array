using System;

namespace SLIDE7.MANG1CHIEU.BAI1.MANG2CHIEU
{
    class Program
    {
        /*
         Bài tập: Viết chương trình có các hàm chức năng sau:
            a. Hàm nhập một mảng số nguyên (bao gồm các thao tác: nhập số lượng phần tử, khởi tạo và nhập giá trị các phần tử của mảng)
            b. Hàm nhập giá trị các phần tử của một mảng số nguyên (mảng đã được khởi tạo trước khi gọi hàm)
            c. Hàm xuất giá trị các phần tử của một mảng số nguyên ra màn hình
         */
        static void nhapmangsonguyen(out int[] arr)
        {
            Console.Write("nhap n: ");
            int n = int.Parse(Console.ReadLine());
            arr= new int[n];
        }
        static int[] nhapmangsonguyen1()
        {
            Console.Write("Nhap n: "); int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            return a;
        }
        static void nhapmang(int[]a)
        {
            for(int i = 0;i < a.Length;i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuatmang(int[]a)
        {
            //foreach(int item in a)
            foreach (var item in a)
            {
                Console.Write($"{item,3}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] a;
            nhapmangsonguyen(out a);
            nhapmang(a);
            xuatmang(a);

            Console.ReadLine();
        }
    }
}
