using UnityEngine;
using System;

public class MovingObjects : MonoBehaviour
{
    public float speed = 4;
    public float distance = 5;

    public float Speed
    {
        get {return speed;}
        set {
                if(value < 0 || value == 0)
                {
                    Debug.LogError("value can't be < 0 or == 0");
                }
                else
                {
                    speed = value;
                }
            }
    }

    public float Distance
    {
        get {return distance;}
        set {
                if(value < 0 || value == 0)
                {
                    Debug.LogError("value can't be < 0 or == 0");
                }
                else
                {
                    distance = value;
                }
            }
    }

    private float randomX;
    private float randomZ;
    private float AwakePosXZ;

    private void Awake() {
        AwakePosXZ = positionXZ();
        randomX = UnityEngine.Random.value > 0.5 ? 1 : -1;
        randomZ = UnityEngine.Random.Range(-1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(randomX,0,randomZ) * Time.deltaTime * speed);

        if( AwakePosXZ - positionXZ() > distance || AwakePosXZ - positionXZ() < -distance)
        {
            if( gameObject != null) 
            { 
                Destroy(gameObject); 
            }
            else
            {
                Destroy(this);
            }
        }
           
    }

    float positionXZ()
    {
       return Math.Abs(transform.position.x) + Math.Abs(transform.position.z);
    }

}

