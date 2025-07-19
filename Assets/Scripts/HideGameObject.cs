using UnityEngine;
using UnityEngine.UI;

public class HideGameObject : MonoBehaviour
{
    [SerializeField]
    GameObject objectToHide;

    Button hideButton;
    void Start()
    {
        hideButton = GetComponent<Button>();
        hideButton.onClick.AddListener(HideObject);
    }

    void HideObject()
    {
        objectToHide.gameObject.SetActive(false);
    }
}
