using System;
using UnityEngine;
public class Click : MonoBehaviour
{
    [SerializeField] private GameDateController dateController;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }
    public void OnClick(){
        dateController.countCash+=dateController.upgradeCash;
        dateController.countCash=(float)Math.Round((float)dateController.countCash,4);

        PlayerPrefs.SetFloat("countCash",dateController.countCash);
        
        ++dateController.countClickOnTime;
        PlayerPrefs.SetInt("countClickOnTime",dateController.countClickOnTime);

        Instantiate(dateController.littleCoin[PlayerPrefs.GetInt("LittleCoinNum")],dateController.spawner.position+new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-2f, 2f), 0), Quaternion.identity);
    }
}
