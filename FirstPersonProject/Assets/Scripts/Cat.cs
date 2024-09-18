using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    // Properties
    public string Name;
    public int Age;

    // Method to simulate a cat meowing
    public void Meow()
    {
        Debug.Log(name + "Cat says Meow!");
    }
}
