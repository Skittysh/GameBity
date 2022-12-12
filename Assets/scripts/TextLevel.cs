using UnityEngine;
using UnityEngine.UI;

public class TextLevel : MonoBehaviour
{
    public int level = 1;
    public EXP expp;
    public Text levelText;

    void Update()
    {
        levelText.text = "Level: " + expp.get_lvl();
    }
}