using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Started by Kyle
    // Will handle the list of toys, the clock, and what the player is holding in the top right.

    bool isPlayerHolding;       // is the player holding something or not
    string playerHoldingName;   // name of the object the player is holding
    List<string> toyList;       // list of toys from Santa's Sack
    SantasSack santasSack;      // reference to Santa's Sack
    Player player;              // reference to the Player

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();     // get the Player script
        isPlayerHolding = player.isHolding;     // set the isPlayerHolding bool
        playerHoldingName = player.holdingName; // set the name of what the player is holding

        // Will break because there is no Santa's Sack object yet
        //santasSack = GameObject.Find("Santa's Sack").GetComponent<SantasSack>();    // get the SantasSack script
        //toyList = santasSack.toyList;   // set the list of toys from SantasSack
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update the list of toys
    void ChangeToyList()
    {
    }

    // Update the holding indicator in the top right
    void ChangeHoldingIndicator()
    {
    }

    // Update the clock
    void Clock()
    {

    }
}
