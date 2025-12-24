using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workLab2_24_12_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            string input;

            Console.WriteLine("กรอกจำนวนเต็ม (พิมพ์ Q เพื่อหยุด)");

            // รับข้อมูลด้วย loop
            while (true)
            {
                Console.Write("กรอกตัวเลข: ");
                input = Console.ReadLine();
                if (input.ToUpper() == "Q") // คำสั่ง break
                    break;
                int number;
                if (int.TryParse(input, out number))
                {
                    data.Add(number);
                }
                else
                {
                    Console.WriteLine("กรอกเฉพาะตัวเลข หรือ Q เท่านั้น");
                }
            }
        

            // ตรวจสอบว่ามีข้อมูลหรือไม่
            if (data.Count == 0)
            {
                Console.WriteLine("ไม่มีข้อมูล");
                return;
            }

            // 1) ค่าเฉลี่ย
            double average = data.Average();

            // 2) ค่าสูงสุด
            int max = data.Max();

            // 3) ค่าต่ำสุด
            int min = data.Min();

            // 4) ค่ากลางข้อมูล
            var sorted = data.OrderBy(x => x).ToList();
            double median;
            int n = sorted.Count;

            if (n % 2 == 0)
                median = (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
            else
                median = sorted[n / 2];

            // 5) เรียงจากมากไปน้อย
            var desc = sorted.OrderByDescending(x => x);

            // 6) เรียงจากน้อยไปมาก
            var asc = sorted.OrderBy(x => x);

            // แสดงผล
            Console.WriteLine("\nผลลัพธ์");
            Console.WriteLine("ค่าเฉลี่ย = " + average);
            Console.WriteLine("ค่าสูงสุด = " + max);
            Console.WriteLine("ค่าต่ำสุด = " + min);
            Console.WriteLine("ค่ากลางข้อมูล = " + median);

            Console.WriteLine("เรียงจากมากไปน้อย:");
            foreach (int i in desc)
                Console.Write(i + " ");

            Console.WriteLine("\nเรียงจากน้อยไปมาก:");
            foreach (int i in asc)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("นายนันท์นิพัทธ์ อ่วมอินทร์ 683450431-9");
            //นายนันท์นิพัทธ์ อ่วมอินทร์ 683450431-9
        }
    }
}



