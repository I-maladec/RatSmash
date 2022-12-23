using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : MonoBehaviour
{
    bool occupied = false;
    private void Start()
    {

    }
    private void OnCollisionExit(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Enemy")) return;
        occupied = false;
    }
    public void SpawnEnemy(GameObject enemy)
    {
        if (occupied) return;
        Instantiate(enemy, gameObject.transform);
        occupied = true;
    }
}
