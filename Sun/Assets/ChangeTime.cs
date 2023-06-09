using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChangeTime : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeTime(string inputTime) {
        if(inputTime.Trim().Length > 0){
            try
            {
                System.DateTime time = System.DateTime.Parse(inputTime);

                TimeSpan totalDay = TimeSpan.FromHours(24);
                float percentageOfDay = (float) (time.TimeOfDay.TotalSeconds / totalDay.TotalSeconds) * 360;
                percentageOfDay -= 90;

                Vector3 newRotation = gameObject.transform.eulerAngles;
                newRotation.x = percentageOfDay;
                gameObject.transform.eulerAngles = newRotation;

                // gameObject.transform.rotation.x = percentageOfDay;
                Debug.Log("Parsed time: " + percentageOfDay + " " + newRotation.x);
            }
            catch (FormatException ex)
            {
                
            }

        }
        
    }
}
