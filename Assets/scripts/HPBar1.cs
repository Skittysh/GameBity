using UnityEngine;
using UnityEngine.UI;

public class HPBar1 : MonoBehaviour
{
    public Slider slider;
    public GameObject target;
    public Heal_or_dmg Knighp;

    void Update()
    {
        // Set the Slider's value to the target's current health
        slider.value = Knighp.current_hp;
        slider.maxValue = Knighp.max_hp;
    }
}