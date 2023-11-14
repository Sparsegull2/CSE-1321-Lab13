/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab13A
*/

using System;

class BuildingBlueprint
{
    private int stories;
    private int rooms;
    private float occ;
    private bool full;

    public BuildingBlueprint()
    {
        stories = 10;
        rooms = 20;
        occ = 1.0f;
        full = true;
    }
    public BuildingBlueprint(int s,int r, float o)
    {
        stories = s;
        rooms=r;
        occ = o;
        if (o == 1.0) 
        {
            full = true;
        }
        else
        {
            full=false;
        }
    }
    public int getStories()
    {
        return stories;
    }
    public int getRooms() 
    { 
        return rooms;
    }
    public float getOcc()
    {
        return occ;
    }
    public bool getFull()
    {
        return full;
    }
    public void setOcc(float o)
    { 
        occ = o; 
        if (o == 1.0)
        {
            full = true;
        }
        else
        {
            full = false;
        }
    }
}
class Lab13A
{

    public static void Main(string[] args)
    {
        BuildingBlueprint buildingOne=new BuildingBlueprint();
        BuildingBlueprint buildingTwo=new BuildingBlueprint(30,30,.75f);
        
        Console.WriteLine("Year 2020:");
        Console.WriteLine("Building 1 has "+buildingOne.getStories()+" floors, "+buildingOne.getRooms()+" apartments, and is "+buildingOne.getOcc()*100+"% occupied. Full? "+buildingOne.getFull());

        Console.WriteLine("Building 1 has " + buildingTwo.getStories() + " floors, " + buildingTwo.getRooms() + " apartments, and is " + buildingTwo.getOcc() * 100 + "% occupied. Full? " + buildingTwo.getFull());
        Console.WriteLine("\nMany years pass.\n");
        buildingOne.setOcc(0.0f);
        buildingTwo.setOcc(1.0f);
        Console.WriteLine("Year 2043:");
        Console.WriteLine("Building 1 has " + buildingOne.getStories() + " floors, " + buildingOne.getRooms() + " apartments, and is " + buildingOne.getOcc() * 100 + "% occupied. Full? " + buildingOne.getFull());
        Console.WriteLine("Building 1 has " + buildingTwo.getStories() + " floors, " + buildingTwo.getRooms() + " apartments, and is " + buildingTwo.getOcc() * 100 + "% occupied. Full? " + buildingTwo.getFull());
        Console.WriteLine("\nLooks like people prefer taller buildings.");

    }
}


