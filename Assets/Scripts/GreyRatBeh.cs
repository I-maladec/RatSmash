using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreyRatBeh : Enemy
{
    [SerializeField] float _attackTime;
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _projectile;
    [SerializeField] GameObject _muzzle;
    DateTime attackTimer;

    // Start is called before the first frame update
    override protected void Start()
    {
        base.Start();
        _animator = GetComponent<Animator>();
        attackTimer = DateTime.Now;
    }

    // Update is called once per frame
    override protected void Update()
    {
        base.Update();
        if (hide)
        {
            _animator.SetBool("isDead", true);
        }
        if ((DateTime.Now - attackTimer) > TimeSpan.FromSeconds(_attackTime) && !hide)
        {
            Instantiate(_projectile, _muzzle.transform);
            hide = true;
        }
    }
}
