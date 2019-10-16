using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RefineResource : MonoBehaviour
{
    private GameObject currentItem; //the item that is being worked
    private Resources currentResource;  //reference to the items resource script, to update its state
    private HoldItem holdItem;  //reference to this tables hold method
    public int interval;  //the time it takes for items to change state
    public State state;


    // Start is called before the first frame update
    void Start()
    {
        currentItem = null;
        holdItem = gameObject.GetComponent<HoldItem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentItem == null &&  holdItem.items.Count != 0)
        {
            currentItem = holdItem.items[0];
            currentResource = currentItem.GetComponent<Resources>();
            StartCoroutine("LoseTime");
        }
    }

    /// <summary>
    ///Method to adjust the timer
    /// </summary>
    /// <returns></returns>
    IEnumerator LoseTime()
    {
        while (currentResource.GetState() != State.stage3)
        {
            yield return new WaitForSeconds(interval);
            switch (currentResource.GetState())
            {
                case State.unrefined:
                    currentResource.SetState(State.stage1);
                    break;
                case State.stage1:
                    currentResource.SetState(State.stage2);
                    break;
                case State.stage2:
                    currentResource.SetState(State.stage3);
                    break;

            }
            state = currentResource.GetState();
        }
    }
}
