using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingBench : Tile
{
    public GameObject UI;
    private UIManager uiManager;
    private Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.Find("UI Manager");
        uiManager = UI.GetComponent<UIManager>();
        sprites = uiManager.sprites;
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
            GameObject indicator = new GameObject("Holding Sprite");
            indicator.AddComponent<SpriteRenderer>();
            uiManager.ChangeHoldingIndicator(indicator.GetComponent<SpriteRenderer>());
            indicator.transform.parent = gameObject.transform;
            indicator.transform.localPosition = Vector3.zero;

            return true;
        }
        else if (isHolding && !player.isHolding)
        {
            player.isHolding = true;
            player.holdingState = holdingState;
            player.holdingName = holdingName;
            isHolding = false;
            holdingName = "";
            GameObject.Destroy(gameObject.transform.Find("Holding Sprite").gameObject);
            return true;
        }
        else return false;
    }
}
