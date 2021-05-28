using System;

namespace _2d_arrays
{
    class Program
    {
        static void Main(string[] args){
            int[] Table = declareTable(2,3);
            foreach( var item in Table){
                Console.WriteLine(item);
            }
            Console.WriteLine(readTableCell(Table, 1,1));
            Console.WriteLine(writeTableCell(Table, 1,1, 1));
            foreach(var item in Table){
                Console.WriteLine(item);
            }
        }
    //declareTable(rows: int, columns: int) : int[]
        static int[] declareTable(int rows, int columns){
            int s = rows*columns;
            int[] Table = new int[s];
            for(int i = 0; i < s; i++){
                Table[i] = i;
            }
            return Table;
        }
    //readTableCell(table: int[], row : int, column: int) : int
        static int readTableCell(int[] table, int row, int column){
            return table[(2*row)+column];
        }
    //writeTableCell(table: int[], row: int, column: int) : int //old-value
        static int writeTableCell(int[] table, int row, int column, int newValue){
            int oldValue = table[(2*row)+column];
            table[(2*row)+column] = newValue;
            return oldValue;
        }    
    }
}
