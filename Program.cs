using System;

namespace ArrayB1
{
    class Program
    {
        static void nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuat(int[] a, int n)
        {
            
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }
       

        static int[] copymang(int[] a, int n)
        {
            int[] b = new int[n];

            for (int i = 0; i < n; i++)
            {
                b[i] = a[i];
            }
            return b;
        }

        static void xuatgiamdan(int[] a, int n)
        {
            int temp;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] > a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            xuat(a, n);
        }
        static int GTLN(int[] a, int n)
        {
            int max = a[0];

            for (int i = 1; i < n; i++)
            {
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        static int GTNN(int[] a, int n)
        {
            int min = a[0];

            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        static int tongchan(int[] a, int n)
        {
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                if (i%2 == 0)
                {
                    tong += a[i];
                }
            }
            return tong;
        }
        static int sochan(int[] a, int n)
        {
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    tong ++;
                }
            }
            return tong;
        }
        static int sosolonnhat(int[] a, int n, int max)
        {
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i]  == max)
                {
                    tong++;
                }
            }
            return tong;
        }
        static int tong(int[] a, int n)
        {
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        static int demso5(int[] a, int n)
        {
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] == 5)
                    tong++;
            }
            return tong;
        }
        static void Main(string[] args)
        {
            Console.Write("Bai 1 \n");
            
            Console.Write("1.Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            nhap(a, n);
            int[] b = copymang(a,n);
            Console.Write("2.Mang giam dan:");
            xuatgiamdan(a, n);
            Console.Write("\n");
            Console.Write("3.Hien thi mang:");
            xuat(b, n);
            Console.Write("\n");
            Console.Write("4.Gia tri lon nhat:");
            Console.Write(GTLN(b,n));
            Console.Write("\n");
            Console.Write("4.Gia tri nho nhat:");
            Console.Write(GTNN(b, n));
            Console.Write("\n");
            Console.Write("5.Tong chi so chan:");
            Console.Write(tongchan(b, n));
            Console.Write("\n");
            Console.Write("5.Trung binh so chan:");
            Console.Write((float)tongchan(b, n)/sochan(b,n));
            Console.Write("\n");
            Console.Write("6.So luong phan tu lon nhat: ");
            Console.Write(sosolonnhat(a,n,GTLN(a,n)));
            Console.Write("\n");
            Console.ReadKey();
            //bai 2
            Console.Write("Bai 2 \n");
            Console.Write("1.Nhap so phan tu cua mang: ");
            int m = int.Parse(Console.ReadLine());
            int[] c = new int[100];
            nhap(c, m);
            Console.Write("\n");
            Console.Write("2.Hien thi mang: ");
            xuat(c, m);
            Console.Write("\n");
            Console.Write("3.Trung binh mang: " + (float)tong(c, m)/n);
           
            Console.Write("\n");
            Console.Write("4.Gia tri lon nhat mang: "+ GTLN(c, m));
            
            Console.Write("\n");
            Console.Write("5.So phan tu bang 5: "+ demso5(c, m));
            
            Console.Write("\n");

            // bai 3
            int tien = 0 ;
            Console.Write("Bai 3 \n");
            Console.Write("Nhap so phut goi : ");
            int phut = int.Parse(Console.ReadLine());
            Console.Write("Nhap loai khach hang : 0 - sinh vien ; 1 - binh thuong  ");
            int loai = int.Parse(Console.ReadLine());
            if(loai == 0)
            {
                phut -= 50;
                
            }
            if (phut <= 0)
            {
                tien = 0;
            }
            else if (phut <= 200)
            {
                tien = 12 * phut;
            }
            else if (phut <= 400)
            {
                tien = 12 * 200 + (phut - 200) * 8;
            }
            else
            {
                tien = 12 * 200 + (phut - 200) * 8 + (phut - 400) * 4;
            }
            tien = (2700 + tien) * 11;

            Console.Write("So tien cuoc : " + tien);
            // bai 4 
            Console.Write("Nhap doanh so (don vi 1000 USD) : ");
            int ds = int.Parse(Console.ReadLine());
            if(ds >= 0 && ds < 4)
            {
                Console.Write("Rat kem (-1%)");
            }
            else if (ds  == 4)
            {
                Console.Write(" Kem (-0.5%)");
            }
            else if (ds == 5)
            {
                Console.Write(" Co co gnag (0.5%)");
            }
            else if (ds == 6)
            {
                Console.Write(" Tot (2%)");
            }
            else if (ds == 7)
            {
                Console.Write(" Rat tot (3.5%)");
            }
            else if (ds > 7 && ds <= 10)
            {
                Console.Write(" Tuyet voi (5%)");
            }
            else
            {
                Console.Write(" Nhap sai");
            }
        }
    }
}
