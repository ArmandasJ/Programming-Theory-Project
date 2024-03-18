using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Person
{
    public string firstName;
    public string lastName;
    public enum Gender { Male, Female };
    public Gender gender;

    // ENCAPSULATION
    [SerializeField]
    private int _age;
    public int age
    {
        get { return _age; }
        set
        {
            if (value < 0)
            {
                Debug.LogError("Age cannot be negative");
            }

            else
            {
                _age = value;
            }

        }
    }

    [SerializeField]
    GameObject figure;

    // ABSTRACTION
    public virtual string Walk()
    {
        return "Walking";
    }
    public virtual string Talk()
    {
        return "Talking";
    }
    public virtual string Sing()
    {
        return "Singing";
    }

    public Person(string firstName, string lastName, Gender gender, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.age = age;
    }
}
