using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class XPManager : MonoBehaviour
{
    [SerializeField]
    Slider xpSlider;
    [SerializeField]
    float xpToAdd;
    [SerializeField]
    ParticleSystem xpVFX;

    float currentXP;
    float xpForNextLevel;
    void Start()
    {
        xpForNextLevel = 20;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Subir XP
        {
            AddXP();
        }

        if (Input.GetKeyDown(KeyCode.R)) // Reiniciar XP
        {
            xpSlider.value = 0;
            xpForNextLevel = 20;
        }
    }

    void AddXP()
    {
        currentXP = xpSlider.value;
        StartCoroutine(AnimateUIElements());//xpSlider.value += xpToAdd;
        Mathf.Clamp(xpSlider.value, 0, xpSlider.maxValue);
        //xpVFX.Play();
    }

    IEnumerator AnimateUIElements()
    {
        while (xpSlider.value < currentXP + xpToAdd)
        {
            xpSlider.value += 0.5f;
            if (xpSlider.value == xpForNextLevel)
            {
                xpVFX.Play();
                xpForNextLevel += 20;
            }
            yield return new WaitForSeconds(0.05f);
            //Debug.Log(xpSlider.value);
        }
    }
}
