﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // configuration paramaters
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minUnitPaddle = 1f;
    [SerializeField] float maxUnitPaddle = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minUnitPaddle, maxUnitPaddle);
        transform.position = paddlePos;
    }
}
