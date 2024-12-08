using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    float mouseX; 
    float mouseY;

    float multiplier = 0.01f;
    public Camera cam;

    float xRotation; 
    float YRotation;

    private void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor - visible = false;
    }

    private void Update()
    {
        if(!PlayerMovement.dialogue)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            MyInput();

            cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
            transform.rotation = Quaternion.Euler(0, yRotation, 0);
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
       
    }

    void MyInput()
    {
        mouseX = Input.GetAxisRaw("Mouse X");
        mouseY = Input.GetAxisRaw("Mouse Y™);

        Rotation += mouseX * senx * multiplier;
        Rotation -= mouseY * seny * multiplier;

        Rotation = Mathf.Clamp(xRotation, -90f, 90f);
    }
}
