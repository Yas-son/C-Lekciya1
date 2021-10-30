Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;
//Присваиваем переменным коортдинаты точек
Console.SetCursorPosition(xa, ya); 
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
//Показываем на экране вершины треугольника

int x = xa, y = xb;
//Определили случайную точку Х и положили в нее первую точку 
int count = 0;
// определили некоторый счетчик count который будет определять
// какое именно количество раз будет проделываться 
// нахождение отрезка и деление его пополам (см.условие задачи)
// видимо, сверху - точка отсчета, а снизу - количество повторений
while (count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    // генератор случайных чисел. Выбор одной из трех 
    // случайных точек, поэтому (0,3)
    if (what == 0)  // если what равно "0" то в Х ложим середину отрезка А:
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)  // если what равно "0" то в Х ложим середину отрезка B:
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)  // если what равно "0" то в Х ложим середину отрезка C:
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y); //установка курсора в нужную позицию
    Console.WriteLine("+"); // курсором будет +
    count++; //становись на 1 больше каждый цикл

}