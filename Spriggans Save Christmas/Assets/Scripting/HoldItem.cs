using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldItem : MonoBehaviour
{
    public List<GameObject> items;
    public int maxSize;

    // Start is called before the first frame update
    void Start()
    {
        items = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool GetItem(GameObject item)
    {
        if (items.Count < maxSize)
        {
            items.Add(item);
            return true;
        }
        else
            return false;
    }
}
