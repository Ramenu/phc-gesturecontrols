using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class CameraGesture : MonoBehaviour
{
  float lastTapPos; // most recent tap

  void Update()
  {
      First_touch=Input.GetTouch(0).position;
      second_touch=Input.GetTouch(1).position;
      distance_current=second_touch.magnitude-First_touch.magnitude; // calculate offset

      if(distance_current!=distance_previous)
      {
          // scale bigger if the distance is further, otherwise scale it smaller
          Vector3 scale_value=spawned_object.transform.localScale*(distance_current/distance_previous);
          spawned_object.transform.localScale=scale_value;

          // set the previous distance to the current one
          distance_previous=distance_current;

      }
  }
}