using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        float increment = 1;
        float max = 10;
        float hi = 1;

        for (float r = 1; r >= 1; r = r)
        {
            for (int j = 0; j < Mathf.Ceil(r); j++)
            {
                float x = Mathf.Abs(r) * Mathf.Cos(2 * Mathf.PI * j / Mathf.Ceil(r));
                float y = Mathf.Abs(r) * Mathf.Sin(2 * Mathf.PI * j / Mathf.Ceil(r));
                GameObject go = Instantiate(prefab, new Vector3(x, hi, y), Quaternion.identity);

                MeshRenderer rend = go.GetComponent<MeshRenderer>();
                rend.material.color = GetRandomColor();
            }

            r += increment;
            hi++;

            if(r >= max)
            {
                increment *= -1;
            }
        }

        //Instantiate(prefab, new Vector3(0, 1, 0), Quaternion.identity);
    }

    public Color GetRandomColor()
    {
        return new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
