using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabCloner : MonoBehaviour
{

    public GameObject prefab;
    public Text inputCloneAmount;
    public int counter;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ClonePrefab()
    {
        if (counter < int.Parse(inputCloneAmount.text)) {
            Instantiate(prefab);
            counter++;
        }
    }
}
