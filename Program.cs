using System;

//Tayana Pugh, ENGR 115, Course Project:Checkpoint 2.
//In this Course Project we will compare the performance of different dynamic systems. 
//In Version 2 I will be adding a do-while loop that repeats as long as the user wants to continue calculations.
//In Version 3, I will be adding methods and arrays to organize and reduce the code that was preveiously used as well as using forloops to execute statements repeatedly. 
//In Version 4, I will be adding classes, one for the program and one for the Math equations. 

namespace ENGR115V4
{

    class Program
    {

        public static void Main(string[] args)
        {
            float inputA = 0.0f,
            inputB,
            inputC,
            inputG,
            resultD,
            resultE,
            resultF;

            string inputstring;

            string stringFour = "Period(s)";
            string stringFive = "AngularFrequency(rads/s)";
            string stringSix = "TimeVsDisplacement";
            string continueMessage = "Hit any key to continue";
            string doMorefunctions = "Add More Numbers Together - y = yes - anything else for no";
            string shouldAddNewTime = "Do you want to add a new time varaible - y = yes - anything else for no";
            string exitMessage = "Invalid Input - exiting program";
            bool moreActions;
            do
            {

                string[] inputs1 = {
          "Mass(kg)",
          "SpringStiffness(N/m)",
          "DampingCoefficient"
        };
                Dictionary<string, float> inputResponse = new Dictionary<string, float>(); //Dictionary is used to help define each input and their title. 

                void collectData(string message)
                {
                    string response = "";
                    Console.WriteLine(message);
                    response = Console.ReadLine();

                    if (Single.TryParse(response, out float result))
                    {
                        float parsedResponse = float.Parse(response);
                        inputResponse.Add(message, parsedResponse);

                    }
                    else
                    {
                        Console.WriteLine(exitMessage);
                        Console.WriteLine(continueMessage);
                        Console.ReadLine();
                        System.Environment.Exit(1);
                    }
                }
                foreach (string message in inputs1)
                {
                    collectData(message);
                }

                ///Solve equation for resultD
                Console.WriteLine(stringFour);
                resultD = ((float)((2 * Math.PI) * (Math.Sqrt(inputResponse["Mass(kg)"] / inputResponse["SpringStiffness(N/m)"]))));

                //display results to screen
                Console.WriteLine("(2 * Math.PI) * (Math.Sqrt(inputA/inputB))={0}", resultD);
                Console.WriteLine(continueMessage);
                Console.ReadLine();

                //Solve equation for resultE
                Console.WriteLine(stringFive);
                resultE = ((float)(Math.Sqrt((inputResponse["SpringStiffness(N/m)"] / inputResponse["Mass(kg)"]) - ((inputResponse["DampingCoefficient"] / (2 * inputResponse["Mass(kg)"])) * (inputResponse["DampingCoefficient"] / (2 * inputResponse["Mass(kg)"]))))));

                //display results to screen
                Console.WriteLine("(Math.Sqrt((inputB / inputA) - (((inputC / (2 * inputA)) * (inputC / (2 * inputA)))) = {0}", resultE);
                Console.WriteLine("");
                // Console.ReadLine();

                // moreActions = false; //reset moreActions
                // Console.WriteLine(doMorefunctions);
                // inputstring = Console.ReadLine();
                // if (inputstring == "y" || inputstring == "y") moreActions = true;

                /// SECTION 2

                bool shouldContinue = true;

                do
                {
                    string time = "Time(t)";
                    Dictionary<string, float> inputResponse2 = new Dictionary<string, float>(); //Dictionary is used to help define each input and their title. 

                    void collectData2(string message)
                    {
                        string response = "";
                        Console.WriteLine(message);
                        response = Console.ReadLine();

                        if (Single.TryParse(response, out float result))
                        {
                            float parsedResponse = float.Parse(response);
                            inputResponse2.Add(message, parsedResponse);

                        }
                        else
                        {
                            Console.WriteLine(exitMessage);
                            Console.WriteLine(continueMessage);
                            Console.ReadLine();
                            System.Environment.Exit(1);
                        }
                    }

                    collectData2(time);

                    ///Solve equation for resultFit
                    Console.WriteLine(stringSix);
                    //resultF = ((float)(1 * Math.E * (Math.Pow((inputResponse2["DampingCoefficient"] * -1 / (2 * inputResponse2["Mass(kg)"])) * (inputResponse2["Time(t)"])))) * (Math.Cos(resultE * inputResponse2["Time(t)"])));

                    float timeDisplacement = ((float)(1) * (float)(Math.Pow(Math.E, ((inputResponse["DampingCoefficient"] * -1 / (2 * inputResponse["Mass(kg)"])) * (inputResponse2["Time(t)"]))) * (Math.Cos(resultE * inputResponse2["Time(t)"]))));

                    //display results to screen
                    Console.WriteLine("(1 * Math.E(Math.Pow((-inputC/(2 * inputA)) * (inputG)))) * (Math.Cos(resutE * inputG)))={0}", timeDisplacement);
                    Console.WriteLine("");
                    Console.WriteLine(shouldAddNewTime);
                    inputstring = Console.ReadLine();
                    if (inputstring == "y")
                    {
                        shouldContinue = true;
                    }
                    else
                    {
                        shouldContinue = false;
                    }
                } while (shouldContinue);

                moreActions = false; //reset moreActions
                Console.WriteLine(doMorefunctions);
                inputstring = Console.ReadLine();
                if (inputstring == "y" || inputstring == "y") moreActions = true;
            } while (moreActions);
        }

        // class MathFunctions
        //     {
        //         //takes the user inputs and calculates the Period, AngularFrequency, and Time vs. Displacement.
        //         private static void ResultD(float[] inputarray, int numberofInputs)
        //         {
        //             float ResultD = 0.0f;
        //             for (int i = 0; i < numberofInputs; i++)
        //             {
        //                 ResultD = ((float)((2 * Math.PI) * (Math.Sqrt(inputarray[1] / inputarray[2]))));
        //             }
        //             //display results to the screen
        //             Console.WriteLine("ResultD = {0}");
        //         }

        //         private static void ResultE(float[] inputarray, int numberofInputs)
        //         {
        //             float ResultE = 0.0f;
        //             for (int i = 0; i < numberofInputs; i++)
        //             {
        //                 ResultE = ((float)(Math.Sqrt((inputarray[2] / inputarray[1]) - ((inputarray[3] / (2 * inputarray[1])) * (inputarray[3] / (2 * inputarray[1]))))));
        //             }
        //             //display results to the screen
        //             Console.WriteLine("ResultE = {0}");
        //         }
        //         private static void ResultF(float[] inputarray, int numberofInputs)
        //         {
        //             float ResultF = 0.0f;
        //             for (int i = 0; i < numberofInputs; i++)
        //             {
        //                 ResultF = ((float)(1 * Math.E(Math.Pow((-inputarray[3] / (2 * inputarray[1])) * (inputarray[4])))) * (Math.Cos(resultE * inputarray[4])));
        //             }
        //             //display results to the screen
        //             Console.WriteLine("ResultF = {0}");
        //         }

        //     }
    }
}
