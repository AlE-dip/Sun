using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChangeTime : MonoBehaviour
{
    float sliderLastX = 90f;
    float time = 30f;
    float sliderX;
    Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        transform = gameObject.transform;
        transform.rotation = Quaternion.Euler(sliderLastX, 30f, 0f);
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
                float sliderX = (float) (time.TimeOfDay.TotalSeconds / totalDay.TotalSeconds) * 360;
                sliderX -= 90;

                Debug.Log("sliderX: " + sliderX);
                Debug.Log("sliderLastX: " + sliderLastX);
                Debug.Log("Parsed time: " + transform.eulerAngles.x);
                // this.transform.eulerAngles = new Vector3(sliderX,transform.eulerAngles.y,transform.eulerAngles.z);
                Quaternion localRotation = Quaternion.Euler(sliderX - sliderLastX, 0f, 0f);
                transform.rotation = transform.rotation * localRotation;
                sliderLastX = sliderX;

                // gameObject.transform.rotation.x = percentageOfDay;
                Debug.Log("Parsed time 2: " + transform.eulerAngles.x);
                
            }
            catch (FormatException ex)
            {
                
            }

        }
        
    }
}
