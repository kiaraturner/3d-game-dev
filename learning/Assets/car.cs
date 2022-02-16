using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle
{
    private int speed;

    public Vehicle(int _speed)
    {
        speed = _speed;
    }

    public abstract void Drive();
}

public class Toyota : Vehicle
{

    public Toyota(int _speed) : base(_speed)
    {

    }

    public override void Drive()
    {
        Debug.Log("We be cruising");
    }
}

