using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Touch02 : MonoBehaviour, IPointerClickHandler
{
    Rigidbody2D sqr;
    public void OnPointerClick(PointerEventData eventData)
    {
        if(TouchNum.touch02 == true) {
            sqr.velocity = Vector2.up*10;
            TouchNum.touch03 = true;
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
