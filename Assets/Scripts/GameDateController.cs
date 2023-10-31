using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Localization.Platform.Android;
using UnityEngine;
using UnityEngine.UI;

public class GameDateController : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject littleBitcoin;
    [Header("MoneyCash")]
    public float countCash;
    public float upgradeCash;
    public float upgradeCashInSeconds;
    [Header("Text")]
    public Text[] textCash;
    public Text[] textCashInSeconds;
    [Header("Transform")]
    public Transform spawner;
    [Header("Shop Controller in Click")]
    public float[] clickCosts;
    public float[] powerClick;
    public int[] level;
    [Space]
    public Text[] costsText;
    public Text[] powerClickText;
    public Text[] levelText;
    [Header("Shop Controller in Mainig")]
    public float[] mainigCosts;
    public float[] mainigInSeconds;
    public int[] levelMainig;
    [Space]
    public Text[] mainigCostsText;
    public Text[] mainigInSecondsText;
    public Text[] levelTextMainig;
    [Header("Shop Controller in Skins")]
    public float[] skinCosts;
    [Space]
    public Text[] skinCostsText;
    public Sprite[] sckin;
    [Header("Sound")]
    public AudioSource clickButtonSound;
    public AudioSource moneySound;
    public float volume = 0.1f;
    [Header("Language")]
    public bool flagLanguage=true;
    [Header("nameUpgradeClick")]
    public Text[] nameUpgradeClickText;
    private string[] nameUpgradeClickRu;
    private string[] nameUpgradeClickEn;
    [Header("nameUpgradeMaining")]
    public Text[] nameUpgradeMainingText;
    public string[] nameUpgradeMainingRu={"Калькулятор","Холодильник","Телевизор","Микроволновка","Старый ПК","Смартфон","Видеокарта","Игровой ПК", "Майнинг ферма","Супер компьютер"};
    public string[] nameUpgradeMainingEn={"Calculator","Fridge","TV","Nuke","Old PC","Smartphone","Videocard","Gaming PC", "Mining Farm","Supercomputer"};
    void Start(){
        countCash=PlayerPrefs.GetFloat("countCash");
        upgradeCash=PlayerPrefs.GetFloat("upgradeCash");
        upgradeCashInSeconds = PlayerPrefs.GetFloat("upgradeCashInSeconds");
        clickButtonSound.volume=volume;
        moneySound.volume=volume;
        flagLanguage=Convert.ToBoolean(PlayerPrefs.GetInt("flagLanguage"));
        for(int lv = 0;lv<level.Length;++lv){
            if(PlayerPrefs.HasKey(lv.ToString() + "clickLevel")){
                level[lv]=PlayerPrefs.GetInt(lv.ToString() + "clickLevel");
            }
        }
        for(int lv = 0;lv<level.Length;++lv){
            if(PlayerPrefs.HasKey(lv.ToString()+"mainingLevel")){
                levelMainig[lv]=PlayerPrefs.GetInt(lv.ToString()+"mainingLevel");
            }
        }
        for(int lv = 0;lv<clickCosts.Length;++lv){
            if(PlayerPrefs.HasKey(lv.ToString() + "clickCosts")){
                clickCosts[lv]=PlayerPrefs.GetFloat(lv.ToString() + "clickCosts");
            }
        }
        for(int lv = 0;lv<mainigCosts.Length;++lv){
            if(PlayerPrefs.HasKey(lv.ToString() + "mainingCosts")){
                mainigCosts[lv]=PlayerPrefs.GetFloat(lv.ToString()+"mainingCosts");
            }
        }
        for(int i=0;i<nameUpgradeMainingText.Length;++i){
            if(flagLanguage==true)
                nameUpgradeMainingText[i].text=nameUpgradeMainingRu[i];
            else
                nameUpgradeMainingText[i].text=nameUpgradeMainingEn[i];
        }
    }
}
