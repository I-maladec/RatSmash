using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ScoreCounter _scoreCounter;
    float _hp;
    [SerializeField] float _maxHp;
    [SerializeField] int _scoreReward;
    [SerializeField] float _stayTime;
    [SerializeField] float _spawnChance;
    [SerializeField] Healthbar _healthbar;
    [SerializeField] float _minimalGameDifficulty;
    [SerializeField] GameplayManager _gameplayManager;
    float currentGameDifficulty;
    DateTime SpawnTime;
    Damager damager;
    bool healing;
    protected bool hide;
    // Start is called before the first frame update
    virtual protected void Start()
    {
        _hp = _maxHp;
        SpawnTime = DateTime.Now;
    }

    // Update is called once per frame
    virtual protected void Update()
    {
        _healthbar.SetHpAmount(_hp, _maxHp);
        if (healing && _hp < _maxHp)
        {
            _hp++;
        }
        if (_hp <= 0 && !hide)
        {
            Destroy(gameObject, 2f);
            hide = true;
            _scoreCounter.AddPoints(_scoreReward);
        }
        if ((DateTime.Now - SpawnTime) > TimeSpan.FromSeconds(_stayTime) && !hide && !healing)
        {
            hide = true;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Hitter"))
        {
            damager = other.gameObject.GetComponent<Damager>();
            _hp = _hp - damager.GetDamage();
        }
    }
    public float GetSpawnChance()
    {
        currentGameDifficulty = _gameplayManager.GetDifficulty();
        if (currentGameDifficulty >= _minimalGameDifficulty) return _spawnChance*currentGameDifficulty;
        else return 0;
    }
}
