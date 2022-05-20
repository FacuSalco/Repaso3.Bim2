using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCloner : MonoBehaviour
{

    public GameObject prefab;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ClonePrefab()
    {
        Instantiate(prefab);
    }
}
