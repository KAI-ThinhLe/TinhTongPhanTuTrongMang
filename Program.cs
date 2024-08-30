using System;

class Program
{
    static void Main()
    {
       
        int[] numbers = new int[5];

        //: Thêm giá trị vào mảng
        numbers[0] = 2;
        numbers[1] = 5;
        numbers[2] = 9;
        numbers[3] = 6;
        numbers[4] = 7;

        //In ra giá trị của mảng
        Console.WriteLine("Các phần tử của mảng:");
        Console.WriteLine(numbers[0]); // In phần tử tại vị trí 0
        Console.WriteLine(numbers[2]); // In phần tử tại vị trí 2
        Console.WriteLine(numbers[3]); // In phần tử tại vị trí 3

        //  Tính tổng 
        int total = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i]; // Cộng dồn giá trị các phần tử vào biến total
        }

        // In ra tổng 
        Console.WriteLine("Tổng các phần tử của mảng: " + total);
    }
}
