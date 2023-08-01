using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField]
    private TMPro.TMP_Text score_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetScoreText(int score)
    {
        score_text.SetText("Score:"+ score.ToString());
    }
}
