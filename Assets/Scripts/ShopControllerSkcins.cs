using UnityEngine;
using UnityEngine.UI;


public class ShopControllerScins : MonoBehaviour
{
    public Sprite trueLock;
    public Image[] iLock;
    public Sprite falseLock;
    [SerializeField] private GameDateController dateController;
    public void Awake(){
        if(dateController == null)
            dateController = GameObject.FindAnyObjectByType<GameDateController>();
    }   
    private void Start()
    {
        if(!PlayerPrefs.HasKey(0.ToString()+"buy") || !PlayerPrefs.HasKey(5.ToString()+"buy")){
            for(int i=0;i<10;++i){
                if(i==0 || i==5){
                    PlayerPrefs.SetInt(i.ToString()+"buy",1);
                    PlayerPrefs.SetInt(i.ToString()+"selected",1);
                }
                else{
                    PlayerPrefs.SetInt(i.ToString()+"buy",0);
                }
            }
        }
    }
    private void Update() {
        for(int i=0;i<10;++i){
            if(PlayerPrefs.GetInt(i.ToString() + "buy")==0){
                iLock[i].GetComponent<Image>().sprite=falseLock;
            }
            else if(PlayerPrefs.GetInt(i.ToString() + "buy")==1){
                iLock[i].GetComponent<Image>().sprite=trueLock;
            }
        }
    }
}
