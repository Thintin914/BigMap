using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Sprite[] pointImages;
    //Up, Down, Left, Right
    public Point[] connectingPoints = new Point[4];
    public bool isPath = true;
    public SpriteRenderer sr;
    public int index;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sortingLayerName = "point";
        if (isPath)
        {
            sr.sprite = null;
        }
        else
        {
            sr.sprite = pointImages[0];
        }
    }
}
