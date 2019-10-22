using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workbench : Tile//NOTE, workbench only works with 2 components.  If we decide we decide we want to change the amount of componenents a toy can take, this'll need to be redone.
{
    // Start is called before the first frame update
    public Tuple<string, HoldingState, string, HoldingState> dragonRecipe;
    public Tuple<string, HoldingState, string, HoldingState> swordRecipe;
    public Tuple<string, HoldingState, string, HoldingState> wandRecipe;
    public Tuple<string, HoldingState, string, HoldingState> boatRecipe;

    void Start()
    {
        dragonRecipe = new Tuple<string, HoldingState, string, HoldingState>("Wood", HoldingState.state1, "Cloth", HoldingState.state2);
        swordRecipe = new Tuple<string, HoldingState, string, HoldingState>("Wood", HoldingState.state3, "Wood", HoldingState.state1);
        wandRecipe = new Tuple<string, HoldingState, string, HoldingState>("Wood", HoldingState.state3, "Cloth", HoldingState.state1);
        boatRecipe = new Tuple<string, HoldingState, string, HoldingState>("Wood", HoldingState.state2, "Cloth", HoldingState.state3);
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
                if (player.holdingState == HoldingState.unrefined || player.holdingState == HoldingState.finished || holdingState == HoldingState.unrefined || holdingState == HoldingState.finished)
                {
                    return false;//these items can't be combined into a toy, so return early
                }
                #region compareItems
                    if (player.holdingName == dragonRecipe.Item1 && player.holdingState == dragonRecipe.Item2 && holdingName == dragonRecipe.Item3 && holdingState == dragonRecipe.Item4)
                    {
                        player.holdingName = "dragon";
                        player.holdingState = HoldingState.finished;
                        holdingState = HoldingState.unrefined;
                        holdingName = "";
                        isHolding = false;
                        return true;
                    }
                    else if (holdingName == dragonRecipe.Item1 && holdingState == dragonRecipe.Item2 && player.holdingName == dragonRecipe.Item3 && player.holdingState == dragonRecipe.Item4)
                    {
                        player.holdingName = "dragon";
                        player.holdingState = HoldingState.finished;
                        holdingState = HoldingState.unrefined;
                        holdingName = "";
                        isHolding = false;
                        return true;
                    }
                    else if (player.holdingName == swordRecipe.Item1 && player.holdingState == swordRecipe.Item2 && holdingName == swordRecipe.Item3 && holdingState == swordRecipe.Item4)
                    {
                        player.holdingName = "sword";
                        player.holdingState = HoldingState.finished;
                        holdingState = HoldingState.unrefined;
                        holdingName = "";
                        isHolding = false;
                        return true;
                    }
                    else if (holdingName == swordRecipe.Item1 && holdingState == swordRecipe.Item2 && player.holdingName == swordRecipe.Item3 && player.holdingState == swordRecipe.Item4)
                    {
                        player.holdingName = "sword";
                        player.holdingState = HoldingState.finished;
                        holdingState = HoldingState.unrefined;
                        holdingName = "";
                        isHolding = false;
                        return true;
                    }
                    else if (player.holdingName == wandRecipe.Item1 && player.holdingState == wandRecipe.Item2 && holdingName == wandRecipe.Item3 && holdingState == wandRecipe.Item4)
                    {
                        player.holdingName = "wand";
                        player.holdingState = HoldingState.finished;
                        holdingState = HoldingState.unrefined;
                        holdingName = "";
                        isHolding = false;
                        return true;
                    }
                    else if (holdingName == wandRecipe.Item1 && holdingState == wandRecipe.Item2 && player.holdingName == wandRecipe.Item3 && player.holdingState == wandRecipe.Item4)
                    {
                        player.holdingName = "wand";
                        player.holdingState = HoldingState.finished;
                        holdingState = HoldingState.unrefined;
                        holdingName = "";
                        isHolding = false;
                        return true;
                    }
                    else if (player.holdingName == boatRecipe.Item1 && player.holdingState == boatRecipe.Item2 && holdingName == boatRecipe.Item3 && holdingState == boatRecipe.Item4)
                    {
                        player.holdingName = "boat";
                        player.holdingState = HoldingState.finished;
                        holdingState = HoldingState.unrefined;
                        holdingName = "";
                        isHolding = false;
                        return true;
                    }
                    else if (holdingName == boatRecipe.Item1 && holdingState == boatRecipe.Item2 && player.holdingName == boatRecipe.Item3 && player.holdingState == boatRecipe.Item4)
                    {
                        player.holdingName = "boat";
                        player.holdingState = HoldingState.finished;
                        holdingState = HoldingState.unrefined;
                        holdingName = "";
                        isHolding = false;
                        return true;
                    }
                #endregion
                //if this is true, set the players holdingState to HoldingState.finished, their isHolding to true, and their holdingName to the completed toys name
                //then set the bench's holdingName to "", and the isHolding to false
            }
            else//if the player has nothing in hand, pick up the object
            {
                player.holdingName = holdingName;
                player.holdingState = holdingState;
                player.isHolding = true;
                holdingName = "";
                isHolding = false;
                return true;
            }
        }
        return false;
    }
}
