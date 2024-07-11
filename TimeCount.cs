using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public Text text_timer;

    void Start()
    {
        GetComponent<Text>().text = "시간 : " + Timer02.TimeR.ToString() + "경과 수강 신청 성공!";

    }

    // Update is called once per frame
    void Update()
    {
    }
}
