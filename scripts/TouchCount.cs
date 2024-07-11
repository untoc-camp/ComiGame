using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Num1 : MonoBehaviour
{
    Rigidbody2D sqr;
    public bool Touched;

    void Awake() {
        sqr = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Debug.Log("start");
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
