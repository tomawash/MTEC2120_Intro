using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public delegate void OnClickEvent(GameObject g);
    public event OnClickEvent OnClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits = Physics.RaycastAll(ray);
        for (int i = 0; i < hits.Length; i++)
        {
            OnClick(hits[i].collider.gameObject);
        }

        if(OnClick != null)
        {
            //ObjectCheck();
        }
    }

    void ObjectCheck(GameObject recieved)
    {
        Debug.Log(recieved);
        //Debug.Log(g.name);
    }
}
