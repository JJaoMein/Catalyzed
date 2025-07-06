using UnityEngine;
using UnityEngine.UI;

public class BattlePassUI : MonoBehaviour
{
    public Slider xpSlider;
    public float xp = 0f;
    public float maxXp = 100f;
    public float incrementAmount = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Subir XP
        {
            xp += incrementAmount;
            xp = Mathf.Clamp(xp, 0, maxXp);
            xpSlider.value = xp;
        }

        if (Input.GetKeyDown(KeyCode.R)) // Reiniciar XP
        {
            xp = 0;
            xpSlider.value = xp;
        }
    }
}
