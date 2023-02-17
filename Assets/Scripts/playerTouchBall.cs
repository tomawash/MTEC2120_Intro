using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTouchBall : MonoBehaviour
{
    public Color objectColor;

    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer thisRenderer = GetComponent<MeshRenderer>();
        Material newMaterial = new Material(thisRenderer.material);
        newMaterial.SetColor("_Color", objectColor);
        thisRenderer.material = newMaterial;

        objectColor = thisRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter: " + other.gameObject.name);

        if (other.gameObject.name == "TrapBall")
        {
            //MeshRenderer otherRenderer = other.GetComponent<MeshRenderer>();
            //Material otherMaterial = new Material(otherRenderer.material);

            Transform thisTransform = GetComponent<Transform>();
            Vector3 newScale = new Vector3(1, 2, 1);
            thisTransform.localScale = newScale;

            /*MeshRenderer thisRenderer = GetComponent<MeshRenderer>();
            Material newMaterial = new Material(thisRenderer.material);

            newMaterial.SetColor("_Color", otherMaterial.color);
            thisRenderer.material = newMaterial;*/

            //Debug.Log("I toucha da ball. THe ball color is " + otherMaterial.color.ToString());
        }
    }
}
