using System;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    public GameDateController dateController;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }  
    public void BuyUpgradeShop(int id){
        if(dateController.countCash<=0){dateController.countCash=0;return;}
        if(dateController.countCash>=dateController.clickCosts[id]){
            dateController.upgradeCash+=dateController.powerClick[id];
            PlayerPrefs.SetFloat("upgradeCash",dateController.upgradeCash);
            dateController.countCash-=dateController.clickCosts[id];
            dateController.countCash=(float)Math.Round((float)dateController.countCash,4);
            PlayerPrefs.SetFloat("countCash",dateController.countCash);
            ++dateController.level[id];
            dateController.clickCosts[id]*=1.1f;
            dateController.clickCosts[id]=(float)Math.Round((float)dateController.clickCosts[id],4);
            PlayerPrefs.SetFloat(id.ToString()+"clickCosts",dateController.clickCosts[id]);
            PlayerPrefs.SetInt(id.ToString()+"clickLevel",dateController.level[id]);
        }
    }
}
