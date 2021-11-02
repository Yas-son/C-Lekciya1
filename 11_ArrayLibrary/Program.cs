void FillArray(int[] col) //вводим метод заполнения массива с аргументом col
{
    int length = col.Length; //получаем длину массива
    int index = 0; //начальная позиция
    while (index < length) //пока индекс меньше длины
    {
        col[index] = new Random().Next(1,10); //целое случайное число из диапазона 1-9
        index++; // увеличиваем индекс на 1
    }
}
void PrintArray(int[] cola) //метод который будет печатать массив
{
    int count = cola.Length; // кол-во элементов
    int position = 0; //начальный элемент (и имя элементов)
    while (position < count) //пока позиция меньше длины массива
    {
        Console.WriteLine(cola[position]); //выводим на экран консоли (распечатка массива)
        position++;
    }
}

int IndexOf(int[] col, int find) //метод IndexOf с аргументами: массив col и элемент find
{// для поиска номера элемента массива соответствующего указанному числу
    int count = col.Length; //определяем кол-во элементов
    int index = 0; //переменная индекс
    int position = -1; //добавили вместе с position = index; - что ниже
    // -1 - возвращает метод на печать если искомого числа нет в массиве
    while (index < count)
    {
        if(col[index] == find) //если индекс совпал с find, то положить его в position
        {
            position = index;
            break; //остановка по нахождению
        }
        index++;
    }
    return position; //ожидаем позицию элемента
}

int [] array = new int [10];

FillArray(array); //заполняет массив
// array[4] = 4; //принудительное присваивание цифры 4 - 4 элементу массива
// array[6] = 4; //принудительное присваивание цифры 4 - 6 элементу массива

PrintArray(array); //будет распечатывать массив
Console.WriteLine(); //печать пустой строки - чтобы быть уверенным, что не является частью выводамассива

int pos = IndexOf(array, 4); //определим переменную pos положим туда результат работы метода и искомую цифру
Console.WriteLine(pos);