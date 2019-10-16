using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The state of the consumable (EX wood block = unrefined, large wood = stage1, medium wood = stage2, small wood = stage3)
public enum State
{
    unrefined = 0,
    stage1 = 1,
    stage2 = 2,
    stage3 = 3
}

public class Resources : MonoBehaviour
{
    // name for the resource
    public string name;

    private State state;
    
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
    public void SetState(State newState)
    {
        state = newState;
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

    public State GetState(){ return state; }

    
}
