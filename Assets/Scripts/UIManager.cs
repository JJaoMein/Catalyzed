using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panelStriker;
    public GameObject panelTasks;
    public GameObject panelBattlePass;
    public GameObject panelProfile;
    public GameObject panelButtonNav;
    [SerializeField] List<GameObject> weekPanels = new();
    ww


    private void Start()
    {
        panelStriker.SetActive(true);
        panelButtonNav.SetActive(false);
        StartCoroutine(disbaleStrikerPanel());
    }

    IEnumerator disbaleStrikerPanel()
    {
        yield return new WaitForSeconds(1);
        panelButtonNav.SetActive(true);
        panelStriker.SetActive(false);
    }

    public void ShowTasks()
    {
        panelTasks.SetActive(true);
        panelBattlePass.SetActive(false);
        panelProfile.SetActive(false);
    }

    public void ShowBattlePass()
    {
        panelTasks.SetActive(false);
        panelBattlePass.SetActive(true);
        panelProfile.SetActive(false);

    }

    public void ShowProfile()
    {
        panelTasks.SetActive(false);
        panelBattlePass.SetActive(false);
        panelProfile.SetActive(true);

    }

    public void ShowWeekPanel(int currentDay)
    {
        //panelTasks.SetActive(false);
        panelBattlePass.SetActive(false);
        panelProfile.SetActive(false);
        foreach (GameObject panel in weekPanels)
        {
            panel.SetActive(false);
        }
        weekPanels[currentDay].SetActive(true);

    } 

    public void ActivateDetailsPanel(int currentDay)
    {
        detailPanels[currentDay].SetActive(true);
    }
}
