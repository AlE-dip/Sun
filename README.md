# Sun
<p><strong>1: Run this program</strong></p>
<img src="https://github.com/AlE-dip/Sun/assets/71812422/2e2bcff4-9d4f-4bcd-9608-3a674e5c7be7" witd="400" height="400"/>
<p>To catch the event, I use On End Edit of the input field and call the function of the Object to be changed</p>
<img src="https://github.com/AlE-dip/Sun/assets/71812422/a3ec4a79-c50f-48c7-a126-08bbb22afbf9" witd="400" height="400"/>

<p><strong>2: Change latitude</strong></p>
<p>Change latitude: change position along the x-axis of the pillar</p>

```
    public void changeLatitude(string inputNumber) {
        if(inputNumber.Trim().Length > 0){
            latitude = float.Parse(inputNumber);
            Vector3 currentPosition = gameObject.transform.position;
            currentPosition.x = latitude;
            gameObject.transform.position = currentPosition;
        }
        
    }
```

<img src="https://github.com/AlE-dip/Sun/assets/71812422/0fb09ec4-25af-441e-ae3b-8f17668d7b0d" witd="400" height="400"/>

<p><strong>3: Change longitude</strong></p>
<p>Change longitude: change position along the z-axis of the pillar</p>

```
    public void changeLongitude(string inputNumber) {
        if(inputNumber.Trim().Length > 0){
            longitude = float.Parse(inputNumber);
            Vector3 currentPosition = gameObject.transform.position;
            currentPosition.z = longitude;
            gameObject.transform.position = currentPosition;
        }
    }
```

<img src="https://github.com/AlE-dip/Sun/assets/71812422/1bc20b56-da1f-4044-adc4-ee081cd2ae7b" witd="400" height="400"/>

<p><strong>4: Change time</strong></p>
<p>I will convert 24h into 360 degrees corresponding to the position of the Sun, and save it to sliderX</p>

```
System.DateTime time = System.DateTime.Parse(inputTime);
TimeSpan totalDay = TimeSpan.FromHours(24);
float sliderX = (float) (time.TimeOfDay.TotalSeconds / totalDay.TotalSeconds) * 360;
sliderX -= 90;
```
<p>Then, plus with transform.rotation, update sliderLastX to not plus twice</p>

```
Quaternion localRotation = Quaternion.Euler(sliderX - sliderLastX, 0f, 0f);
transform.rotation = transform.rotation * localRotation;
sliderLastX = sliderX;
```
<p>This function</p>

```
    public void changeTime(string inputTime) {
        if(inputTime.Trim().Length > 0){
            try
            {
                System.DateTime time = System.DateTime.Parse(inputTime);

                TimeSpan totalDay = TimeSpan.FromHours(24);
                float sliderX = (float) (time.TimeOfDay.TotalSeconds / totalDay.TotalSeconds) * 360;
                sliderX -= 90;

                Quaternion localRotation = Quaternion.Euler(sliderX - sliderLastX, 0f, 0f);
                transform.rotation = transform.rotation * localRotation;
                sliderLastX = sliderX;
            }
            catch (FormatException ex)
            { 
            }
        }
    }
```

<img src="https://github.com/AlE-dip/Sun/assets/71812422/d51cfe91-6e09-4ca1-812c-ab2d295f2362" witd="200" height="200"/>
<img src="https://github.com/AlE-dip/Sun/assets/71812422/d2fef303-2826-4569-b9f9-470bd2a49949" witd="200" height="200"/>
<img src="https://github.com/AlE-dip/Sun/assets/71812422/f62fca77-1004-4e4b-81b3-c85be8de0cb5" witd="200" height="200"/>
<img src="https://github.com/AlE-dip/Sun/assets/71812422/9f505dc9-9b8f-4d2e-8bb8-598cae8439f1" witd="200" height="200"/>

