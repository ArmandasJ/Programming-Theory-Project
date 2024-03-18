using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text player1NameField;
    public Text player2NameField;
    public Text player3NameField;
    public Text player1Tooltip;
    public Text player2Tooltip;
    public Text player3Tooltip;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetPlayer1Name(string name)
    {
        player1NameField.text = name;
    }

    public void SetPlayer2Name(string name)
    {
        player2NameField.text = name;
    }

    public void SetPlayer3Name(string name)
    {
        player3NameField.text = name;
    }

    public void SetPlayer1Talk(string talk)
    {
        player1Tooltip.text = talk;
    }

    public void SetPlayer1Walk(string walk)
    {
        player1Tooltip.text = walk;
    }
    public void SetPlayer1Sing(string sing)
    {
        player1Tooltip.text = sing;
    }


    public void SetPlayer2Talk(string talk)
    {
        player2Tooltip.text = talk;
    }

    public void SetPlayer2Walk(string walk)
    {
        player2Tooltip.text = walk;
    }
    public void SetPlayer2Sing(string sing)
    {
        player2Tooltip.text = sing;
    }

    public void SetPlayer3Talk(string talk)
    {
        player3Tooltip.text = talk;
    }

    public void SetPlayer3Walk(string walk)
    {
        player3Tooltip.text = walk;
    }
    public void SetPlayer3Sing(string sing)
    {
        player3Tooltip.text = sing;
    }
}
