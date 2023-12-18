using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoost : MonoBehaviour
{
    [Header("HealthBoost")]
    public PlayerScripts player;
    private float healthToGive = 120f;
    private float radius = 2.5f;

    [Header("Sounds")]
    public AudioClip HealthBoostSound;
    public AudioSource audioSource;

    [Header("healthBox Animator")]
    public Animator animator;

    private void Update()
    {
        if(Vector3.Distance(transform.position,player.transform.position) < radius);
        {
            if(Input.GetKeyDown("f"))
            {
                animator.SetBool("open", true);
                player.presentHealth = healthToGive;

                //sound effect
                audioSource.PlayOneShot(HealthBoostSound);

                Object.Destroy(gameObject, 1.5f);
            }
        }
    }
}
