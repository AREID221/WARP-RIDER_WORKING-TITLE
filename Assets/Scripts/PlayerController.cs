using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField]
    private GameObject g_Anchor;
    private float speed;
    private float speedBoosted;
    private float invicibilityBoosted;
    private float doublePointBoosted;
    public bool DoublePoints;
    public GameObject pAnchor;
    private void Awake()
    {
        g_Anchor = GameObject.FindGameObjectWithTag("ANCHOR").gameObject;
        speed = 180.0f;
        speedBoosted = 0;
        invicibilityBoosted = 0;

    }
    private void Update()
    {
        if(speedBoosted > 0)
        {
            speedBoosted--;
            if(speedBoosted <=0)
            {
                speed *= 0.5f;
            }
        }
        if(Input.touchCount != 0)
        {
            Vector2 ScreenPosTouch = Input.GetTouch(0).position;
            Debug.Log(ScreenPosTouch);
        }
        {

        }
        if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("this is D");
            PlayerMove(true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("this is A");
            PlayerMove(false);
        }

    }
    public void SpeedBoost()
    {
        //double speed 
        speed *= 2;
        //speed bonus duration 2 seconds
        speedBoosted = 60 / 30;
    }
    public void Invicibility()
    {
        //disable player collider for 2 seconds
        invicibilityBoosted = 60 / 30;
    }
    public void DoublePoint()
    {
        //player double points is active
        DoublePoints = true;
        //player double points duration is 60 seconds
        doublePointBoosted = 60f;
    }
    public void PlayerMove(bool Input)
    {
        
        if (Input)
        {
            //true is right
            pAnchor.GetComponent<Rigidbody>().AddTorque(Vector3.up, ForceMode.VelocityChange);
             //transform.RotateAround(g_Anchor.transform.position, new Vector3(0,1,0), speed * Time.deltaTime);
        }
        else
        {
            //false is left
            pAnchor.GetComponent<Rigidbody>().AddTorque(-Vector3.up, ForceMode.VelocityChange);
            //transform.RotateAround(g_Anchor.transform.position, new Vector3(0, 1, 0), -speed * Time.deltaTime);
        }

    }

}
