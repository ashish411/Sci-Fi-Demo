using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    [SerializeField]
    private float _sensitivity = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouse_Y = Input.GetAxis("Mouse Y");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x -= mouse_Y * _sensitivity;
        transform.localEulerAngles = newRotation;
    }
}
