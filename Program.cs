internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Chào thế giới!");
        Console.WriteLine("Chương trinh tổng 2 số!");
        int so1, so2, tong, tru, nhan, chia;
        try
        {
            //int so = Console.ReadLine(); Chương trình báo lỗi do int là số còn ReadLine là String(chuỗi), phải thêm nhue bên dưới.
            Console.Write("Nhập số 1: ");
            so1 = Convert.ToInt32(Console.ReadLine());
            //int so = Console.ReadLine(); Chương trình báo lỗi do int là số còn ReadLine là String(chuỗi), phải thêm nhue bên dưới.
            Console.Write("Nhập số 2: ");
            so2 = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Phải nhập vào số");
            return;
        }
        tong = so1 + so2;
        Console.WriteLine("Tổng của hai số " + so1 + " và " + so2 + " là " + tong);
        Console.WriteLine("Tổng của hai số {0} và {1} là {2}", so1, so2, tong);
        Console.WriteLine($"Tổng của hai số {so1} và {so2} là {tong}");
        tru = so1 - so2;
        Console.WriteLine("Thương của hai số " + so1 + " và " + so2 + " là " + tru);
        Console.WriteLine("Thương của hai số {0} và {1} là {2}", so1, so2, tru);
        Console.WriteLine($"Tổng của hai số {so1} và {so2} là {tru}");
        nhan = so1 * so2;
        Console.WriteLine("Tích của hai số " + so1 + " và " + so2 + " là " + nhan);
        Console.WriteLine("Tích của hai số {0} và {1} là {2}", so1, so2, nhan);
        Console.WriteLine($"Tổng của hai số {so1} và {so2} là {nhan}");
        try
        {
            chia = so1 / so2;
            Console.WriteLine("Chia của hai số " + so1 + " và " + so2 + " là " + chia);
            Console.WriteLine("Chia của hai số {0} và {1} là {2}", so1, so2, chia);
            Console.WriteLine($"Chia của hai số {so1} và {so2} là {chia}");
        }
        catch
        {
            Console.WriteLine("Không thể chia cho 0");
            return;
        }
    }
}