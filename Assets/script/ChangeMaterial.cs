using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material Black;
    public Material Green;
    public Material Pink;
    public Material Red;
    public GameObject MushroomHead;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeBlack() {
        MushroomHead.GetComponent<Renderer>().material = Black;
    }
    public void ChangeGreen()
    {
        MushroomHead.GetComponent<Renderer>().material = Green;
    }
    public void ChangePink()
    {
        MushroomHead.GetComponent<Renderer>().material = Pink;
    }
    public void ChangeRed()
    {
        MushroomHead.GetComponent<Renderer>().material = Red;
    }
}
