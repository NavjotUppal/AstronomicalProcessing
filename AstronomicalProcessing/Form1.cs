using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalProcessing
{

    public partial class Form1 : Form
    {
        // Parallel array for Neutrino Interactions in chronological order Stu
        int[] neutrinoChrono = new int[24];
        // Parallel array for time periods in chronological order Stu
        string[] timePeriodChrono = new string[24];

        // Parallel array for neutrino interactions in ascending order Stu
        int[] neutrinoAscend = new int[24];
        // Parallel array for time periods in ascending order Stu
        string[] timePeriodAscend = new string[24];

        public Form1()
        {
            InitializeComponent();
        }

        // Method to sort the Neutrion Interactions in to ascending order Nav
        private void SortByNeutrinoInteraction()
        {
            for (int i = 0; i < (neutrinoAscend.Length - 1); i++)
            {
                for (int j = 0; j < (neutrinoAscend.Length - 1); j++)
                {
                    if (neutrinoAscend[j + 1] < neutrinoAscend[j])
                    {
                        int temp = neutrinoAscend[j];
                        neutrinoAscend[j] = neutrinoAscend[j + 1];
                        neutrinoAscend[j + 1] = temp;

                        // Repeating the same array sort function to the parallel timePeriod array Stu
                        string tempString = timePeriodAscend[j];
                        timePeriodAscend[j] = timePeriodAscend[j + 1];
                        timePeriodAscend[j + 1] = tempString;
                    }
                }
            }
        }

        // Method to update ListBox, takes ListBox as parameter Stu
        // listBox = which List Box to be updated
        // timePeriod = which Array to be added (chronological or ascending)
        // neutrino = which Array to be added (chronological or ascending)
        private void UpdateListBox(ListBox listBox, string[] timePeriod, int[] neutrino)
        {
            listBox.Items.Clear();
            for (int i = 0; i < 24; i++)
            {
                listBox.Items.Add(timePeriod[i] + " " + neutrino[i].ToString());
            }
        }
        // Method for generating array of neutrino interactions in chronological order Stu
        // Generates a parallel array of neutrino interactions to be sorted in ascending order later Stu
        private void GenerateNeutrinoInteractions()
        {
            int max = 100;
            int min = 10;
            Random random = new Random();
            for (int i = 0; i < 24; i++)
            {
                int temp = random.Next(min, max);
                neutrinoChrono[i] = temp;
                neutrinoAscend[i] = temp;                
            }
        }

        // Method for generating array  of time periods in chronological order Stu
        // Generates a parallel array of time periods to be sorted in ascending order later Stu
        private void GenerateTimePeriod()
        {
            int hour;
            string period;

            for (int i = 0; i < 24; i++)
            {
                hour = i % 12 + 1;
                if (i < 11 || i > 22)
                    period = "am";
                else
                    period = "pm";
                timePeriodChrono[i] = (hour + period);
                timePeriodAscend[i] = (hour + period);
            }
        }
        // Method for clicking btnGetInteractions Nav
        public void btnGetInteractions_Click(object sender, EventArgs e)
        {
            GenerateNeutrinoInteractions();
            GenerateTimePeriod();
            ListBoxSort.Items.Clear();
            UpdateListBox(ListBoxInteractions, timePeriodChrono, neutrinoChrono);
        }
        // Method for clicking btnSortInteractions Nav
        public void btnSortInteractions_Click(object sender, EventArgs e)
        {
            // Clearing ListBoxSort Nav
            ListBoxSort.Items.Clear();
            // Checking if ListBoxInteractions is showing an array Nav
            if (ListBoxInteractions.Items.Count != 0)
            {
                // Sorting the array Nav
                SortByNeutrinoInteraction();
                // Showing the array in ListBoxSort Stu
                UpdateListBox(ListBoxSort, timePeriodAscend, neutrinoAscend);
            }
            // If Neutrino Interactions have not been generated and shown, show message Nav
            else if(ListBoxInteractions == null)
            {
                MessageBox.Show("Get Interactions First.");
                return;
            }
        }
        // Method for clicking btnSearch, searching the array for a specified value Nav
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int midPoint;
            int lowerBound = 0;
            int upperBound = neutrinoChrono.Length - 1;
            int target;
            bool flag = false;
            if (!(Int32.TryParse(TextBoxSearch.Text, out target)))
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            while (!flag) // Check “<” or “<=” Nav
            {

                ListBoxResults.Items.Clear();
                // Find the mid-point Nav
                midPoint = (lowerBound + upperBound) / 2;
                if (upperBound < lowerBound)
                {
                    MessageBox.Show("Error Occured");
                    flag = true;
                }
                // Pause with a messagebox Nav
                // MessageBox.Show("Low:" + lowBound + " Mid:" + mid + Nav
                //  " High:" + highBound); Nav
                if (neutrinoAscend[midPoint] == target)
                {
                    // Target has been found Nav
                    ListBoxResults.Items.Add(timePeriodAscend[midPoint] + " " + neutrinoAscend[midPoint]);

                    // Checking if value after also equal to target Stu
                    int i = 1;
                    bool checkAfter = false;

                    while (!checkAfter)
                    {
                        if (midPoint + i < 24 && neutrinoAscend[midPoint + i] == target)
                        {
                            ListBoxResults.Items.Add(timePeriodAscend[midPoint + i] + " " + neutrinoAscend[midPoint + i]);
                            i++;
                        }
                        // If the check shows that the value after is not the same, checkAfter becomes true and ends the loop Stu
                        else
                            checkAfter = true;
                    }

                    i = 1;
                    bool checkBefore = false;

                    // Checking if value before also equal to target Stu
                    while (!checkBefore)
                    {
                        if (midPoint - i >= 0 && neutrinoAscend[midPoint - i] == target)
                        {
                            ListBoxResults.Items.Add(timePeriodAscend[midPoint - i] + " " + neutrinoAscend[midPoint - i]);
                            i++;
                        }
                        // If the check shows that the value before is not the same, checkBefore becomes false and ends the loop Stu
                        else
                            checkBefore = true;
                    }
                    MessageBox.Show("Search is successful");
                    return;
                }
                else if (neutrinoAscend[midPoint] >= target)
                {
                    upperBound = midPoint - 1;
                }
                else
                {
                    lowerBound = midPoint + 1;
                }
            }
            MessageBox.Show("Not Found, try again.");
        }

        // Method for editing the array Stu
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // Takes the string as the time from TextBoxTime Stu
            string time = TextBoxTime.Text;
            // Takes the string as the new value from TextBoxNewValue and converts it to an integer Stu
            int newValue = int.Parse(TextBoxNewValue.Text);
            for (int i = 0; i < 24; i++)
            {
                // Iterating through the time periods in chronological order Stu
                // Looking for the time that has been entered Stu
                if (timePeriodChrono[i] == time)
                {
                    // Editing to the new value Stu
                    neutrinoChrono[i] = newValue;
                    // Immediatelly updating the ListBoxInteractions Stu
                    UpdateListBox(ListBoxInteractions, timePeriodChrono, neutrinoChrono);
                    // Coping the arrays so that the Ascending arrays match the Chronological arrays Stu
                    Array.Copy(neutrinoChrono, neutrinoAscend, 24);
                    Array.Copy(timePeriodChrono, timePeriodAscend, 24);
                    
                    // If there are items showing in the ListBoxSort...
                    if(ListBoxSort.Items.Count != 0)
                    {
                        // it will sort new lists...
                        SortByNeutrinoInteraction();
                        // and update the ListBoxSort Stu
                        UpdateListBox(ListBoxSort, timePeriodAscend, neutrinoAscend);
                    }
                }    
            }
        }
        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            // Clearing all of the List Boxes, Text Boxes Stu, edited by Nav
            ListBoxInteractions.Items.Clear();
            ListBoxSort.Items.Clear();
            ListBoxResults.Items.Clear();
            ListBoxSearchResults.Items.Clear();
            TextBoxNewValue.Clear();
            TextBoxTime.Clear();
            TextBoxSearch.Clear();
            TextBox_SeqSearch.Clear();
            TextBoxMidExtreme.Clear();
            TextBoxMode.Clear();
            TextBoxAverage.Clear();
            TextBoxRange.Clear();
            // Resetting all of the arrays to their original values of 0 and null Stu
            for (int i = 0; i < 24; i++)
            {
                neutrinoChrono[i] = 0;
                neutrinoAscend[i] = 0;
                timePeriodChrono[i] = null;
                timePeriodAscend[i] = null;
            }
        }

        private void TextBoxTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonMode_Click(object sender, EventArgs e)
        {
            int frequency = 1;
            int maxFrequency = 1;
            string mode = null;

            for (int i = 0; i < 23; i++)
            {
                frequency = 1;
                while(i < 23 && neutrinoAscend[i] == neutrinoAscend[i + 1])
                {
                    frequency++;
                    i++;
                }
                if (frequency == maxFrequency)
                {
                    mode = mode + ", " + neutrinoAscend[i].ToString();
                }
                else if (frequency > maxFrequency)
                {
                    maxFrequency = frequency;
                    mode = neutrinoAscend[i].ToString();
                }
            }
            if (maxFrequency > 1)
            {
                TextBoxMode.Text = mode;
            }
            else
            {
                TextBoxMode.Text = "no mode";
            }
        }

        private void ButtonMidExtreme_Click(object sender, EventArgs e)
        {
            int range = neutrinoAscend[23] + neutrinoAscend[0];
            double midExtreme = range / 2;
            TextBoxMidExtreme.Text = midExtreme.ToString();
        }

        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int average = 0;
            for (int i = 0; i < 24; i++)
            {
                sum += neutrinoAscend[i];
            }
            average = sum / 24;
            TextBoxAverage.Text = average.ToString();
        }

        private void ButtonRange_Click(object sender, EventArgs e)
        {
            int range = neutrinoAscend[23] - neutrinoAscend[0];
            TextBoxRange.Text = range.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Button for sequentially searching neutrinoChrono Stu + Edited by Nav
        private void ButtonSequentialSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            int target;
            // Checking if the search input is an integer Stu
            if (!(Int32.TryParse(TextBox_SeqSearch.Text, out target)))
            {
                // Checking if the search box contains any input stu
                if (TextBox_SeqSearch.Text == "")
                {
                    // Empty search box error message Stu
                    MessageBox.Show("Search box is empty\nEnter an integer");
                }
                else
                {
                    // Non integer search value error message Stu
                    MessageBox.Show("You must enter an integer");
                    return;
                }
            }
            else
            {
                // Sequentially searching through neutrinoChrono Stu
                for (int i = 0; i < 24; i++)
                {
                    if (neutrinoChrono[i] == target)
                    {
                        found = true;
                        // Showing the search results Stu
                        ListBoxSearchResults.Items.Add(timePeriodChrono[i] + " " + neutrinoChrono[i]);
                    }
                }
                if (found)
                {
                    MessageBox.Show("Search is successful");
                }
                else
                {
                    // NeutrinoChrono does not contain the search value Stu
                    MessageBox.Show("Not Found, try again.");
                }
            }
        }
        // Tool tip functions (Nav)
        public void btnGetInteraction_MouseHover(object sender, EventArgs e)
        {
            toolTip_btngetInteractions.SetToolTip(btnGetInteractions, "Click to Generate Neutrino Interactions per hour");
        }
        public void ListBoxInteractions_MouseHover(object sender, EventArgs e)
        {
            toolTip_ListBoxInteractions.SetToolTip(ListBoxInteractions, "Shows the list of Neutrino Interactions per hour");
        }
        public void btnSortInteractions_MouseHover(object sender, EventArgs e)
        {
            toolTip_btnSortInteractions.SetToolTip(btnSortInteractions, "Click to Sort the Neutrino Interactions per hour");
        }
        public void ListBoxSortInteractions_MouseHover(object sender, EventArgs e)
        {
            toolTip_ListBoxSortInteractions.SetToolTip(ListBoxSort, "Shows the Sorted list of Neutrino Interactions per hour");
        }
        public void btnSerach_MouseHover(object sender, EventArgs e)
        {
            toolTip_btnBinarySearch.SetToolTip(btnSearch, "Click to Binary Search the data from the list");
        }
        public void TextBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip_txtBoxSearch.SetToolTip(TextBoxSearch, "Enter value to search from the list using Binary Search");
        }
        public void ListBoxResults_MouseHover(object sender, EventArgs e)
        {
           toolTip_ListBoxSearch.SetToolTip(ListBoxResults, "Shows Results of Binary search");
        }
        public void TextBoxSeqSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip_TextBoxSeqSearch.SetToolTip(TextBox_SeqSearch, "Enter value to search from the list using Sequential Search");
        }
        public void ListBoxSearchResults_MouseHover(object sender, EventArgs e)
        {
            toolTip_ListBoxSearchResults.SetToolTip(ListBoxSearchResults, "Shows Results of Sequential search");
        }

        public void btnSequentialSerach_MouseHover(object sender, EventArgs e)
        {
            toolTip_btnSequentialSearch.SetToolTip(ButtonSequentialSearch, "Click to Sequential Search the data from the list");
        }
        public void TextBoxTime_MouseHover(object sender, EventArgs e)
        {
            toolTip_TextBoxTime.SetToolTip(TextBoxTime, "Enter the time(_am/pm)");
        }
        public void TextBoxNewValue_MouseHover(object sender, EventArgs e)
        {
            toolTip_TextBoxNewValue.SetToolTip(TextBoxNewValue, "Enter the new value for Neutrino Interaction/hour");
        }
        public void ButtonEdit_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonEdit.SetToolTip(ButtonEdit, "Click to Edit the value");
        }
        public void ButtonMidExtreme_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonMidExtreme.SetToolTip(ButtonMidExtreme, "Click to Calculate Mid-Extreme");
        }
        public void TextBoxMidExtreme_MouseHover(object sender, EventArgs e)
        {
            toolTip_TextBoxMidExtreme.SetToolTip(TextBoxMidExtreme, "Mid-Extreme Value");
        }
        public void ButtonMode_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonMode.SetToolTip(ButtonMode, "Click to Calculate Mode");
        }
        public void TextBoxMode_MouseHover(object sender, EventArgs e)
        {
            toolTip_TextBoxMode.SetToolTip(TextBoxMode, "Mode Value");
        }
        public void ButtonRange_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonRange.SetToolTip(ButtonRange, "Click to Calculate Range");
        }
        public void TextBoxRange_MouseHover(object sender, EventArgs e)
        {
            toolTip_TextBoxRange.SetToolTip(TextBoxRange, "Range Value");
        }
        public void ButtonAverage_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonAverage.SetToolTip(ButtonAverage, "Click to Calculate Average");
        }
        public void TextBoxAverage_MouseHover(object sender, EventArgs e)
        {
            toolTip_TextBoxAverage.SetToolTip(TextBoxAverage, "Average Value");
        }
        public void ButtonClearAll_MouseHover(object sender, EventArgs e)
        {
            toolTip_ButtonClearAll.SetToolTip(ButtonClearAll, "Click to Clear All the data");
        }
    }
}

