// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


int[] InputTriangle() {
    int[] triangle = new int [3];
    Console.WriteLine("Введите первую сторону треугольника: ");
    triangle[0] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите вторую сторону треугольника: ");
    triangle[1] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите третью сторону треугольника: ");
    triangle[2] = int.Parse(Console.ReadLine()!);
    return triangle;
}

void checkTriangle(int[] triangle) {
    if (triangle[0] + triangle[1] > triangle[2] && triangle[0] + triangle[2] > triangle[1] && triangle[1] + triangle[2] > triangle[0]) {
        Console.WriteLine("Такой треугольник может существовать");
    }
    else {
        Console.WriteLine("Такой треугольник НЕ может существовать");
    }
}

checkTriangle(InputTriangle());
