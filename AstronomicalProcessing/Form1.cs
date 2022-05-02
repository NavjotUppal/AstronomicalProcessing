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
        int[] neutrino = new int[24];
        public Form1()
        {
            InitializeComponent();
          //  generateNeutrinoInteractions();
        }
        

        private void generateNeutrinoInteractions()
        {
           
            int max = 200;
            //int min = 1;
            Random random = new Random();
            for (int i = 0; i < neutrino.Length; i++)
            {
                neutrino[i] = random.Next(max);
                
            }
           // neutrino

        }

        public void btnGetInteractions_Click(object sender, EventArgs e)
        {
            generateNeutrinoInteractions();
            ListBoxInteractions.Items.Clear();
            foreach (int nu in neutrino)
            {
                ListBoxInteractions.Items.Add(nu.ToString() + " ");
            }

        }

        public void btnSortInteractions_Click(object sender, EventArgs e)
        {
            ListBoxSort.Items.Clear();
            if (ListBoxInteractions != null)
            {
                for(int i = 0;i<(neutrino.Length-1);i++)
                {
                    for(int j=0;j<(neutrino.Length-1);j++)
                    {
                        if(neutrino[j+1]<neutrino[j])
                        {
                            int temp = neutrino[j];
                            neutrino[j] = neutrino[j+1];
                            neutrino[j+1] = temp;

                        }
                    }
                }
                foreach (int nu in neutrino)
                {
                   
                    ListBoxSort.Items.Add(nu.ToString() + " ");
                }

            }
            else if(ListBoxInteractions == null)
            {
                MessageBox.Show("Get Interactions First.");
                return;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int midPoint;
            int lowerBound = 0;
            int upperBound = neutrino.Length-1;
            int target;
            bool flag = false;
            if (!(Int32.TryParse(TextBoxSearch.Text, out target)))
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            while (!flag) // Check “<” or “<=”
            {

                ShowArray(lowerBound,upperBound);
                // Find the mid-point

                midPoint = (lowerBound + upperBound) / 2;
                if(upperBound<lowerBound)
                {
                    MessageBox.Show("Error Occured");
                    flag = true;
                }
                // Pause with a messagebox
               // MessageBox.Show("Low:" + lowBound + " Mid:" + mid +
             //  " High:" + highBound);
               if (neutrino[midPoint] == target)
                {
                    // Target has been found
                    ListBoxResults.Items.Add("Found at position " + (midPoint+1));
                    return;
                }
                else if (neutrino[midPoint] >= target)
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
        // Method to display Array
        private void ShowArray(int low, int high)
        {
            ListBoxResults.Items.Clear();
          /* for (int i = low; i < high; i++)
            {
                ListBoxResults.Items.Add(neutrino[i]);
            }*/
        }

    }
}

