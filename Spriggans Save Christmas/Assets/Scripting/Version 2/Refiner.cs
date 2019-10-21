using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refiner : Tile
{
    public float intervalTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Changes the state of the resource
    public override bool Interact(Player player)
    {
        if (!player.isHolding)
        {
            return false;
        }
        //StartCoroutine(LoseTime(player));
        return true;
    }

    /// <summary>
    ///Method to adjust the timer
    /// </summary>
    /// <returns></returns>
    //IEnumerator LoseTime(Player player)
   // {
        //while (player.holdingState != HoldingState.state3)
        //{
        //    yield return new WaitForSeconds(intervalTime);
        //    if (removed)
        //    {
        //        break;
        //    }
        //    switch (player.holdingState())
        //    {
        //        case State.unrefined:
        //            currentResource.SetState(State.stage1);
        //            break;
        //        case State.stage1:
        //            currentResource.SetState(State.stage2);
        //            break;
        //        case State.stage2:
        //            currentResource.SetState(State.stage3);
        //            break;
        //    }
        //    state = currentResource.GetState();
        //}
    //}
}
