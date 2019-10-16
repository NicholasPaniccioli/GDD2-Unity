using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldItem : MonoBehaviour
{
    public List<GameObject> items;
    public string acceptedResource; //the resource this machine refines


    // Start is called before the first frame update
    void Start()
    {

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
    bool SetItem(GameObject item)
    {
        if ((item.GetComponent<Resources>().name == acceptedResource || item.GetComponent<Resources>().name == "All") && items.Count < items.Capacity)
        {
            items.Add(item);
            return true;
        }
        else
            return false;
    }
}
