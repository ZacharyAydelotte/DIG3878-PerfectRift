using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TimeRev : MonoBehaviour
{
    public GameObject indic;
    public float rewindLength = 5.0f;
    bool isRewinding = false;
    List<PointInTime> pointsInTime;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        pointsInTime = new List<PointInTime>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            indic.SetActive(true);
            gameObject.GetComponent<RigidbodyFirstPersonController>().enabled = false;
            StartRewind();
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
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
        if (pointsInTime.Count > 0)
        {
            PointInTime pointInTime = pointsInTime[0];
            transform.position = pointInTime.position;
            transform.rotation = pointInTime.rotation;
            pointsInTime.RemoveAt(0);
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
    }

    public void StopRewind()
    {
        isRewinding = false;
        rb.isKinematic = false;
    }
}
