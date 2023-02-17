using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceColorChange : MonoBehaviour
{
    public Color objectColor;

    // Start is called before the first frame update
    void Start()
    {
        objectColor = GetRandomColor();

        MeshRenderer thisRenderer = GetComponent<MeshRenderer>();
        Material newMaterial = new Material(thisRenderer.material);
        newMaterial.SetColor("_Color", objectColor);
        thisRenderer.material = newMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Returns a random color
    public Color GetRandomColor()
    {
        return new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollissionEnter: " + collision.gameObject.name);

        objectColor = GetRandomColor();

        MeshRenderer thisRenderer = GetComponent<MeshRenderer>();
        Material newMaterial = new Material(thisRenderer.material);
        newMaterial.SetColor("_Color", objectColor);
        thisRenderer.material = newMaterial;
    }

    
}
