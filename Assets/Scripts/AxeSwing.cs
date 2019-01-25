using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeSwing : MonoBehaviour {

    public GameObject TheAxe;
    public bool isSwinging;
    public AudioSource SwingSound; 

	void Update () {
		if(Input.GetButtonDown("Fire1") && isSwinging == false)
        {
            isSwinging = true;
            StartCoroutine(SwingTheAxe());
        }
    }
    IEnumerator SwingTheAxe()
    {
        SwingSound.Play();
        TheAxe.GetComponent<Animation>().Play("SwingAxe");
        yield return new WaitForSeconds(0.55f);
        isSwinging = false;
    }
}
