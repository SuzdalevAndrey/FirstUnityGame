using System;
using UnityEngine;

public class SckinControl : MonoBehaviour
{
    public GameDateController dateController;
    public void BuyFonAndSkin(int id){
        if(dateController.countCash<=0){dateController.countCash=0;return;}
        if(PlayerPrefs.GetInt(id.ToString()+"buy")==0){
            if(dateController.countCash>=dateController.skinCosts[id]){
                dateController.countCash-=dateController.skinCosts[id];
                dateController.countCash=(float)Math.Round((float)dateController.countCash,4);
                PlayerPrefs.SetFloat("countCash",dateController.countCash);
                PlayerPrefs.SetInt(id.ToString()+"buy",1);
                PlayerPrefs.SetInt(id.ToString()+"selected",0);
            }
        }
    }

    public void ChooseFon(int id){
        if(PlayerPrefs.GetInt(id.ToString()+"buy")==1){
            if(PlayerPrefs.GetInt(id.ToString()+"selected")==0){
                for(int i=0;i<5;++i){
                    if(i==id)
                        PlayerPrefs.SetInt(i.ToString()+"selected",1);
                    else
                        PlayerPrefs.SetInt(i.ToString()+"selected",0);
                }
                dateController.mainCamera.GetComponent<Camera>().backgroundColor=dateController.fon[id];
                PlayerPrefs.SetInt("FonNum",id);
            }
        }
    }

    public void ChooseSkin(int id){
        if(PlayerPrefs.GetInt(id.ToString()+"buy")==1){
            if(PlayerPrefs.GetInt(id.ToString()+"selected")==0){
                for(int i=5;i<10;++i){
                    if(i==id)
                        PlayerPrefs.SetInt(i.ToString()+"selected",1);
                    else
                        PlayerPrefs.SetInt(i.ToString()+"selected",0);
                }
                int index=id-5;
                dateController.MainMoney.sprite=dateController.skins[index].sprite;
                dateController.iconMoney.sprite=dateController.iconsMoneyOnChoose[index];
                PlayerPrefs.SetInt("SkinNum",index);

                PlayerPrefs.SetInt("LittleCoinNum",index);

                PlayerPrefs.SetInt("iconMoneyNum",index);
            }
        }
    }
}
