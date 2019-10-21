using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workbench : Tile//NOTE, workbench only works with 2 components.  If we decide we decide we want to change the amount of componenents a toy can take, this'll need to be redone.
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Combine resources together to make a toy
    public override bool Interact(Player player)
    {
        if (!isHolding && player.isHolding)
        {
            isHolding = true;
            holdingName = player.holdingName;
            holdingState = player.holdingState;
            player.holdingName = "";
            player.isHolding = false;
        }
        else if(isHolding)
        {
            if (player.isHolding)//if the player has something in hand, combine the 2 into a toy
            {
                //if (compare the item in the players hand, plus the item already on the bench, to a list of possible combinations)
                //if this is true, set the players holdingState to HoldingState.finished, their isHolding to true, and their holdingName to the completed toys name
                //then set the bench's holdingName to "", and the isHolding to false
            }
            else//if the player has nothing in hand, pick up the object
            {
                player.holdingName = holdingName;
                player.holdingState = HoldingState.unrefined;
                player.isHolding = true;
                holdingName = "";
                isHolding = false;
                return true;
            }
        }
        return false;
    }
}
