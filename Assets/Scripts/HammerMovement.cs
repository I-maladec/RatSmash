using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerMovement : MonoBehaviour
{
    [SerializeField] float _mouseSensivity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Mouse X")*_mouseSensivity, 0, Input.GetAxis("Mouse Y")*_mouseSensivity);
    }
}
