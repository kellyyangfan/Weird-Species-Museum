using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    protected Vector3 posLastFame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            posLastFame = Input.mousePosition;

        if (Input.GetMouseButton(0)) {

            var delta = Input.mousePosition - posLastFame;
            posLastFame = Input.mousePosition;
            delta.y = 0;

            var axis = Quaternion.AngleAxis(-90f, Vector3.forward) * delta;
            transform.rotation = Quaternion.AngleAxis(delta.magnitude * 0.5f, axis)* transform.rotation;
        }
      
    }
}
