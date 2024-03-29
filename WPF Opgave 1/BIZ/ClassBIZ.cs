﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Opgave_1
{
    class ClassBIZ
    {
        public ClassBIZ()
        {

        }
        public void Opgave12(ListBox listBox)
        {
            ClearList(listBox);

            int start = 4711;
            while (start < 4736)
            {                
                listBox.Items.Add(start.ToString());
                start++;
            }
        }
        public void Opgave13(ListBox listBox)
        {
            Random random = new Random();
            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000,1000001);
                listBox.Items.Add(randomTal.ToString());
            }
        }
        public void Opgave14(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();

            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt.Add(randomTal);
            }

            listInt.Sort();

            foreach(int tal in listInt)
            {
                listBox.Items.Add(tal.ToString());
            }
        }
        public void Opgave15(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt1 = new List<int>();
            List<int> listInt2 = new List<int>();

            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt1.Add(randomTal);
                listInt2.Add(randomTal);
            }

            listInt2.Sort();

            for (int i = 0; i < listInt1.Count; i++)
            {
                listBox.Items.Add($"{listInt1[i]} - {listInt2[i]}");
            }
        }


        public void Opgave16(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();

            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listBox.Items.Add(randomTal);
                listInt.Add(randomTal);
            }

            listBox.Items.Add("");
            listBox.Items.Add($"Gennemsnitsværdi : {GetAvarageValue(listInt)}");
        }
        private int GetAvarageValue(List<int> list)
        {
            int intRes = 0;
            int intCount = 0;

            foreach (int tal in list)
            {
                intRes += tal;
                intCount++;
            }

            intRes = intRes / intCount;

            return intRes;
        }
        public void Opgave17(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();
            ClearList(listBox);

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt.Add(randomTal);
            }
            listInt.Sort();
            foreach(int tal in listInt)
            {
                listBox.Items.Add($"{tal} - {GetAvarageValue(listInt)} = {tal - GetAvarageValue(listInt)}");
            }
        }
        public void Opgave18(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();

            ClearList(listBox);

            int intAvarage = 0;

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000,1000001);
                listInt.Add(randomTal);
            }

            intAvarage = GetAvarageValue(listInt);

            listInt.Sort();

            foreach (int tal in listInt)
            {
                listBox.Items.Add($"{tal} + {intAvarage} = {tal + intAvarage}");
            }
        }
        //Clear ListBox
        private void ClearList(ListBox listBox)
        {
            if (listBox.ItemsSource != null)
            {
                listBox.ItemsSource = null;
            }
            listBox.Items.Clear();
        }
        public void Opgave19(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();
            int intavarage = 0;

            ClearList(listBox);

            for(int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000,1000001);
                listInt.Add(randomTal);
            }

            intavarage = GetAvarageValue(listInt);

            listInt.Sort();

            foreach (int tal in listInt)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                if ((tal % 2) != 0)
                {
                    listBoxItem.Background = Brushes.AliceBlue;
                }
                else
                {
                    listBoxItem.Background = Brushes.HotPink;
                }
                listBoxItem.Content = $"{tal} - {intavarage} = {tal - intavarage}";
                listBox.Items.Add(listBoxItem);
            }
        }
    }
}
