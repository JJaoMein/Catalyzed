using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class XPButton : MonoBehaviour
{
    [SerializeField]
    Slider xpSlider;
    [SerializeField]
    TextMeshProUGUI xpText;
    [SerializeField]
    float xpToAdd;

    Button xpButton;
    float currentXP;
    void Start()
    {
        xpButton = GetComponent<Button>();
        xpButton.onClick.AddListener(AddXP);
    }

    void AddXP()
    {
        currentXP = xpSlider.value;
        StartCoroutine(AnimateUIElements());//xpSlider.value += xpToAdd;
        Mathf.Clamp(xpSlider.value, 0, xpSlider.maxValue);
        xpText.text = "+ " + xpToAdd + " XP!";
        xpText.gameObject.SetActive(true);
    }

    IEnumerator AnimateUIElements()
    {
        yield return new WaitForSeconds(0.5f);
        xpText.gameObject.SetActive(false);

        while (xpSlider.value < currentXP + xpToAdd)
        {
            xpSlider.value += 5;
            yield return new WaitForSeconds(0.07f);
            Debug.Log(xpSlider.value);
        }
    }
}
