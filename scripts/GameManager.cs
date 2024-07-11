using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Num1 LastTouch;
    public GameObject TouchPrefab;
    public Transform TouchGroup;

    Num1 GetNext() {
        GameObject instant = Instantiate(TouchPrefab, TouchGroup);
        Num1 instantTouch = instant.GetComponent<Num1>();
        return instantTouch;

    }
    void NextTouch() {
        Num1 newNum = GetNext();
        LastTouch = newNum;
    }
    void Start()
    {
        GetNext();
    }
    public void NumTouch(){
        if(LastTouch == null) return;
        LastTouch.isTouched();
    } 
}