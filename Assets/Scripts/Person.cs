using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public enum Gender { Male, Female };
    public Gender gender;

    // ENCAPSULATION
    private int _age;
    public int age
    {
        get { return _age; }
        set
        {
            if (age < 0)
            {
                Debug.LogError("Age cannot be negative");
            }

            else
            {
                _age = value;
            }

        }
    }

    // ABSTRACTION
    public virtual void Walk()
    {
        Debug.Log("Walking");
    }
    public virtual void Talk()
    {
        Debug.Log("Talking");
    }
    public virtual void Sing()
    {
        Debug.Log("Singing");
    }
}
