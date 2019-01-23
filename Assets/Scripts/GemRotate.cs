using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour {

    public int RotateSpeed;
    public AudioSource CollectSound;
    public GameObject Gem;

	void Update () {
        transform.Rotate(0, RotateSpeed, 0, Space.World);
	}

    //void OnTriggerEnter(Collider other)
    //{
    //    CollectSound.Play();
    //    Gem.SetActive(false);
    //}
}
