int [] massive = GetArray (5, -3, 10);

int count = 0;

foreach (int i in massive){
    if (i > 0){
        count = count + 1;
    }
}

int [] GetArray (int size, int minValue, int maxValue){
    int [] array = new int [size];
    for (int i = 0; i < size; i++){
        array [i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}

Console.WriteLine($"В массиве [{String.Join(", ", massive)}] количество положительных чисел = {count}");


