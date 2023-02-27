using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject trapDoor;
    
    private void OnTriggerEnter()
    {
        trapDoor.SetActive(true);
    }
}
