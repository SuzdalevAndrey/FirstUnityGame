using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    
    [SerializeField] private GameDateController dateController;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }    
    public void ButtonOnClickRestart(){
        PlayerPrefs.SetFloat("countCash",0.0000f);

        PlayerPrefs.SetFloat("upgradeCash",0.0001f);

        PlayerPrefs.SetFloat("upgradeCashInSeconds",0.0000f);

        PlayerPrefs.SetInt("LevelGame",1);

        PlayerPrefs.SetInt("countClickOnTime",0);

        PlayerPrefs.SetInt("FonNum",0);

        PlayerPrefs.SetInt("SkinNum",0);

        PlayerPrefs.SetInt("LittleCoinNum",0);

        PlayerPrefs.SetInt("iconMoneyNum",0);

        PlayerPrefs.SetInt("flagLanguage",1);


        for(int lv = 0;lv<dateController.level.Length;++lv){
            if(PlayerPrefs.HasKey(lv.ToString() + "clickLevel")){
                PlayerPrefs.SetInt(lv.ToString() + "clickLevel",0);
            }
        }
        for(int lv = 0;lv<dateController.level.Length;++lv){
            if(PlayerPrefs.HasKey(lv.ToString()+"mainingLevel")){
                PlayerPrefs.SetInt(lv.ToString()+"mainingLevel",0);
            }
        }
        for(int lv = 0;lv<dateController.clickCosts.Length;++lv){
            if(PlayerPrefs.HasKey(lv.ToString() + "clickCosts")){
                PlayerPrefs.DeleteKey(lv.ToString() + "clickCosts");
            }
        }
        for(int lv = 0;lv<dateController.mainigCosts.Length;++lv){
            if(PlayerPrefs.HasKey(lv.ToString() + "mainingCosts")){
                PlayerPrefs.DeleteKey(lv.ToString()+"mainingCosts");
            }
        }
        for(int i = 0;i<dateController.fon.Length;++i){
            if(PlayerPrefs.HasKey(i.ToString() + "buy")){
                PlayerPrefs.DeleteKey(i.ToString()+"buy");
            }
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
