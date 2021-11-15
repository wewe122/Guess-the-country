using UnityEngine;
using UnityEngine.UI;
using System;

public class CategoryBtnScript : MonoBehaviour
{
    [SerializeField] private Text categoryTitleText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Button btn;

    public Button Btn { get => btn; }

    public void SetButton(string title, int totalQuestion)
    {
        categoryTitleText.text = title;
        scoreText.text = ""+totalQuestion; 
    }

}
