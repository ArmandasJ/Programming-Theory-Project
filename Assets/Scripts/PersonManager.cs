using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class PersonManager : MonoBehaviour
{
    // Inheritance
    [SerializeField]
    Person John;
    [SerializeField]
    Person Lucy;
    [SerializeField]
    Person Mike;
    private UIManager _uiManager;
    // Start is called before the first frame update
    void Start()
    {
        John = new Person("John", "Doe", Person.Gender.Male, 34);
        Debug.Log(John.age);

        Lucy = new Person("Lucy", "Smith", Person.Gender.Female, 25);

        Mike = new Person("Mike", "Jones", Person.Gender.Male, 42);

        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _uiManager.SetPlayer1Name(John.firstName + " " + John.lastName);
        _uiManager.SetPlayer2Name(Lucy.firstName + " " + Lucy.lastName);
        _uiManager.SetPlayer3Name(Mike.firstName + " " + Mike.lastName);

    }



    public void OnP1Talk()
    {
        _uiManager.SetPlayer1Talk(John.Talk());
    }

    public void OnP1Walk()
    {
        _uiManager.SetPlayer1Walk(John.Walk());
    }

    public void OnP1Sing()
    {
        _uiManager.SetPlayer1Sing(John.Sing());
    }

    public void OnP2Talk()
    {
        _uiManager.SetPlayer2Talk(Lucy.Talk());
    }

    public void OnP2Walk()
    {
        _uiManager.SetPlayer2Walk(Lucy.Walk());
    }

    public void OnP2Sing()
    {
        _uiManager.SetPlayer2Sing("La la la la laaaa");
    }
    public void OnP3Talk()
    {
        _uiManager.SetPlayer3Talk(Mike.Talk());
    }

    public void OnP3Walk()
    {
        _uiManager.SetPlayer3Walk(Mike.Walk());
    }

    public void OnP3Sing()
    {
        _uiManager.SetPlayer3Sing(Mike.Sing());
    }



    // Update is called once per frame
    void Update()
    {

    }
}
