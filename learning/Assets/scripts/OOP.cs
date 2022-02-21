using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOP : MonoBehaviour
{
    private void Start()
    {
        Fish fish; // create empty variable that stores fish datatype
        //insubstanciate fish and store in variable
        fish = new Fish("idk",7);
        fish.PrintAnimal();
        
    }
}


//abstact classes can only be inherited from, not instanciated
public abstract class Animal
{
    //ecapsulated data can only be changed from within the class
    private string name;
    private int age;

    //class constructor for instantising the object
    public Animal(string _name, int _age) // class constructor
    {
        name = _name;
        age = _age; 
    }

    public abstract void Eat();
    public abstract void Eat(string food);

    public virtual void PrintAnimal()
    {
        Debug.Log("Name:"+ name);
        Debug.Log("Age:"+ age);

    }
}

// Fish class inherits the animal class
public class Fish : Animal
{
    //fish constructor
    //passes parameters to base class constructor

    public Fish(string _name, int _age) : base(_name, _age)
    {
     
    }

    // override version of animals eat method
    public override void Eat()
    {
        Debug.Log("Fish is eating");
    }

    public override void Eat(string food)
    {
        Debug.Log("Fish has eaten" + food);
    }

    // Extended version of animals PrintAnimal method
    public override void PrintAnimal()
    {
        Debug.Log("This is a fish");
    }
}