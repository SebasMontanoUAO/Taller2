using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControllerScene1 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textGreenApple;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShowGreenApple();
    }

    public void ShowGreenApple()
    {
        textGreenApple.text = GameManager.Instance.AppleCount.ToString();
    }
}