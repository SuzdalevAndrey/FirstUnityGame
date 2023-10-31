using System;
using UnityEngine;
using UnityEngine.UI;

public class ShopControllerScins : MonoBehaviour
{
    public GameObject mainMoney;
    public Image[] skins;
    void Start(){
        mainMoney.GetComponent<Image>().sprite=skins[PlayerPrefs.GetInt("skinNum")].GetComponent<Sprite>();
    }
}
