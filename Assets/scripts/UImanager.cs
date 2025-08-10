using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI statsText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame



    void Update()
    {
        statsText.text =

            "to start press q"+
            "\nScore: " + playercontroller.score +
            "\ntimer: " + Mathf.CeilToInt(spawner.wavetimer) +
            "\nbestscore: " + playercontroller.bestscore +
            "\nmouse sensitivity: " + playercontroller.mouseSensitivity+
            "\nto change sensitivity (arrowup,arrowdown)";
    }
        
    
}
