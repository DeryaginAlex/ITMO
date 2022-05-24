using System;
internal class Program {
    static void Main(string[] args) {
        int size;
        Console.Write("Введите длинну массива (size): ");
        size = Int32.Parse(Console.ReadLine());
        int[] mas = new int[size];
        mas = GetArray(size);
        printArray(mas);
        Console.ReadKey();
    }
    static void printArray(int[] mas) {
        Console.Write("Массив: ");
        for(int i = 0 ; i < mas.Length ; i++) {
            Console.Write(mas[i] + " ");
        }
        Console.WriteLine();
    }
    static int[] GetArray(int size) {
        int[] mas = new int[size];
        int n;
        Console.Write("Введите размер статической последовательности (n): ");
        do {
            n = Int32.Parse(Console.ReadLine());
        } while(n > size || n < 0);
        for(int i = 0 ; i < n ; i++) {
            if(i <= n) {
                Console.Write("Введите " + (i + 1) + " элемент массива: ");
                mas[i] = Int32.Parse(Console.ReadLine());
            }
        }
        return mas;
    }
}