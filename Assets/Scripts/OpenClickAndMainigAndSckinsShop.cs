using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenClickShop : MonoBehaviour
{
    public GameObject mainShop;
    public GameObject childShop1;
    public GameObject childShop2;

    public GameObject button1;
    public GameObject button2;
    public void OnClickOpenShop(){
        mainShop.SetActive(true);
        childShop1.SetActive(false);
        childShop2.SetActive(false);
        gameObject.GetComponent<Image>().color=Color.green;
        button1.GetComponent<Image>().color=Color.white;
        button2.GetComponent<Image>().color=Color.white;
    }
}
