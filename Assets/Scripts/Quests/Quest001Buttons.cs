using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Buttons : MonoBehaviour {

    public GameObject Player;
    public GameObject NoticeCam;
    public GameObject UIquest;
    public GameObject ActiveQuestBox;
    public GameObject Objective001;
    public GameObject Objective002;
    public GameObject Objective003;


    public void AcceptQuest ()
    {
        Player.SetActive(true);
        NoticeCam.SetActive(false);
        UIquest.SetActive(false);
        StartCoroutine (SetQuestUI ());
    }

    IEnumerator SetQuestUI()
    {
        ActiveQuestBox.GetComponent<Text>().text = "My First Weapon";
        Objective001.GetComponent<Text>().text = "Reach the Hills";
        Objective002.GetComponent<Text>().text = "Open chest";
        Objective003.GetComponent<Text>().text = "Retrieve weapon";
        QuestManager.ActiveQuestNumber = 1;
        yield return new WaitForSeconds(0.5f);
        ActiveQuestBox.SetActive(true);
        yield return new WaitForSeconds(1);
        Objective001.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective002.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective003.SetActive(true);
        yield return new WaitForSeconds(9);
        ActiveQuestBox.SetActive(false);
        Objective001.SetActive(false);
        Objective002.SetActive(false);
        Objective003.SetActive(false);

    }

    public void DeclineQuest ()
    {
        Player.SetActive(true);
        NoticeCam.SetActive(false);
        UIquest.SetActive(false);
    }
}
