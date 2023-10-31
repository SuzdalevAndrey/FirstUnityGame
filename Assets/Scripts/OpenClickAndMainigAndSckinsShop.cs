using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenClickShop : MonoBehaviour
{
    public GameObject mainShop;
    public GameObject childShop1;
    public GameObject childShop2;
    public void OnClickOpenShop(){
        mainShop.SetActive(true);
        childShop1.SetActive(false);
        childShop2.SetActive(false);
    }
}
