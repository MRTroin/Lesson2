using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disconect : MonoBehaviour
{
    private HingeJoint2D _Joint;

     private void Start()
    {
        _Joint= GetComponent<HingeJoint2D>();
        Debug.Log(_Joint.name);
    }


     private void Update()
    {
        if (Input.GetMouseButton(0))
        {
           Destroy(_Joint);
        }
    }
}
