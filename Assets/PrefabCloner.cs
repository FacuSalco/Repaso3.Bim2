using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabCloner : MonoBehaviour
{

    public GameObject prefab;
    public Text inputCloneAmount;
    public int counter;
    public Text displayClonesLeft;

    void Start()
    {
        counter = 0;
        displayClonesLeft.text = "?";
    }

    
    void Update()
    {
        
    }

    public void ClonePrefab()
    {
        if (counter < int.Parse(inputCloneAmount.text)) {
            Instantiate(prefab);
            counter++;
            displayClonesLeft.text = (int.Parse(inputCloneAmount.text) - counter).ToString();
        }
    }
}
