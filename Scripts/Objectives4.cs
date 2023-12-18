using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objectives4 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Vehicle")
        {
            //completed objective
            ObjectivesComplete.occurrence.GetObjectivesDone(true, true, true, true);

            SceneManager.LoadScene("MainMenu");
        }
    }
}
