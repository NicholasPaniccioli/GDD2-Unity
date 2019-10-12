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

    /// <summary>
    /// Adds an item to its holding list
    /// </summary>
    /// <param name="item">the item to add</param>
    /// <returns></returns>
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
