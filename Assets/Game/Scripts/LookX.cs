using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    [SerializeField]
    private float _sensitivity = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouse_X = Input.GetAxis("Mouse X");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.y += mouse_X * _sensitivity;
        transform.localEulerAngles = newRotation;

    }
}
