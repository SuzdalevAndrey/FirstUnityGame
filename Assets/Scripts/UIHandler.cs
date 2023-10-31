using System.Collections;
using System;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public GameDateController dateController;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }  
    private float interval = 1.0f;
    private void Start(){
        StartCoroutine(CallFunctionEverySecond());
    }
    private void Update(){
        UpdateTextAllMoney();
        UpdateTextCostUpgradeInShop();
        UpdateTextPowerClickUpgradeInShop();
        UpdateTextLevelUpgradeInShop();
        UpdateTextMoneyInSeconds();
        UpdateTextMainigCostUpgradeInShop();
        UpdateTextMainigInSecondsUpgradeInShop();
        UpdateTextMainigLevelUpgradeInShop();
        UpdateTextNameUpgradeMaining();
    }
    private void UpdateTextAllMoney(){
        if(dateController.countCash<0.0001f)
        {
            for(int i=0;i<dateController.textCash.Length;++i){
                dateController.textCash[i].text="0,0000";
            }
        }
        else{
            for(int i=0;i<dateController.textCash.Length;++i){
                dateController.textCash[i].text=dateController.countCash.ToString();
            }
        }
    }
    private void UpdateTextMoneyInSeconds(){
        if(dateController.upgradeCashInSeconds<=0.0001f)
        {
            for(int i=0;i<dateController.textCashInSeconds.Length;++i){
                dateController.textCashInSeconds[i].text="0,0000";
                if(dateController.flagLanguage==true)
                    dateController.textCashInSeconds[i].text+="/сек";
                else
                    dateController.textCashInSeconds[i].text+="/sec";
            }
        }
        else{
            for(int i=0;i<dateController.textCashInSeconds.Length;++i){
                dateController.textCashInSeconds[i].text=dateController.upgradeCashInSeconds.ToString();
                if(dateController.flagLanguage==true)
                    dateController.textCashInSeconds[i].text+="/сек";
                else
                    dateController.textCashInSeconds[i].text+="/sec";
            }
        }
    }
    private void UpdateTextCostUpgradeInShop(){
        for(int i=0;i<dateController.costsText.Length;++i){
            if(dateController.flagLanguage==true)
                dateController.costsText[i].text="Цена: ";
            else
                dateController.costsText[i].text="Costs: ";
            dateController.costsText[i].text += dateController.clickCosts[i].ToString();
        }
    }
    private void UpdateTextPowerClickUpgradeInShop(){
        for(int i=0;i<dateController.powerClickText.Length;++i){
            if(dateController.flagLanguage==true)
                dateController.powerClickText[i].text="Клик + ";
            else
                dateController.powerClickText[i].text="Click + ";
            dateController.powerClickText[i].text += dateController.powerClick[i].ToString();
        }
    }
    private void UpdateTextLevelUpgradeInShop(){
        for(int i=0;i<dateController.powerClickText.Length;++i){
            if(dateController.flagLanguage==true)
                dateController.levelText[i].text="Уровень: ";
            else
                dateController.levelText[i].text="Level: ";
            dateController.levelText[i].text += dateController.level[i].ToString();
        }
    }
    private void UpdateTextMainigCostUpgradeInShop(){
        for(int i=0;i<dateController.mainigCostsText.Length;++i){
            if(dateController.flagLanguage==true)
                dateController.mainigCostsText[i].text="Цена: ";
            else
                dateController.mainigCostsText[i].text="Costs: ";
            dateController.mainigCostsText[i].text += dateController.mainigCosts[i].ToString();
        }
    }
    private void UpdateTextMainigInSecondsUpgradeInShop(){
        for(int i=0;i<dateController.mainigInSecondsText.Length;++i){
            dateController.mainigInSecondsText[i].text = dateController.mainigInSeconds[i].ToString();
            if(dateController.flagLanguage==true)
                dateController.mainigInSecondsText[i].text+="/сек";
            else
                dateController.mainigInSecondsText[i].text+="/sec";
        }
    }
    private void UpdateTextMainigLevelUpgradeInShop(){
        for(int i=0;i<dateController.levelTextMainig.Length;++i){
            if(dateController.flagLanguage==true)
                dateController.levelTextMainig[i].text="Уровень: ";
            else
                dateController.levelTextMainig[i].text="Level: ";
            dateController.levelTextMainig[i].text += dateController.levelMainig[i].ToString();
        }
    }
    private void UpdateTextNameUpgradeMaining(){
        for(int i=0;i<dateController.nameUpgradeMainingText.Length;++i){
            if(dateController.flagLanguage==true)
                dateController.nameUpgradeMainingText[i].text=dateController.nameUpgradeMainingRu[i];
            else
                dateController.nameUpgradeMainingText[i].text=dateController.nameUpgradeMainingEn[i];
        }
    }
    
    private IEnumerator CallFunctionEverySecond()
    {
        while (true)
        {
            dateController.countCash+=dateController.upgradeCashInSeconds;
            dateController.countCash=(float)Math.Round((float)dateController.countCash,4);
            PlayerPrefs.SetFloat("countCash", dateController.countCash);
            yield return new WaitForSeconds(interval);
        }
    }
}
