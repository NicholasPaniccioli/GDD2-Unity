using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {

    private Tile[,] grid = new Tile[20,9];
    public Tile[,] Grid { get { return grid; } }

    public int width = 20;
    public int height = 9;

    public int x,y = 0;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
