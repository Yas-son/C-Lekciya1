
// Поиск максимального числа из девяти
// Поиск с помощью функции (от+++ до +++)
int Max(int arg1, int arg2, int arg3) //функция и 3 аргумента
// будет искать максимальное из трех:
{ //плюс - если возникнет ошибка, искать ее в одном месте (используется одна функция)
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// решение стихийным методом (от === до ===)
//===
// Определяем девять переменных:
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;

//int max = a1; //определим переменную max в которую положим значение аргумента a1
// if (b1 > max) max = b1; //Если B1 больше чем макс, тогда в макс кладем b1
// if (c1 > max) max = c1; //И так далее (находим максимум)
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;
//+++ 1 вариант:
// int max1 = Max(a1, b1, c1); //показываем функции переменные для поиска максимума
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3); //ищем максимум из максимумов
// 2 вариант (то же, но одной строкой):
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2),Max(a3, b3, c3));

Console.WriteLine(max);
//+++
//Console.WriteLine(max);
//===