using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class ToolCollection : iToolCollection
    {

        //fields
        private Tool[] toolList;
        private int countTools;
        private int capacity;
        private List<Tool> myToolList;


        //constructor
        public ToolCollection()
        {

            capacity = 30;
            toolList = new Tool[capacity];
            countTools = 0;
            myToolList = new List<Tool>();

        }

        //get quantity of a tool collection   
        public int Number
        {
            get { return countTools; }
        }


        //add new tool
        public void add(Tool tool)
        {

            toolList[countTools] = tool;
            countTools++;
            tool.Quantity++;
            tool.AvailableQuantity = tool.Quantity;

            if(countTools > capacity)
            {
                Console.WriteLine("the tool list is full");
            }

        }

        //delete a tool
        public void delete(Tool tool)
        {



            int check = 0;

            while (countTools > check && toolList[check].CompareTo(tool) != 0)
            {
                check++;

            }

            if (countTools == 0)
            {
                Console.WriteLine("There is no tool that can be deleted");
            }
            else
            {

                int i = 0;

                for (int j = check + 1; j < countTools; j++)
                {
                    toolList[j - 1] = toolList[j];
                    myToolList.Add(toolList[j - 1]);
                }

                //toolList = myToolList.ToArray();
                countTools--;
            }

        }


        //veirfy if the tool in this collection
        public bool search(Tool tool)
        {


                for (int i = 0; i < countTools; i++)
                {

                    if (toolList[i].CompareTo(tool) == 0)
                    {

                        return true;
                    }
                }   

            return false;
        }


        //veirfy if the tool in this collection and return it
        public Tool searchTool(Tool tool)
        {

                for (int i = 0; i < toolList.Length; i++)
                {

                    if (toolList[i].CompareTo(tool) == 0)
                    {

                        return toolList[i];
                    }
                }       

            return null;
        }


        //display tools usage state and return that toolList 
        public Tool[] ToArray()
        {
            Console.WriteLine("");
            Console.WriteLine("==================================================================================");
            var header = String.Format("{0,-25}{1,25}{2,15}{3,15}", "Tool", "Quantity", "AvaliableNum", "NoBorrowing");
            Console.WriteLine(header);
            for (int i = 0; i < countTools; i++)
            {
                if (toolList[i] != null)
                {

                    var output = String.Format("{0,-25}{1,25}{2,15}{3,15}\n ", toolList[i].Name, toolList[i].Quantity, toolList[i].AvailableQuantity, toolList[i].NoBorrowings);
                    Console.WriteLine(output);
                }
            }
            return toolList;
        }
    }
}
