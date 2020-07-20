using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMuseum : MonoBehaviour
{

    public GameObject PlayerCamera;
    public GameObject displayModel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Back() {


        PlayerCamera.SetActive(true);

        displayModel.SetActive(false);
        displayModel.GetComponent<Rotate>().enabled = false;
        displayModel.transform.rotation = Quaternion.Euler(Vector3.zero);
    }
}
