using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WallRun3Gravity : MonoBehaviour
{
    private bool isWallR = false;
    private bool isWallL = false;
    private RaycastHit hitR;
    private RaycastHit hitL;
    private int jumpCount = 0;
    private RigidbodyFirstPersonController cc;
    private Rigidbody rb;
    public float runTime = 0.5f;

    void Start()
    {
        cc = GetComponent<RigidbodyFirstPersonController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (cc.Grounded)
        {
            jumpCount = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !cc.Grounded && jumpCount <= 1) //off the ground check
        {
            if (Physics.Raycast(transform.position, -transform.right, out hitL, 1)) //wall check, hit left wall
            {
                if (hitL.transform.tag == "Wall") //tag check for Wall
                {
                    isWallL = true; //log and confirm as left wall
                    isWallR = false; //confirm not right wall
                    jumpCount += 1; //log jump
                    Physics.gravity = new Vector3(11, -4f, 0); //(X, Y, Z) gravity controls positive and negative gravity can be applied.
                    cc.advancedSettings.airControl = false; //turn off air control so player does not angle and float awau from wall

                    if (Input.GetKeyDown(KeyCode.Space) && !cc.Grounded && jumpCount > 1) //if space bar is hit again
                    {
                        Physics.gravity = new Vector3(-11, 1f, 0); //change in gravity to give you a push off the wall to the next, could be diabled if gamebreaking or not functionijng as inteded/hindering enjoyment.
                        jumpCount = 0; //since transferring walls, reset jump count
                        isWallL = false; //log that no wall contact is occurring
                        isWallR = false;
                        if (cc.Grounded) //if the ground is touched
                        {
                            isWallL = false; //log again that walls are not touched
                            isWallR = false;
                            Physics.gravity = new Vector3(0, -9.18f, 0); //normal gravity restored
                            cc.advancedSettings.airControl = true; //air control restored to the player
                        }
                        if (Input.GetKeyDown(KeyCode.Space) && !cc.Grounded && jumpCount <= 1) //space bar pressed at the next wall during the transfer
                        {
                            if (Physics.Raycast(transform.position, transform.right, out hitR, 1))
                            {
                                if (hitR.transform.tag == "Wall")
                                {
                                    isWallR = true; //right wall contact confirmed
                                    isWallL = false; //left wall not in contact
                                    jumpCount += 1; //jump count increased
                                    Physics.gravity = new Vector3(-11, -4f, 0); //gravity change, pushing against wall
                                    cc.advancedSettings.airControl = false; //air control turned off for player

                                    if (Input.GetKeyDown(KeyCode.Space) && !cc.Grounded && jumpCount > 1) //space bar pressed again
                                    {
                                        Physics.gravity = new Vector3(0, -9.18f, 0); //gravity normal
                                        cc.advancedSettings.airControl = true; //air control restored to player
                                        isWallR = false; //no longer touching either wall
                                        isWallL = false;
                                        jumpCount = 0; //jump count reset to zero.
                                    }
                                }
                            }
                        }
                    }

                    StartCoroutine(afterRun()); //starts timer co routine, to reset wall run timer and make sure all settings are reset back to starting
                }
            }
            if (Physics.Raycast(transform.position, transform.right, out hitR, 1)) //basically the same just for starting the chain with the right side wall
            {
                if (hitR.transform.tag == "Wall") //first jump
                {
                    isWallR = true;
                    isWallL = false;
                    jumpCount += 1;
                    Physics.gravity = new Vector3(-11, -4f, 0);
                    cc.advancedSettings.airControl = false;

                    if (Input.GetKeyDown(KeyCode.Space) && !cc.Grounded && jumpCount > 1) //push off the wall
                    {
                        Physics.gravity = new Vector3(11, 1f, 0);
                        jumpCount = 0;
                        isWallL = false;
                        isWallR = false;
                        if (cc.Grounded) //if hitting the ground
                        {
                            isWallL = false;
                            isWallR = false;
                            Physics.gravity = new Vector3(0, -9.18f, 0);
                            cc.advancedSettings.airControl = true;
                        }
                        if (Input.GetKeyDown(KeyCode.Space) && !cc.Grounded && jumpCount <= 1) //connecting to the next wall
                        {
                            if (Physics.Raycast(transform.position, -transform.right, out hitL, 1)) //left wall connection successful
                            {
                                if (hitR.transform.tag == "Wall") //active wall run
                                {
                                    isWallR = false;
                                    isWallL = true;
                                    jumpCount += 1;
                                    Physics.gravity = new Vector3(11, -4f, 0);
                                    cc.advancedSettings.airControl = false;

                                    if (Input.GetKeyDown(KeyCode.Space) && !cc.Grounded && jumpCount > 1) //jump off of wall
                                    {
                                        Physics.gravity = new Vector3(0, -9.18f, 0); //gravity returns to normal
                                        cc.advancedSettings.airControl = true;
                                        isWallR = false;
                                        isWallL = false;
                                        jumpCount = 0;
                                    }
                                }
                            }
                        }
                    }

                    StartCoroutine(afterRun());
                }
            }

        }
    }
    IEnumerator afterRun()
    {
        yield return new WaitForSeconds(runTime); //timer
        isWallL = false;
        isWallR = false;
        Physics.gravity = new Vector3(0, -9.81f, 0); //normal gravity
        cc.advancedSettings.airControl = true;
    } 
}