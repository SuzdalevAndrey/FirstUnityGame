using System;
using UnityEngine;

public class ShopControlerMainig : MonoBehaviour
{
    [SerializeField] private GameDateController dateController;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }
    public void BuyUpgradeShop(int id){
        if(dateController.countCash<=0){dateController.countCash=0;return;}
        if(dateController.countCash>=dateController.mainigCosts[id]){
            dateController.upgradeCashInSeconds+=dateController.mainigInSeconds[id];
            dateController.countCash-=dateController.mainigCosts[id];
            dateController.countCash=(float)Math.Round((float)dateController.countCash,4);
            dateController.upgradeCashInSeconds=(float)Math.Round((float)dateController.upgradeCashInSeconds,3);
            PlayerPrefs.SetFloat("upgradeCashInSeconds",dateController.upgradeCashInSeconds);
            PlayerPrefs.SetFloat("countCash",dateController.countCash);
            ++dateController.levelMainig[id];
            dateController.mainigCosts[id]*=1.1f;
            dateController.mainigCosts[id]=(float)Math.Round((float)dateController.mainigCosts[id],2);
            PlayerPrefs.SetFloat(id.ToString()+"mainingCosts",dateController.mainigCosts[id]);
            PlayerPrefs.SetInt(id.ToString()+"mainingLevel",dateController.levelMainig[id]);
        }
    }
}
