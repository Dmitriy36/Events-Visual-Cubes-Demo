using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber : MonoBehaviour
{

    public GameObject ground;
    Light _light;

    void Start()
    {
        TestingEvents testingEvents = ground.GetComponent<TestingEvents>();
        testingEvents.OnSpacePressed += TestingEvents_OnSpacePressed;        
    }

    private void TestingEvents_OnSpacePressed(object sender, EventArgs e)
    {
        //Debug.Log("space pressed detected.");
        _light = GetComponentInChildren<Light>();

        if (_light.intensity > 0)
        {
            _light.intensity = 0;
        }
        else _light.intensity = 1;

    }

    void Update()
    {
        
    }
}
