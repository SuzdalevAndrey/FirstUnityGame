using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
    [SerializeField] private GameDateController dateController;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    } 
    public void OnClickLanguage(){
        if(gameObject.tag=="ButtonRuLanguage"){
            dateController.flagLanguage=true;
            PlayerPrefs.SetInt("flagLanguage",1);
        }
        else{
            dateController.flagLanguage=false;
            PlayerPrefs.SetInt("flagLanguage",0);
        }
    }
}
