﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorAffordance: MonoBehaviour {

    [SerializeField] Texture2D walkCursor = null;
    [SerializeField] Texture2D targetCursor = null;
    [SerializeField] Texture2D unknownCursor = null;
    [SerializeField] Vector2 cursorHotspot = new Vector2(0, 0);

    CameraRaycaster ray;

	// Use this for initialization
	void Start () {
        ray = FindObjectOfType<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void Update () {
        switch (ray.layerHit){
            case Layer.Walkable:
                Cursor.SetCursor(walkCursor, cursorHotspot, CursorMode.Auto);
                break;
            case Layer.Enemy:
                Cursor.SetCursor(targetCursor, cursorHotspot, CursorMode.Auto);
                break;
            default:
                Cursor.SetCursor(unknownCursor, cursorHotspot, CursorMode.Auto);
                return;
        }

    }

   
}
