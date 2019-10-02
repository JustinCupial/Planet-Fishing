using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    Grabber grabber;
    Handedness handy;
    public GameObject laserPrefab;
    GenericVRButton button = GenericVRButton.Index;

    void Start()
    {
        grabber = GetComponent<Grabber>();
        handy = grabber.handedness;
    }

  
    void Update()
    {

        if(VRInput.GetDown(button, handy)) {

            Instantiate(laserPrefab, transform.position, transform.rotation);

        }
    }
}
