using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panelStriker;
    public GameObject panelTasks;
    public GameObject panelBattlePass;
    public GameObject panelProfile;

    private void Start()
    {
        panelStriker.SetActive(true);
    }

    public void ShowTasks()
    {
        panelTasks.SetActive(true);
        panelBattlePass.SetActive(false);
        panelProfile.SetActive(false);
        panelStriker.SetActive(false);
    }

    public void ShowBattlePass()
    {
        panelTasks.SetActive(false);
        panelBattlePass.SetActive(true);
        panelProfile.SetActive(false);
        panelStriker.SetActive(false);
        
    }

    public void ShowProfile()
    {
        panelTasks.SetActive(false);
        panelBattlePass.SetActive(false);
        panelProfile.SetActive(true);
        panelStriker.SetActive(false);
        
    }
}
