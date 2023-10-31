using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    [SerializeField] private GameDateController dateController;
    public GameObject button;
    public Sprite onMusic;
    public Sprite offMusic;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }  
    void Update()
    {
        dateController.moneySound.volume=dateController.volume;
        dateController.clickButtonSound.volume=dateController.volume;
        if(dateController.volume!=0){
            button.GetComponent<Image>().sprite=onMusic;
        }
        else{
            button.GetComponent<Image>().sprite=offMusic;
        }
    }
    public void setVolume(float vol){
        dateController.volume=vol;
    }
}
