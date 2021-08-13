using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class Program
    {
        //fields
        private static ToolLirarySystem ToolLirarySystem;
        private static Tool tool;
        private static string read;
        private static Member member;
        private static int readCatorgoryNum;
        private static int readToolTypeNum;
        private static int num;


        //constructor
        public Program()
        {
            ToolLirarySystem = new ToolLirarySystem();
            MainMenu(read);
        }

        private static void MainMenu(string read)
        {
            //main menu
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("==============Main Menu=============");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Console.WriteLine("0. Exit");
            Console.WriteLine("====================================");
            Console.WriteLine(" ");
            Console.Write("Please make a selection (1-2, or 0 to exit) - ");
            read = Console.ReadLine();

            do
            {
                if(read != "1" && read != "2" && read != "0")
                {
                    Console.Write("Please input a correct index - ");
                    read = Console.ReadLine();

                }
                if (read == "1")
                {
                    Console.Clear();
                    StaffMenu(read);
                }
                else if (read == "2")
                {
                    Console.Clear();

                    VerifyMember();

                    //MemberMenu();
                }
                else if (read == "0")
                {
                    System.Environment.Exit(0);
                }

            }
            while (read != "1" && read != "2" && read != "0");          

        }

        private static void MemberMenu(string read)
        {
            //member menu
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===============Member Menu==============");
            Console.WriteLine("1. Display all the tools of a tool type");
            Console.WriteLine("2. Borrow a tool");
            Console.WriteLine("3. Return a tool");
            Console.WriteLine("4. List all the tools that I am renting");
            Console.WriteLine("5. Display top three (3) most frequentely rented tools");
            Console.WriteLine("0. Reuturn to main menu");
            Console.WriteLine("========================================");
            Console.WriteLine(" ");
            Console.Write("Please make a selection (1-5, or 0 to exit) - ");
            read = Console.ReadLine();



            do
            {
                if(read != "1" && read != "2" && read != "3" && read != "4" && read != "5" && read != "6" && read != "0")
                {

                    Console.Write("Please input a correct index, please try again- ");
                    read = Console.ReadLine();
                    MemberMenu(read);
                }
                else if (read == "1")
                {
                    Console.Clear();

                    readCater(read);
                    readToolType(read);
                    string name = "";
                    ToolLirarySystem.displayTools(name);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back member menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    MemberMenu(read);
                }
                else if (read == "2")
                {
                    Console.Clear();

                    BrorrowTool(read);
                    ToolLirarySystem.borrowTool(member, tool);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back member menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    MemberMenu(read);
                }
                else if (read == "3")
                {
                    Console.Clear();

                    ReturnTool(read);
                    ToolLirarySystem.returnTool(member, tool);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back member menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    MemberMenu(read);

                }
                else if (read == "4")
                {
                    Console.Clear();

                    ToolLirarySystem.displayBorrowingTools(member);

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back member menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    MemberMenu(read);

                }
                else if (read == "5")
                {
                    Console.Clear();

                    ToolLirarySystem.displayTopTHree();

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back member menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    MemberMenu(read);

                }
                else if (read == "0")
                {
                    MainMenu(read);

                }


            }
            while (read != "1" && read != "2" && read != "3" && read != "4" && read != "5" && read != "0");

        }

        private static void  StaffMenu(string read)
        {
            //staff menu

            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===============Staff Menu==============");
            Console.WriteLine("1. Add a new tool");
            Console.WriteLine("2. Add new pieces of an existing tool");
            Console.WriteLine("3. Remove some pieces of tool");
            Console.WriteLine("4. Register a new member");
            Console.WriteLine("5. Remove a memeber");
            Console.WriteLine("6. Find the contact number of a member");
            Console.WriteLine("0. Reuturn to main menu");
            Console.WriteLine("========================================");
            Console.WriteLine(" ");
            Console.Write("Please make a selection (1-6, or 0 to exit) -");
            read = Console.ReadLine();

            do
            {
                
                if(read != "1" && read != "2" && read != "3" && read != "4" && read != "5" && read != "6" && read != "0")
                {
                    Console.Write("Please enter correct funcational index - ");
                    read = Console.ReadLine();
                }
                if (read == "1")
                {
                    
                    ToolName(read);
                    readCater(read);
                    readToolType(read);
                    ToolLirarySystem.add(tool);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back staff menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    StaffMenu(read);


                }
                else if (read == "2")
                {
                    Console.Clear();
                    readCater(read);
                    readToolType(read);
                    ToolLirarySystem.add(tool, num);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back staff menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    StaffMenu(read);

                }
                else if (read == "3")
                {
                    Console.Clear();
                    readCater(read);
                    readToolType(read);
                    ToolLirarySystem.delete(tool, num);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back staff menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    StaffMenu(read);

                }
                else if (read == "4")
                {
                    Console.Clear();
                    CreateMember();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back staff menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    StaffMenu(read);

                }
                else if (read == "5")
                {
                    Console.Clear();
                    DeleteExistingMember();
                    ToolLirarySystem.delete(member);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back staff menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    StaffMenu(read);

                }
                else if (read == "6")
                {

                    Console.Clear();
                    readMobile(member);
                    //ToolLirarySystem.mobileNum(readMobile(member));
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Please press any key to back staff menu - ");
                    Console.ReadKey();
                    Console.Clear();
                    StaffMenu(read);

                }
                else if (read == "0")
                {
                    MainMenu(read);

                }
            }
            while (read != "1" && read != "2" && read != "3" && read != "4" && read != "5" && read != "6" && read != "0");


 

        }

        private static void VerifyMember()
        {
            do
            {
                //Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("=================================================");
                Console.WriteLine("              Verify Member          ");
                Console.WriteLine("=================================================");
                Console.WriteLine("");
                Console.Write("     Please input your memberID (Firstlastname+Lastname): ");
                string readName = Console.ReadLine();
                Console.Write("     Please input your Pin: ");
                string readPassWord = Console.ReadLine();


                if(readName == "0" && readPassWord == "0")
                {
                    Console.Clear();
                    MainMenu(read);
                }

                int check = 0;
                for (int i = 0; i < ToolLirarySystem.GetCollection.toArray().Length; i++)
                {
                    if(ToolLirarySystem.GetCollection.toArray()[i].FirstName + ToolLirarySystem.GetCollection.toArray()[i].LastName == readName && readPassWord == ToolLirarySystem.GetCollection.toArray()[i].PIN)
                    {
                        member = ToolLirarySystem.GetCollection.toArray()[i];
                        check = 1;
                    }
                }

                if (check == 1)
                {

                    Console.WriteLine("=========================================================");
                    Console.WriteLine("Verifying...");
                    Thread.Sleep(1000);
                    Console.WriteLine("");
                    Console.Write(readName+" is our member," + " press any key to get in member section - ");
                    Console.ReadKey();
                    Console.Clear();
                    MemberMenu(read);
                }
                else
                {
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("");
                    Console.WriteLine("This is no registered member in the system, please register first or check if you input a correct password and memberID with correct format.");
                    Console.WriteLine("");
                    Console.Write("Now please try again-");
                    if (Console.ReadLine() == "0")
                    {
                        Console.Clear();
                        StaffMenu(read);
                    }
                    //MainMenu(read);

                }
            }
            while (true);

        }

        private static void CreateMember()
        {
            do
            {
                Console.WriteLine("");
                Console.WriteLine("============================================================");
                Console.WriteLine("     Please fill a form below and finish the registeration");
                Console.WriteLine("============================================================");
                Console.WriteLine("");
                Console.Write("     Lastname: ");
                string readLastname = Console.ReadLine();
                Console.Write("     Firstname: ");
                string readFirstname = Console.ReadLine();
                Console.Write("     Mobile number: ");
                string readMobile = Console.ReadLine();
                Console.Write("     PIN: ");
                string readPin = Console.ReadLine();

                int convertMobile;
                int convertPin;


                if(readLastname =="0" && readFirstname =="0" && readMobile == "0" && readPin =="0")
                {
                    Console.Clear();
                    StaffMenu(read);
                }
                else if(readLastname == "" || readFirstname == "")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Make sure you input a correct format.");
                }

                else if(char.IsUpper(readLastname[0]) != true || char.IsUpper(readFirstname[0]) != true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Make sure you input a correct last name and first name format with capital letter.");

                }
                else
                {

                    if (readPin.Length != 4 || int.TryParse(readMobile, out convertMobile) != true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("The mobile number and Pin number only allow digit numbers.");
                        Console.WriteLine("");
                        Console.WriteLine("The Pin number allows 4 bit number, make sure the format correct.");
                    }
                    else if (readPin.Length == 4)
                    {

                        if (int.TryParse(readPin, out convertPin) == true)
                        {

                            member = new Member(readLastname, readFirstname, readMobile, readPin);

                            
                            ToolLirarySystem.add(member);

                            break;

                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("This is not a valid digit number, please try again.");
                        }
                    }

                }

            }
            while (true);
        }

        private static void  DeleteExistingMember()
        {
            Console.Clear();
            Console.WriteLine("==============================================================");
            Console.WriteLine("               Delete a member from the system");
            Console.WriteLine("==============================================================");
            Console.WriteLine("");
            Console.WriteLine("Please enter the index number of that member to finish delete ");
            Console.WriteLine("==============================================================");


        }

        //input a tool name
        private static Tool ToolName(string toolName)
        {

            Console.WriteLine("");
            Console.Write("   Please input your tool name: ");
            string readToolName = Console.ReadLine();
            tool = new Tool(readToolName, 0);
            return tool; 

        }

        private static void BrorrowTool(string toolName)
        {
            Console.Clear();
            readCater(read);
            readToolType(read);

        }

        private static void ReturnTool(string toolName)
        {
            Console.Clear();
            readCater(read);
            readToolType(read);
        }

        //index of category
        private static void readCater(string readCatory)
        {

            Console.Clear();
            Console.WriteLine("Library System - Display Tools By Tool Type");
            Console.WriteLine("===========================================");
            Console.WriteLine("     1. Gardening Tools");
            Console.WriteLine("     2. Flooring Tools");
            Console.WriteLine("     3. Fencing Tools");
            Console.WriteLine("     4. Measuring Tools");
            Console.WriteLine("     5. Cleaning Tools");
            Console.WriteLine("     6. Painting Tools");
            Console.WriteLine("     7. Electronic Tools");
            Console.WriteLine("     8. Electricity Tools");
            Console.WriteLine("     9. Automotive Tools");
            Console.WriteLine("     0. Return to main menu");
            Console.WriteLine("");
            Console.Write("  Select a tool category: ");

            do
            {

                readCatory = Console.ReadLine();


                if (readCatory == "0")
                {
                    MainMenu(read);
                }
                else if (readCatory == "1" || readCatory == "2" || readCatory == "3" || readCatory == "4" || readCatory == "5" || readCatory == "6" || readCatory == "7" || readCatory == "8" || readCatory == "9")
                {
                    try
                    {
                        readCatorgoryNum = Int32.Parse(readCatory);
                        ToolLirarySystem.ReadCategoryType = readCatorgoryNum;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.Write("Please input a correct catorgory index number - ");

                }

            }
            while (readCatory != "0" && readCatory != "1" && readCatory != "2" && readCatory != "3" && readCatory != "4" && readCatory != "5" && readCatory != "6" && readCatory != "7" && readCatory != "8" && readCatory != "9");
        }

        //index of tool type
        private static void readToolType(string readToolType)
        {


                //gardening 5
                if (readCatorgoryNum == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("     Tool Type List");
                    Console.WriteLine("========================================");
                    Console.WriteLine("     1. Line_Trimmers");
                    Console.WriteLine("     2. Lawn_Mowers");
                    Console.WriteLine("     3. Hand_tools_gardening");
                    Console.WriteLine("     4. Wheelbarrows");
                    Console.WriteLine("     5. Garden_Power_Tools");
                    Console.WriteLine("");
                    Console.Write("   Select a tool type： ");
                    //readToolType = Console.ReadLine();

                    do
                    {

                        readToolType = Console.ReadLine();

                        if (readToolType == "1" || readToolType == "2" || readToolType == "3" || readToolType == "4" || readToolType == "5")
                        {

                            try
                            {
                                readToolTypeNum = Int32.Parse(readToolType);
                                ToolLirarySystem.ReadToolType = readToolTypeNum;
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e);
                            }

                        }
                        else
                        {

                            Console.Write("Please input a correct Tool type index number -");

                        }
                    }
                    while (readToolType != "1" && readToolType != "2" && readToolType != "3" && readToolType != "4" && readToolType != "5");


                }

                //Flooring 6
                else if (readCatorgoryNum == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("     Tool Type List");
                    Console.WriteLine("========================================");
                    Console.WriteLine("     1. Scrapers");
                    Console.WriteLine("     2. loorLasers");
                    Console.WriteLine("     3. Floor_Levelling_Tools");
                    Console.WriteLine("     4. Floor_Levelling_Materials");
                    Console.WriteLine("     5. Floor_Hand_Tools");
                    Console.WriteLine("     6. Tiling_Tools");
                    Console.WriteLine("");
                    Console.Write("   Select a tool type： ");
                do
                {

                    readToolType = Console.ReadLine();

                    if (readToolType == "1" || readToolType == "2" || readToolType == "3" || readToolType == "4" || readToolType == "5" || readToolType == "6")
                    {

                        try
                        {
                            readToolTypeNum = Int32.Parse(readToolType);
                            ToolLirarySystem.ReadToolType = readToolTypeNum;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                        }

                        break;
                    }
                    else
                    {

                        Console.Write("Please input a correct Tool type index number -");

                    }
                }
                while (readToolType != "1" && readToolType != "2" && readToolType != "3" && readToolType != "4" && readToolType != "5" && readToolType == "6");

            }
                //Fencing 5
                else if (readCatorgoryNum == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("     Tool Type List");
                    Console.WriteLine("========================================");
                    Console.WriteLine("     1. Hand_tools_fencing");
                    Console.WriteLine("     2. Electric_Fencing");
                    Console.WriteLine("     3. Steel_Fencing_Tools");
                    Console.WriteLine("     4. Power_Tools");
                    Console.WriteLine("     5. Fencing_Accessories");
                    Console.WriteLine("");
                    Console.Write("   Select a tool type： ");
                do
                {

                    readToolType = Console.ReadLine();

                    if (readToolType == "1" || readToolType == "2" || readToolType == "3" || readToolType == "4" || readToolType == "5")
                    {

                        try
                        {
                            readToolTypeNum = Int32.Parse(readToolType);
                            ToolLirarySystem.ReadToolType = readToolTypeNum;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {

                        Console.Write("Please input a correct Tool type index number -");

                    }
                }
                while (readToolType != "1" && readToolType != "2" && readToolType != "3" && readToolType != "4" && readToolType != "5");

            }
                //Measuring 6
                else if (readCatorgoryNum == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("     Tool Type List");
                    Console.WriteLine("========================================");
                    Console.WriteLine("     1. Distance_Tools");
                    Console.WriteLine("     2. Laser_Measurer");
                    Console.WriteLine("     3. Measuring_Jugs");
                    Console.WriteLine("     4. Temperature_Humidity");
                    Console.WriteLine("     5. Levelling_Tools");
                    Console.WriteLine("     6. Markers");
                    Console.WriteLine("");
                    Console.Write("   Select a tool type： ");
                do
                {

                    readToolType = Console.ReadLine();

                    if (readToolType == "1" || readToolType == "2" || readToolType == "3" || readToolType == "4" || readToolType == "5" || readToolType == "6")
                    {

                        try
                        {
                            readToolTypeNum = Int32.Parse(readToolType);
                            ToolLirarySystem.ReadToolType = readToolTypeNum;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                        }

                        break;

                    }
                    else
                    {

                        Console.Write("Please input a correct Tool type index number -");

                    }
                }
                while (readToolType != "1" && readToolType != "2" && readToolType != "3" && readToolType != "4" && readToolType != "5" && readToolType == "6");

            }
                //Cleaning 6
                else if (readCatorgoryNum == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("     Tool Type List");
                    Console.WriteLine("========================================");
                    Console.WriteLine("     1. Draining");
                    Console.WriteLine("     2. Car_Cleaning");
                    Console.WriteLine("     3. Vacuum");
                    Console.WriteLine("     4. Pressure_Cleaners");
                    Console.WriteLine("     5. Pool_Cleaning");
                    Console.WriteLine("     6. Floor_Cleaning");
                    Console.WriteLine("");
                    Console.Write("   Select a tool type： ");
                do
                {

                    readToolType = Console.ReadLine();

                    if (readToolType == "1" || readToolType == "2" || readToolType == "3" || readToolType == "4" || readToolType == "5" || readToolType == "6")
                    {

                        try
                        {
                            readToolTypeNum = Int32.Parse(readToolType);
                            ToolLirarySystem.ReadToolType = readToolTypeNum;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                        }

                        break;
                    }
                    else
                    {

                        Console.Write("Please input a correct Tool type index number -");

                    }
                }
                while (readToolType != "1" && readToolType != "2" && readToolType != "3" && readToolType != "4" && readToolType != "5" && readToolType == "6");

                }

            //painting 6
            else if (readCatorgoryNum == 6)
            {
                Console.WriteLine("");
                Console.WriteLine("     Tool Type List");
                Console.WriteLine("========================================");
                Console.WriteLine("     1. Sanding_Tools");
                Console.WriteLine("     2. Brushes");
                Console.WriteLine("     3. Rollers");
                Console.WriteLine("     4. Paint_Removal_Tools");
                Console.WriteLine("     5. Paint_Scrapers");
                Console.WriteLine("     6. Sprayers");
                Console.WriteLine("");
                Console.Write("   Select a tool type： ");
                do
                {

                    readToolType = Console.ReadLine();

                    if (readToolType == "1" || readToolType == "2" || readToolType == "3" || readToolType == "4" || readToolType == "5" || readToolType == "6")
                    {

                        try
                        {
                            readToolTypeNum = Int32.Parse(readToolType);
                            ToolLirarySystem.ReadToolType = readToolTypeNum;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                        }

                        break;
                    }
                    else
                    {

                        Console.Write("Please input a correct Tool type index number -");

                    }
                }
                while (readToolType != "1" && readToolType != "2" && readToolType != "3" && readToolType != "4" && readToolType != "5" && readToolType == "6");


            }

            //electronic 5
            else if (readCatorgoryNum == 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("     Tool Type List");
                    Console.WriteLine("========================================");
                    Console.WriteLine("     1. Voltage_Tester");
                    Console.WriteLine("     2. Oscilloscopes");
                    Console.WriteLine("     3. Thermal_Imaging");
                    Console.WriteLine("     4. Data_Test_Tool");
                    Console.WriteLine("     5. Insulation_Testers");
                    Console.WriteLine("");
                    Console.Write("   Select a tool type： ");
                do
                {

                    readToolType = Console.ReadLine();

                    if (readToolType == "1" || readToolType == "2" || readToolType == "3" || readToolType == "4" || readToolType == "5")
                    {

                        try
                        {
                            readToolTypeNum = Int32.Parse(readToolType);
                            ToolLirarySystem.ReadToolType = readToolTypeNum;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {

                        Console.Write("Please input a correct Tool type index number -");

                    }
                }
                while (readToolType != "1" && readToolType != "2" && readToolType != "3" && readToolType != "4" && readToolType != "5");

            }
                //electricity 5
                else if (readCatorgoryNum == 8)
                {
                    Console.WriteLine("");
                    Console.WriteLine("     Tool Type List");
                    Console.WriteLine("========================================");
                    Console.WriteLine("     1. Test_Equipment");
                    Console.WriteLine("     2. Safety_Equipment");
                    Console.WriteLine("     3. Basic_Hand_Tools");
                    Console.WriteLine("     4. Circuit_Portection");
                    Console.WriteLine("     5. Cable_Tools");
                    Console.WriteLine("");
                    Console.Write("   Select a tool type： ");
                do
                {

                    readToolType = Console.ReadLine();

                    if (readToolType == "1" || readToolType == "2" || readToolType == "3" || readToolType == "4" || readToolType == "5")
                    {

                        try
                        {
                            readToolTypeNum = Int32.Parse(readToolType);
                            ToolLirarySystem.ReadToolType = readToolTypeNum;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {

                        Console.Write("Please input a correct Tool type index number -");

                    }
                }
                while (readToolType != "1" && readToolType != "2" && readToolType != "3" && readToolType != "4" && readToolType != "5");

            }
                //automative 6
                else if (readCatorgoryNum == 9)
                {
                    Console.WriteLine("");
                    Console.WriteLine("     Tool Type List");
                    Console.WriteLine("========================================");
                    Console.WriteLine("     1. Jacks");
                    Console.WriteLine("     2. Air_Compressors");
                    Console.WriteLine("     3. Battery_Tools");
                    Console.WriteLine("     4. Socket_Tools");
                    Console.WriteLine("     5. Barking");
                    Console.WriteLine("     6. Drivetrain");
                    Console.WriteLine("");
                    Console.Write("   Select a tool type：");
                do
                {

                    readToolType = Console.ReadLine();

                    if (readToolType == "1" || readToolType == "2" || readToolType == "3" || readToolType == "4" || readToolType == "5" || readToolType == "6")
                    {

                        try
                        {
                            readToolTypeNum = Int32.Parse(readToolType);
                            ToolLirarySystem.ReadToolType = readToolTypeNum;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                        }

                        break;
                    }
                    else
                    {

                        Console.Write("Please input a correct Tool type index number -");

                    }
                }
                while (readToolType != "1" && readToolType != "2" && readToolType != "3" && readToolType != "4" && readToolType != "5" && readToolType == "6");

            }

        }        

        //display the mobile number
        private static void readMobile(Member member)
        {
            do
            {
                Console.WriteLine("");
                Console.WriteLine("==============================================================================");
                Console.WriteLine("                          Display a member mobile number                                 ");
                Console.WriteLine("==============================================================================");
                Console.WriteLine("");

                var header = String.Format("{0, -15}{1,15}{2,15}", "Num", "Lastname", "Firstname");
                Console.WriteLine(header);

                for (int j = 0; j < ToolLirarySystem.GetCollection.toArray().Length; j++)
                {
                    var output = String.Format("{0,-15}{1,15}{2,15}", j + 1, ToolLirarySystem.GetCollection.toArray()[j].LastName, ToolLirarySystem.GetCollection.toArray()[j].FirstName);
                    Console.WriteLine(output);
                }
                Console.WriteLine("===============================================================================");
                Console.WriteLine("");
                Console.Write("Please input the index of member to check member's mobile number: ");

                read = Console.ReadLine();

                int readNum;

                try
                {
                    readNum = Int32.Parse(read);

                    if (readNum == 0)
                    {
                        Console.Clear();
                        StaffMenu(read);
                    }

                    if (readNum > ToolLirarySystem.GetCollection.toArray().Length)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Please input a correct index number");
                        Console.WriteLine("");
                    }
                    else if (readNum != 0 && readNum <= ToolLirarySystem.GetCollection.toArray().Length)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(ToolLirarySystem.GetCollection.toArray()[readNum - 1].LastName
                            + " " + ToolLirarySystem.GetCollection.toArray()[readNum - 1].FirstName + " 's mobile number is " +
                            ToolLirarySystem.GetCollection.toArray()[readNum - 1].ContactNumber);

                        break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("");
                    Console.WriteLine(e.Message);
                }   

            }
            while (true);

        }

        public static void Main(string[] args)
        {
            Program program = new Program();          
        }
    }
}
