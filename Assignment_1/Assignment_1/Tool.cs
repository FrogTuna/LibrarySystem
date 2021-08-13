using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Assignment_1
{
    class Tool: iTool, IComparable<Tool>
    {

        private string name;
        private int quantity;
        private int avaliableQuatity;
        private int noborrowing;
        private MemberCollection holdingMembers;
        //private Tool privatetool;

        public Tool(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
            this.avaliableQuatity = quantity;
            this.noborrowing = 0;
            holdingMembers = new MemberCollection();

        }

        public Tool(string name)
        {
            this.name = name;
            Quantity = quantity;
            this.avaliableQuatity = quantity;
            this.noborrowing = 0;
            holdingMembers = new MemberCollection();
        }

        public string Name { get { return name; } set { name = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public int AvailableQuantity { get { return avaliableQuatity; } set { avaliableQuatity = value; } }
        public int NoBorrowings { get { return noborrowing; } set { noborrowing = value; } }


        //member who borrowed item from system 
        //record in thiscollection 
        public MemberCollection GetBorrowers
        {
            get { return holdingMembers; }
        }


        //a member borrows this tool 
        public void addBorrower(Member aMember)
        {


            if (avaliableQuatity == 0)
            {
                    Console.WriteLine("there is no more avaliable tool at this moment");                    
            }
            else
            {
                holdingMembers.add(aMember);
                avaliableQuatity--;
                noborrowing++;
            }          

        }

        //a member return this tool
        public void deleteBorrower(Member aMember)
        {
            

            holdingMembers.delete(aMember);
            avaliableQuatity++;

        }


        //output the tool detail and usage state
        public override string ToString()
        {
            var output = String.Format("{0,-25}{1,25}{2,15}{3,15}\n ", this.name, this.quantity, this.avaliableQuatity, this.noborrowing);
            Console.WriteLine(output);
            return output;

        }

        //compare the tool name
        public int CompareTo(Tool other)
        {

            if (this.name.CompareTo(other.Name) < 0)
            {
                return -1;
            }
            else if (this.name.CompareTo(other.Name) == 0)
            {
                return this.name.CompareTo(other.Name);
            }

            return 1;


        }
    }
}
