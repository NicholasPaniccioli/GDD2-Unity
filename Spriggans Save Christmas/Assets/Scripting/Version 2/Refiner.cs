﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refiner : Tile
{
    public float intervalTime;
    public string neededItem;
    public Sprite[] sprites = new Sprite[3];
    private int currentSprite;

    // Start is called before the first frame update
    void Start()
    {
        currentSprite = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHolding)
        {
            if (currentSprite >= 12)
            {
                currentSprite = 0;
            }
            else
            {
                currentSprite++;
            }
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[currentSprite / 6];
        }
    }

    // Changes the state of the resource
    public override bool Interact(Player player)
    {
        if (player.isHolding && player.holdingName == neededItem && !isHolding)
        {
            holdingName = player.holdingName;
            holdingState = player.holdingState;
            isHolding = true;
            player.isHolding = false;
            player.holdingName = "";
            StartCoroutine(LoseTime(player));
            return true;
        }
        else if (isHolding && !player.isHolding)
        {
            player.isHolding = true;
            player.holdingState = holdingState;
            player.holdingName = holdingName;
            isHolding = false;
            holdingName = "";
            return true;
        }
        else return false;
    }

    /// <summary>
    ///Method to adjust the timer
    /// </summary>
    /// <returns></returns>
    IEnumerator LoseTime(Player player)
    {
        if(PauseMenu.paused == false)
        {
            while (isHolding && player.holdingState != HoldingState.state3)
            {
                yield return new WaitForSeconds(intervalTime);
                switch (holdingState)
                {
                    case HoldingState.unrefined:
                        holdingState = HoldingState.state1;
                        break;
                    case HoldingState.state1:
                        holdingState = HoldingState.state2;
                        break;
                    case HoldingState.state2:
                        holdingState = HoldingState.state3;
                        break;
                }
            
            }
        }

    }
}
