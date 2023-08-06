using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddObjects : MonoBehaviour
{
    public GameObject sampleObject;
    public Transform Spawnpoint;    
    public void AddObject(Transform spawn)
    {   
        
        Instantiate(sampleObject, spawn.position , Quaternion.identity);
    }
}
