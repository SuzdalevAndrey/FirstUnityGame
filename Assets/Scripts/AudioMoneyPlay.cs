using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMoneyPlay : MonoBehaviour
{
    [SerializeField] private GameDateController dateController;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }    
    public void playSoundOnButton(){
        dateController.moneySound.Play();
    }
}
