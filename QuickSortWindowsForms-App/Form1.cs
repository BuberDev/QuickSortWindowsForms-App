using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSortWindowsForms_App
{
    public partial class Quicksort : Form
    {
        //Initziere eine Liste
        private List<int> numbers = new List<int>();
        public Quicksort()
        {
            InitializeComponent();
        }

        //"addBtn" hat ein Click Event und fügt eine Zahlen in die "UnsortedList" zu
        private void addBtn_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberToAdd.Value);
            UnsortedList.Items.Add(numberToAdd.Value);
            numbers.Add(number);
         
            
        }
        //"doQuicksortBtn" hat ein ClickEvent. Der macht ganze Quicksort
        private void doQuicksortBtn_Click(object sender, EventArgs e)
        {
            //Ausrufen 
            Quick_Sort(numbers, 0, numbers.Count -1);
            Partition(numbers, 0, numbers.Count -1);

            //Die schleife zeigt sortierte Liste 
            foreach(int num in numbers)
            {
                SortedList.Items.Add(num);
            }
        }
        //In dieser Funktion geht es um Rekursion
        public static void Quick_Sort(List<int> numbers, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(numbers, left, right);

                if (pivot > 1)
                {
                    //Linke Bereich vom Pivot
                    Quick_Sort(numbers, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {   //Recht Bereich vom Pivot
                    Quick_Sort(numbers, pivot + 1, right);
                }
            }

        }

        public static int Partition(List<int> numbers, int leftPartition, int rightPartition)
        {
            float temp1 = ((leftPartition + rightPartition) / 2);
            //Erstellen eine Pivot-variable. Am besten in der Mitte. Es kann erste position oder auch letzte sein
            int pivot = numbers[Convert.ToInt32(Math.Round(temp1))];
            
            while (true)
            {
                //Prüfen ob Wert auf erste Position kleiner ist als pivot. Wenn ja,
                //dann wir prüfen Wert eine Position weiter
                while (numbers[leftPartition] < pivot)
                {
                    leftPartition++;
                }
                //Prüfen ob Wert auf letzte Position kleiner ist als pivot. Wenn ja,
                //dann wir prüfen Wert eine vorherige Position.  
                while (numbers[rightPartition] > pivot)
                {
                    rightPartition--;
                }

                if (leftPartition < rightPartition)
                {
                    if (numbers[leftPartition] == numbers[rightPartition])
                    {
                        return rightPartition;
                    }
                    //Wir vertauschen Wert "numbers[left]" mit den Wert "numbers[right]"
                    //Wir inizieren eien Hilfsvariable temp in der wir könenen vordesten Wert zwischen speichern
                    int temp = numbers[leftPartition];
                    numbers[leftPartition] = numbers[rightPartition];
                    numbers[rightPartition] = temp;


                }
                else
                {
                    return rightPartition;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            UnsortedList.Items.Clear();
            SortedList.Items.Clear();
            numbers.Clear();
        }
    }
}
