using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{

    public float latitude = 0f;
    public float longitude = 0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeLatitude(string inputNumber) {
        if(inputNumber.Trim().Length > 0){
            latitude = float.Parse(inputNumber);
            Vector3 currentPosition = gameObject.transform.position;
            currentPosition.x = latitude;
            gameObject.transform.position = currentPosition;
        }
        
    }

    public void changeLongitude(string inputNumber) {
        if(inputNumber.Trim().Length > 0){
            longitude = float.Parse(inputNumber);
            Vector3 currentPosition = gameObject.transform.position;
            currentPosition.z = longitude;
            gameObject.transform.position = currentPosition;
        }
        
    }
}
