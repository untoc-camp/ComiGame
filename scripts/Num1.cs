using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TouchCount : MonoBehaviour
{
    public bool Touched;
    Rigidbody2D sqr;
    void Awake() {
        sqr = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Touched) {
            Debug.Log("Touched");
            sqr.velocity = Vector2.up*10;
        }
    }
    public void isTouched() {
        Touched = true;
        sqr.simulated = true;
    }
}
