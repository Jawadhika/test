using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodstepSound : MonoBehaviour
{
    private AudioSource audioSource;

    [Header("FoodSteps Sources")]
    public AudioClip[] foodstepsSound;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private AudioClip GetRandomFoodStep()
    {
        return foodstepsSound [UnityEngine.Random.Range(0, foodstepsSound.Length)];
    }

    private void Step()
    {
        AudioClip clip = GetRandomFoodStep();
        audioSource.PlayOneShot(clip);
    }
}
