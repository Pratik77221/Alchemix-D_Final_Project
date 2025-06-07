using System.Collections;
using UnityEngine;

public class PourDetector : MonoBehaviour
{

    public float pourThreashold = 70;
    public Transform origin1 = null;
    public Transform origin2 = null;
    private GameObject streamPrefab = null;

    private bool isPouring = false;
    private Stream currentStream = null;

    public GameObject colliderPrefab1;
    public GameObject colliderPrefab2;

    //public float velocity;

    private float rotationAngle;


    // The axis of rotation to calculate the angle (default is Y-axis)
    //public Vector3 rotationAxis = Vector3.right;

    // Optional: Set a reference direction for angle calculation (default is forward)
    public Vector3 referenceDirection = Vector3.up;


    private void Update()
    {

        //bool pourCheck = calculatePourAngle() < pourThreashold;

        //if (isPouring != pourCheck)
        //{

        //    isPouring = pourCheck;

        //    if (isPouring)
        //    {
        //        Debug.Log("Wrong");
        //        startPour();
        //        GameObject colliderObject = Instantiate(colliderPrefab, origin.position, Quaternion.identity, transform);
        //        Debug.Log("Hi");
        //        colliderObject.transform.parent = null;

        //        //Destroy(colliderObject, 5f);
        //    }
        //    else
        //    {
        //        endPour();

        //    }

        //}







        //if (calculatePourAngle() > pourThreashold)
        //{
        //    Debug.Log("Wrong");
        //}

        //if(/*(calculatePourAngle(Vector3.forward) > pourThreashold) ||*/ (calculatePourAngle(Vector3.right) > pourThreashold))
        //{
        //    Debug.Log("Object Rotated");
        //}

        // Debug.Log(calculatePourAngle(Vector3.forward));

        if (calculateAngleDiffWay() > pourThreashold)
        {

            //startPour();
            GameObject colliderObject1 = Instantiate(colliderPrefab1, origin1.position, Quaternion.identity, transform);
            GameObject colliderObject2 = Instantiate(colliderPrefab2, origin2.position, Quaternion.identity, transform);
            colliderObject1.transform.parent = null;
            colliderObject2.transform.parent = null;
            //colliderObject1.transform.rotation = Quaternion.Euler(90, 0, 0);
            //colliderObject2.transform.rotation = Quaternion.Euler(90, 0, 0);
            //colliderObject1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, velocity);
            //colliderObject2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, velocity);
            Destroy(colliderObject1, 2.3f);
            Destroy(colliderObject2, 2.3f);


        }

        else
        {
            endPour();
        }





    }

    private void startPour()
    {
        //print("Start");
        currentStream = createStream();
        currentStream.Begin();
    }

    private void endPour()
    {
        //print("End");
    }

    //private float calculatePourAngle(Vector3 rotationAxis)
    //{


    //    //return transform.forward.z * Mathf.Rad2Deg;
    //    //return transform.rotation.x;

    //    Quaternion currentRotation = transform.rotation;
    //    /* Reference Direction -> Current Direction (Up(y-axis))
    //       currentRotation * referenceDiretion -> Quarternion-Vector Multiplication which gives the direction (Vector) of the Object after rotation thus inside the SignedAngle
    //       function, it gives the 'To' of the function and Reference Direction becomes the 'from' of the function */

    //    rotationAngle = Vector3.SignedAngle(referenceDirection, currentRotation * referenceDirection, rotationAxis);
    //    //rotationAngle2 = Vector3.SignedAngle(referenceDirection, currentRotation * referenceDirection, Vector3.forward);
    //    //Debug.Log(rotationAngle);
    //    return rotationAngle;

    //}

    private float calculateAngleDiffWay()
    {
        rotationAngle = Vector3.Angle(Vector3.up, transform.up);
        //Debug.Log(rotationAngle);
        return rotationAngle;


    }

    private Stream createStream()
    {
        GameObject streamObject = Instantiate(streamPrefab, origin1.position, Quaternion.identity, transform);


        return streamObject.GetComponent<Stream>();
    }


}