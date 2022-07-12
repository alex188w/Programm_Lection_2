int[] array = {1, 12, 31, 4, 15, 16, 17, 28, 4};

int n = array.Length; //определяет длину массива
int find = 4;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
      Console.WriteLine(index); 
      break; //прервать 
    }
    //index = index + 1;
    index++;  
}

