using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LastTouch : MonoBehaviour , IPointerClickHandler
{
    Rigidbody2D sqr;
    public void OnPointerClick(PointerEventData eventData)
    {
        Timer02.TimeR = Timer02.TimeResult;
        SceneManager.LoadScene("ResultScene");

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
