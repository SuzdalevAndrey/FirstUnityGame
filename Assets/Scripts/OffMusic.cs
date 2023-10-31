using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffMusic : MonoBehaviour
{
    [SerializeField] private GameDateController dateController;
    private float vol;
    public Sprite onMusic;
    public Sprite offMusic;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }  
    public void clikcButtonOffOnMusic(){
        if(dateController.volume!=0){
            vol=dateController.volume;
            dateController.volume=0f;
        }
        else{
            dateController.volume=vol;
        }
    }
}
