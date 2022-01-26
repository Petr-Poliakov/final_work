void methodArray (string [] array){
     for (int i=0; i<array.Length; i++){      
        if(array[i].Length<=3){
        string[] newarr = new string[array.Length];
        newarr[i]=array[i];
        Console.WriteLine(newarr[i]); 
        }
     }
        Console.WriteLine(); 
}

void Print(string [] Array){
    for (int i=0; i<Array.Length; i++){
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}

string [] array = {"hello", "2", "world", ":-)"};

methodArray(array);
Print(array);
