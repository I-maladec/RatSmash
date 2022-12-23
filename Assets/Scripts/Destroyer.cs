using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] float _time;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
