<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Gun : MonoBehaviour {
    
    private Handedness handedness;
    private Grabber myGrabber;

    public GameObject bullet;

    private void Start() {
        myGrabber = GetComponent<Grabber>();
        handedness = myGrabber.handedness;
    }

    
    void Update() {
        if (VRInput.GetDown(GenericVRButton.Index, handedness)) 
            Shoot();
        
    }

    private void Shoot() {
        
        Destroy(Instantiate(bullet, transform.position, transform.rotation), 2f);
        
    }
    
    
}
>>>>>>> f89cec711f8f88f97a312da72abd9d6174ae9906
