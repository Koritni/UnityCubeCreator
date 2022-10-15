
using System;
using UnityEngine;

public class TextBoxValue : MonoBehaviour
{

    public TMPro.TMP_InputField Secondsfield;
    public TMPro.TMP_InputField Speedfield;
    public TMPro.TMP_InputField Distancefield;

    public Creator creatorObj;
    public MovingObjects MOObj;
    

    public void OnEndSeconds() 
    {
        try{
            int number = Int32.Parse(Secondsfield.text);
            if(number < 0 || number == 0)
            {
                Debug.LogError("value can't be < 0 or == 0");
            }
            else
            {
                creatorObj.seconds = number; 
            }
            
        }
        catch (FormatException){
            Debug.Log("NumberFormatException");
        }
    }

     public void OnEndSpeed() 
    {
        try{
            float number = float.Parse(Speedfield.text);
            if(number < 0 || number == 0)
            {
                Debug.LogError("value can't be < 0 or == 0");
            }
            else
            {
                MOObj.speed = number;
            }
           
        }
        catch (FormatException){
            Debug.Log("NumberFormatException");
        }
    }

     public void OnEndDistance() 
    {
        try{
            float number = float.Parse(Distancefield.text);
            if(number < 0 || number == 0)
            {
                Debug.LogError("value can't be < 0 or == 0");
            }
            else
            {
                MOObj.distance = number;
            }
            
        }
        catch (FormatException){
            Debug.Log("NumberFormatException");
        }
    }
}
