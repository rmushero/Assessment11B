﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment11B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordBox.BackColor = Color.Red;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            verifyPassword();
            
        }

        private void searchReplaceButton_Click(object sender, EventArgs e)
        {
            List<int> positions = new List<int>();
            string searchString = searchBox.Text;
            string pastedText = pasteBin.Text;
            string pasteString = replaceBox.Text;
            string replaceText = replaceBox.Text;

            ClearSome();

            if (replaceBox.Text != "")
            {
                searchText(positions, pastedText, searchString);
                ReplaceText(positions, pastedText, replaceText, searchString);
            }
            else
            {
                searchText(positions, pastedText, searchString);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void verifyPassword()
        {
            string checkMe = passwordBox.Text;
            spaceCheck.Checked = false;
            uppercaseCheck.Checked = false;
            lowerCheck.Checked = false;
            numbersCheck.Checked = false;
            specialCheck.Checked = false;
            passwordBox.BackColor = Color.Red;


            if (checkMe != "")
            {
                foreach (char letter in checkMe)
                {
                    if (char.IsDigit(letter))
                    {
                        numbersCheck.Checked = true;
                    }
                    else if (char.IsUpper(letter))
                    {
                        uppercaseCheck.Checked = true;
                    }
                    else if (char.IsLower(letter))
                    {
                        lowerCheck.Checked = true;
                    }
                    else if (char.IsWhiteSpace(letter))
                    {
                        spaceCheck.Checked = true;
                    }
                    else if (checkMe.Contains('!') || checkMe.Contains('@') || checkMe.Contains('#') || checkMe.Contains('$') || checkMe.Contains('%'))
                    {
                        specialCheck.Checked = true;
                    }
                    else if (!char.IsDigit(letter))
                    {
                        numbersCheck.Checked = false;
                        passwordBox.BackColor = Color.Red;
                    }
                    else if (!char.IsUpper(letter))
                    {
                        uppercaseCheck.Checked = false;
                        passwordBox.BackColor = Color.Red;
                    }
                    else if (!char.IsLower(letter))
                    {
                        lowerCheck.Checked = false;
                        passwordBox.BackColor = Color.Red;
                    }
                    else if (!char.IsWhiteSpace(letter))
                    {
                        spaceCheck.Checked = false;
                        passwordBox.BackColor = Color.Red;
                    }
                    else if (!checkMe.Contains('!') || !checkMe.Contains('@') || !checkMe.Contains('#') || !checkMe.Contains('$') || !checkMe.Contains('%'))
                    {
                        specialCheck.Checked = false;
                        passwordBox.BackColor = Color.Red;
                    }
                }
            }
           
                if (specialCheck.Checked == true && spaceCheck.Checked == true && lowerCheck.Checked == true && uppercaseCheck.Checked == true && numbersCheck.Checked == true)
            {
                passwordBox.BackColor = Color.Green;
            }
            
        }

        private void searchText(List<int> positionList, string pastedText, string searchString)
        {          
            int i = 0;
            while ((i < pastedText.Length) && (i = pastedText.IndexOf(searchString, i)) != -1 )
            {
                positionList.Add(i);
                i += searchString.Length;
            }

            foreach (int position in positionList)
            {
                searchListBox.Items.Add(position);
            }
        }

        private void ReplaceText(List<int>positions, string pastedText, string replaceString, string searchString)
        {
            int end = searchString.Length;
           foreach (int pos in positions)
            {
               pastedText = pastedText.Remove(pos, end).Insert(pos, replaceString);
               
            }
            pasteBin.Text = pastedText;
           

        }

        private void ClearSome()
        {
            searchListBox.Items.Clear();
            
          
        }

        private void ClearAll()
        {

            searchListBox.Items.Clear();
            passwordBox.Text = "";
            spaceCheck.Checked = false;
            uppercaseCheck.Checked = false;
            lowerCheck.Checked = false;
            numbersCheck.Checked = false;
            specialCheck.Checked = false;
            passwordBox.BackColor = Color.Red;
            pasteBin.Text = "";
            searchBox.Text = "";
            replaceBox.Text = "";

        }
       
    }
}
