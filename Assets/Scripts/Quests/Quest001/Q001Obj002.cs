﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001Obj002 : MonoBehaviour {

    public float TheDistance;
    public GameObject TreasureChest;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheObjective;
    public int CloseObjective;
    public GameObject TakeSword;
	
	
	void Update () {
        TheDistance = PlayerCasting.DistanceFromTarget;

        if(CloseObjective == 3)
        {
            if (TheObjective.transform.localScale.y <= 0.0f)
            {
                CloseObjective = 0;
                TheObjective.SetActive(false);
            }
            else
            {
                TheObjective.transform.localScale -= new Vector3(0.0f, 0.01f, 0.0f);
            }
        }
    }


    void OnMouseOver()
    {
       if(TheDistance <= 3)
        {
            ActionText.GetComponent<Text>().text = "Open chest";
            ActionText.SetActive(true);
            ActionDisplay.SetActive(true);

        }
       if(Input.GetButtonDown("Action"))
        {
            if(TheDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                TreasureChest.GetComponent<Animation>().Play("Q01ChestOpen");
                TakeSword.SetActive(true);
                CloseObjective = 3;
                ActionText.SetActive(false);
                ActionDisplay.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
