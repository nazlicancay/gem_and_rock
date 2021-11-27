using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class leanTouchController : MonoBehaviour
{
    public void LeanSolaCek(LeanFinger lf)
    {
        leanTouchManager.LeanTouchManagerInstance.swipeleft = true;
    }
    public void LeanSagaCek(LeanFinger lf)
    {
        leanTouchManager.LeanTouchManagerInstance.swiperight = true;
    }
}
