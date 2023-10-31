using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSettings : MonoBehaviour
{
    [SerializeField] private Button shop;
    [SerializeField] private Button settings;
    [SerializeField] private Button exit;

    public void OnClickOpenSettings(){
        shop.enabled=!shop.enabled;
        settings.enabled=!settings.enabled;
        exit.enabled=!exit.enabled;
    }
}
