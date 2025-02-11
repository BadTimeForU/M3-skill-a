using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{

    SpriteRenderer spriteRenderer;  
    bool state = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state)
        {
            spriteRenderer.color = Color.green;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }
    }
    void OnMouseUp()
    {
        state = !state;
    }
}
