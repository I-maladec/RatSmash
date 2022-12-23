using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] GameObject _wellsContainer;
    [SerializeField] List<GameObject> _enemies;
    [SerializeField] float _spawnDelay;
    [SerializeField] float gameDifficultyRaise;
    float gameDifficulty = 1;
    Well[] wells;
    int spawnedObjectIndex;
    DateTime SpawnDelayTimer;
    void Start()
    {
        SpawnDelayTimer = DateTime.Now;
    }
    void Update()
    {
        if ((DateTime.Now - SpawnDelayTimer) > TimeSpan.FromSeconds(_spawnDelay/gameDifficulty))
        {
            spawnedObjectIndex = UnityEngine.Random.Range(0, _enemies.Count);
            if (UnityEngine.Random.Range(0, 100) < _enemies[spawnedObjectIndex].GetComponent<Enemy>().GetSpawnChance())
            {
                wells[UnityEngine.Random.Range(0, wells.Length)].SpawnEnemy(_enemies[spawnedObjectIndex]);
                gameDifficulty += gameDifficultyRaise;
                SpawnDelayTimer = DateTime.Now;
            }
        }
        if (gameDifficulty > 50) gameDifficultyRaise = 0;
    }
    public void LoadWells()
    {
        wells = _wellsContainer.transform.GetComponentsInChildren<Well>();
    }
    public float GetDifficulty()
    {
        return gameDifficulty;
    }
}
