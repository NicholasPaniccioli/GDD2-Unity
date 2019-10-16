﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    //The state of the consumable (EX wood block = unrefined, large wood = stage1, medium wood = stage2, small wood = stage3)
    public enum State
    {
        unrefined,
        stage1,
        stage2,
        stage3
    }

    // name for the resource
    public string name;

    public State state;
    
    //A list of sprites, so we can change the image depending on the state of the consumable.  Since we don't have art, this is commented out.
    //public List<Sprite> sprites;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    ///Sets a new state, and Changes the sprite depending on the state of the object.  Since there is no art, that section is commented out
    /// </summary>
    public void changeState(State state)
    {
        this.state = state;
        /*SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        switch (state)
        {
            case State.unrefined:
                renderer.sprite = sprites[0];
                break;
            case State.stage1:
                renderer.sprite = sprites[1];
                break;
            case State.stage2:
                renderer.sprite = sprites[2];
                break;
            case State.stage3:
                renderer.sprite = sprites[3];
                break;
        }*/
    }

}
