using System;

using System.Collections;


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
public class SimpleDataBase<T>
{
    private List<T> storedData;    
    private List<DateTime> inputDates;

    public SimpleDataBase() 
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        int i = 1;
        foreach (T data in storedData)
        {
            Console.WriteLine($"Data {i} berisi: {data}, yang disimpan pada waktu {DateTime.Now}");
            i++;
        }
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

  

        SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();
        simpleDataBase.AddNewData(10);
        simpleDataBase.AddNewData(30);
        simpleDataBase.AddNewData(22);
        simpleDataBase.printAllData();
     
    }
}