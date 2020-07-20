using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigate : MonoBehaviour
{
    public GameObject UICamera;
    public GameObject PlayerCamera;
    public GameObject displayModel;
    public GameObject theName; //Name
    public GameObject theDesc; //Description
    public int theNo;
    public GameObject MaterialButton;

    static private string[] Name = new string[] { "Manhead Wrasse", "Triplet Turtle", "Ugly Mushroom" };
    static private string[] Desc = new string[] { "A spieces that exist deep under Southern Ocean from million years ago. With a man-like face, it's told that once you saw this fish, it'll bring you bad luck.", 
                                                  "A creature created by children's dream, they consume dream to be alive. Usually parasite in little boys' or girls' mind. They treate their hosts well. But will prevent children from growing up.",
                                                  "It's an ugly Mushroom, period." };
    // Start is called before the first frame update
    void Start()
    {
        //UICamera = GameObject.Find("UICamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider e) {
        if (e.gameObject.name == "Player") {





            GameObject.Find("BackButton").GetComponent<BackMuseum>().displayModel = displayModel;

            PlayerCamera.SetActive(false);
            UICamera.SetActive(true);

            displayModel.SetActive(true);
            displayModel.GetComponent<Rotate>().enabled = true;


            theName.GetComponent<Text>().text = Name[theNo];
            theDesc.GetComponent<Text>().text = Desc[theNo];


            //Allow changing texture for the mushroom
            if (displayModel.name == "Mushroom_Navigate")
            {
                MaterialButton.SetActive(true);
            }
            else {
                MaterialButton.SetActive(false);
            }
        }

    }


}
