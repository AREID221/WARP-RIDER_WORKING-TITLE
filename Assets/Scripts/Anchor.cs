using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    //-9.81f y = x = -4.905f z = -4.905f
    public float _initialVelocity;
    public float _zeroRange;
    public GameObject[] testObstacles;
    Vector3 _trajectoryPoint1;
    public Vector3 _launchPoint;
    private float angle = 0f;
    private float angle2 = 270f;
    int i;
    public float spawrate;
    private void Awake()
    {
        i = 0;
        _launchPoint = this.transform.position - new Vector3(0, 0, 0);
    }
    private void Start()
    {
        Invoke("Launch", spawrate);
        //InvokeRepeating("Launch", 0f, spawrate);
    }
    private void Launch()
    {
        for (int s = 0; s <=1 ; s++)
        {
            float DirX = _launchPoint.x + Mathf.Sin(((angle + 180F * s)) * Mathf.PI / 180F);
            float Dirz = _launchPoint.z + Mathf.Cos(((angle + 180F * s)) * Mathf.PI / 180F);

            Vector3 moveVector = new Vector3(DirX, 0, Dirz);
            Vector3 direction = (moveVector + new Vector3(0,.66f,0)).normalized;
            
            GameObject objLauched = Instantiate(testObstacles[Random.RandomRange(0, 2)].gameObject);
            objLauched.transform.position = transform.position;
            objLauched.transform.rotation = transform.rotation;
            objLauched.GetComponent<Rigidbody>().AddForce(direction * 13f, ForceMode.VelocityChange);

            angle += 10f + Random.RandomRange(0f,10f);

            if(angle >= 360f)
            {
                angle = 0f;
            }

        }
        for (int s = 0; s <= 1; s++)
        {
            float Dir1X = _launchPoint.x + Mathf.Sin(((angle2 + 180F * s)) * Mathf.PI / 180F);
            float Dir1z = _launchPoint.z + Mathf.Cos(((angle2 + 180F * s)) * Mathf.PI / 180F);

            Vector3 moveVector1 = new Vector3(-Dir1X, -2.0f, -Dir1z);
            Vector3 direction1 = (moveVector1 + new Vector3(0, .66f, 0)).normalized;

            GameObject objLauched1 = Instantiate(testObstacles[Random.RandomRange(0,2)].gameObject);
            objLauched1.transform.position = transform.position;
            objLauched1.transform.rotation = transform.rotation;
            objLauched1.GetComponent<Rigidbody>().AddForce(-direction1 * 13f, ForceMode.VelocityChange);

            angle2 += 10f+ Random.RandomRange(0f, 10f);

            if (angle2 >= 360f)
            {
                angle2 = 0f;
            }

        }
        Invoke("Launch", spawrate);
    }
    private void Update()
    {
        //spawrate -= 0.001f;
        //    i++;
           transform.RotateAroundLocal(transform.up, 1.33f * Time.deltaTime);
        //    Vector3 onGizVec3_1 = new Vector3 (0,0,0);

        //    Vector3 onGizVec3_2 = this.transform.position + this.transform.forward;
        //    Vector3 _predictedVelocity = onGizVec3_1 + onGizVec3_2 * (-(_initialVelocity - _zeroRange) + _initialVelocity);

        //    _trajectoryPoint1 = onGizVec3_1;
        //    if(i == 30)
        //    {
        //        i = 0;
        //        var onTheFly = Instantiate(testObstacle);
        //        onTheFly.transform.position = this.transform.position - new Vector3(0, 5.0f, 0);
        //        onTheFly.GetComponent<Rigidbody>().AddForce(-this.transform.position.normalized+testObstacle.transform.position.normalized + new Vector3(0,0.5f,0) * 33f, ForceMode.VelocityChange);

        //    }





        //    for (float t = 0; t < 2; t += 0.001f)
        //    {
        //        testObstacle.transform.position = _trajectoryPoint1;


        //        _predictedVelocity += new Vector3(2.0f, 29.81f, 2.0f) * (0.0001f * _initialVelocity);
        //        onGizVec3_2 = _trajectoryPoint1 + _predictedVelocity * (0.0001f);
        //        //onGizVec3_2 = new Vector3(this.transform.position.x + onGizVec3_2.x, onGizVec3_2.y, onGizVec3_2.z);
        //        //Gizmos.color = Color.red;
        //        //Gizmos.DrawLine(_trajectoryPoint1, onGizVec3_2);
        //        _trajectoryPoint1 = onGizVec3_2;
        //        //GameObject onFly = Instantiate(testObstacle);
        //        //onFly.transform.position = _launchPoint;
        //        //onFly.GetComponent<Rigidbody>().AddForce(_trajectoryPoint1 + transform.forward, ForceMode.VelocityChange);
        //    }
        //}

    }
}


