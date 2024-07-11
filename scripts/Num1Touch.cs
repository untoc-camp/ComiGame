using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour , IPointerClickHandler
{
    Rigidbody2D sqr;
    [SerializeField]
    public GameObject[] Num1;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Touched");
        sqr.velocity = Vector2.up*10;
    }
    void Num1call() {
        for(int x = 0; x<4; x++) {
            for(int y=0; y<4; y++) {
            Vector3 position = new Vector3((float)(-2.0+x*1.2), (float)(3.9 - y), 0);
            Instantiate(Num1[4*x+y],position,Quaternion.identity);
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        sqr = GetComponent<Rigidbody2D>();
        Num1call();
        for(int j = 0; j< 16; j++) Destroy(Num1[j],10);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
