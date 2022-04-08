using System;
using System.Collections.Generic;

namespace Slide12.List
{
    class Program
    {
        /*
         Bài tập: Viết chương trình thực hiện các yêu cầu sau:
            a. Khai báo và khởi tạo một List số nguyên. In ra màn hình giá trị thuộc tính Count và Capacity của List
            b. Thêm lần lượt các số nguyên từ 1 đến 10 vào cuối List. Sau mỗi lượt thêm in ra màn hình giá trị các phần tử hiện có trong List, các thuộc tính Count và Capacity của List
            c. Lần lượt xóa phần tử ở đầu List cho đến khi hết danh sách. Sau mỗi lượt xóa in ra màn hình giá trị các phần tử hiện có trong List, các thuộc tính Count và Capacity của List
         */
        static void nhaplist(out List<int> list)
        {
            list = new List<int>();
            Console.WriteLine($"thuoc tinh count cua list la: {list.Count}");
            Console.WriteLine($"thuoc tinh capacity cua list la:{list.Capacity}");
        }
        static void nhapphantu(List<int> list)
        {
            int value = 1;
            for (int i = 0;i<10;i++)
            {
                list.Add(value);
                value++;
                foreach (var item in list)
                    Console.Write($"{item,3}");
                Console.WriteLine($"\nCount : {list.Count}");
                Console.WriteLine($"Capacity: {list.Capacity}");
            }
        }
        static void xoaphantu(List<int>list)
        {
            while(list.Count > 0)
            { 
                list.RemoveAt(0);
                foreach (var item in list)
                    Console.Write($"{item,3}");
                Console.WriteLine($"\n count : {list.Count}");
                Console.WriteLine($"capacity: {list.Capacity}");
            }
        }

        static void Main(string[] args)
        {
            List<int> list;
            nhaplist(out list);
            nhapphantu(list);
            xoaphantu(list);
        }
    }
}
