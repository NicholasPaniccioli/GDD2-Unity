﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refiner : Tile
{
    public float intervalTime;
    public int fakeTime = 0;
    public string neededItem;
    public Sprite[] sprites = new Sprite[3];
    public Sprite[] progressSprites = new Sprite[31];
    private int currentSprite;
    private bool removed;
    private SpriteRenderer spriteRenderer;
    private GameObject progressBar;

    // Start is called before the first frame update
    void Start()
    {
        currentSprite = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
        removed = true;

        progressBar = new GameObject("Progress Sprite");
        progressBar.AddComponent<SpriteRenderer>();
        progressBar.transform.parent = gameObject.transform;
        progressBar.transform.localPosition = new Vector3(0, 0.4f, -0.01f);
        progressBar.GetComponent<SpriteRenderer>().sprite = progressSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        ProgressBar();
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
        else
        {
            progressBar.GetComponent<SpriteRenderer>().sprite = progressSprites[0];
            progressBar.SetActive(false);
            fakeTime = 30;
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
            if (holdingState == HoldingState.unrefined)
            {
                removed = false;
            }
            spriteRenderer.color = new Color(Color.white.r - (float)(0.2*(int)holdingState), Color.white.g - (float)(0.2 * (int)holdingState), Color.white.b - (float)(0.2 * (int)holdingState), Color.white.a);
            StartCoroutine(LoseTime(player));
            return true;
        }
        else if (isHolding && !player.isHolding)
        {
            removed = true;
            player.isHolding = true;
            player.holdingState = holdingState;
            player.holdingName = holdingName;
            isHolding = false;
            holdingName = "";
            spriteRenderer.color = Color.white;
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
        while (isHolding && player.holdingState != HoldingState.state3)
        {
            progressBar.SetActive(true);
            if (PauseMenu.paused == false)
            {
                yield return new WaitForSeconds(intervalTime);
                if (!removed)
                {
                    switch (holdingState)
                    {
                        case HoldingState.unrefined:
                            holdingState = HoldingState.state1;
                            spriteRenderer.color = new Color(spriteRenderer.color.r - 0.2f, spriteRenderer.color.g - 0.2f, spriteRenderer.color.b - 0.2f, spriteRenderer.color.a);
                            break;
                        case HoldingState.state1:
                            holdingState = HoldingState.state2;
                            spriteRenderer.color = new Color(spriteRenderer.color.r - 0.2f, spriteRenderer.color.g - 0.2f, spriteRenderer.color.b - 0.2f, spriteRenderer.color.a);
                            break;
                        case HoldingState.state2:
                            holdingState = HoldingState.state3;
                            spriteRenderer.color = new Color(spriteRenderer.color.r - 0.2f, spriteRenderer.color.g - 0.2f, spriteRenderer.color.b - 0.2f, spriteRenderer.color.a);
                            break;
                    }
                }
                else
                {
                    removed = false;
                    yield break;
                }
            }
        }
    }

    // show/change progress bar
    void ProgressBar()
    {
        if (isHolding)
        {
            fakeTime++;
            switch (holdingState)
            {
                case HoldingState.unrefined:
                    progressBar.GetComponent<SpriteRenderer>().sprite = progressSprites[(fakeTime/30)];
                    break;
                case HoldingState.state1:
                    progressBar.GetComponent<SpriteRenderer>().sprite = progressSprites[(fakeTime / 30) + 10];
                    break;
                case HoldingState.state2:
                    progressBar.GetComponent<SpriteRenderer>().sprite = progressSprites[(fakeTime / 30) + 20];
                    break;
                default:
                    progressBar.GetComponent<SpriteRenderer>().sprite = progressSprites[0];
                    break;
            }
            if(fakeTime >= 300)
            {
                fakeTime = 30;
            }
        }
        else
        {
            fakeTime = 30;
        }
    }
}
