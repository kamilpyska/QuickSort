using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuickSortBubbleSort
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            this.outputTBox.Text = "";
            ToolTip tooltip = new ToolTip();

            if (string.IsNullOrEmpty(inputTBox.Text))
            {
                tooltip.Show("Podaj liczby do posortowania.", this.inputTBox, 0, -20, 2000);
            }
            else if (quicksortCheckBox.Checked==false && bubbleSortCheckBox.Checked==false)
            {
                tooltip.Show("Wybierz algorytm sortowania.", this.quicksortCheckBox, 0, -20, 2000);
            }
            else
            {
                List<int> numbers = new List<int>();
                List<string> strings =this.inputTBox.Text.Trim().Split(' ').ToList();
                Stopwatch watch = new Stopwatch();

                if (quicksortCheckBox.Checked)
                {
                    watch.Start();
                    numbers = Quicksort(strings.ConvertAll(s => Int32.Parse(s)), 0, strings.Count() - 1);
                    watch.Stop();
                }
                else
                {
                    watch.Start();
                    numbers = BubbleSort(strings.ConvertAll(s => Int32.Parse(s)));
                    watch.Stop();
                }
                
                foreach (var number in numbers)
                {
                    this.outputTBox.Text += number + " ";
                }

                this.timeLabel.Text = watch.ElapsedMilliseconds.ToString() + " ms.";
            }
        }

        private List<int> BubbleSort(List<int> list)
        {
            bool changed = true;

            while (changed)
            {
                changed = false;
                for (int i = 0; i < list.Count-1; i++)
                {
                    if (list[i]>list[i+1])
                    {
                        list = swapPlaces(list, i, i + 1);
                        changed = true;
                    }
                }
            }
            return list;
        }

        private List<int> Quicksort(List<int> list, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int divideIndex = (startIndex + endIndex) / 2;
                int valueOfDividePoint = list[divideIndex];
                int actualPosition = startIndex;
                list = swapPlaces(list, divideIndex, endIndex);

                for (int i = startIndex; i < endIndex; i++)
                {
                    if (list[i] < valueOfDividePoint)
                    {
                        list = swapPlaces(list, i, actualPosition);
                        actualPosition += 1;
                    }
                }

                list = swapPlaces(list, actualPosition, endIndex);
                Quicksort(list, startIndex, actualPosition - 1);
                Quicksort(list, actualPosition + 1, endIndex);
            }
            return list;
        }

        private List<int> swapPlaces(List<int> list, int el1, int el2)
        {
            int tmp = list[el1];
            list[el1] = list[el2];
            list[el2] = tmp;
            return list;
        }

        private void inputTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)))
            {
                ToolTip tooltip = new ToolTip();
                tooltip.ToolTipTitle = "Niedozwolony znak.";
                tooltip.Show("Pole może zawierać tylko liczby.", this.inputTBox, 0, -20, 2000);
                e.Handled = true;
            }
        }

        private void outputTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.ToolTipTitle = "Niedozwolone działanie.";
            tooltip.Show("Pole służy tylko do wyświetlenia wyniku.", this.outputTBox, 0, -20, 2000);
            e.Handled = true;
        }

        private void quicksortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (quicksortCheckBox.Checked)
            {
                bubbleSortCheckBox.Checked = false;
            }
        }

        private void bubbleSortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bubbleSortCheckBox.Checked)
            {
                quicksortCheckBox.Checked = false;
            }
        }

        private void randomNumbersBtn_Click(object sender, EventArgs e)
        {
            this.inputTBox.Text = "";

            for (int i = 0; i < this.nUpDown.Value; i++)
            {
                this.inputTBox.Text += r.Next(0, 101).ToString() + " ";
            }
        }
    }
}
