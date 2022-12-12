using UnityEngine;
using UnityEngine.UI;

public class HPBar2M : MonoBehaviour
{
    public Slider slider;
    public GameObject target;
    public Heal_or_dmg Mag;

    void Update()
    {
        // Set the Slider's value to the target's current health
        slider.value = Mag.current_hp;
        slider.maxValue = Mag.max_hp;
    }
}