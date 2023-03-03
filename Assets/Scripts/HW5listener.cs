using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW5listener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HW5broadcaster.OnClick += OnClickEventListener;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClickEventListener(GameObject g)
    {
        Debug.Log("Raycast hit: " + g.name);
    }
}
