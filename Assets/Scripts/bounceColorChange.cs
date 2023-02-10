using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollissionEnter: " + collision.gameObject.name);
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter: " + other.gameObject.name);
    }
}
