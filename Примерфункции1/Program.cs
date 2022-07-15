// Нахождение максимальное число из 9 предложенных с помощью функции

int Max (int arg1, int arg2, int arg3)      // В участке обозначенном слешем написана функция нахождения максимального
{                                           // числа по тройкам
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}                                           //

int a1 = 21;
int b1 = 43;
int c1 = 32;
int a2 = 2241;
int b2 = 4343;
int c2 = 3213;
int a3 = 21425;
int b3 = 43523;
int c3 = 314;

//int max1 = Max(a1,b1,c1);         Первый вариант сравнения чисел по тройкам с исп. пром. переменных
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max(max1,max2,max3);

int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3)); // Второй вариант сравнения с исп. функции написанной ранее
Console.WriteLine(max);