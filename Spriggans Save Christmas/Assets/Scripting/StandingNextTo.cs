using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingNextTo : MonoBehaviour
{
    Vector2 currentPos;
    Vector2 forwardVec;

    // Start is called before the first frame update
    void Start()
    {
        currentPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = gameObject.transform.position;

    }
}
