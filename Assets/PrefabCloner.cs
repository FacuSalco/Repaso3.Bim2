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
    public InputField IField;

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

        if (inputCloneAmount.text != "")
        {
            IField.readOnly = true;

            int cloneAmount = int.Parse(inputCloneAmount.text);

            if (counter < cloneAmount) {
            Instantiate(prefab);
            counter++;
            displayClonesLeft.text = (cloneAmount - counter).ToString();
            }
            else
            {
            displayClonesLeft.text = "No hay mas Prefabs";
            }
        }
        

        else
        {
            displayClonesLeft.text = "ERROR. Ingrese un valor";
        }

        
    }
}
