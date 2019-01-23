using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFollow : MonoBehaviour {

    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedDistance = 5;
    public GameObject TheNPC;
    public float FollowSpeed;
    public RaycastHit Shot;
	
	void Update () {
        transform.LookAt(ThePlayer.transform);
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Shot)) {
            TargetDistance = Shot.distance;
            if(TargetDistance >= AllowedDistance){
                FollowSpeed = 0.2f;
                //TheNPC.GetComponent<Animation().Play("run");
                transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed);
            }
            else {
                FollowSpeed = 0;
                //TheNPC.GetComponent<Animation().Play("Idle");
            }
        }
	}
}
