using UnityEngine;
using UnityEngine.UI;

public class WeeklyTasksUI : MonoBehaviour
{
    public GameObject activityInfoPanel;
    //public Text descriptionText;

    // Simulación de descripciones
    private string[] taskDescriptions = {
        "Task 1: Practice short passes for 10 minutes.",
        "Task 2: Practice short passes for 10 minutes.",
        "Task 3: Practice short passes for 10 minutes."
    };

    void OnEnable()
    {
        activityInfoPanel.SetActive(false);
    }
    public void ShowPopup(int index)
    {
        //descriptionText.text = taskDescriptions[index];
        activityInfoPanel.SetActive(true);
    }

    public void HidePopup()
    {
        activityInfoPanel.SetActive(false);
    }


}
