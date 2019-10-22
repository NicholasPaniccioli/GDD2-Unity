using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingBench : Tile
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override bool Interact(Player player)
    {
        if (player.isHolding && !isHolding)
        {
            holdingName = player.holdingName;
            holdingState = player.holdingState;
            isHolding = true;
            player.isHolding = false;
            player.holdingName = "";
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
}
