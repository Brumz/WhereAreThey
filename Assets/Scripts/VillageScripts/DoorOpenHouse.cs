using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenHouse : MonoBehaviour {

    public GameObject theDoor;
    public AudioSource creakSound;

    void OnTriggerEnter(Collider other)
    {
        creakSound.Play();
        theDoor.GetComponent<Animator>().enabled = true;
        theDoor.GetComponent<Animator>().Play("OpenDoorVillage");
        this.GetComponent<BoxCollider>().enabled = false;
    }

}
