using System;
internal class QuadraticEquationSolutionViaDiscriminant {
    static void Main(string[] args) {
        Console.WriteLine("Данная программа решает квадратное уравнения вида, a*x*x + b*x + c = 0, \nгде х - искомая величина, a - первый коэффициент, b - второй коэффициент, с - третий коэффициент\n");
        double[] coefficients = new double[2];
        double discriminant;
        coefficients = initializationСoefficients();
        discriminant = getDiscriminant(coefficients);
        printResult(discriminant, coefficients);
    }
    static public double[] initializationСoefficients() {
        double[] result = new double[3];
        for(int i = 0 ; i <= 2 ; i++) {
            Console.Write("Введите " + (i + 1) + " коэффициент: ");
            result[i] = Double.Parse(Console.ReadLine());
        }
        return result;
    }
    static public double getDiscriminant(double[] coefficients) {
        return coefficients[1] * coefficients[1] - 4 * coefficients[0] * coefficients[2];
    }
    static public void printResult(double discriminant, double[] coefficients) {
        if(discriminant < 0) {
            Console.WriteLine("Не существует вещественных корней");
        }
        if(discriminant > 0) {
            Console.WriteLine("Уравнение имеет два решения, первое равно " + (-coefficients[1] + Math.Sqrt(discriminant) / (2 * coefficients[0])) + ", второе равно " + (-coefficients[1] - Math.Sqrt(discriminant) / (2 * coefficients[0])));
        }
        if(discriminant == 0) {
            Console.WriteLine("Уравнение имеет одно решение, равное " + (-coefficients[1] / (2 * coefficients[0])));
        } else {
            Console.WriteLine("Не правильно посчитан дискриминант");
        }
    }
}