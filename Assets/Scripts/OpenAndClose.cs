using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenShop : MonoBehaviour
{
    public void OpenAndClose(GameObject panel){
        panel.SetActive(!panel.activeInHierarchy);
    }
}
