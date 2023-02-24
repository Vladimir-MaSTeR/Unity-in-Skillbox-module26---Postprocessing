using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LoockCamera : MonoBehaviour {

    [SerializeField]
    private PlayableDirector _dialogTimeLine;

    public void StartTimeLineTwo() {
        _dialogTimeLine.Play();
    }
}
