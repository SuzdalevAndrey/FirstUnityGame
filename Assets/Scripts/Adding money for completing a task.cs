using UnityEngine;

public class AddingMoneyForCompletingaTask : MonoBehaviour
{
    [SerializeField] private GameDateController dateController;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }
    public void AddMoney(){
        if(dateController.LevelGame<8)
            dateController.countCash+=dateController.LevelGame*dateController.maxValue*0.01f;
        else
            dateController.countCash+=dateController.LevelGame*dateController.maxValue;
        PlayerPrefs.SetFloat("countCash",dateController.countCash);
        gameObject.SetActive(false);
    }
}
