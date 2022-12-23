using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitControl : MonoBehaviour
{
    [SerializeField] float cooldownSeconds;
    float animationSeconds = 0.6f;
    Animator animator;
    DateTime cooldownTimer;
    DateTime animationTimer;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        cooldownTimer = DateTime.Now;
        animationTimer = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && (DateTime.Now - cooldownTimer) > TimeSpan.FromSeconds(cooldownSeconds))
        {
            animator.SetBool("isKicking", true);
            cooldownTimer = DateTime.Now;
            animationTimer = DateTime.Now;
        }
        if (animator.GetBool("isKicking") && (DateTime.Now - animationTimer) > TimeSpan.FromSeconds(animationSeconds))
        {
            animator.SetBool("isKicking", false);
        }
    }
}
