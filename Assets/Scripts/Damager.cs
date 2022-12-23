using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] float _damage;
    [SerializeField] float _damageDelaySeconds;
    bool canDamage = true;
    DateTime damageDelayTimer;
    private void Update()
    {
        if((DateTime.Now - damageDelayTimer) > TimeSpan.FromSeconds(_damageDelaySeconds))
        {
            canDamage = true;
        }
    }
    public float GetDamage()
    {
        if (canDamage)
        {
            damageDelayTimer = DateTime.Now;
            canDamage = false;
            return _damage;
        }
        else return 0;
    }
}
