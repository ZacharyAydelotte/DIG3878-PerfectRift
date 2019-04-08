using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TimeRev : MonoBehaviour
{
    public GameObject indic;
    public float rewindLength = 5.0f;
    public bool isRewinding = false;
    public int rwCounter = 5;
    List<PointInTime> pointsInTime;
    Rigidbody rb;
    float rwTimer;

    // Start is called before the first frame update
    void Start()
    {
        pointsInTime = new List<PointInTime>();
        rb = GetComponent<Rigidbody>();
        rwTimer = rewindLength;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && rwCounter > 0)
        {
            indic.SetActive(true);
            gameObject.GetComponent<RigidbodyFirstPersonController>().enabled = false;
            StartRewind();
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            indic.SetActive(false);
            gameObject.GetComponent<RigidbodyFirstPersonController>().enabled = true;
            StopRewind();
        }
    }

    void FixedUpdate()
    {
        if (isRewinding)
            Rewind();
        else
            Record();
    }

    void Rewind()
    {
        if (pointsInTime.Count > 0 && rwTimer > 0)
        {
            PointInTime pointInTime = pointsInTime[0];
            transform.position = pointInTime.position;
            transform.rotation = pointInTime.rotation;
            pointsInTime.RemoveAt(0);

            rwTimer -= Time.deltaTime;
        }
        else
        {
            StopRewind();
        }
    }

    void Record()
    {
        if (pointsInTime.Count > Mathf.Round(rewindLength / Time.fixedDeltaTime))
        {
            pointsInTime.RemoveAt(pointsInTime.Count - 1);
        }

        pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
    }

    public void StartRewind()
    {
        isRewinding = true;
        rb.isKinematic = true;

        if (rwCounter >= 1)
        {
            rwCounter--;
        }
    }

    public void StopRewind()
    {
        rwTimer = rewindLength;
        isRewinding = false;
        rb.isKinematic = false;
    }
}
