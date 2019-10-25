using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Tile
{
    // Start is called before the first frame update
    private int animationFrame;
    public bool canMove;
    void Start()
    {
        isHolding = false;
        canMove = true;
        holdingName = null;
        holdingState = HoldingState.unrefined;
        animationFrame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Move(float moveDelay, Vector3 direction)
    {
        Vector3 move = direction / 10;
        canMove = false;
        while (animationFrame != 10 )
        {
            yield return new WaitForSeconds(moveDelay / 10);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + move.x, gameObject.transform.position.y + move.y, gameObject.transform.position.z + move.z);
            animationFrame++;
        }
        gameObject.transform.position = new Vector3(Mathf.RoundToInt(gameObject.transform.position.x), Mathf.RoundToInt(gameObject.transform.position.y), Mathf.RoundToInt(gameObject.transform.position.z));
        canMove = true;
        animationFrame = 0;
    }
}
