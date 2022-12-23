using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnce : MonoBehaviour
{
    [SerializeField] GameObject _spawnedObject;
    [SerializeField] GameplayManager _gameplayManager;
    [SerializeField] GameObject _parent;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v3 = new Vector3();
        Quaternion rotation = new Quaternion();
        for (int i = -6; i<7; i=i+3)
        {
            for (int j = -6; j < 7; j = j + 3)
            {
                v3 = new Vector3(j, 0, i);
                Instantiate(_spawnedObject, v3, rotation, _parent.transform);
            }
        }
        _gameplayManager.LoadWells();
    }
}
