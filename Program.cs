using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Khai báo mảng
            //string[] Array = new string[3];
            //int[] IntArray = { 1, 2, 3 };
            //string[] Kteam = new string[] { "How Kteam", "Free Education" };
            //Console.WriteLine(Kteam[1]);
            #endregion

            #region Duyệt mảng
            //int[] Kteam = new int[3];
            //for (int i= 0; int < 3;int++)
            //{
            //    //Do Something
            //}
            //int[] Kteam = new int[3];
            //for(int i=0;i<Kteam.Length;i++)
            //{
            //    //Do Something
            //}
            #endregion

            #region Ví dụ
            int Year;
            string[] Can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] Chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tị", "Ngọ", "Mùi" };
            Console.WriteLine("Mời bạn nhập năm:");
            Year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Năm {0} có năm âm lịch là:{1} {2}", Year, Can[Year % 10], Chi[Year % 12]);
            Console.WriteLine("Ốc gà");

            #endregion
            Console.ReadKey();
        }
    }
}
