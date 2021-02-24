using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public GameObject PlayerNamesOb;
    public Text PlayerNamesObText;
    public InputField inputField;
    public int playerNum;
    private string player1Name;
    private string player2Name;


    void Awake()    
    {
        if(instance == null)
        {

            instance = this;

        }
        else
        {
            Destroy(instance);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        playerNum = 1;
        PlayerNamesObText.text = "What is Player One's Name?";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SubmitName()
    {
        if(playerNum == 1)
        {
            player1Name = inputField.text;
            playerNum = 2;
            PlayerNamesObText.text = "What is Player Two's Name?";
            inputField.text = null;
        }
        else if(playerNum == 2)
        {
            player2Name = inputField.text;
            Debug.Log("player 1 name: " + player1Name);
            Debug.Log("player 2 name: " + player2Name);
        }
    

    }
}
