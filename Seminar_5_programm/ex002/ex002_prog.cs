using static Metods;
public class ex002_prog
{
public static void ex002()
{
//создадим массив
int [] array = CreateArray(Input("Введите размер массива: "));
//заполняем случайно
FillArray(array);
//вывод массива
WriteArray(array);
Console.WriteLine();
//поиск и замена одинаковых+-
FindNumberInArrayAndReplase(array);
//вывод массива
WriteArray(array);
}
}