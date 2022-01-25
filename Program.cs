 void methodArray (string [] array){
     for (int i=0; i<array.Length; i++){
//         Console.Writeline([arr])        
         //if (array[i]!=string.Empty){
        //Console.WriteLine (array[i].Length);
        if(array[i].Length<=3){
        Console.WriteLine (array[i]);
        }
//         // int [] newArr = new int [arr[i]];
//        // Array.Copy(arr,1, newArr,0, newArr.Length);
//         //Console.Write(newArr);
//         //return int [] newArr;
        }
     }


// void Print(string [] Array){
//     for (int i=0; i<Array.Length; i++){
//         Console.Write(" " + Array[i]);
//     }
//     Console.WriteLine();
// }

string [] array = {"hello", "2", "world", ":-)"};
methodArray(array);
//Print(array);
