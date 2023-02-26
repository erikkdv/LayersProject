using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChestCollision : MonoBehaviour
{

    public GameObject chestLid;
    
    private void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "ChestTrigger")
        {
            chestLid.transform.rotation = Quaternion.Euler(45, 0, 0);
        }
            
    }
}
