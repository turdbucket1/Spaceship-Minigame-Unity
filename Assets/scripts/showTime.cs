using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showTime : MonoBehaviour
{

    [SerializeField] private TMP_Text textTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textTime.text = ((float)Time.realtimeSinceStartup).ToString() + " km";
    }
}
