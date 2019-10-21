using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Tile
{
    // Start is called before the first frame update
    void Start()
    {
        isHolding = false;
        holdingName = null;
        holdingState = HoldingState.unrefined;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
