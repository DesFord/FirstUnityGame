using UnityEngine;
using System.Collections;

public class GameGridBehavior : MonoBehaviour {
    public int gridX;
    public int gridY;
    public Cell[,] grid;
    public GameObject cellTemplate;

    // Use this for initialization
    void Start()
    {
        grid = new Cell[gridX, gridY];
        Random.seed = (int)System.DateTime.Now.Ticks;
        for (int x = 0; x < gridX; x++)
        {
            for (int y = 0; y < gridY; y++)
            {
                grid[x, y] = ((GameObject)Instantiate(cellTemplate, new Vector2(x, y), Quaternion.identity)).GetComponent<Cell>();
            }
        }
        //this.GetComponent<BoxCollider2D>().size = new Vector2(gridX, gridY);
        //this.GetComponent<BoxCollider2D>().offset = new Vector2(gridX / 2, gridY / 2);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
