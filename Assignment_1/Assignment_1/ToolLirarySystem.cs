using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class ToolLirarySystem : iToolLibrarySystem
    {
        //fields
        private MemberCollection memberTree;
        private ToolCollection[] gardeningTool;
        private Tool gardeningTool_1_tool_1;
        private Tool gardeningTool_1_tool_2;
        private Tool gardeningTool_2_tool_1;
        private Tool gardeningTool_2_tool_2;
        private Tool gardeningTool_3_tool_1;
        private Tool gardeningTool_3_tool_2;
        private Tool gardeningTool_4_tool_1;
        private Tool gardeningTool_4_tool_2;
        private Tool gardeningTool_5_tool_1;
        private Tool gardeningTool_5_tool_2;
        private ToolCollection[] flooringTool;
        private Tool flooringTool_1_tool_1;
        private Tool flooringTool_1_tool_2;
        private Tool flooringTool_2_tool_1;
        private Tool flooringTool_2_tool_2;
        private Tool flooringTool_3_tool_1;
        private Tool flooringTool_3_tool_2;
        private Tool flooringTool_4_tool_1;
        private Tool flooringTool_4_tool_2;
        private Tool flooringTool_5_tool_1;
        private Tool flooringTool_5_tool_2;
        private ToolCollection[] fencingTool;
        private Tool fencingTool_1_tool_1;
        private Tool fencingTool_1_tool_2;
        private Tool fencingTool_2_tool_1;
        private Tool fencingTool_2_tool_2;
        private Tool fencingTool_3_tool_1;
        private Tool fencingTool_3_tool_2;
        private Tool fencingTool_4_tool_1;
        private Tool fencingTool_4_tool_2;
        private Tool fencingTool_5_tool_1;
        private Tool fencingTool_5_tool_2;
        private ToolCollection[] measuringTool;
        private Tool measuringTool_1_tool_1;
        private Tool measuringTool_1_tool_2;
        private Tool measuringTool_2_tool_1;
        private Tool measuringTool_2_tool_2;
        private Tool measuringTool_3_tool_1;
        private Tool measuringTool_3_tool_2;
        private Tool measuringTool_4_tool_1;
        private Tool measuringTool_4_tool_2;
        private Tool measuringTool_5_tool_1;
        private Tool measuringTool_5_tool_2;
        private ToolCollection[] cleaningTool;
        private Tool cleaningTool_1_tool_1;
        private Tool cleaningTool_1_tool_2;
        private Tool cleaningTool_2_tool_1;
        private Tool cleaningTool_2_tool_2;
        private Tool cleaningTool_3_tool_1;
        private Tool cleaningTool_3_tool_2;
        private Tool cleaningTool_4_tool_1;
        private Tool cleaningTool_4_tool_2;
        private Tool cleaningTool_5_tool_1;
        private Tool cleaningTool_5_tool_2;
        private ToolCollection[] paintingTool;
        private Tool paintingTool_1_tool_1;
        private Tool paintingTool_1_tool_2;
        private Tool paintingTool_2_tool_1;
        private Tool paintingTool_2_tool_2;
        private Tool paintingTool_3_tool_1;
        private Tool paintingTool_3_tool_2;
        private Tool paintingTool_4_tool_1;
        private Tool paintingTool_4_tool_2;
        private Tool paintingTool_5_tool_1;
        private Tool paintingTool_5_tool_2;
        private ToolCollection[] electronicTool;
        private Tool electronicTool_1_tool_1;
        private Tool electronicTool_1_tool_2;
        private Tool electronicTool_2_tool_1;
        private Tool electronicTool_2_tool_2;
        private Tool electronicTool_3_tool_1;
        private Tool electronicTool_3_tool_2;
        private Tool electronicTool_4_tool_1;
        private Tool electronicTool_4_tool_2;
        private Tool electronicTool_5_tool_1;
        private Tool electronicTool_5_tool_2;
        private ToolCollection[] electricityTool;
        private Tool electricityTool_1_tool_1;
        private Tool electricityTool_1_tool_2;
        private Tool electricityTool_2_tool_1;
        private Tool electricityTool_2_tool_2;
        private Tool electricityTool_3_tool_1;
        private Tool electricityTool_3_tool_2;
        private Tool electricityTool_4_tool_1;
        private Tool electricityTool_4_tool_2;
        private Tool electricityTool_5_tool_1;
        private Tool electricityTool_5_tool_2;
        private ToolCollection[] autometiveTool;
        private Tool autometiveTool_1_tool_1;
        private Tool autometiveTool_1_tool_2;
        private Tool autometiveTool_2_tool_1;
        private Tool autometiveTool_2_tool_2;
        private Tool autometiveTool_3_tool_1;
        private Tool autometiveTool_3_tool_2;
        private Tool autometiveTool_4_tool_1;
        private Tool autometiveTool_4_tool_2;
        private Tool autometiveTool_5_tool_1;
        private Tool autometiveTool_5_tool_2;
        private int readCatergoryType;
        private int readToolType;
        private List<Tool> borrowToolList;


        //Constructor
        public ToolLirarySystem()
        {
            memberTree = new MemberCollection();
            gardeningTool = new ToolCollection[5];
            paintingTool = new ToolCollection[6];
            flooringTool = new ToolCollection[6];
            fencingTool = new ToolCollection[5];
            measuringTool = new ToolCollection[6];
            cleaningTool = new ToolCollection[6];
            electronicTool = new ToolCollection[5];
            electricityTool = new ToolCollection[5];
            autometiveTool = new ToolCollection[6];
            borrowToolList = new List<Tool>();
            createToolCollectionInstance();
            createToolInstance();

        }


        //get index of category 
        public int ReadCategoryType
        {
            get { return readCatergoryType; }
            set { readCatergoryType = value; }
        }

        //get index of tool type
        public int ReadToolType
        {
             get { return readToolType; }
             set { readToolType = value; }

        }

        //return registered members that system recorded
        public MemberCollection GetCollection
        {
            get { return memberTree; }
        }

        //create instances of toolCollection;
        private void createToolCollectionInstance()
        {
            for(int i = 0; i < gardeningTool.Length; i++)
            {
                gardeningTool[i] = new ToolCollection();

            }
            for (int i = 0; i < paintingTool.Length; i++)
            {
                paintingTool[i] = new ToolCollection();

            }
            for (int i = 0; i < flooringTool.Length; i++)
            {
                flooringTool[i] = new ToolCollection();

            }
            for (int i = 0; i < fencingTool.Length; i++)
            {
                fencingTool[i] = new ToolCollection();

            }
            for (int i = 0; i < measuringTool.Length; i++)
            {
                measuringTool[i] = new ToolCollection();
            }
            for (int i = 0; i < cleaningTool.Length; i++)
            {
                cleaningTool[i] = new ToolCollection();
            }
            for (int i = 0; i < electronicTool.Length; i++)
            {
                electronicTool[i] = new ToolCollection();
            }
            for (int i = 0; i < electricityTool.Length; i++)
            {
                electricityTool[i] = new ToolCollection();
            }
            for (int i = 0; i < autometiveTool.Length; i++)
            {
                autometiveTool[i] = new ToolCollection();
            }

        }

        //create instances of tool;
        private void createToolInstance()
        {
            ///

            //gardening tool instances (two)
            gardeningTool_1_tool_1 = new Tool("hammer", 0);
            gardeningTool_1_tool_2 = new Tool("saw", 0);
            gardeningTool[0].add(gardeningTool_1_tool_1);
            gardeningTool[0].add(gardeningTool_1_tool_2);

            gardeningTool_2_tool_1 = new Tool("gardeningTool_2_tool_1", 0);
            gardeningTool_2_tool_2 = new Tool("gardeningTool_2_tool_2", 0);
            gardeningTool[1].add(gardeningTool_2_tool_1);
            gardeningTool[1].add(gardeningTool_2_tool_2);

            gardeningTool_3_tool_1 = new Tool("gardeningTool_3_tool_1", 0);
            gardeningTool_3_tool_2 = new Tool("gardeningTool_3_tool_2", 0);
            gardeningTool[2].add(gardeningTool_3_tool_1);
            gardeningTool[2].add(gardeningTool_3_tool_2);


            gardeningTool_4_tool_1 = new Tool("gardeningTool_4_tool_1", 0);
            gardeningTool_4_tool_2 = new Tool("gardeningTool_4_tool_2", 0);
            gardeningTool[3].add(gardeningTool_4_tool_1);
            gardeningTool[3].add(gardeningTool_4_tool_2);


            gardeningTool_5_tool_1 = new Tool("gardeningTool_5_tool_1", 0);
            gardeningTool_5_tool_2 = new Tool("gardeningTool_5_tool_2", 0);
            gardeningTool[4].add(gardeningTool_5_tool_1);
            gardeningTool[4].add(gardeningTool_5_tool_2);


            //painting tool instances (two)
            paintingTool_1_tool_1 = new Tool("paintingTool_1_tool_1", 0);
            paintingTool_1_tool_2 = new Tool("paintingTool_1_tool_2", 0);
            paintingTool[0].add(paintingTool_1_tool_1);
            paintingTool[0].add(paintingTool_1_tool_2);

            paintingTool_2_tool_1 = new Tool("paintingTool_2_tool_1", 0);
            paintingTool_2_tool_2 = new Tool("paintingTool_2_tool_2", 0);
            paintingTool[1].add(paintingTool_2_tool_1);
            paintingTool[1].add(paintingTool_2_tool_2);

            paintingTool_3_tool_1 = new Tool("paintingTool_3_tool_1", 0);
            paintingTool_3_tool_2 = new Tool("paintingTool_3_tool_2", 0);
            paintingTool[2].add(paintingTool_3_tool_1);
            paintingTool[2].add(paintingTool_3_tool_2);

            paintingTool_4_tool_1 = new Tool("paintingTool_4_tool_1", 0);
            paintingTool_4_tool_2 = new Tool("paintingTool_4_tool_2", 0);
            paintingTool[3].add(paintingTool_4_tool_1);
            paintingTool[3].add(paintingTool_4_tool_2);

            paintingTool_5_tool_1 = new Tool("paintingTool_5_tool_1", 0);
            paintingTool_5_tool_2 = new Tool("paintingTool_5_tool_2", 0);
            paintingTool[4].add(paintingTool_5_tool_1);
            paintingTool[4].add(paintingTool_5_tool_2);

            //flooring Two instance 
            flooringTool_1_tool_1 = new Tool("flooringTool_1_tool_1", 0);
            flooringTool_1_tool_2 = new Tool("flooringTool_1_tool_2", 0);
            flooringTool[0].add(flooringTool_1_tool_1);
            flooringTool[0].add(flooringTool_1_tool_2);

            flooringTool_2_tool_1 = new Tool("flooringTool_2_tool_1", 0);
            flooringTool_2_tool_2 = new Tool("flooringTool_2_tool_2", 0);
            flooringTool[1].add(flooringTool_2_tool_1);
            flooringTool[1].add(flooringTool_2_tool_2);

            flooringTool_3_tool_1 = new Tool("flooringTool_3_tool_1", 0);
            flooringTool_3_tool_2 = new Tool("flooringTool_3_tool_2", 0);
            flooringTool[2].add(flooringTool_3_tool_1);
            flooringTool[2].add(flooringTool_3_tool_2);

            flooringTool_4_tool_1 = new Tool("flooringTool_4_tool_1", 0);
            flooringTool_4_tool_2 = new Tool("flooringTool_4_tool_2", 0);
            flooringTool[3].add(flooringTool_4_tool_1);
            flooringTool[3].add(flooringTool_4_tool_2);

            flooringTool_5_tool_1 = new Tool("flooringTool_5_tool_1", 0);
            flooringTool_5_tool_2 = new Tool("flooringTool_5_tool_2", 0);
            flooringTool[4].add(flooringTool_5_tool_1);
            flooringTool[4].add(flooringTool_5_tool_2);

            //fencing 
            fencingTool_1_tool_1 = new Tool("fencingTool_1_tool_1", 0);
            fencingTool_1_tool_2 = new Tool("fencingTool_1_tool_2", 0);
            fencingTool[0].add(fencingTool_1_tool_1);
            fencingTool[0].add(fencingTool_1_tool_2);

            fencingTool_2_tool_1 = new Tool("fencingTool_2_tool_1", 0);
            fencingTool_2_tool_2 = new Tool("fencingTool_2_tool_2", 0);
            fencingTool[1].add(fencingTool_2_tool_1);
            fencingTool[1].add(fencingTool_2_tool_2);

            fencingTool_3_tool_1 = new Tool("fencingTool_3_tool_1", 0);
            fencingTool_3_tool_2 = new Tool("fencingTool_3_tool_2", 0);
            fencingTool[2].add(fencingTool_3_tool_1);
            fencingTool[2].add(fencingTool_3_tool_2);

            fencingTool_4_tool_1 = new Tool("fencingTool_4_tool_1", 0);
            fencingTool_4_tool_2 = new Tool("fencingTool_4_tool_2", 0);
            fencingTool[3].add(fencingTool_4_tool_1);
            fencingTool[3].add(fencingTool_4_tool_2);

            fencingTool_5_tool_1 = new Tool("fencingTool_5_tool_1", 0);
            fencingTool_5_tool_2 = new Tool("fencingTool_5_tool_2", 0);
            fencingTool[4].add(fencingTool_5_tool_1);
            fencingTool[4].add(fencingTool_5_tool_2);

            //measuring
            measuringTool_1_tool_1 = new Tool("measuringTool_1_tool_1", 0);
            measuringTool_1_tool_2 = new Tool("measuringTool_1_tool_2", 0);
            measuringTool[0].add(measuringTool_1_tool_1);
            measuringTool[0].add(measuringTool_1_tool_2);

            measuringTool_2_tool_1 = new Tool("measuringTool_2_tool_1", 0);
            measuringTool_2_tool_2 = new Tool("measuringTool_2_tool_2", 0);
            measuringTool[1].add(measuringTool_2_tool_1);
            measuringTool[1].add(measuringTool_2_tool_2);

            measuringTool_3_tool_1 = new Tool("measuringTool_3_tool_1", 0);
            measuringTool_3_tool_2 = new Tool("measuringTool_3_tool_2", 0);
            measuringTool[2].add(measuringTool_3_tool_1);
            measuringTool[2].add(measuringTool_3_tool_2);

            measuringTool_4_tool_1 = new Tool("measuringTool_4_tool_1", 0);
            measuringTool_4_tool_2 = new Tool("measuringTool_4_tool_2", 0);
            measuringTool[3].add(measuringTool_4_tool_1);
            measuringTool[3].add(measuringTool_4_tool_2);

            measuringTool_5_tool_1 = new Tool("measuringTool_5_tool_1", 0);
            measuringTool_5_tool_2 = new Tool("measuringTool_5_tool_2", 0);
            measuringTool[4].add(measuringTool_5_tool_1);
            measuringTool[4].add(measuringTool_5_tool_2);


            //cleaning
            cleaningTool_1_tool_1 = new Tool("cleaningTool_1_tool_1", 0);
            cleaningTool_1_tool_2 = new Tool("cleaningTool_1_tool_2", 0);
            cleaningTool[0].add(cleaningTool_1_tool_1);
            cleaningTool[0].add(cleaningTool_1_tool_2);

            cleaningTool_2_tool_1 = new Tool("cleaningTool_2_tool_1", 0);
            cleaningTool_2_tool_2 = new Tool("cleaningTool_2_tool_2", 0);
            cleaningTool[1].add(cleaningTool_2_tool_1);
            cleaningTool[1].add(cleaningTool_2_tool_2);

            cleaningTool_3_tool_1 = new Tool("cleaningTool_3_tool_1", 0);
            cleaningTool_3_tool_2 = new Tool("cleaningTool_3_tool_2", 0);
            cleaningTool[2].add(cleaningTool_3_tool_1);
            cleaningTool[2].add(cleaningTool_3_tool_2);

            cleaningTool_4_tool_1 = new Tool("cleaningTool_4_tool_1", 0);
            cleaningTool_4_tool_2 = new Tool("cleaningTool_4_tool_2", 0);
            cleaningTool[3].add(cleaningTool_4_tool_1);
            cleaningTool[3].add(cleaningTool_4_tool_2);

            cleaningTool_5_tool_1 = new Tool("cleaningTool_5_tool_1", 0);
            cleaningTool_5_tool_2 = new Tool("cleaningTool_5_tool_2", 0);
            cleaningTool[4].add(cleaningTool_5_tool_1);
            cleaningTool[4].add(cleaningTool_5_tool_2);

            //electricity
            electricityTool_1_tool_1 = new Tool("electricityTool_1_tool_1", 0);
            electricityTool_1_tool_2 = new Tool("electricityTool_1_tool_2", 0);
            electricityTool[0].add(electricityTool_1_tool_1);
            electricityTool[0].add(electricityTool_1_tool_2);

            electricityTool_2_tool_1 = new Tool("electricityTool_2_tool_1", 0);
            electricityTool_2_tool_2 = new Tool("electricityTool_2_tool_2", 0);
            electricityTool[1].add(electricityTool_2_tool_1);
            electricityTool[1].add(electricityTool_2_tool_2);

            electricityTool_3_tool_1 = new Tool("electricityTool_3_tool_1", 0);
            electricityTool_3_tool_2 = new Tool("electricityTool_3_tool_2", 0);
            electricityTool[2].add(electricityTool_3_tool_1);
            electricityTool[2].add(electricityTool_3_tool_2);

            electricityTool_4_tool_1 = new Tool("electricityTool_4_tool_1", 0);
            electricityTool_4_tool_2 = new Tool("electricityTool_4_tool_2", 0);
            electricityTool[3].add(electricityTool_4_tool_1);
            electricityTool[3].add(electricityTool_4_tool_2);

            electricityTool_5_tool_1 = new Tool("electricityTool_5_tool_1", 0);
            electricityTool_5_tool_2 = new Tool("electricityTool_5_tool_2", 0);
            electricityTool[4].add(electricityTool_5_tool_1);
            electricityTool[4].add(electricityTool_5_tool_2);

            //eletronic
            electronicTool_1_tool_1 = new Tool("electronicTool_1_tool_1", 0);
            electronicTool_1_tool_2 = new Tool("electronicTool_1_tool_2", 0);
            electronicTool[0].add(electronicTool_1_tool_1);
            electronicTool[0].add(electronicTool_1_tool_2);

            electronicTool_2_tool_1 = new Tool("electronicTool_2_tool_1", 0);
            electronicTool_2_tool_2 = new Tool("electronicTool_2_tool_2", 0);
            electronicTool[1].add(electronicTool_2_tool_1);
            electronicTool[1].add(electronicTool_2_tool_2);

            electronicTool_3_tool_1 = new Tool("electronicTool_3_tool_1", 0);
            electronicTool_3_tool_2 = new Tool("electronicTool_3_tool_2", 0);
            electronicTool[2].add(electronicTool_3_tool_1);
            electronicTool[2].add(electronicTool_3_tool_2);

            electronicTool_4_tool_1 = new Tool("electronicTool_4_tool_1", 0);
            electronicTool_4_tool_2 = new Tool("electronicTool_4_tool_2", 0);
            electronicTool[3].add(electronicTool_4_tool_1);
            electronicTool[3].add(electronicTool_4_tool_2);

            electronicTool_5_tool_1 = new Tool("electronicTool_5_tool_1", 0);
            electronicTool_5_tool_2 = new Tool("electronicTool_5_tool_2", 0);
            electronicTool[4].add(electronicTool_5_tool_1);
            electronicTool[4].add(electronicTool_5_tool_2);

            //autometive
            autometiveTool_1_tool_1 = new Tool("autometiveTool_1_tool_1", 0);
            autometiveTool_1_tool_2 = new Tool("autometiveTool_1_tool_2", 0);
            autometiveTool[0].add(autometiveTool_1_tool_1);
            autometiveTool[0].add(autometiveTool_1_tool_2);

            autometiveTool_2_tool_1 = new Tool("autometiveTool_2_tool_1", 0);
            autometiveTool_2_tool_2 = new Tool("autometiveTool_2_tool_2", 0);
            autometiveTool[1].add(autometiveTool_2_tool_1);
            autometiveTool[1].add(autometiveTool_2_tool_2);

            autometiveTool_3_tool_1 = new Tool("autometiveTool_3_tool_1", 0);
            autometiveTool_3_tool_2 = new Tool("autometiveTool_3_tool_2", 0);
            autometiveTool[2].add(autometiveTool_3_tool_1);
            autometiveTool[2].add(autometiveTool_3_tool_2);

            autometiveTool_4_tool_1 = new Tool("autometiveTool_4_tool_1", 0);
            autometiveTool_4_tool_2 = new Tool("autometiveTool_4_tool_2", 0);
            autometiveTool[3].add(autometiveTool_4_tool_1);
            autometiveTool[3].add(autometiveTool_4_tool_2);

            autometiveTool_5_tool_1 = new Tool("autometiveTool_5_tool_1", 0);
            autometiveTool_5_tool_2 = new Tool("autometiveTool_5_tool_2", 0);
            autometiveTool[4].add(autometiveTool_5_tool_1);
            autometiveTool[4].add(autometiveTool_5_tool_2);



        }

        //done (all) add tool type
        public void add(Tool readTool)
        {

            //gardening
            if (readCatergoryType - 1 == 0)
            {  
                if (readToolType - 1 == 0)
                {
                    gardeningAdd(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    gardeningAdd(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    gardeningAdd(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    gardeningAdd(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    gardeningAdd(readTool);
                }
            }

            //flooring
            else if (readCatergoryType - 1 == 1)
            {
                if (readToolType - 1 == 0)
                {
                    flooringAdd(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    flooringAdd(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    flooringAdd(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    flooringAdd(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    flooringAdd(readTool);
                }
                else if (readToolType - 1 == 5)
                {
                    flooringAdd(readTool);
                }
            }
            //fencing
            else if (readCatergoryType - 1 == 2)
            {
                if (readToolType - 1 == 0)
                {
                    fencingAdd(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    fencingAdd(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    fencingAdd(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    fencingAdd(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    fencingAdd(readTool);
                }

            }

            //measuring
            else if (readCatergoryType - 1 == 3)
            {
                if (readToolType - 1 == 0)
                {
                    measuringAdd(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    measuringAdd(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    measuringAdd(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    measuringAdd(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    measuringAdd(readTool);
                }
                else if (readToolType - 1 == 5)
                {
                    measuringAdd(readTool);
                }

            }
            //cleaning
            else if (readCatergoryType - 1 == 4)
            {
                if (readToolType - 1 == 0)
                {
                    cleaningAdd(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    cleaningAdd(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    cleaningAdd(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    cleaningAdd(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    cleaningAdd(readTool);
                }
                else if (readToolType - 1 == 5)
                {
                    cleaningAdd(readTool);
                }

            }

            //painting
            else if (readCatergoryType - 1 == 5)
            {

                if (readToolType - 1 == 0)
                {
                    paintingAdd(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    paintingAdd(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    paintingAdd(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    paintingAdd(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    paintingAdd(readTool);
                }
                else if (readToolType - 1 == 5)
                {
                    paintingAdd(readTool);
                }
            }
            //electronic
            else if (readCatergoryType - 1 == 6)
            {
                if (readToolType - 1 == 0)
                {
                    electronicAdd(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    electronicAdd(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    electronicAdd(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    electronicAdd(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    electronicAdd(readTool);
                }

            }
            //electrivity
            else if (readCatergoryType - 1 == 7)
            {
                if (readToolType - 1 == 0)
                {
                    electricityAdd(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    electricityAdd(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    electricityAdd(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    electricityAdd(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    electricityAdd(readTool);
                }

            }
            //automative
            else if (readCatergoryType - 1 == 8)
            {

                if (readToolType - 1 == 0)
                {
                    automativeAdd(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    automativeAdd(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    automativeAdd(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    automativeAdd(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    automativeAdd(readTool);
                }
                else if (readToolType - 1 == 5)
                {
                    automativeAdd(readTool);
                }

            }

        }

        /// <summary>
        /// if tool in the collection, invoke a warning. otherwise,
        /// add into toolcollection
        /// can not add two same tool name in the same collection
        /// </summary>
        /// <param name="readTool">verify tool</param>
        private void gardeningAdd(Tool readTool)
        {
            
            if (gardeningTool[readToolType - 1].search(readTool) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("====================================");
                Console.WriteLine("The item has already existed in the system, you can not add exsiting tool type");
            }
           
            else
            {
                gardeningTool[readToolType - 1].add(readTool);
                Console.WriteLine("");
                gardeningTool[readToolType - 1].ToArray();
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
        }
        private void flooringAdd(Tool readTool)
        {
            if (flooringTool[readToolType - 1].search(readTool) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("====================================");
                Console.WriteLine("The item has already existed in the system, you can not add exsiting tool type");
            }
            else
            {
                flooringTool[readToolType - 1].add(readTool);
                Console.WriteLine("");
                flooringTool[readToolType - 1].ToArray();
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }

        }
        private void fencingAdd(Tool readTool)
        {
            if (fencingTool[readToolType - 1].search(readTool) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("====================================");
                Console.WriteLine("The item has already existed in the system, you can not add exsiting tool type");
            }
            else
            {
                fencingTool[readToolType - 1].add(readTool);
                Console.WriteLine("");
                fencingTool[readToolType - 1].ToArray();
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
        }
        private void measuringAdd(Tool readTool)
        {
            if (measuringTool[readToolType - 1].search(readTool) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("====================================");
                Console.WriteLine("The item has already existed in the system, you can not add exsiting tool type");
            }
            else
            {
                measuringTool[readToolType - 1].add(readTool);
                Console.WriteLine("");
                measuringTool[readToolType - 1].ToArray();
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
        }
        private void cleaningAdd(Tool readTool)
        {
            if (cleaningTool[readToolType - 1].search(readTool) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("====================================");
                Console.WriteLine("The item has already existed in the system, you can not add exsiting tool type");
            }
            else
            {
                cleaningTool[readToolType - 1].add(readTool);
                Console.WriteLine("");
                cleaningTool[readToolType - 1].ToArray();
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
        }
        private void paintingAdd(Tool readTool)
        {
            if (paintingTool[readToolType - 1].search(readTool) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("====================================");
                Console.WriteLine("The item has already existed in the system, you can not add exsiting tool type");
            }
            else
            {
                paintingTool[readToolType - 1].add(readTool);
                Console.WriteLine("");
                paintingTool[readToolType - 1].ToArray();
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }

        }
        private void electronicAdd(Tool readTool)
        {
            if (electronicTool[readToolType - 1].search(readTool) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("====================================");
                Console.WriteLine("The item has already existed in the system, you can not add exsiting tool type");
            }
            else
            {
                electronicTool[readToolType - 1].add(readTool);
                Console.WriteLine("");
                electronicTool[readToolType - 1].ToArray();
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
        }
        private void electricityAdd(Tool readTool)
        {
            if (electricityTool[readToolType - 1].search(readTool) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("====================================");
                Console.WriteLine("The item has already existed in the system, you can not add exsiting tool type");
            }
            else
            {
                electricityTool[readToolType - 1].add(readTool);
                Console.WriteLine("");
                electricityTool[readToolType - 1].ToArray();
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
        }
        private void automativeAdd(Tool readTool)
        {
            if (autometiveTool[readToolType - 1].search(readTool) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("====================================");
                Console.WriteLine("The item has already existed in the system, you can not add exsiting tool type");
            }
            else
            {
                autometiveTool[readToolType - 1].add(readTool);
                Console.WriteLine("");
                autometiveTool[readToolType - 1].ToArray();
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
        }


        //done (all) add tool type quality
        public void add(Tool readTool, int num)
        {

            //gardening 5
            if (readCatergoryType - 1 == 0)
            {

                if (readToolType - 1 == 0)
                {
                    gardeningAddExist(readTool, num);
                }
                else if (readToolType - 1 == 1)
                {
                    gardeningAddExist(readTool, num);
                }
                else if (readToolType - 1 == 2)
                {
                    gardeningAddExist(readTool, num);
                }
                else if (readToolType - 1 == 3)
                {
                    gardeningAddExist(readTool, num);
                }
                else if (readToolType - 1 == 4)
                {
                    gardeningAddExist(readTool, num);
                }
            }

            //flooring 6
            else if (readCatergoryType - 1 == 1)
            {

                if (readToolType - 1 == 0)
                {
                    flooringAddExist(readTool, num);
                }
                else if (readToolType - 1 == 1)
                {
                    flooringAddExist(readTool, num);
                }
                else if (readToolType - 1 == 2)
                {
                    flooringAddExist(readTool, num);
                }
                else if (readToolType - 1 == 3)
                {
                    flooringAddExist(readTool, num);
                }
                else if (readToolType - 1 == 4)
                {
                    flooringAddExist(readTool, num);
                }
                else if (readToolType - 1 == 5)
                {
                    flooringAddExist(readTool, num);
                }
            }

            //fencing 5
            else if (readCatergoryType - 1 == 2)
            {

                if (readToolType - 1 == 0)
                {
                    fencingAddExist(readTool, num);
                }
                else if (readToolType - 1 == 1)
                {
                    fencingAddExist(readTool, num);
                }
                else if (readToolType - 1 == 2)
                {
                    fencingAddExist(readTool, num);
                }
                else if (readToolType - 1 == 3)
                {
                    fencingAddExist(readTool, num);
                }
                else if (readToolType - 1 == 4)
                {
                    fencingAddExist(readTool, num);
                }
            }

            //measuring 6 
            else if (readCatergoryType - 1 == 3)
            {

                if (readToolType - 1 == 0)
                {
                    measuringAddExist(readTool, num);
                }
                else if (readToolType - 1 == 1)
                {
                    measuringAddExist(readTool, num);
                }
                else if (readToolType - 1 == 2)
                {
                    measuringAddExist(readTool, num);
                }
                else if (readToolType - 1 == 3)
                {
                    measuringAddExist(readTool, num);
                }
                else if (readToolType - 1 == 4)
                {
                    measuringAddExist(readTool, num);
                }
                else if (readToolType - 1 == 5)
                {
                    measuringAddExist(readTool, num);
                }

            }

            //cleaning 6
            else if (readCatergoryType - 1 == 4)
            {

                if (readToolType - 1 == 0)
                {
                    cleaningAddExist(readTool, num);
                }
                else if (readToolType - 1 == 1)
                {
                    cleaningAddExist(readTool, num);
                }
                else if (readToolType - 1 == 2)
                {
                    cleaningAddExist(readTool, num);
                }
                else if (readToolType - 1 == 3)
                {
                    cleaningAddExist(readTool, num);
                }
                else if (readToolType - 1 == 4)
                {
                    cleaningAddExist(readTool, num);
                }
                else if (readToolType - 1 == 5)
                {
                    cleaningAddExist(readTool, num);
                }
            }

            //painting 6
            else if (readCatergoryType - 1 == 5)
            {

                if (readToolType - 1 == 0)
                {
                    paintingAddExist(readTool, num);
                }
                else if (readToolType - 1 == 1)
                {
                    paintingAddExist(readTool, num);
                }
                else if (readToolType - 1 == 2)
                {
                    paintingAddExist(readTool, num);
                }
                else if (readToolType - 1 == 3)
                {
                    paintingAddExist(readTool, num);
                }
                else if (readToolType - 1 == 4)
                {
                    paintingAddExist(readTool, num);
                }
                else if (readToolType - 1 == 5)
                {
                    paintingAddExist(readTool, num);
                }
            }

            //electronic 5
            else if (readCatergoryType - 1 == 6)
            {

                if (readToolType - 1 == 0)
                {
                    electronicAddExist(readTool, num);
                }
                else if (readToolType - 1 == 1)
                {
                    electronicAddExist(readTool, num);
                }
                else if (readToolType - 1 == 2)
                {
                    electronicAddExist(readTool, num);
                }
                else if (readToolType - 1 == 3)
                {
                    electronicAddExist(readTool, num);
                }
                else if (readToolType - 1 == 4)
                {
                    electronicAddExist(readTool, num);
                }
            }

            //electricity 5
            else if (readCatergoryType - 1 == 7)
            {

                if (readToolType - 1 == 0)
                {
                    electricityAddExist(readTool, num);
                }
                else if (readToolType - 1 == 1)
                {
                    electricityAddExist(readTool, num);
                }
                else if (readToolType - 1 == 2)
                {
                    electricityAddExist(readTool, num);
                }
                else if (readToolType - 1 == 3)
                {
                    electricityAddExist(readTool, num);
                }
                else if (readToolType - 1 == 4)
                {
                    electricityAddExist(readTool, num);
                }
            }

            //automative 6
            else if (readCatergoryType - 1 == 8)
            {

                if (readToolType - 1 == 0)
                {
                    autometiveAddExist(readTool, num);
                }
                else if (readToolType - 1 == 1)
                {
                    autometiveAddExist(readTool, num);
                }
                else if (readToolType - 1 == 2)
                {
                    autometiveAddExist(readTool, num);
                }
                else if (readToolType - 1 == 3)
                {
                    autometiveAddExist(readTool, num);
                }
                else if (readToolType - 1 == 4)
                {
                    autometiveAddExist(readTool, num);
                }
                else if (readToolType - 1 == 5)
                {
                    autometiveAddExist(readTool, num);
                }
            }
        }

        /// <summary>
        /// increasing the existing tool quantity
        /// check if tool in the list, otherwise invoke a warning
        /// </summary>
        /// <param name="readTool">verify tool</param>
        /// <param name="num">quantity that user want add</param>
        private void gardeningAddExist(Tool readTool, int num)
        {
            gardeningTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.Write("Please input the tool name - ");
            string readToolName = Console.ReadLine();
            Console.Write("Please input the quatity of adding - ");
            string readNum = Console.ReadLine();
            try
            {
                num = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(readToolName, 0);

            if (gardeningTool[readToolType - 1].search(readTool) == true)
            {
                gardeningTool[readToolType - 1].searchTool(readTool).Quantity = gardeningTool[readToolType - 1].searchTool(readTool).Quantity + num;
                gardeningTool[readToolType - 1].searchTool(readTool).AvailableQuantity = gardeningTool[readToolType - 1].searchTool(readTool).AvailableQuantity +num;
                Console.WriteLine("");
                Console.WriteLine("You successfully added " + readTool.Name + " quanlity to the tool library system.");
                Console.WriteLine("");
                gardeningTool[readToolType - 1].ToArray();

            }
            else
            {
                Console.WriteLine("");
                Console.Write("There is no correct tool name in this system, please press any key and back to staff menu and resart.");
            }

        }
        private void flooringAddExist(Tool readTool, int num)
        {

            flooringTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.Write("Please input the tool name - ");
            string readToolName = Console.ReadLine();
            Console.Write("Please input the quatity of adding - ");
            string readNum = Console.ReadLine();
            try
            {
                num = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(readToolName, 0);
            if (flooringTool[readToolType - 1].search(readTool) == true)
            {

                flooringTool[readToolType - 1].searchTool(readTool).Quantity = flooringTool[readToolType - 1].searchTool(readTool).Quantity + num;
                flooringTool[readToolType - 1].searchTool(readTool).AvailableQuantity = flooringTool[readToolType - 1].searchTool(readTool).AvailableQuantity + num;
                Console.WriteLine("");
                Console.WriteLine("You successfully added " + readTool.Name + " quanlity to the tool library system.");
                Console.WriteLine("");
                flooringTool[readToolType - 1].ToArray();

            }
            else
            {
                Console.WriteLine("");
                Console.Write("There is no correct tool name in this system, please press any key and back to staff menu and resart.");

            }

        }
        private void fencingAddExist(Tool readTool, int num)
        {

            fencingTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.Write("Please input the tool name - ");
            string readToolName = Console.ReadLine();
            Console.Write("Please input the quatity of adding - ");
            string readNum = Console.ReadLine();
            try
            {
                num = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(readToolName, 0);
            if (fencingTool[readToolType - 1].search(readTool) == true)
            {

                fencingTool[readToolType - 1].searchTool(readTool).Quantity = fencingTool[readToolType - 1].searchTool(readTool).Quantity + num;
                fencingTool[readToolType - 1].searchTool(readTool).AvailableQuantity = fencingTool[readToolType - 1].searchTool(readTool).AvailableQuantity + num;
                Console.WriteLine("");
                Console.WriteLine("You successfully added " + readTool.Name + " quanlity to the tool library system.");
                Console.WriteLine("");
                fencingTool[readToolType - 1].ToArray();

            }
            else
            {
                Console.WriteLine("");
                Console.Write("There is no correct tool name in this system, please press any key and back to staff menu and resart.");

            }

        }
        private void measuringAddExist(Tool readTool, int num)
        {

            measuringTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.Write("Please input the tool name - ");
            string readToolName = Console.ReadLine();
            Console.Write("Please input the quatity of adding - ");
            string readNum = Console.ReadLine();
            try
            {
                num = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(readToolName, 0);
            if (measuringTool[readToolType - 1].search(readTool) == true)
            {

                measuringTool[readToolType - 1].searchTool(readTool).Quantity = measuringTool[readToolType - 1].searchTool(readTool).Quantity + num;
                measuringTool[readToolType - 1].searchTool(readTool).AvailableQuantity = measuringTool[readToolType - 1].searchTool(readTool).AvailableQuantity + num;
                Console.WriteLine("");
                Console.WriteLine("You successfully added " + readTool.Name + " quanlity to the tool library system.");
                Console.WriteLine("");
                measuringTool[readToolType - 1].ToArray();

            }
            else
            {
                Console.WriteLine("");
                Console.Write("There is no correct tool name in this system, please press any key and back to staff menu and resart.");

            }

        }
        private void cleaningAddExist(Tool readTool, int num)
        {

            cleaningTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.Write("Please input the tool name - ");
            string readToolName = Console.ReadLine();
            Console.Write("Please input the quatity of adding - ");
            string readNum = Console.ReadLine();
            try
            {
                num = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(readToolName, 0);
            if (cleaningTool[readToolType - 1].search(readTool) == true)
            {

                cleaningTool[readToolType - 1].searchTool(readTool).Quantity = cleaningTool[readToolType - 1].searchTool(readTool).Quantity + num;
                cleaningTool[readToolType - 1].searchTool(readTool).AvailableQuantity = cleaningTool[readToolType - 1].searchTool(readTool).AvailableQuantity + num;
                Console.WriteLine("");
                Console.WriteLine("You successfully added " + readTool.Name + " quanlity to the tool library system.");
                Console.WriteLine("");
                cleaningTool[readToolType - 1].ToArray();

            }
            else
            {
                Console.WriteLine("");
                Console.Write("There is no correct tool name in this system, please press any key and back to staff menu and resart.");

            }


        }
        private void paintingAddExist(Tool readTool, int num)
        {

            paintingTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.Write("Please input the tool name - ");
            string readToolName = Console.ReadLine();
            Console.Write("Please input the quatity of adding - ");
            string readNum = Console.ReadLine();
            try
            {
                num = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(readToolName, 0);
            if (paintingTool[readToolType - 1].search(readTool) == true)
            {

                paintingTool[readToolType - 1].searchTool(readTool).Quantity = paintingTool[readToolType - 1].searchTool(readTool).Quantity + num;
                paintingTool[readToolType - 1].searchTool(readTool).AvailableQuantity = paintingTool[readToolType - 1].searchTool(readTool).AvailableQuantity + num;
                Console.WriteLine("");
                Console.WriteLine("You sucessfully added " + readTool.Name + " quanlity to the tool library system.");
                Console.WriteLine("");
                paintingTool[readToolType - 1].ToArray();

            }
            else
            {
                Console.WriteLine("");
                Console.Write("There is no correct tool name in this system, please press any key and back to staff menu and resart.");

            }

        }
        private void electronicAddExist(Tool readTool, int num)
        {

            electronicTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.Write("Please input the tool name - ");
            string readToolName = Console.ReadLine();
            Console.Write("Please input the quatity of adding - ");
            string readNum = Console.ReadLine();
            try
            {
                num = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(readToolName, 0);
            if (electronicTool[readToolType - 1].search(readTool) == true)
            {

                electronicTool[readToolType - 1].searchTool(readTool).Quantity = electronicTool[readToolType - 1].searchTool(readTool).Quantity + num;
                electronicTool[readToolType - 1].searchTool(readTool).AvailableQuantity = electronicTool[readToolType - 1].searchTool(readTool).AvailableQuantity + num;
                Console.WriteLine("");
                Console.WriteLine("You successfully added " + readTool.Name + " quanlity to the tool library system");
                Console.WriteLine("");
                electronicTool[readToolType - 1].ToArray();

            }
            else
            {
                Console.WriteLine("");
                Console.Write("There is no correct tool name in this system, please press any key and back to staff menu and resart.");

            }


        }
        private void electricityAddExist(Tool readTool, int num)
        {

            electricityTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.Write("Please input the tool name - ");
            string readToolName = Console.ReadLine();
            Console.Write("Please input the quatity of adding - ");
            string readNum = Console.ReadLine();
            try
            {
                num = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(readToolName, 0);
            if (electricityTool[readToolType - 1].search(readTool) == true)
            {

                electricityTool[readToolType - 1].searchTool(readTool).Quantity = electricityTool[readToolType - 1].searchTool(readTool).Quantity + num;
                electricityTool[readToolType - 1].searchTool(readTool).AvailableQuantity = electricityTool[readToolType - 1].searchTool(readTool).AvailableQuantity + num ;
                Console.WriteLine("");
                Console.WriteLine("You successfully added " + readTool.Name + " quanlity to the tool library system");
                Console.WriteLine("");
                electricityTool[readToolType - 1].ToArray();

            }
            else
            {
                Console.WriteLine("");
                Console.Write("There is no correct tool name in this system, please press any key and back to staff menu and resart.");

            }

        }
        private void autometiveAddExist(Tool readTool, int num)
        {

            autometiveTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.Write("Please input the tool name - ");
            string readToolName = Console.ReadLine();
            Console.Write("Please input the quatity of adding - ");
            string readNum = Console.ReadLine();
            try
            {
                num = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(readToolName, 0);
            if (autometiveTool[readToolType - 1].search(readTool) == true)
            {

                autometiveTool[readToolType - 1].searchTool(readTool).Quantity = autometiveTool[readToolType - 1].searchTool(readTool).Quantity + num;
                autometiveTool[readToolType - 1].searchTool(readTool).AvailableQuantity = autometiveTool[readToolType - 1].searchTool(readTool).AvailableQuantity + num ;
                Console.WriteLine("");
                Console.WriteLine("You successfully added " + readTool.Name + " quanlity to the tool library system");
                Console.WriteLine("");
                autometiveTool[readToolType - 1].ToArray();

            }
            else
            {
                Console.WriteLine("");
                Console.Write("There is no correct tool name in this system, please press any key and back to staff menu and resart.");

            }

        }

        //done (all) add a member
        public void add(Member aMember)
        {

            if (memberTree.search(aMember) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("===========================================================");
                Console.WriteLine("");
                Console.WriteLine("This member name has already exsit in our system, please try again.");
            }
            else
            {
                memberTree.add(aMember);
                Console.WriteLine("");
                Console.WriteLine("==============================================================");
                Console.WriteLine("");
                Console.WriteLine("Congratulation, " + aMember.LastName + " " + aMember.FirstName + " successfully registred an account for this system.");
                Console.WriteLine("");
            }

        }

        //done (all) delete a member
        public void delete(Member aMember)
        {
            do
            {

                var header = String.Format("{0, -10}{1,-20}{2,15}{3,15}", "Num", "Lastname", "Firstname", "MobileNum");
                Console.WriteLine(header);
                for (int i = 0; i < memberTree.toArray().Length; i++)
                {
                    var output = String.Format("{0,-10}{1,-20}{2,15}{3,15}", i + 1, memberTree.toArray()[i].LastName, memberTree.toArray()[i].FirstName, memberTree.toArray()[i].ContactNumber);
                    Console.WriteLine(output);
                }

                Console.WriteLine("==================================================================");
                Console.WriteLine("");
                Console.Write("Please input the index number to delete a member -");
                string read = Console.ReadLine();
                try
                {
                    int readNum = Int32.Parse(read);
                    if (readNum == 0)
                    {
                        break;
                    }
                    else if(readNum > memberTree.toArray().Length)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Make sure you input a correct index number");
                        Console.WriteLine("");
                        
                    }
                    else if(memberTree.toArray()[readNum - 1].Tools[0] != null)
                    {
                            Console.WriteLine("");
                            Console.WriteLine("This member couldn't be deleted, becasue this member holds one of tools in this system, please return first or press zero (0) back to staffmenu -");
                            Console.WriteLine("");
                    }   
                    else
                    {
                        memberTree.delete(memberTree.toArray()[readNum - 1]);

                        Console.WriteLine("");
                        Console.WriteLine("========================================================================");
                        var header2 = String.Format("{0, -10}{1,-20}{2,15}{3,15}", "Num", "Lastname", "Firstname", "MobileNum");
                        Console.WriteLine(header2);
                        for (int i = 0; i < memberTree.toArray().Length; i++)
                        {
                            var output = String.Format("{0,-10}{1,-20}{2,15}{3,15}", i + 1, memberTree.toArray()[i].LastName, memberTree.toArray()[i].FirstName, memberTree.toArray()[i].ContactNumber);
                            Console.WriteLine(output);
                        }

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("The member successfully deleted from the system.");
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("");
                }

            }
            while (true);
        }

        //done (all) borrow a tool
        public void borrowTool(Member aMember, Tool tool)
        {

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("          Please select and borrow one of tool by inputting tool name");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("");

            //gardening Tool 5
            if (readCatergoryType - 1 == 0)
            {

                if (readToolType - 1 == 0)
                {
                    gardeningBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    gardeningBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    gardeningBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    gardeningBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    gardeningBorrow(aMember, tool);
                }
            }

            //flooring 6
            else if (readCatergoryType - 1 == 1)
            {

                if (readToolType - 1 == 0)
                {
                    flooringBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    flooringBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    flooringBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    flooringBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    flooringBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 5)
                {
                    flooringBorrow(aMember, tool);
                }
            }
            //fencing 5
            else if (readCatergoryType - 1 == 2)
            {

                if (readToolType - 1 == 0)
                {
                    fencingBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    fencingBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    fencingBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    fencingBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    fencingBorrow(aMember, tool);
                }
            }
            //measurung 6
            else if (readCatergoryType - 1 == 3)
            {

                if (readToolType - 1 == 0)
                {
                    measuringBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    measuringBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    measuringBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    measuringBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    measuringBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 5)
                {
                    measuringBorrow(aMember, tool);
                }
            }
            //cleaning 6
            else if (readCatergoryType - 1 == 4)
            {

                if (readToolType - 1 == 0)
                {
                    cleaningBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    cleaningBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    cleaningBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    cleaningBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    cleaningBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 5)
                {
                    cleaningBorrow(aMember, tool);
                }
            }
            //painting tool 6
            else if (readCatergoryType - 1 == 5)
            {

                if (readToolType - 1 == 0)
                {
                    paintingBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    paintingBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    paintingBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    paintingBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    paintingBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 5)
                {
                    paintingBorrow(aMember, tool);
                }
            }
            //electronic 5
            else if (readCatergoryType - 1 == 6)
            {

                if (readToolType - 1 == 0)
                {
                    electronicBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    electronicBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    electronicBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    electronicBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    electronicBorrow(aMember, tool);
                }
            }

            //electricity 5 
            else if (readCatergoryType - 1 == 7)
            {

                if (readToolType - 1 == 0)
                {
                    electricityBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    electricityBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    electricityBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    electricityBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    electricityBorrow(aMember, tool);
                }
            }

            //automative 6
            else if (readCatergoryType - 1 == 8)
            {

                if (readToolType - 1 == 0)
                {
                    automativeBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    automativeBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    automativeBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    automativeBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    automativeBorrow(aMember, tool);
                }
                else if (readToolType - 1 == 5)
                {
                    automativeBorrow(aMember, tool);
                }
            }

        }

        /// <summary>
        /// borrow specific tool from system and give it to the login member
        /// </summary>
        /// <param name="aMember">registred member and login</param>
        /// <param name="tool">specific tool</param>
        private void gardeningBorrow(Member aMember, Tool tool)
        {

            gardeningTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0; 

            for(int i = 0; i < aMember.Tools.Length;i++)
            {
                if(aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user have borrowed more than 3 quantity of tool
            if (count < 3)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to borrow - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in the list, give it to member
                if (gardeningTool[readToolType - 1].search(tool) == true)
                {

                    //if tool avaliablequantity is 0, which mean can not borrow any more
                    if (gardeningTool[readToolType - 1].searchTool(tool).AvailableQuantity == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("There is no more avaliable item in the system. please back to member menu and restart it");
                    }
                    else
                    {

                        aMember.addTool(gardeningTool[readToolType - 1].searchTool(tool));
                        gardeningTool[readToolType - 1].searchTool(tool).addBorrower(aMember);
                        borrowToolList.Add(gardeningTool[readToolType - 1].searchTool(tool));
                        gardeningTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully borrow that item from the system.");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Each member only allows to borrow no more three items.");
            }

        }
        private void flooringBorrow(Member aMember, Tool tool)
        {
            flooringTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }


            //if user have borrowed more than 3 quantity of tool
            if (count < 3)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to borrow - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in the list, give it to member
                if (flooringTool[readToolType - 1].search(tool) == true)
                {
                    //if tool avaliablequantity is 0, which mean can not borrow any more
                    if (flooringTool[readToolType - 1].searchTool(tool).AvailableQuantity == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("There is no more avaliable item in the system, please back to member menu and restart it.");
                    }
                    else
                    {
                        aMember.addTool(flooringTool[readToolType - 1].searchTool(tool));
                        flooringTool[readToolType - 1].searchTool(tool).addBorrower(aMember);
                        borrowToolList.Add(flooringTool[readToolType - 1].searchTool(tool));
                        flooringTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully borrow that item from the system.");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Each member only allows to borrow no more three items.");
            }
        }
        private void fencingBorrow(Member aMember, Tool tool)
        {
            fencingTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user have borrowed more than 3 quantity of tool
            if (count < 3)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to borrow - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in the list, give it to member
                if (fencingTool[readToolType - 1].search(tool) == true)
                {
                    //if tool avaliablequantity is 0, which mean can not borrow any more
                    if (fencingTool[readToolType - 1].searchTool(tool).AvailableQuantity == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("There is no more avaliable item in the system, please back to member menu and restart it.");
                    }
                    else
                    {
                        aMember.addTool(fencingTool[readToolType - 1].searchTool(tool));
                        fencingTool[readToolType - 1].searchTool(tool).addBorrower(aMember);
                        borrowToolList.Add(fencingTool[readToolType - 1].searchTool(tool));
                        fencingTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully borrow that item from the system.");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Each member is only allowed to borrow no more three items.");
            }

        }
        private void measuringBorrow(Member aMember, Tool tool)
        {
            measuringTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user have borrowed more than 3 quantity of tool
            if (count < 3)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to borrow - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in the list, give it to member
                if (measuringTool[readToolType - 1].search(tool) == true)
                {

                    //if tool avaliablequantity is 0, which mean can not borrow any more
                    if (measuringTool[readToolType - 1].searchTool(tool).AvailableQuantity == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("There is no more avaliable item in the system, please back to member menu and restart it.");
                    }
                    else
                    {
                        aMember.addTool(measuringTool[readToolType - 1].searchTool(tool));
                        measuringTool[readToolType - 1].searchTool(tool).addBorrower(aMember);
                        borrowToolList.Add(measuringTool[readToolType - 1].searchTool(tool));
                        measuringTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully borrow that item from the system.");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Each member only allows to borrow no more three items.");
            }
        }
        private void cleaningBorrow(Member aMember, Tool tool)
        {

            cleaningTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user have borrowed more than 3 quantity of tool
            if (count < 3)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to borrow - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in the list, give it to member
                if (cleaningTool[readToolType - 1].search(tool) == true)
                {

                    //if tool avaliablequantity is 0, which mean can not borrow any more
                    if (cleaningTool[readToolType - 1].searchTool(tool).AvailableQuantity == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("There is no more avaliable item in the system, please back to member menu and restart it.");
                    }
                    else
                    {
                        aMember.addTool(cleaningTool[readToolType - 1].searchTool(tool));
                        cleaningTool[readToolType - 1].searchTool(tool).addBorrower(aMember);
                        borrowToolList.Add(cleaningTool[readToolType - 1].searchTool(tool));
                        cleaningTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully borrow that item from the system.");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("each member only allows to borrow no more three items.");
            }
        }
        private void paintingBorrow(Member aMember, Tool tool)
        {
            paintingTool[readToolType - 1].ToArray();
            Console.WriteLine("");


            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user have borrowed more than 3 quantity of tool
            if (count < 3)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to borrow - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in the list, give it to member
                if (paintingTool[readToolType - 1].search(tool) == true)
                {
                    //if tool avaliablequantity is 0, which mean can not borrow any more
                    if (paintingTool[readToolType - 1].searchTool(tool).AvailableQuantity == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("There is no more avaliable item in the system, please back to member menu and restart it.");
                    }
                    else
                    {
                        aMember.addTool(paintingTool[readToolType - 1].searchTool(tool));
                        paintingTool[readToolType - 1].searchTool(tool).addBorrower(aMember);
                        borrowToolList.Add(paintingTool[readToolType - 1].searchTool(tool));
                        paintingTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully borrow that item from the system.");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Each member only allows to borrow no more three items.");
            }
        }
        private void electronicBorrow(Member aMember, Tool tool)
        {
            electronicTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user have borrowed more than 3 quantity of tool
            if (count < 3)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to borrow - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in the list, give it to member
                if (electronicTool[readToolType - 1].search(tool) == true)
                {

                    //if tool avaliablequantity is 0, which mean can not borrow any more
                    if (electronicTool[readToolType - 1].searchTool(tool).AvailableQuantity == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("There is no more avaliable item in the system, please back to member menu and restart it.");
                    }
                    else
                    {
                        aMember.addTool(electronicTool[readToolType - 1].searchTool(tool));
                        electronicTool[readToolType - 1].searchTool(tool).addBorrower(aMember);
                        borrowToolList.Add(electronicTool[readToolType - 1].searchTool(tool));
                        electronicTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully borrow that item from the system.");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Each member only allows to borrow no more three items.");
            }
        }
        private void electricityBorrow(Member aMember, Tool tool)
        {

            electricityTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }
            //if user have borrowed more than 3 quantity of tool
            if (count < 3)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to borrow - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in the list, give it to member
                if (electricityTool[readToolType - 1].search(tool) == true)
                {

                    //if tool avaliablequantity is 0, which mean can not borrow any more
                    if (electronicTool[readToolType - 1].searchTool(tool).AvailableQuantity == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("There is no more avaliable item in the system, please back to member menu and restart it.");
                    }
                    else
                    {
                        aMember.addTool(electricityTool[readToolType - 1].searchTool(tool));
                        electricityTool[readToolType - 1].searchTool(tool).addBorrower(aMember);
                        borrowToolList.Add(electricityTool[readToolType - 1].searchTool(tool));
                        electricityTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully borrow that item from the system.");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Each member only allows to borrow no more three items.");
            }

        }
        private void automativeBorrow(Member aMember, Tool tool)
        {
            autometiveTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user have borrowed more than 3 quantity of tool
            if (count < 3)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to borrow - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in the list, give it to member
                if (autometiveTool[readToolType - 1].search(tool) == true)
                {

                    //if tool avaliablequantity is 0, which mean can not borrow any more
                    if (autometiveTool[readToolType - 1].searchTool(tool).AvailableQuantity == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("There is no more avaliable item in the system, please back to member menu and restart it.");
                    }
                    else
                    {
                        aMember.addTool(autometiveTool[readToolType - 1].searchTool(tool));
                        autometiveTool[readToolType - 1].searchTool(tool).addBorrower(aMember);
                        borrowToolList.Add(autometiveTool[readToolType - 1].searchTool(tool));
                        autometiveTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully borrow that item from the system.");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Each member only allows to borrow no more three items.");
            }
        }


        //done (all) return a tool
        public void returnTool(Member aMember, Tool tool)
        {

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("          Please select and return one of tools by inputting tool name");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("");

            //gardening 5
            if (readCatergoryType - 1 == 0)
            {

                if (readToolType - 1 == 0)
                {
                    gardeningReturn(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    gardeningReturn(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    gardeningReturn(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    gardeningReturn(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    gardeningReturn(aMember, tool);
                }
            }
            //flooring 6
            else if (readCatergoryType - 1 == 1)
            {

                if (readToolType - 1 == 0)
                {
                    flooringReturn(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    flooringReturn(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    flooringReturn(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    flooringReturn(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    flooringReturn(aMember, tool);
                }
                else if (readToolType - 1 == 5)
                {
                    flooringReturn(aMember, tool);
                }

            }
            //fencing 5
            else if (readCatergoryType - 1 == 2)
            {

                if (readToolType - 1 == 0)
                {
                    fencingReturn(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    fencingReturn(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    fencingReturn(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    fencingReturn(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    fencingReturn(aMember, tool);
                }
            }
            //measuring
            else if (readCatergoryType - 1 == 3)
            {

                if (readToolType - 1 == 0)
                {
                    measuringReturn(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    measuringReturn(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    measuringReturn(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    measuringReturn(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    measuringReturn(aMember, tool);
                }
                else if (readToolType - 1 == 5)
                {
                    measuringReturn(aMember, tool);
                }
            }
            //cleaning 6 
            else if (readCatergoryType - 1 == 4)
            {

                if (readToolType - 1 == 0)
                {
                    cleaningReturn(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    cleaningReturn(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    cleaningReturn(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    cleaningReturn(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    cleaningReturn(aMember, tool);
                }
                else if (readToolType - 1 == 5)
                {
                    cleaningReturn(aMember, tool);
                }
            }
            //painting 
            else if (readCatergoryType - 1 == 5)
            {

                if (readToolType - 1 == 0)
                {
                    paintingReturn(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    paintingReturn(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    paintingReturn(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    paintingReturn(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    paintingReturn(aMember, tool);
                }
                else if (readToolType - 1 == 5)
                {
                    paintingReturn(aMember, tool);
                }

            }
            //electronic 5 
            else if (readCatergoryType - 1 == 6)
            {

                if (readToolType - 1 == 0)
                {
                    electronicReturn(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    electronicReturn(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    electronicReturn(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    electronicReturn(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    electronicReturn(aMember, tool);
                }
            }
            //clectricity 5
            else if (readCatergoryType - 1 == 7)
            {

                if (readToolType - 1 == 0)
                {
                    electricityReturn(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    electricityReturn(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    electricityReturn(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    electricityReturn(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    electricityReturn(aMember, tool);
                }
            }
            //automative 6
            else if (readCatergoryType - 1 == 8)
            {

                if (readToolType - 1 == 0)
                {
                    autometiveReturn(aMember, tool);
                }
                else if (readToolType - 1 == 1)
                {
                    autometiveReturn(aMember, tool);
                }
                else if (readToolType - 1 == 2)
                {
                    autometiveReturn(aMember, tool);
                }
                else if (readToolType - 1 == 3)
                {
                    autometiveReturn(aMember, tool);
                }
                else if (readToolType - 1 == 4)
                {
                    autometiveReturn(aMember, tool);
                }
                else if (readToolType - 1 == 5)
                {
                    autometiveReturn(aMember, tool);
                }
            }


        }


        /// <summary>
        /// return specific tool to system and collect it from the login member
        /// </summary>
        /// <param name="aMember">registred member and login</param>
        /// <param name="tool">specific tool</param>
        private void gardeningReturn(Member aMember, Tool tool)
        {

            gardeningTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user has borrowed at least borrowed one item from system
            if (count > 0)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to return - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in this list 
                if (gardeningTool[readToolType - 1].search(tool) == true)
                {
                    int correct = 0;

                    for (int i = 0; i < memberTree.toArray().Length; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (memberTree.toArray()[i].Tools[j] == tool.Name)
                            {
                                correct = 1;
                            }
                        }
                    }

                    //check if member borrow input tool name
                    if(correct == 1)
                    {

                        aMember.deleteTool(gardeningTool[readToolType - 1].searchTool(tool));
                        gardeningTool[readToolType - 1].searchTool(tool).deleteBorrower(aMember);
                        gardeningTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully return that item to the system.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You haven't borrowed this item from this system");
                    }


                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You haven't borrow any item from the system.");
            }

        }
        private void flooringReturn(Member aMember, Tool tool)
        {
            flooringTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }
            //if user has borrowed at least borrowed one item from system
            if (count > 0)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to return - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in this list 
                if (flooringTool[readToolType - 1].search(tool) == true)
                {

                    int correct = 0;

                    for (int i = 0; i < memberTree.toArray().Length; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (memberTree.toArray()[i].Tools[j] == tool.Name)
                            {
                                correct = 1;
                            }
                        }
                    }

                    //check if member borrow input tool name
                    if (correct == 1)
                    {

                        aMember.deleteTool(flooringTool[readToolType - 1].searchTool(tool));
                        flooringTool[readToolType - 1].searchTool(tool).deleteBorrower(aMember);
                        flooringTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully return that item to the system.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You haven't borrowed this item from this system");
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You haven't borrow any item from ouur system.");
            }

        }
        private void fencingReturn(Member aMember, Tool tool)
        {
            fencingTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user has borrowed at least borrowed one item from system
            if (count > 0)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to return - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in this list 
                if (fencingTool[readToolType - 1].search(tool) == true)
                {
                    int correct = 0;

                    for (int i = 0; i < memberTree.toArray().Length; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (memberTree.toArray()[i].Tools[j] == tool.Name)
                            {
                                correct = 1;
                            }
                        }
                    }

                    //check if member borrow input tool name
                    if (correct == 1)
                    {

                        aMember.deleteTool(fencingTool[readToolType - 1].searchTool(tool));
                        fencingTool[readToolType - 1].searchTool(tool).deleteBorrower(aMember);
                        fencingTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully return that item to the system.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You haven't borrowed this item from this system");
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You haven't borrow any item from ouur system.");
            }

        }
        private void measuringReturn(Member aMember, Tool tool)
        {
            measuringTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }
            //if user has borrowed at least borrowed one item from system
            if (count > 0)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to return - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in this list 
                if (measuringTool[readToolType - 1].search(tool) == true)
                {

                    int correct = 0;

                    for (int i = 0; i < memberTree.toArray().Length; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (memberTree.toArray()[i].Tools[j] == tool.Name)
                            {
                                correct = 1;
                            }
                        }
                    }

                    //check if member borrow input tool name
                    if (correct == 1)
                    {

                        aMember.deleteTool(measuringTool[readToolType - 1].searchTool(tool));
                        measuringTool[readToolType - 1].searchTool(tool).deleteBorrower(aMember);
                        measuringTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully return that item to the system.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You haven't borrowed this item from this system");
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You haven't borrow any item from ouur system.");
            }

        }
        private void cleaningReturn(Member aMember, Tool tool)
        {
            cleaningTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user has borrowed at least borrowed one item from system
            if (count > 0)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to return - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in this list 
                if (cleaningTool[readToolType - 1].search(tool) == true)
                {
                    int correct = 0;

                    for (int i = 0; i < memberTree.toArray().Length; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (memberTree.toArray()[i].Tools[j] == tool.Name)
                            {
                                correct = 1;
                            }
                        }
                    }

                    //check if member borrow input tool name
                    if (correct == 1)
                    {

                        aMember.deleteTool(cleaningTool[readToolType - 1].searchTool(tool));
                        cleaningTool[readToolType - 1].searchTool(tool).deleteBorrower(aMember);
                        cleaningTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully return that item to the system.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You haven't borrowed this item from this system");
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You haven't borrow any item from ouur system.");
            }


        }
        private void paintingReturn(Member aMember, Tool tool)
        {
            paintingTool[readToolType - 1].ToArray();
            Console.WriteLine("");


            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }
            //if user has borrowed at least borrowed one item from system
            if (count > 0)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to return - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in this list 
                if (paintingTool[readToolType - 1].search(tool) == true)
                {
                    int correct = 0;

                    for (int i = 0; i < memberTree.toArray().Length; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (memberTree.toArray()[i].Tools[j] == tool.Name)
                            {
                                correct = 1;
                            }
                        }
                    }

                    //check if member borrow input tool name
                    if (correct == 1)
                    {

                        aMember.deleteTool(paintingTool[readToolType - 1].searchTool(tool));
                        paintingTool[readToolType - 1].searchTool(tool).deleteBorrower(aMember);
                        paintingTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully return that item to the system.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You haven't borrowed this item from this system");
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You haven't borrow any item from the system.");
            }


        }
        private void electronicReturn(Member aMember, Tool tool)
        {
            electronicTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user has borrowed at least borrowed one item from system
            if (count > 0)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to return - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in this list 
                if (electronicTool[readToolType - 1].search(tool) == true)
                {
                    int correct = 0;

                    for (int i = 0; i < memberTree.toArray().Length; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (memberTree.toArray()[i].Tools[j] == tool.Name)
                            {
                                correct = 1;
                            }
                        }
                    }

                    //check if member borrow input tool name
                    if (correct == 1)
                    {

                        aMember.deleteTool(electronicTool[readToolType - 1].searchTool(tool));
                        electronicTool[readToolType - 1].searchTool(tool).deleteBorrower(aMember);
                        electronicTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully return that item to the system.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You haven't borrowed this item from this system");
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You haven't borrow any item from ouur system.");
            }

        }
        private void electricityReturn(Member aMember, Tool tool)
        {
            electricityTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user has borrowed at least borrowed one item from system
            if (count > 0)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to return - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in this list 
                if (electricityTool[readToolType - 1].search(tool) == true)
                {

                    int correct = 0;

                    for (int i = 0; i < memberTree.toArray().Length; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (memberTree.toArray()[i].Tools[j] == tool.Name)
                            {
                                correct = 1;
                            }
                        }
                    }

                    //check if member borrow input tool name
                    if (correct == 1)
                    {

                        aMember.deleteTool(electricityTool[readToolType - 1].searchTool(tool));
                        electricityTool[readToolType - 1].searchTool(tool).deleteBorrower(aMember);
                        electricityTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully return that item to the system.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You haven't borrowed this item from this system");
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You haven't borrow any item from ouur system.");
            }

        }
        private void autometiveReturn(Member aMember, Tool tool)
        {
            autometiveTool[readToolType - 1].ToArray();
            Console.WriteLine("");

            int count = 0;

            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    count++;
                }
            }

            //if user has borrowed at least borrowed one item from system
            if (count > 0)
            {

                Console.WriteLine("=============================================================================");
                Console.Write("Please input the tool name that you want to return - ");
                string readToolName = Console.ReadLine();
                tool = new Tool(readToolName);

                //if tool in this list 
                if (autometiveTool[readToolType - 1].search(tool) == true)
                {

                    int correct = 0;

                    for (int i = 0; i < memberTree.toArray().Length; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (memberTree.toArray()[i].Tools[j] == tool.Name)
                            {
                                correct = 1;
                            }
                        }
                    }

                    //check if member borrow input tool name
                    if (correct == 1)
                    {

                        aMember.deleteTool(autometiveTool[readToolType - 1].searchTool(tool));
                        autometiveTool[readToolType - 1].searchTool(tool).deleteBorrower(aMember);
                        autometiveTool[readToolType - 1].ToArray();
                        Console.WriteLine("=============================================================================");
                        Console.WriteLine("");
                        Console.WriteLine("You successfully return that item to the system.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You haven't borrowed this item from this system");
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("There is no correct tool name in the list, make sure input a corrent tool name and try again.");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You haven't borrow any item from ouur system.");
            }
        }

        //done (all)
        public string[] listTools(Member aMember)
        {

            string[] strings = new string[3];

            for (int i = 0; i < aMember.Tools.Length; i++)
            {

                strings[i] = aMember.Tools[i];

            }

            return strings;

        }

        //done (all)
        public void displayTools(string toolName)
        {

            //gardening 5
            if (readCatergoryType - 1 == 0)
            {

                if (readToolType - 1 == 0)
                {
                    Console.Clear();
                    gardeningTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 1)
                {
                    Console.Clear();
                    gardeningTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 2)
                {
                    Console.Clear();
                    gardeningTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 3)
                {
                    Console.Clear();
                    gardeningTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 4)
                {
                    Console.Clear();
                    gardeningTool[readToolType - 1].ToArray();
                }
            }
            //flooring 6
            else if (readCatergoryType - 1 == 1)
            {

                if (readToolType - 1 == 0)
                {
                    Console.Clear();
                    flooringTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 1)
                {
                    Console.Clear();
                    flooringTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 2)
                {
                    Console.Clear();
                    flooringTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 3)
                {
                    Console.Clear();
                    flooringTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 4)
                {
                    Console.Clear();
                    flooringTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 5)
                {
                    Console.Clear();
                    flooringTool[readToolType - 1].ToArray();
                }

            }

            //fencing 5
            else if (readCatergoryType - 1 == 2)
            {

                
                if (readToolType - 1 == 0)
                {
                    Console.Clear();
                    fencingTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 1)
                {
                    Console.Clear();
                    fencingTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 2)
                {
                    Console.Clear();
                    fencingTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 3)
                {
                    Console.Clear();
                    fencingTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 4)
                {
                    Console.Clear();
                    fencingTool[readToolType - 1].ToArray();
                }

            }

            //measuring 6
            else if (readCatergoryType - 1 == 3)
            {

                if (readToolType - 1 == 0)
                {
                    Console.Clear();
                    measuringTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 1)
                {
                    Console.Clear();
                    measuringTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 2)
                {
                    Console.Clear();
                    measuringTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 3)
                {
                    Console.Clear();
                    measuringTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 4)
                {
                    Console.Clear();
                    measuringTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 5)
                {
                    Console.Clear();
                    measuringTool[readToolType - 1].ToArray();
                }

            }

            //cleaning 6
            else if (readCatergoryType - 1 == 4)
            {

                if (readToolType - 1 == 0)
                {
                    Console.Clear();
                    cleaningTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 1)
                {
                    Console.Clear();
                    cleaningTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 2)
                {
                    Console.Clear();
                    cleaningTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 3)
                {
                    Console.Clear();
                    cleaningTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 4)
                {
                    Console.Clear();
                    cleaningTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 5)
                {
                    Console.Clear();
                    cleaningTool[readToolType - 1].ToArray();
                }

            }

            //painting 6
            else if (readCatergoryType - 1 == 5)
            {

                if (readToolType - 1 == 0)
                {
                    Console.Clear();
                    paintingTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 1)
                {
                    Console.Clear();
                    paintingTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 2)
                {
                    Console.Clear();
                    paintingTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 3)
                {
                    Console.Clear();
                    paintingTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 4)
                {
                    Console.Clear();
                    paintingTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 5)
                {
                    Console.Clear();
                    paintingTool[readToolType - 1].ToArray();
                }

            }

            //electronic 5
            else if (readCatergoryType - 1 == 6)
            {

                if (readToolType - 1 == 0)
                {
                    Console.Clear();
                    electronicTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 1)
                {
                    Console.Clear();
                    electronicTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 2)
                {
                    Console.Clear();
                    electronicTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 3)
                {
                    Console.Clear();
                    electronicTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 4)
                {
                    Console.Clear();
                    electronicTool[readToolType - 1].ToArray();
                }

            }

            //electricity 5
            else if (readCatergoryType - 1 == 7)
            {

                if (readToolType - 1 == 0)
                {
                    Console.Clear();
                    electricityTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 1)
                {
                    Console.Clear();
                    electricityTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 2)
                {
                    Console.Clear();
                    electricityTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 3)
                {
                    Console.Clear();
                    electricityTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 4)
                {
                    Console.Clear();
                    electricityTool[readToolType - 1].ToArray();
                }

            }

            //automative 6
            else if (readCatergoryType - 1 == 8)
            {

                if (readToolType - 1 == 0)
                {
                    Console.Clear();
                    autometiveTool[readToolType - 1].ToArray();

                }
                else if (readToolType - 1 == 1)
                {
                    Console.Clear();
                    autometiveTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 2)
                {
                    Console.Clear();
                    autometiveTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 3)
                {
                    Console.Clear();
                    autometiveTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 4)
                {
                    Console.Clear();
                    autometiveTool[readToolType - 1].ToArray();
                }
                else if (readToolType - 1 == 5)
                {
                    Console.Clear();
                    autometiveTool[readToolType - 1].ToArray();
                }

            }

        }
        
        //done (all) delete tool type
        public void delete(Tool readTool)
        {
            //gardening
            if (readCatergoryType - 1 == 0)
            {
                if (readToolType - 1 == 0)
                {
                    gardeningDelete(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    gardeningDelete(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    gardeningDelete(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    gardeningDelete(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    gardeningDelete(readTool);
                }
            }
            //flooring
            else if (readCatergoryType - 1 == 1)
            {
                if (readToolType - 1 == 0)
                {
                    flooringDelete(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    flooringDelete(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    flooringDelete(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    flooringDelete(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    flooringDelete(readTool);
                }
                else if (readToolType - 1 == 5)
                {
                    flooringDelete(readTool);
                }
            }
            //fencing
            else if (readCatergoryType - 1 == 2)
            {
                if (readToolType - 1 == 0)
                {
                    fencingDelete(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    fencingDelete(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    fencingDelete(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    fencingDelete(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    fencingDelete(readTool);
                }

            }
            //measuring
            else if (readCatergoryType - 1 == 3)
            {
                if (readToolType - 1 == 0)
                {
                    measuringDelete(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    measuringDelete(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    measuringDelete(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    measuringDelete(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    measuringDelete(readTool);
                }
                else if (readToolType - 1 == 5)
                {
                    measuringDelete(readTool);
                }

            }
            //cleaning
            else if (readCatergoryType - 1 == 4)
            {
                if (readToolType - 1 == 0)
                {
                    cleaningDelete(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    cleaningDelete(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    cleaningDelete(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    cleaningDelete(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    cleaningDelete(readTool);
                }
                else if (readToolType - 1 == 5)
                {
                    cleaningDelete(readTool);
                }

            }
            //painting
            else if (readCatergoryType - 1 == 5)
            {

                if (readToolType - 1 == 0)
                {
                    paintingDelete(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    paintingDelete(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    paintingDelete(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    paintingDelete(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    paintingDelete(readTool);
                }
                else if (readToolType - 1 == 5)
                {
                    paintingDelete(readTool);
                }
            }
            //electronic
            else if (readCatergoryType - 1 == 6)
            {
                if (readToolType - 1 == 0)
                {
                    electronicDelete(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    electronicDelete(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    electronicDelete(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    electronicDelete(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    electronicDelete(readTool);
                }

            }
            //electrivity
            else if (readCatergoryType - 1 == 7)
            {
                if (readToolType - 1 == 0)
                {
                    electricityDelete(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    electricityDelete(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    electricityDelete(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    electricityDelete(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    electricityDelete(readTool);
                }
            }
            //automative
            else if (readCatergoryType - 1 == 8)
            {

                if (readToolType - 1 == 0)
                {
                    automativeDelete(readTool);
                }
                else if (readToolType - 1 == 1)
                {
                    automativeDelete(readTool);
                }
                else if (readToolType - 1 == 2)
                {
                    automativeDelete(readTool);
                }
                else if (readToolType - 1 == 3)
                {
                    automativeDelete(readTool);
                }
                else if (readToolType - 1 == 4)
                {
                    automativeDelete(readTool);
                }
                else if (readToolType - 1 == 5)
                {
                    automativeDelete(readTool);
                }

            }
        }

        /// <summary>
        /// if tool does not in the collection, invoke a warning. otherwise,
        /// delete into toolcollection
        /// </summary>
        /// <param name="readTool">verify tool</param>
        private void gardeningDelete(Tool readTool)
        {
            if (gardeningTool[readToolType - 1].search(readTool) == true)
            {
                gardeningTool[readToolType - 1].delete(readTool);
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
            else
            {
                Console.WriteLine("There is no correct tool name in this system");
            }
        }
        private void flooringDelete(Tool readTool)
        {
            if (flooringTool[readToolType - 1].search(readTool) == true)
            {
                flooringTool[readToolType - 1].delete(readTool);
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
            else
            {
                Console.WriteLine("There is no correct tool name in this system");
            }
        }
        private void fencingDelete(Tool readTool)
        {
            if (fencingTool[readToolType - 1].search(readTool) == true)
            {
                fencingTool[readToolType - 1].delete(readTool);
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
            else
            {
                Console.WriteLine("There is no correct tool name in this system");
            }
        }
        private void measuringDelete(Tool readTool)
        {
            if (measuringTool[readToolType - 1].search(readTool) == true)
            {
                measuringTool[readToolType - 1].delete(readTool);
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
            else
            {
                Console.WriteLine("There is no correct tool name in this system");
            }
        }
        private void cleaningDelete(Tool readTool)
        {
            if (cleaningTool[readToolType - 1].search(readTool) == true)
            {
                cleaningTool[readToolType - 1].delete(readTool);
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
            else
            {
                Console.WriteLine("There is no correct tool name in this system");
            }
        }
        private void paintingDelete(Tool readTool)
        {
            if (paintingTool[readToolType - 1].search(readTool) == true)
            {
                paintingTool[readToolType - 1].delete(readTool);
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
            else
            {
                Console.WriteLine("There is no correct tool name in this system");
            }
        }
        private void electronicDelete(Tool readTool)
        {
            if (electronicTool[readToolType - 1].search(readTool) == true)
            {
                electronicTool[readToolType - 1].delete(readTool);
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
            else
            {
                Console.WriteLine("There is no correct tool name in this system");
            }
        }
        private void electricityDelete(Tool readTool)
        {
            if (electricityTool[readToolType - 1].search(readTool) == true)
            {
                electricityTool[readToolType - 1].delete(readTool);
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
            else
            {
                Console.WriteLine("There is no correct tool name in this system");
            }
        }
        private void automativeDelete(Tool readTool)
        {
            if (electricityTool[readToolType - 1].search(readTool) == true)
            {
                electronicTool[readToolType - 1].delete(readTool);
                Console.WriteLine("");
                Console.WriteLine(readTool.Name + " has sucessfully added in the list");
            }
            else
            {
                Console.WriteLine("There is no correct tool name in this system");
            }
        }

        //done (all) delete tool type quatity
        public void delete(Tool readTool, int count)
        {


            //gardening 5
            if (readCatergoryType - 1 == 0)
            {

                if (readToolType - 1 == 0)
                {
                    gardeningDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 1)
                {
                    gardeningDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 2)
                {
                    gardeningDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 3)
                {
                    gardeningDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 4)
                {
                    gardeningDeleteExist(readTool, count);
                }
            }
            //flooring 6
            else if (readCatergoryType - 1 == 1)
            {

                if (readToolType - 1 == 0)
                {
                    flooringDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 1)
                {
                    flooringDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 2)
                {
                    flooringDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 3)
                {
                    flooringDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 4)
                {
                    flooringDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 5)
                {
                    flooringDeleteExist(readTool, count);
                }
            }
            //fencing 5
            else if (readCatergoryType - 1 == 2)
            {

                if (readToolType - 1 == 0)
                {
                    fencingDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 1)
                {
                    fencingDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 2)
                {
                    fencingDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 3)
                {
                    fencingDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 4)
                {
                    fencingDeleteExist(readTool, count);
                }
            }
            //measuring 6
            else if (readCatergoryType - 1 == 3)
            {

                if (readToolType - 1 == 0)
                {
                    measuringDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 1)
                {
                    measuringDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 2)
                {
                    measuringDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 3)
                {
                    measuringDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 4)
                {
                    measuringDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 5)
                {
                    measuringDeleteExist(readTool, count);
                }
            }
            //cleaning 6
            else if (readCatergoryType - 1 == 4)
            {

                if (readToolType - 1 == 0)
                {
                    cleaningDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 1)
                {
                    cleaningDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 2)
                {
                    cleaningDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 3)
                {
                    cleaningDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 4)
                {
                    cleaningDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 5)
                {
                    cleaningDeleteExist(readTool, count);
                }
            }
            //painting
            else if (readCatergoryType - 1 == 5)
            {

                if (readToolType - 1 == 0)
                {
                    paintingDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 1)
                {
                    paintingDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 2)
                {
                    paintingDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 3)
                {
                    paintingDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 4)
                {
                    paintingDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 5)
                {
                    paintingDeleteExist(readTool, count);
                }
            }
            //electronic 5
            else if (readCatergoryType - 1 == 6)
            {

                if (readToolType - 1 == 0)
                {
                    electronicDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 1)
                {
                    electronicDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 2)
                {
                    electronicDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 3)
                {
                    electronicDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 4)
                {
                    electronicDeleteExist(readTool, count);
                }
            }
            //electrivicity 5
            else if (readCatergoryType - 1 == 7)
            {

                if (readToolType - 1 == 0)
                {
                    electricityDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 1)
                {
                    electricityDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 2)
                {
                    electricityDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 3)
                {
                    electricityDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 4)
                {
                    electricityDeleteExist(readTool, count);
                }
            }
            //aumative 6
            else if (readCatergoryType - 1 == 8)
            {

                if (readToolType - 1 == 0)
                {
                    automativeDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 1)
                {
                    automativeDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 2)
                {
                    automativeDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 3)
                {
                    automativeDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 4)
                {
                    automativeDeleteExist(readTool, count);
                }
                else if (readToolType - 1 == 5)
                {
                    automativeDeleteExist(readTool, count);
                }
            }

        }

        /// <summary>
        /// decreasing the existing tool quantity
        /// check if tool in the list, otherwise invoke a warning
        /// </summary>
        /// <param name="readTool">verify tool</param>
        /// <param name="count">quantity that user want add</param>
        private void gardeningDeleteExist(Tool readTool, int count)
        {

            gardeningTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.Write("Input your tool name: ");
            string read = Console.ReadLine();
            Console.Write("How many quantity that you want to delete: ");
            string readNum = Console.ReadLine();
            try
            {
                count = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(read, count);


            if (gardeningTool[readToolType - 1].search(readTool) == true)
            {


                if (gardeningTool[readToolType - 1].searchTool(readTool).AvailableQuantity >= count)
                {
                    gardeningTool[readToolType - 1].searchTool(readTool).Quantity = gardeningTool[readToolType - 1].searchTool(readTool).Quantity - count;
                    gardeningTool[readToolType - 1].searchTool(readTool).AvailableQuantity = gardeningTool[readToolType - 1].searchTool(readTool).AvailableQuantity - count;
                    Console.WriteLine("");
                    Console.WriteLine(readTool.Name + " has sucessfully deleted from this system.");
                    gardeningTool[readToolType - 1].ToArray();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please input a valid avaliable number, and back previous page and try it again.");
                }
            }
            else
            {
                Console.WriteLine("There is no correct tool name in the list, please try it again.");
            }

        }
        private void flooringDeleteExist(Tool readTool, int count)
        {

            flooringTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.Write("Input your tool name: ");
            string read = Console.ReadLine();
            Console.Write("How many quantity that you want to delete: ");
            string readNum = Console.ReadLine();
            try
            {
                count = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(read, count);

            if (flooringTool[readToolType - 1].search(readTool) == true)
            {

                if (flooringTool[readToolType - 1].searchTool(readTool).AvailableQuantity >= count)
                {
                    flooringTool[readToolType - 1].searchTool(readTool).Quantity = flooringTool[readToolType - 1].searchTool(readTool).Quantity - count;
                    flooringTool[readToolType - 1].searchTool(readTool).AvailableQuantity = flooringTool[readToolType - 1].searchTool(readTool).AvailableQuantity - count;
                    Console.WriteLine("");
                    Console.WriteLine(readTool.Name + " has sucessfully deleted from this system.");
                    flooringTool[readToolType - 1].ToArray();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please input a valid avaliable number, and back previous page and try it again.");
                }

            }
            else
            {

                Console.WriteLine("There is no correct tool name in the list, please try it again.");
            }

        }
        private void fencingDeleteExist(Tool readTool, int count)
        {

            fencingTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.Write("Input your tool name: ");
            string read = Console.ReadLine();
            Console.Write("How many quantity that you want to delete: ");
            string readNum = Console.ReadLine();
            try
            {
                count = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(read, count);

            if (fencingTool[readToolType - 1].search(readTool) == true)
            {

                if (fencingTool[readToolType - 1].searchTool(readTool).AvailableQuantity >= count)
                {
                    fencingTool[readToolType - 1].searchTool(readTool).Quantity = fencingTool[readToolType - 1].searchTool(readTool).Quantity - count;
                    fencingTool[readToolType - 1].searchTool(readTool).AvailableQuantity = fencingTool[readToolType - 1].searchTool(readTool).AvailableQuantity - count;
                    Console.WriteLine("");
                    Console.WriteLine(readTool.Name + " has sucessfully deleted from this system.");
                    fencingTool[readToolType - 1].ToArray();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please input a valid avaliable number, and back previous page and try it again.");
                }

            }
            else
            {

                Console.WriteLine("There is no correct tool name in the list, please try it again.");
            }

        }
        private void measuringDeleteExist(Tool readTool, int count)
        {
            measuringTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.Write("Input your tool name: ");
            string read = Console.ReadLine();
            Console.Write("How many quantity that you want to delete: ");
            string readNum = Console.ReadLine();
            try
            {
                count = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(read, count);

            if (measuringTool[readToolType - 1].search(readTool) == true)
            {

                if (measuringTool[readToolType - 1].searchTool(readTool).AvailableQuantity >= count)
                {
                    measuringTool[readToolType - 1].searchTool(readTool).Quantity = measuringTool[readToolType - 1].searchTool(readTool).Quantity - count;
                    measuringTool[readToolType - 1].searchTool(readTool).AvailableQuantity = measuringTool[readToolType - 1].searchTool(readTool).AvailableQuantity - count;
                    Console.WriteLine("");
                    Console.WriteLine(readTool.Name + " has sucessfully deleted from this system.");
                    measuringTool[readToolType - 1].ToArray();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please input a valid avaliable number, and back previous page and try it again.");
                }

            }
            else
            {

                Console.WriteLine("There is no correct tool name in the list, please try it again.");
            }
        }
        private void cleaningDeleteExist(Tool readTool, int count)
        {
            cleaningTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.Write("Input your tool name: ");
            string read = Console.ReadLine();
            Console.Write("How many quantity that you want to delete: ");
            string readNum = Console.ReadLine();
            try
            {
                count = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(read, count);

            if (cleaningTool[readToolType - 1].search(readTool) == true)
            {

                if (cleaningTool[readToolType - 1].searchTool(readTool).AvailableQuantity >= count)
                {
                    cleaningTool[readToolType - 1].searchTool(readTool).Quantity = cleaningTool[readToolType - 1].searchTool(readTool).Quantity - count;
                    cleaningTool[readToolType - 1].searchTool(readTool).AvailableQuantity = cleaningTool[readToolType - 1].searchTool(readTool).AvailableQuantity - count;
                    Console.WriteLine("");
                    Console.WriteLine(readTool.Name + " has sucessfully deleted from this system.");
                    cleaningTool[readToolType - 1].ToArray();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please input a valid avaliable number, and back previous page and try it again.");
                }

            }
            else
            {

                Console.WriteLine("There is no correct tool name in the list, please try it again.");
            }

        }
        private void paintingDeleteExist(Tool readTool, int count)
        {

            paintingTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.Write("Input your tool name: ");
            string read = Console.ReadLine();
            Console.Write("How many quantity that you want to delete: ");
            string readNum = Console.ReadLine();
            try
            {
                count = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(read, count);

            if (paintingTool[readToolType - 1].search(readTool) == true)
            {

                if (paintingTool[readToolType - 1].searchTool(readTool).AvailableQuantity >= count)
                {
                    paintingTool[readToolType - 1].searchTool(readTool).Quantity = paintingTool[readToolType - 1].searchTool(readTool).Quantity - count;
                    paintingTool[readToolType - 1].searchTool(readTool).AvailableQuantity = paintingTool[readToolType - 1].searchTool(readTool).AvailableQuantity - count;
                    Console.WriteLine("");
                    Console.WriteLine(readTool.Name + " has sucessfully deleted from this system.");
                    paintingTool[readToolType - 1].ToArray();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please input a valid avaliable number, and back previous page and try it again.");
                }

            }
            else
            {

                Console.WriteLine("There is no correct tool name in the list, please try it again.");
            }

        }
        private void electronicDeleteExist(Tool readTool, int count)
        {

            electronicTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.Write("Input your tool name: ");
            string read = Console.ReadLine();
            Console.Write("How many quantity that you want to delete: ");
            string readNum = Console.ReadLine();
            try
            {
                count = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(read, count);

            if (electronicTool[readToolType - 1].search(readTool) == true)
            {

                if (electronicTool[readToolType - 1].searchTool(readTool).AvailableQuantity >= count)
                {
                    electronicTool[readToolType - 1].searchTool(readTool).Quantity = electronicTool[readToolType - 1].searchTool(readTool).Quantity - count;
                    electronicTool[readToolType - 1].searchTool(readTool).AvailableQuantity = electronicTool[readToolType - 1].searchTool(readTool).AvailableQuantity - count;
                    Console.WriteLine("");
                    Console.WriteLine(readTool.Name + " has sucessfully deleted from this system.");
                    electronicTool[readToolType - 1].ToArray();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please input a valid avaliable number, and back previous page and try it again.");
                }

            }
            else
            {

                Console.WriteLine("There is no correct tool name in the list, please try it again.");
            }

        }
        private void electricityDeleteExist(Tool readTool, int count)
        {
            electricityTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.Write("Input your tool name: ");
            string read = Console.ReadLine();
            Console.Write("How many quantity do you want to delete: ");
            string readNum = Console.ReadLine();
            try
            {
                count = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(read, count);

            if (electricityTool[readToolType - 1].search(readTool) == true)
            {

                if (electricityTool[readToolType - 1].searchTool(readTool).AvailableQuantity >= count)
                {
                    electricityTool[readToolType - 1].searchTool(readTool).Quantity = electricityTool[readToolType - 1].searchTool(readTool).Quantity - count;
                    electricityTool[readToolType - 1].searchTool(readTool).AvailableQuantity = electricityTool[readToolType - 1].searchTool(readTool).AvailableQuantity - count;
                    Console.WriteLine("");
                    Console.WriteLine(readTool.Name + " has sucessfully deleted from this system.");
                    electricityTool[readToolType - 1].ToArray();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please input a valid avaliable number, and back previous page and try it again.");
                }

            }
            else
            {

                Console.WriteLine("There is no correct tool name in the list, please try it again.");
            }


        }
        private void automativeDeleteExist(Tool readTool, int count)
        {

            autometiveTool[readToolType - 1].ToArray();
            Console.WriteLine("");
            Console.Write("Input your tool name: ");
            string read = Console.ReadLine();
            Console.Write("How many quantity do you want to delete: ");
            string readNum = Console.ReadLine();
            try
            {
                count = Int32.Parse(readNum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================================================");
                Console.WriteLine(e.Message);
            }
            readTool = new Tool(read, count);

            if (autometiveTool[readToolType - 1].search(readTool) == true)
            {

                if (autometiveTool[readToolType - 1].searchTool(readTool).AvailableQuantity >= count)
                {
                    autometiveTool[readToolType - 1].searchTool(readTool).Quantity = autometiveTool[readToolType - 1].searchTool(readTool).Quantity - count;
                    autometiveTool[readToolType - 1].searchTool(readTool).AvailableQuantity = autometiveTool[readToolType - 1].searchTool(readTool).AvailableQuantity - count;
                    Console.WriteLine("");
                    Console.WriteLine(readTool.Name + " has sucessfully delete in the list");
                    autometiveTool[readToolType - 1].ToArray();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please input a valid avaliable number, and back previous page and try it again.");
                }

            }
            else
            {

                Console.WriteLine("There is no correct tool name in the list, please try it again");
            }

        }

        //done (ALL)
        public void displayBorrowingTools(Member aMember)
        {

            Console.WriteLine("");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("                             Your borrowing item list below ");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("");


                Console.WriteLine("{0} {1}'s borrowing item: ", aMember.LastName, aMember.FirstName);
                Console.WriteLine("");

                for (int i = 0; i < aMember.Tools.Length; i++)
                {

                    Console.WriteLine("                         {0}.  {1}", i+1, aMember.Tools[i]);
                    Console.WriteLine("");

                }

        }

        //done (all) BUBBLE SORT
        public void displayTopTHree()
        {

            Console.WriteLine("");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("                  The most frequency borrowing items below (Top 3)");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("");


            //delete repeated borrowing items 
            for (int i = 0; i < borrowToolList.Count; i++)
            {
                for (int j = borrowToolList.Count - 1; j > i; j--)
                {
                    if (borrowToolList[i] == borrowToolList[j])
                    {
                        borrowToolList.RemoveAt(j);
                    }
                }

            }

            //sort list from high to low (bubble sort)  complexity: the power of n
            int temp = 0;
            for(int i = 0; i< borrowToolList.Count - 1; i++)
            {
                for(int j = i+1; j<borrowToolList.Count;j++)
                {
                    if(borrowToolList[i].NoBorrowings < borrowToolList[j].NoBorrowings)
                    {
                        temp = borrowToolList[i].NoBorrowings;
                        borrowToolList[i].NoBorrowings = borrowToolList[j].NoBorrowings;
                        borrowToolList[j].NoBorrowings = temp;
                    }
                }
            }

            Console.WriteLine("");

            //output
            for(int i = 0; i <borrowToolList.Count;i++)
            {
                if(i < 3 && borrowToolList[i] != null)
                {
                    var output = String.Format("The top {0} frequecy item is: Tool's name: {1,-5}   Tool's borrowing amount: {2,2}", i + 1, borrowToolList[i].Name, borrowToolList[i].NoBorrowings);
                    Console.WriteLine(output);
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("==============================================================================");
            

        }



    }
}
