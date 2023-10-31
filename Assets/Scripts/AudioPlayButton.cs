using UnityEngine;
using UnityEngine.UI;

public class AudioPlayButton : MonoBehaviour
{
    [SerializeField] private GameDateController dateController;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }    
    public void playSoundOnButton(){
        dateController.clickButtonSound.Play();
    }
}
