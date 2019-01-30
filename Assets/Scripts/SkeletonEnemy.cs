using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonEnemy : MonoBehaviour {

    public int EnemyHealth = 10;
    public GameObject TheSkeleton;
    public int SkeletonStatus;


    void DeductPoints (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    void Update () {
		if(EnemyHealth <= 0)
        {
            if(SkeletonStatus == 0)
            {
                StartCoroutine(DeathSkeleton());
            }

        }
    }
    IEnumerator DeathSkeleton ()
    {
        SkeletonStatus = 7;
        yield return new WaitForSeconds(0.5f);
        TheSkeleton.GetComponent<Animation>().Play("Death");

    }
}
