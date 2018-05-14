using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatLong : MonoBehaviour {


public  float myradius = 5; // globe ball radius
//经纬度
public  float mylatitude;
public float Mylongitude; 




public  void Start()
{
  mylatitude = Mathf.PI * mylatitude / 180;
  Mylongitude = Mathf.PI * Mylongitude / 180;

	// adjust position by radians	
  mylatitude -= 1.570795765134f; // subtract 90 degrees (in radians)

	// and switch z and y (since z is forward)
  float xPos = (myradius) * Mathf.Sin(mylatitude) * Mathf.Cos(Mylongitude);
  float zPos = (myradius) * Mathf.Sin(mylatitude) * Mathf.Sin(Mylongitude);
  float yPos = (myradius) * Mathf.Cos(mylatitude);


	// move marker to position
  transform.position = new Vector3(xPos, yPos, zPos);

}
}
