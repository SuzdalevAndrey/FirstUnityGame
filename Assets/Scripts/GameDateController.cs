using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDateController : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject[] littleCoin;
    [Header("MoneyCash")]
    public float countCash;
    public Image iconMoney;
    public Sprite[] iconsMoneyOnChoose;
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
    public Text[] skinName;
    public string[] skinNameRu={"Фон","Фон","Фон","Фон","Фон","Биткоин","XRP","Кардано","ДогеКоин","Лайткоин"};
    public string[] skinNameEn={"Fon","Fon","Fon","Fon","Fon","Bitcoin","XRP","Cardano","DogeCoin","LiteCoin"};
    public Text[] skinCostsText;
    [Space]
    public Color[] fon;
    public Camera mainCamera;
    [Space]
    public Image[] skins;
    public Image MainMoney;

    [Header("Sound")]
    public AudioSource clickButtonSound;
    public AudioSource moneySound;
    public float volume = 0.1f;
    [Header("Language")]
    public bool flagLanguage=true;
    [Header("nameUpgradeClick")]
    public Text[] nameUpgradeClickText;
    public string[] nameUpgradeClickRu = {"Скорость Сатоши","Драйв Догекоина","Кардано Клик","XRP-эффект","Стабильность","Салют Соланы","Энергия Лайткоина","Блокчейн Бустер","Эфирный Экстаз","Бум Биткоина"};
    public string[] nameUpgradeClickEn = {"Satoshi's Speed","Dogecoin Drive","Cardano Click","XRP-effect","Stability","Salute to Solana","Litecoin Energy","Blockchain Booster","Ethereal Ecstasy","Bitcoin Boom"};
    [Header("nameUpgradeMaining")]
    public Text[] nameUpgradeMainingText;
    public string[] nameUpgradeMainingRu={"Калькулятор","Холодильник","Телевизор","Микроволновка","Старый ПК","Смартфон","Видеокарта","Игровой ПК", "Майнинг ферма","Супер компьютер"};
    public string[] nameUpgradeMainingEn={"Calculator","Fridge","TV","Nuke","Old PC","Smartphone","Videocard","Gaming PC", "Mining Farm","Supercomputer"};
    [Header("LevelGame")]
    public int LevelGame = 1;
    public int countClickOnTime;
    public Slider SliderLevel;
    public int maxValue = 50;
    public GameObject Accomplishment;

    void Start(){
        if(PlayerPrefs.HasKey("countCash"))
            countCash=PlayerPrefs.GetFloat("countCash");
        else 
            countCash=0.0000f;


        if(PlayerPrefs.HasKey("upgradeCash"))
            upgradeCash=PlayerPrefs.GetFloat("upgradeCash");
        else 
            upgradeCash=0.0001f; 


        if(PlayerPrefs.HasKey("upgradeCashInSeconds"))
            upgradeCashInSeconds=PlayerPrefs.GetFloat("upgradeCashInSeconds");
        else 
            upgradeCashInSeconds=0.0000f; 


        clickButtonSound.volume=volume;
        moneySound.volume=volume;


        if(PlayerPrefs.HasKey("flagLanguage"))
            flagLanguage=Convert.ToBoolean(PlayerPrefs.GetInt("flagLanguage"));
        else
            flagLanguage=true;


        if(PlayerPrefs.HasKey("LevelGame"))
            LevelGame=PlayerPrefs.GetInt("LevelGame");
        else
            LevelGame=1;


        if(PlayerPrefs.HasKey("countClickOnTime"))
            countClickOnTime=PlayerPrefs.GetInt("countClickOnTime");
        else
            countClickOnTime=0;

        SliderLevel.maxValue=LevelGame*maxValue;
        SliderLevel.value=countClickOnTime;

        if(PlayerPrefs.HasKey("FonNum"))
            mainCamera.GetComponent<Camera>().backgroundColor=fon[PlayerPrefs.GetInt("FonNum")];
        else
            mainCamera.GetComponent<Camera>().backgroundColor=fon[0];

        if(PlayerPrefs.HasKey("SkinNum"))
            MainMoney.sprite=skins[PlayerPrefs.GetInt("SkinNum")].sprite;
        else
            MainMoney.sprite=skins[0].sprite;

        if(!PlayerPrefs.HasKey("LittleCoinNum"))
            PlayerPrefs.SetInt("LittleCoinNum",0);

        if(PlayerPrefs.HasKey("iconMoneyNum"))
            iconMoney.sprite=iconsMoneyOnChoose[PlayerPrefs.GetInt("iconMoneyNum")];
        else
            iconMoney.sprite=iconsMoneyOnChoose[0];

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

        for(int i=0;i<nameUpgradeClickText.Length;++i){
            if(flagLanguage==true)
                nameUpgradeClickText[i].text=nameUpgradeClickRu[i];
            else
                nameUpgradeClickText[i].text=nameUpgradeClickEn[i];
        }
    }
}
