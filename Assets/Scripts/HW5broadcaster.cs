using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW5broadcaster : MonoBehaviour
{
    public delegate void OnClickEvent(GameObject g);
    public static event OnClickEvent OnClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits = Physics.RaycastAll(ray);
            for (int i = 0; i < hits.Length; i++)
            {
                OnClick(hits[i].collider.gameObject);
            }
        }
    }
}
