using System;



public class PemrosesData
{
    public void dapatkanNilaiTerbesar<T>(T param1, T param2, T param3)
    {
        dynamic temp1 = param1;
        dynamic temp2 = param2;
        dynamic temp3 = param3;

        dynamic biggest;

        if (temp1 > temp2)
        {
            biggest = temp1;
        } else
        {
            biggest = temp2;
        }

        if (biggest < temp3)
        {
            biggest = temp3;
        }
        Console.WriteLine($"Nilai terbesar: {biggest}");
    }
}

class MainProgram
{
    public static void Main(string[] args)
    {
        PemrosesData pemrosesData = new PemrosesData();
        long input1 = long.Parse(Console.ReadLine());
        long input2 = long.Parse(Console.ReadLine());
        long input3 = long.Parse(Console.ReadLine());
        pemrosesData.dapatkanNilaiTerbesar<long>(input1, input2, input3);

    }
}