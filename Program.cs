using System;

namespace _2d_arrays
{
    class Program
    {
        static void Main(string[] args){
           int[] table = declareTable(2,3);
           foreach(var item in table){
               Console.WriteLine(item);
           }
            Console.WriteLine(readTableCell(table,0,0));  
            Console.WriteLine(writeTableCell(table,0,0,30)); 
            foreach(var item in table){
               Console.WriteLine(item);
           } 
        }
    //declareTable(rows: int, columns: int) : int[]
        static int[] declareTable(int rows, int columns){
            int s = rows*columns;
            int[] Table = new int[s];

            for(int i = 0; i<s; i++){
                Table[i] = i *3;
            }
            return Table;
        }
    //readTableCell(table: int[], row : int, column: int) : int
        static int readTableCell(int[] table, int row, int column){
            return table[row*row + column];
        }
    //writeTableCell(table: int[], row: int, column: int) : int //old-value
        static int writeTableCell(int[] table, int row, int column, int newValue){
             int oldValue = table[row*row + column];
             table[row*row + column] = newValue;
            return oldValue;
        }
    }
}
