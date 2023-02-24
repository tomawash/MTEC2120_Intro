using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSphereControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    void FixedUpdate()
    {
        var gamepad = Gamepad.current;

        if (gamepad == null)
        {
            return;
        }
    }

    //
    public void OnJump(InputValue value)
    {
        Debug.Log("JUMP");
    }
}
