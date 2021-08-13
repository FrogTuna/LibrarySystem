using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Linq;

namespace Assignment_1
{
    class Member : iMember, IComparable<Member>
    {
        //fields
        private string lastName;
        private string firstName;
        private string mobileNum;
        private string Pin;
        private int countTool;
        private string[] myToolList;
        private int capacity;


        //constructor
        public Member(string lastName, string firstName, string mobileNum, string Pin) 
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.mobileNum = mobileNum;
            this.Pin = Pin;
            countTool = 0;
            capacity = 3;
            myToolList = new string[capacity];

        }

        //constructor
        public Member(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            countTool = 0;
            capacity = 3;
            myToolList = new string[capacity];

        }

        //constructor
        public Member(string lastName, string firstName, string Pin)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.Pin = Pin;
            countTool = 0;
            capacity = 3;
            myToolList = new string[capacity];

        }


        public string FirstName
        {
            get{ return firstName; }
            set{ firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string ContactNumber
        {
            get { return mobileNum; }
            set { mobileNum = value; }
        }
        public string PIN
        {
            get { return Pin; }
            set { Pin = value; }
        }


        //member borrowing tools (no more than 3)
        public string[] Tools
        {
            get {return myToolList;}
        }


        //member borrow a tool
        public void addTool(Tool tool)
        {  
            

            if(countTool == capacity)
            {
                Console.WriteLine("");
                Console.WriteLine("Each member is only allowed to borrow no more three items.");
            }
            else
            {
                if(myToolList.Length == 0)
                {
                    myToolList = new string[capacity];
                }
                myToolList[countTool] = tool.Name;
                countTool++;

            }

        }


        //veirfy member
        public int CompareTo(Member other)
        {

            if (this.lastName.CompareTo(other.LastName) < 0)
            {
                return -1;
            }
            else if (this.lastName.CompareTo(other.LastName) == 0 && this.firstName.CompareTo(other.FirstName) == 0 && this.Pin.CompareTo(other.PIN) == 0)
            {
                return this.Pin.CompareTo(other.PIN);
            }

            return 1;

        }

        //delete a borrowing tool
        public void deleteTool(Tool tool)
        {

            resizeArray(tool);  

        }


        //delete a borrowing tool and resize it
        private string[] resizeArray(Tool tool)
        {

            List<string> toolList = new List<string>();

            if (countTool == 0)
            {
                Console.WriteLine("You have borrow any item.");
            }
            else
            {
                if (myToolList[0] == tool.Name || myToolList[1] == tool.Name || myToolList[2] == tool.Name)
                {
                    for (int i = 0; i < myToolList.Length; i++)
                    {
                        toolList.Add(myToolList[i]);
                    }

                    //get delete tool name position in array
                    int postion = toolList.FindIndex(str => str.Contains(tool.Name));


                    toolList.RemoveAt(postion);

                    myToolList = toolList.ToArray();

                    //make sure array length is 3
                    if (myToolList.Length < 3)
                    {
                        Array.Resize<string>(ref myToolList, 3);
                    }
                    countTool--;

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You haven't borrow this item from this system.");
                }

                
            }

            return myToolList;
        }


        public override string ToString()
        {

            var output = String.Format("{0,-15}{1,15}{2,25}\n ", this.lastName, this.firstName,this.mobileNum);
            Console.WriteLine(output);
            return output;
           
        }
    }
}
