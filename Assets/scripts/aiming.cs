using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiming : MonoBehaviour
{
    float x,y, mouseX, mouseY;

    [SerializeField] Camera main;
  
    void Update()
    {

        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        x += mouseX;
        y -= mouseY;

        transform.localRotation = Quaternion.Euler(y, 0, 0);
        transform.parent.rotation = Quaternion.Euler(0, x, 0);
    }
}
