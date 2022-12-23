using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseMover : MonoBehaviour
{
    [SerializeField] Vector3 _force;
    [SerializeField] GameObject _parent;
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = _parent.transform;
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.AddForce(_force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
