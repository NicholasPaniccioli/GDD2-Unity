using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcePile : Tile
{
    // Start is called before the first frame update
    void Start()
    {
        isHolding = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override bool Interact(Player player)
    {
        if (player.isHolding)
        {
            return false;
        }
        player.holdingName = holdingName;
        player.holdingState = HoldingState.unrefined;
        player.isHolding = true;
        return true;
    }
}
