using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreTxt;
    public  static float scoreValue;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt.text= scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = scoreValue.ToString();
    }
}
