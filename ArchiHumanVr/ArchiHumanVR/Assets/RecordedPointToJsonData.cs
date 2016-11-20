using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;

public class RecordedPointToJsonData : MonoBehaviour {

    public Transform _recordedPoint;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    
}

public class PathRecored {

    public List<Vector3> _recordedPoint;
}

[System.Serializable]
public class RecordedPoint {

    [JsonProperty(PropertyName = "TSR")]
    public float TimeSinceRecord { get { return _timeSinceRecord; } }
    [JsonProperty(PropertyName = "Pos")]
    public Vector3 Position { get { return _position; } }
    [JsonProperty(PropertyName = "Rot")]
    public Quaternion Rotation { get { return _rotation; } }

    [SerializeField]
    private float _timeSinceRecord;

    [SerializeField]
    private Vector3 _position;

    [SerializeField]
    private Quaternion _rotation;


    RecordedPoint() {

    }



}
