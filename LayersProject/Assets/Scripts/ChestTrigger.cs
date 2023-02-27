using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{
    [SerializeField] private Transform key;
    [SerializeField] private Transform spawnPoint;
    

    void OnTriggerEnter(Collider other) 
        {
            key.transform.position = spawnPoint.transform.position;
        }
}
