using System;
using UnityEngine;
using UnityEngine.UI;

public class SckinControl : MonoBehaviour
{
    public GameDateController dateController;
    public Sprite trueLock;
    public Image iLock;
    public Sprite falseLock;
    public Button buySkin;
    public Image[] skins;
    void Start()
    {
        if(PlayerPrefs.GetInt("skin1"+"buy")==0){
            foreach(Image img in skins){
                if("skin1"==img.name){
                    PlayerPrefs.SetInt("skin1"+"buy",1);
                }
                else{
                    PlayerPrefs.SetInt(GetComponent<Image>().name+"buy",0);
                }
            }
        }
    }

    void Update()
    {
        if(PlayerPrefs.GetInt(GetComponent<Image>().name + "buy")==0){
            iLock.GetComponent<Image>().sprite=falseLock;
        }
        else if(PlayerPrefs.GetInt(GetComponent<Image>().name + "buy")==1){
            iLock.GetComponent<Image>().sprite=trueLock;
            if(PlayerPrefs.GetInt(GetComponent<Image>().name + "equip")==1){
                buySkin.GetComponentInChildren<Text>().text="equipped";
            }
            else{
                buySkin.GetComponentInChildren<Text>().text="equip";
            }
        }
    }
    public void BuyUpdateShop(int id){
        if(dateController.countCash<=0){dateController.countCash=0;return;}
        if(PlayerPrefs.GetInt(GetComponent<Image>().name+"buy")==0){
            if(dateController.countCash>=dateController.skinCosts[id]){
                dateController.countCash-=dateController.skinCosts[id];
                dateController.countCash=(float)Math.Round((float)dateController.countCash,4);
                iLock.GetComponent<Image>().sprite=trueLock;
                buySkin.GetComponentInChildren<Text>().text="equip";
                PlayerPrefs.SetInt(GetComponent<Image>().name+"buy",1);
                PlayerPrefs.SetInt("skinNum",id);
                foreach(Image img in skins){
                    if(GetComponent<Image>().name==img.name){
                        PlayerPrefs.SetInt(img.name+"equip",1);
                    }
                    else{
                        PlayerPrefs.SetInt(img.name+"equip",0);
                    }
                }
            }
        }
        else if(PlayerPrefs.GetInt(GetComponent<Image>().name+"buy")==1){
            buySkin.GetComponentInChildren<Text>().text="Lala";
            iLock.GetComponent<Image>().sprite=trueLock;
            PlayerPrefs.SetInt("skinNum",id);
            PlayerPrefs.SetInt(GetComponent<Image>().name + "equip",1);
            foreach(Image img in skins){
                if(GetComponent<Image>().name==img.name){
                    PlayerPrefs.SetInt(img.name+"equip",1);
                }
                else{
                    PlayerPrefs.SetInt(img.name+"equip",0);
                }
            }
        }
    }
}
