int [] massive = GetArray (10, 0, 100);

Console.WriteLine($"[{String.Join(", ", massive)}]");

GetRevers(massive);
Console.WriteLine($"[{String.Join(", ", massive)}]");


int [] GetArray (int size, int minValue, int maxValue){
    int [] array = new int [size];
    for (int i = 0; i < size; i++){
        array [i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}


void GetRevers (int [] array){
    for (int i = 0; i < array.Length-1; i++){
        for (int j = i+1; j < array.Length; j++){
            if (array[i] > array[j]){
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }   
} 