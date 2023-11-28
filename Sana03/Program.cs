using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int N, arrMaxIndex,arrSumIndexPositive=0, intNum=0;
double arrSumMinus = 0, arrMin, arrMax, arrMaxAbs, arrMaxAbsReal;
Console.Write("Введіть кількість елементів в масиві: ");
int.TryParse(Console.ReadLine(), out N);
double[] arr = new double[N];
Random rnd = new Random();
Console.Write("Масив: ");
for (int i = 0; i < N; i++)
{
    arr[i] = rnd.Next(20) - 10 + rnd.NextDouble();
    arr[i] = Math.Round(arr[i],1);
    Console.Write($"{arr[i]}\t");
}
arrMin = arr[0];
arrMax = arr[0];
arrMaxAbs = arr[0];
arrMaxAbsReal = arr[0];
arrMaxIndex = 0;
for (int i = 0; i < N; i++)
{
    if (arr[i] < 0)
       arrSumMinus += arr[i];
    if (arr[i] > 0)
        arrSumIndexPositive += i;
    if ((arr[i]*10) % 10 == 0)
        intNum ++;
    if (arrMin > arr[i])
        arrMin = arr[i];
    if (arrMax < arr[i])
    {
        arrMax = arr[i];
        arrMaxIndex = i;
    }
    if (arrMaxAbs < Math.Abs(arr[i]))
    {
        arrMaxAbs = Math.Abs(arr[i]);
        arrMaxAbsReal = arr[i];
    }
}
Console.WriteLine($"\nсума від’ємних елементів масиву: {arrSumMinus}");
Console.WriteLine($"мінімальний елемент масиву: {arrMin}");
Console.WriteLine($"номер (індекс) максимального елемента масиву: {arrMaxIndex}");
Console.WriteLine($"максимальний за модулем елемент масиву: {arrMaxAbsReal}");
Console.WriteLine($"сума індексів додатних елементів: {arrSumIndexPositive}");
Console.WriteLine($"кількість цілих чисел у масиві: {intNum}");