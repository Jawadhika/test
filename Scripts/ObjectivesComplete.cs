using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectivesComplete : MonoBehaviour
{
    [Header("Objectives to Complete")]
    public Text Objectives1;
    public Text Objectives2;
    public Text Objectives3;
    public Text Objectives4;

    public static ObjectivesComplete occurrence;

    private void Awake()
    {
        occurrence = this;
    }

    public void GetObjectivesDone(bool obj1, bool obj2, bool obj3, bool obj4)
    {
        if(obj1 == true)
        {
            Objectives1.text ="1. Completed";
            Objectives1.color = Color.green;
        }
        else
        {
            Objectives1.text = "01. Find the Rifle";
            Objectives1.color = Color.white;
        }
        
        if(obj2 == true)
        {
            Objectives2.text = "2. Completed";
            Objectives2.color =  Color.green;
        }
        else
        {
            Objectives2.text = "2. Locate the villagers";
            Objectives2.color = Color.white;
        }

        if(obj3 == true)
        {
            Objectives3.text = "3. Completed";
            Objectives3.color = Color.green;
        }
        else
        {
            Objectives3.text = "3. Find Vehicle";
            Objectives3.color = Color.white;
        }

        if(obj4 == true)
        {
            Objectives4.text = "4. Completed";
            Objectives4.color = Color.green;
        }
        else
        {
            Objectives4.text = "4. Get all villagers into vehicle";
            Objectives4.color = Color.white;
        }
    }
}
