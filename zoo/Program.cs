using System;
using System.Data;
using System.Net;
using System.Runtime.CompilerServices;

string[] pettingZoo = 
            {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };

    planschoolvisit("school A",6);
    planschoolvisit("school B", 2);
    void planschoolvisit(string schoolname,int groups)
        {
        RandomizeAnimals();
        string[,] group1 = AssingGroups(groups);
        Console.WriteLine(schoolname);
        printGroup(group1);
        }


    void RandomizeAnimals()
    {
        Random rand = new Random();
        for(int i=0; i<pettingZoo.Length; i++)
        {
            

            int r = rand.Next(i,pettingZoo.Length);

            string temp = pettingZoo[i];
            pettingZoo[i] = pettingZoo[r];
            pettingZoo[r] = temp;
        }
        
    }

string[,] AssingGroups(int groups)
{
    string[,] result = new string[groups,pettingZoo.Length/groups];
    int start = 0;
    for(int i=0; i<groups; i++)
    {
        for(int j=0; j<result.GetLength(1); j++)
        {
            result[i,j] = pettingZoo[start++];
        }
    }
    return result;
}

void printGroup(string[,] print)
{
    for(int i=0 ;i<print.GetLength(0); i++)
    {
        Console.Write($"Group{i+1}: ");
        for(int j=0; j<print.GetLength(1); j++)
        {
            Console.Write($"{print[i,j]} ");
        }
        Console.WriteLine();
    }
}



   
