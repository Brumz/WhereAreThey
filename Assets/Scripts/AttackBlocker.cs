using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBlocker : MonoBehaviour {

    public static int BlockSword;
    public int InternalBlock;

	void Update () {
        InternalBlock = BlockSword;
	}
}
