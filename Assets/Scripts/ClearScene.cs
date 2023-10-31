using System;
using UnityEngine;

public class Physics : MonoBehaviour
{
    public void Update(){
        GameObject[] clones = GameObject.FindGameObjectsWithTag("LittleBitcoin");

        foreach (GameObject clone in clones)
        {
            if (clone.transform.position.y < -53)
            {
                Destroy(clone);
            }
        }
    }
}
