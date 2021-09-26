using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class AnswerManager : MonoBehaviour
{

    public GameObject answer_object = null;
    public int score_num = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text answer_text = answer_object.GetComponent<Text>();
        answer_text.text = "Score:"+score_num;
        score_num += 1;
    }
}
