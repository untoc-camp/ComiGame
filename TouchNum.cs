using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TouchNum : MonoBehaviour, IPointerClickHandler
{
    public static bool touch01 = false;
    public static bool touch02 = false;
    public static bool touch03 = false;
    public static bool touch04 = false;
    public static bool touch05 = false;
    public static bool touch06 = false;
    public static bool touch07 = false;
    public static bool touch08 = false;
    public static bool touch09 = false;
    public static bool touch10 = false;
    public static bool touch11 = false;
    public static bool touch12 = false;
    public static bool touch13 = false;
    public static bool touch14 = false;
    public static bool touch15 = false;
    public static bool touch16 = false;

    Rigidbody2D sqr;
    public void OnPointerClick(PointerEventData eventData)
    {           
        TouchNum.touch01 = true;
        if(TouchNum.touch01 == true) {
            sqr.velocity = Vector2.up*10;
            TouchNum.touch02 = true;
        }
        else sqr.velocity = Vector2.up*0;
    }

    // Start is called before the first frame update
    void Start()
    {
        sqr = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
