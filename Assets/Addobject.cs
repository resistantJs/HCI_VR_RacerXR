using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addobject : MonoBehaviour
{
public GameObject sampleObject;

public void AddObject()
{
    Instantiate(sampleObject, Vector3.zero, Quaternion.Identity);
}
}
