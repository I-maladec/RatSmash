using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Healthbar _healthbar;
    [SerializeField] float _maxHealth;
    [SerializeField] GameObject _looseScreen;
    [SerializeField] GameObject _game;
    [SerializeField] ScoreCounter _scoreCounter;
    [SerializeField] GameObject _menu;
    float _health;
    Damager damager;
    // Start is called before the first frame update
    void Start()
    {
        _health = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(_health <= 0)
        {
            _looseScreen.SetActive(true);
            _game.SetActive(false);
            _scoreCounter.SaveBest();
        }
        _healthbar.SetHpAmount(_health, _maxHealth);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(_menu.activeSelf) _menu.SetActive(false);
            else _menu.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("EnemyHitter")) return;
        damager = other.gameObject.GetComponent<Damager>();
        _health -= damager.GetDamage();
        Destroy(other.gameObject);
    }
}
