using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bombtext : MonoBehaviour
{
    [SerializeField] public TMP_Text bombText;
    [SerializeField] public aeronef aeronef;
    private GameObject detonator;

    // Start is called before the first frame update
    void Start()
    {
        detonator = GameObject.Find("bomb");
        bombText.text = ("-").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
    
}
