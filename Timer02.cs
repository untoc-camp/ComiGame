using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer02 : MonoBehaviour
{
    private float Gametime = 15;
    public static float TimeR = 0;
    public static float TimeResult =0;
    public Text Gametimetext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((int)Gametime ==0) {
            Debug.Log("게임종료");
            Gametimetext.text ="수강 신청 실패";

        }
        else {
            Gametime -= Time.deltaTime;
            Debug.Log((int)Gametime);
            Gametimetext.text = "Time: " + (int)Gametime;
        }
        Timer02.TimeResult += Time.deltaTime;
    }
}
