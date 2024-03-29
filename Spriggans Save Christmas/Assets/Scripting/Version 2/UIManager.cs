﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Started by Kyle
    // Will handle the list of toys, the clock, and what the player is holding in the top right.

    bool isPlayerHolding;       // is the player holding something or not
    string playerHoldingName;   // name of the object the player is holding
    HoldingState holdingState;
    List<string> toyList;       // list of toys from Santa's Sack
    SantasSack santasSack;      // reference to Santa's Sack
    Player player;              // reference to the Player
    GameObject holdingIndicator; // refernece to the holding indicator in the top right
    SpriteRenderer holdingIndicatorSR;  // reference to the holding indicator's sprite renderer

    public Sprite[] sprites;

    TextMeshProUGUI holdingText;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();     // get the Player script
        isPlayerHolding = player.isHolding;     // set the isPlayerHolding bool
        playerHoldingName = player.holdingName; // set the name of what the player is holding
        holdingState = player.holdingState;

        santasSack = GameObject.Find("Santa Bag").GetComponent<SantasSack>();    // get the SantasSack script
        toyList = santasSack.toyList;   // set the list of toys from SantasSack

        holdingIndicator = GameObject.Find("Holding Indicator");
        holdingIndicatorSR = GameObject.Find("Holding Indicator").GetComponent<SpriteRenderer>();

        holdingText = GameObject.Find("Player Holding UI").GetComponentInChildren<TextMeshProUGUI>(); // get the TextMesh Pro UGUI
    }

    // Update is called once per frame
    void Update()
    {
        isPlayerHolding = player.isHolding;
        playerHoldingName = player.holdingName;
        
        ChangeHoldingIndicator(holdingIndicatorSR);
        
    }

    // Update the list of toys
    void ChangeToyList(SantasSack santasSack, string playerHoldingName)
    {
        santasSack.CheckGift(playerHoldingName);    // CheckGift already updates the list
    }

    // Update the holding indicator in the top right
    public void ChangeHoldingIndicator(SpriteRenderer holdingIndicatorSR)
    {
        for(int i = 0; i < sprites.Length; i++)
        {
            
            if (playerHoldingName == "Wood")    // if the player is holding Wood
            {
                //Debug.Log("Player is holding Wood");
                switch(player.holdingState)
                {
                    case HoldingState.unrefined:
                        holdingIndicatorSR.sprite = sprites[4]; // changes sprite to WoodRough
                        holdingText.SetText("Rough Wood");
                        break;
                    case HoldingState.state1:
                        holdingIndicatorSR.sprite = sprites[5]; // changes sprite to WoodLarge
                        holdingText.SetText("Large Wood");
                        break;
                    case HoldingState.state2:
                        //Debug.Log("Wood is unrefined");
                        holdingIndicatorSR.sprite = sprites[6]; // changes sprite to WoodMedium
                        holdingText.SetText("Medium Wood");
                        break;
                    case HoldingState.state3:
                        holdingIndicatorSR.sprite = sprites[7]; // changes sprite to WoodSmall
                        holdingText.SetText("Small Wood");
                        break;
                }
            }
            else if(playerHoldingName == "Cloth")   // if the player is holding Cloth
            {
                //Debug.Log("Player is holding Cloth");
                switch (player.holdingState)
                {
                    case HoldingState.unrefined:
                        holdingIndicatorSR.sprite = sprites[8]; // changes sprite to ClothRough
                        holdingText.SetText("Rough Cloth");
                        break;
                    case HoldingState.state1:
                        holdingIndicatorSR.sprite = sprites[11]; // changes sprite to ClothSmall
                        holdingText.SetText("Small Cloth");
                        break;
                    case HoldingState.state2:
                        //Debug.Log("Wood is unrefined");
                        holdingIndicatorSR.sprite = sprites[10]; // changes sprite to ClothMedium
                        holdingText.SetText("Medium Cloth");
                        break;
                    case HoldingState.state3:
                        holdingIndicatorSR.sprite = sprites[9]; // changes sprite to ClothLarge
                        holdingText.SetText("Large Cloth");
                        break;
                }
            }
            else if(playerHoldingName == "Coal")    // if the player is holding Coal
            {
                //Debug.Log("Player is holding Coal");
                holdingIndicatorSR.sprite = sprites[12]; // changes sprite to Coal
                holdingText.SetText("Coal");
            }

            else if(playerHoldingName == "Boat")    // if the player is holding Boat
            {
                //Debug.Log("Player is holding Boat");
                holdingIndicatorSR.sprite = sprites[0]; // change sprite to Boat
                holdingText.SetText("Boat");
            }

            else if (playerHoldingName == "Dragon")    // if the player is holding Dragon
            {
                //Debug.Log("Player is holding Dragon");
                holdingIndicatorSR.sprite = sprites[1]; // change sprite to Dragon
                holdingText.SetText("Dragon");
            }

            else if (playerHoldingName == "Sword")    // if the player is holding Sword
            {
                //Debug.Log("Player is holding Sword");
                holdingIndicatorSR.sprite = sprites[2]; // change sprite to Sword
                holdingText.SetText("Sword");
            }

            else if (playerHoldingName == "Wand")    // if the player is holding Wand
            {
                //Debug.Log("Player is holding Wand");
                holdingIndicatorSR.sprite = sprites[3]; // change sprite to Wand
                holdingText.SetText("Wand");
            }
            else
            {
                holdingIndicatorSR.sprite = null;
                holdingText.SetText("Nothing");
            }
        }
    }

    // Update the clock
    void Clock()
    {

    }
}
