using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WhiteRatBeh : Enemy
{
    [SerializeField] Animator _animator;
    // Start is called before the first frame update
    override protected void Start()
    {
        base.Start();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    override protected void Update()
    {
        base.Update();
        if(hide)
        {
            _animator.SetBool("isDead", true);
        }
    }
}
