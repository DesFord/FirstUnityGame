using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UpdateSize();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseUp()
    {
        Debug.Log("TEST");
    }

    void UpdateSize()
    {
        Bounds bounds = GetComponent<SpriteRenderer>().bounds;
        if (bounds.size.x != 1 || bounds.size.y != 1)
        {
            Vector3 Scale = new Vector3(1 / bounds.size.x, 1 / bounds.size.y, 1);
            this.transform.localScale = Scale;
            //this.GetComponent<BoxCollider2D>().size = new Vector2(1, 1);
        }
    }
}
