using UnityEngine;
using UnityEngine.UI;

public class SliderXP : MonoBehaviour
{
    public Slider slider;
    public EXP exp;
    public EXP exp2;

    void Update()
    {
        // Set the Slider's value to the target's current health
        slider.value = exp.get_expAmount() + exp2.get_expAmount();
        slider.maxValue = exp.get_maxExp();

    }
    
}