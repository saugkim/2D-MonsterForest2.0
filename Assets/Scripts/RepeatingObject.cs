﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingObject : MonoBehaviour {

    private BoxCollider2D boxCollider;

    private float numberOfBackground = 5f;

    protected float boxColliderHorizontalLength;

    // Use this for initialization
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        boxColliderHorizontalLength = boxCollider.size.x;

    }

   
    public void RepositionBackground()
    {

        Vector2 groundOffset = new Vector2(boxColliderHorizontalLength * numberOfBackground, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}